﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Alpari.QDF.Domain;
using Alpari.QualityAssurance.SpecFlowExtensions.TypeUtilities;
using qdf.AcceptanceTests.TypedDataTables;

namespace qdf.AcceptanceTests.Helpers
{
    /// <summary>
    ///     Class containing methods for aggregating CC and QDF Data to put them into comparable formats
    /// </summary>
    public class QdfccDataReconciliation
    {
        public QdfccDataReconciliation(CcToolData cCToolData, List<Deal> qDfDeals)
        {
            CcToolData = cCToolData;
            QdfDeals = qDfDeals;
        }

        public CcToolData CcToolData { get; private set; }
        public List<Deal> QdfDeals { get; private set; }
        public List<QdfDealPositionGrouping> QdfDealPositionGroupings { get; private set; }
        public List<QdfDealPosition> QdfDealPositions { get; private set; }
        public List<CcToolPosition> CcToolPositions { get; private set; }

        public void AggregateQdfDeals()
        {
            QdfDealPositionGroupings = GetAggregatedQdfDeals();

            CalculateQdfCumulativePosition();

            QdfDealPositions = QdfDealPositionGroupings.SelectMany(x => x.QdfDealPositions).ToList();

            Console.WriteLine("Print flattened list of cumulative sums");
            QdfDealPositions.ForEach(
                x => Console.WriteLine("{0} {1} {2}", x.PositionName, x.Position, x.CumulativePosition));
        }

        private void CalculateQdfCumulativePosition()
        {
            foreach (var grouping in QdfDealPositionGroupings)
            {
                Console.WriteLine("get position values for {0}", grouping.PositionGroupingName);
                var positions = grouping.QdfDealPositions.Select(deal => deal.Position).ToList();
                foreach (var item in positions)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();

                Console.WriteLine("get cumulative position values");
                var cumulativePositions = positions.CumulativeSum().ToList();
                //IEnumerable<double> cumulativePositions = positions.CumulativeSum<decimal>();
                foreach (var item in cumulativePositions)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();

                for (var i = 0; i < cumulativePositions.Count(); i++)
                {
                    grouping.QdfDealPositions[i].CumulativePosition = cumulativePositions[i];
                }
            }
        }

        public void AggregateCcToolData()
        {
            CalculateCcVolumeSize();
            CombineCcSectionData();
        }

        /// <summary>
        ///     Add a column called VolumeSize to hold the calculated value of the Volume
        ///     TODO:- add to the CCTool Data table definiton so that code from this pont on can still be strongly typed
        /// </summary>
        private void CalculateCcVolumeSize()
        {
            CcToolData.Columns.Add(new DataColumn("VolumeSize", typeof (decimal)));

            #region nice little demo of not using deferred execution

            //works ok, but dow we really need to double query the rows?
            //List<CCtoolRow> ccrowQuery = (from CCtoolRow row in CCToolData.Rows
            //                            select row).ToList<CCtoolRow>();
            //List<DataRow> rowQuery = (from DataRow row in CCToolData.Rows
            //                          select row).ToList<DataRow>();

            //for (int i = 0; i < ccrowQuery.Count(); i++)
            //{
            //    var VolumeSize = ccrowQuery[i].Volume * ccrowQuery[i].ContractSize;
            //    rowQuery[i]["VolumeSize"] = VolumeSize;
            //}

            //rowQuery = (from DataRow row in CCToolData.Rows
            //            select row).ToList<DataRow>();
            //foreach (DataRow row in rowQuery)
            //{
            //    Assert.AreEqual((decimal)row["VolumeSize"], (decimal)row["Volume"] * (decimal)row["ContractSize"]);
            //}

            #endregion

            var rowQuery = (from DataRow row in CcToolData.Rows
                select row);
            foreach (var row in rowQuery)
            {
                row["VolumeSize"] = (decimal) row["Volume"]*(decimal) row["ContractSize"];
            }

            //foreach (DataRow row in rowQuery)
            //{
            //    Console.WriteLine("CC position {0} has a value of {1}",
            //        GetCCToolPositionName(row), 
            //        row["VolumeSize"]);
            //}
        }

        private void CombineCcSectionData()
        {
            var rowQuery = (from DataRow row in CcToolData.Rows
                select row);
            var aggregatedPositions = rowQuery.GroupBy(x => new
            {
                Book = ((ulong) x["IsBookA"] == 0 ? Book.A : Book.B),
                Instrument = x["SymbolCode"].ToString(),
                ServerId = x["ServerName"].ToString(),
                TimeStamp = (DateTime) x["UpdateDateTime"]
            }
                )
                .Select(x => new CcToolPosition
                {
                    PositionName =
                        String.Format("{0} {1} {2} {3}", x.Key.Book, x.Key.Instrument, x.Key.ServerId,
                            Convert.ToDateTime(x.Key.TimeStamp).ToString(DateTimeUtils.MySqlDateFormatToSeconds)),
                    Book = x.Key.Book,
                    Instrument = x.Key.Instrument,
                    ServerId = x.Key.ServerId,
                    TimeStamp = x.Key.TimeStamp,
                    Positions = x.ToList()
                }
                ).ToList();
            foreach (var position in aggregatedPositions)
            {
                position.CalculatePosition();
                Console.WriteLine("CCTool position {0} contains {1} positions and has a value of {2}",
                    position.PositionName, position.Positions.Count, position.Position);
            }
            CcToolPositions = aggregatedPositions;
        }

// ReSharper disable once InconsistentNaming - used in code that is currently commented out, but will be more generally applicable
        private static string GetCCToolPositionName(DataRow row)
        {
            return String.Format("{0} {1} {2} {3}", row["IsBookA"], row["SymbolCode"], row["ServerName"],
                Convert.ToDateTime(row["UpdateDateTime"]).ToString(DateTimeUtils.MySqlDateFormatToSeconds));
        }

        //check console output by dumping to excel, sorting and applying this formula =IF(CONCATENATE(C2,D2,E2,F2,G2)<>CONCATENATE(C1,D1,E1,F1,G1),"ok","dup")

        private List<QdfDealPositionGrouping> GetAggregatedQdfDeals()
        {
            //should work, but always ends up with non-unique groupings, and the same number of deals as groups!
            //var aggregatedDeals = QDFDeals.GroupBy(x => new QDFDealPositionGrouping()
            //                                                    {
            //                                                        Book = x.Book,
            //                                                        Instrument = x.Instrument,
            //                                                        ServerId = x.ServerId//,
            //                                                        //Side = x.Side
            //                                                    }
            //                                       )
            //answer - group using an anonymous type. This works!
            var aggregatedDeals = QdfDeals.GroupBy(x => new
            {
                x.Book,
                x.Instrument,
                x.Server,
                x.TimeStamp
                //Side = x.Side
            }
//                                       ).Select(x => new QDFDealPosition()).ToList<QDFDealPosition>();
                )
                .Select(x => new QdfDealPosition
                {
                    PositionName =
                        String.Format("{0} {1} {2} {3}", x.Key.Book, x.Key.Instrument, x.Key.Server,
                            x.Key.TimeStamp.ConvertDateTimeToMySqlDateFormatToSeconds()),
                    Book = x.Key.Book,
                    Instrument = x.Key.Instrument,
                    Server = x.Key.Server,
                    TimeStamp = x.Key.TimeStamp,
                    QdfDeals = x.ToList()
                }
                ).ToList();

            foreach (var position in aggregatedDeals)
            {
                position.CalculatePosition();
                Console.WriteLine("QDF position {0} contains {1} deals and has a value of {2}", position.PositionName,
                    position.QdfDeals.Count, position.Position);
            }

            //group the positions by the above factors except Timestamp, then order by timestamp
            var groupedAggregation = aggregatedDeals.GroupBy(x => new
            {
                PositionGroupingName = String.Format("{0} {1} {2}", x.Book, x.Instrument, x.Server),
                x.Book,
                x.Instrument,
                x.Server
            }
                );

            //should be able to combine the ordering and then adding the groupings to the list
            foreach (var item in groupedAggregation)
            {
                item.OrderBy(x => x.TimeStamp);
            }

            var groupedPositions = groupedAggregation.Select(x => new QdfDealPositionGrouping
            {
                PositionGroupingName = x.Key.PositionGroupingName,
                Book = x.Key.Book,
                Instrument = x.Key.Instrument,
                Server = x.Key.Server,
                QdfDealPositions = x.ToList()
            }
                ).ToList();

            return groupedPositions;
        }
    }

    public class QdfDealPosition
    {
        public string PositionName { get; set; }

        public Book Book { get; set; }

        public string Instrument { get; set; }

        public TradingServer Server { get; set; }

        public DateTime TimeStamp { get; set; }

        public List<Deal> QdfDeals { get; set; }

        public decimal Position { get; private set; }

        public decimal CumulativePosition { get; set; }

        public void CalculatePosition()
        {
            QdfDeals.ForEach(delegate(Deal deal) { Position += deal.Volume*(deal.Side == Side.Buy ? 1 : -1); });
        }
    }

    public class CcToolPosition
    {
        public string PositionName { get; set; }

        public Book Book { get; set; }

        public string Instrument { get; set; }

        public string ServerId { get; set; }

        //public Side Side { get; set; }

        public DateTime TimeStamp { get; set; }

        public List<DataRow> Positions { get; set; }

        public decimal Position { get; private set; }

        public void CalculatePosition()
        {
            Positions.ForEach(delegate(DataRow position) { Position += (decimal) position["VolumeSize"]; });
        }
    }

    public class QdfDealPositionGrouping
    {
        public Book Book { get; set; }

        public string Instrument { get; set; }

        public TradingServer Server { get; set; }

        public List<QdfDealPosition> QdfDealPositions { get; set; }

        public string PositionGroupingName { get; set; }
    }
}