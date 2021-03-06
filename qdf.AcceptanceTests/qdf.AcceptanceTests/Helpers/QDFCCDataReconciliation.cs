﻿using System.Security.Cryptography;
using Alpari.QDF.Domain;
using Alpari.QualityAssurance.RefData;
using Alpari.QualityAssurance.SpecFlowExtensions.TypeUtilities;
using qdf.AcceptanceTests.Annotations;
using qdf.AcceptanceTests.TypedDataTables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace qdf.AcceptanceTests.Helpers
{
    /// <summary>
    ///     Class containing methods for aggregating CC and QDF Data to put them into comparable formats
    /// </summary>
    public class QdfccDataReconciliation
    {
        public QdfccDataReconciliation(CcToolDataTable cCToolDataTable, List<Deal> qDfDeals, string fileOutputDirectory)
        {
            CcToolDataTable = cCToolDataTable;
            QdfDeals = qDfDeals;
            FileOutputDirectory = fileOutputDirectory;
        }

        public CcToolDataTable CcToolDataTable { get; private set; }
        public List<Deal> QdfDeals { get; private set; }
        public List<QdfDealPositionGrouping> QdfDealPositionGroupings { get; private set; }
        public List<CcToolPositionGrouping> CcToolPositionGroupings { get; private set; }
        public List<QdfDealPosition> QdfDealPositions { get; private set; }
        public List<CcToolPosition> CcToolPositions { get; private set; }
        public string FileOutputDirectory { get; set; }

        public void AggregateQdfDeals()
        {
            QdfDealPositionGroupings = GetAggregatedQdfDeals();

            CalculateQdfCumulativePosition();

//            QdfDealPositions.EnumerableToCsv(FileOutputDirectory + "CalculateQdfCumulativePosition.csv", true);

            QdfDealPositions =
                QdfDealPositionGroupings.SelectMany(x => x.QdfDealPositions).ToList();
            //Console.WriteLine("Print flattened list of cumulative sums");
            //QdfDealPositions.ForEach(
            //    x => Console.WriteLine("{0} {1} {2}", x.PositionName, x.Position, x.CumulativePosition));
            //QdfDealPositions.EnumerableToCsv(FileOutputDirectory + "CalculateQdfCumulativePosition.csv", true);
            
            CalculateQdfDeltas();
            QdfDealPositionGroupings.Clear();
            QdfDealPositionGroupings = null;
            //Console.WriteLine("Print QDF Deltas");
            //Console.WriteLine("PositionName, Position, CumulativePosition, PositionDelta");

            //QdfDealPositions.ForEach(
            //    x =>
            //        Console.WriteLine("{0} {1} {2} {3}", x.PositionName, x.Position, x.CumulativePosition,
            //            x.PositionDelta));
            //QdfDealPositions = QdfDealPositions.OrderBy(x=>x.PositionName).ThenBy(x => x.TimeStamp).ToList();
            QdfDealPositions = QdfDealPositions.OrderBy(x => x.PositionName).ToList(); //don't need the sort by timestamp as it's part of the position name
            QdfDealPositions.EnumerableToCsv(string.Format("{0}CalculateQdfDeltas.csv", FileOutputDirectory), true);
        }

        /// <summary>
        ///     using the start and end snapshot times from the CCTool data, find the QDF Deals from the equivalent time periods
        ///     and group them by time and by Book, Instrument, Server
        /// </summary>
        public void AggregateQdfDealsByDay()
        {
            List<DateTime> snapShotTimes =
                CcToolDataTable.Rows.Cast<CCtoolRow>().Select(row => row.UpdateDateTime).Distinct().ToList();
            snapShotTimes.Sort();
            var groupedByDay = GroupQdfDealsByDay(snapShotTimes);

            List<QdfDealPositionGrouping> groupedPositionsByDay = new List<QdfDealPositionGrouping>();

            foreach (var t in groupedByDay)
            {
                Console.WriteLine("{0}", t.Key);
            }

            foreach (var kvp in groupedByDay)
            {
                KeyValuePair<DateTime, IEnumerable<Deal>> dealsOnDate = kvp;
                List<QdfDealPosition> aggregatedDeals = (from deal in dealsOnDate.Value
                //List<QdfDealPosition> aggregatedDeals = (from deal in QdfDeals
                    group deal by new {deal.Book, deal.Instrument, deal.Server}
                    into dealGroup
                    select new QdfDealPosition
                    {
                        PositionName =
                            String.Format("{0} {1} {2} {3}", dealGroup.Key.Book, dealGroup.Key.Instrument,
                                dealGroup.Key.Server, dealsOnDate.Key),
                        Book = dealGroup.Key.Book,
                        Instrument = dealGroup.Key.Instrument,
                        Server = dealGroup.Key.Server,
                        QdfDeals = dealGroup.OrderBy(x => x.TimeStamp).ToList()
                    }).ToList();
                //calculate the positions
                aggregatedDeals.ForEach(position => position.CalculatePosition());                
            }



            #region prob wrong

            //List<QdfDealPosition> aggregatedDeals = (from deal in QdfDeals
            //    group deal by new {deal.Book, deal.Instrument, deal.Server}
            //    into dealGroup
            //    select new QdfDealPosition
            //    {
            //        PositionName =
            //            String.Format("{0} {1} {2}", dealGroup.Key.Book, dealGroup.Key.Instrument,
            //                dealGroup.Key.Server),
            //        Book = dealGroup.Key.Book,
            //        Instrument = dealGroup.Key.Instrument,
            //        Server = dealGroup.Key.Server,
            //        QdfDeals = dealGroup.OrderBy(x => x.TimeStamp).ToList()
            //    }).ToList();
            //////calculate the positions
            ////aggregatedDeals.ForEach(position => position.CalculatePosition());

            ////group into groupings
            //List<QdfDealPositionGrouping> groupedPositions = CreateQdfGroupedPositions(aggregatedDeals);

            ////create subgroups broken up by time periods
            //List<QdfDealPositionGrouping> groupedPositionsByDay = new List<QdfDealPositionGrouping>();
            //foreach (QdfDealPositionGrouping qdfDealPositionGrouping in groupedPositions)
            //{
            //    foreach (QdfDealPosition qdfDealPosition in qdfDealPositionGrouping.QdfDealPositions)
            //    {
            //        for (int i = 0; i < snapShotTimes.Count - 1; i++)
            //        {
            //            int index = i;
            //            DateTime snapShotTime = snapShotTimes[i];
            //            var thisPositionGroupingByDayName = string.Format("{0} {1}",
            //                qdfDealPositionGrouping.PositionGroupingName, snapShotTime.Date);

            //            if (groupedPositionsByDay.Any(x => x.PositionGroupingName == thisPositionGroupingByDayName))
            //            {
            //                QdfDealPositionGrouping thisPositionGroupingByDay =
            //                    groupedPositionsByDay.First(x => x.PositionGroupingName == thisPositionGroupingByDayName);
            //                //var dealsToAdd = from position in qdfDealPositionGrouping.QdfDealPositions 
            //                //                 where position.QdfDeals.


            //                var dealsToAdd =
            //                    GetQdfDealsToAdd(qdfDealPositionGrouping, snapShotTimes, index);
            //                //thisPositionGroupingByDay.QdfDealPositions[]
            //            }
            //            else
            //            {
            //                groupedPositionsByDay.Add(new QdfDealPositionGrouping
            //                {
            //                    Book = qdfDealPositionGrouping.Book,
            //                    Instrument = qdfDealPositionGrouping.Instrument,
            //                    PositionGroupingName = thisPositionGroupingByDayName,
            //                    //QdfDealPositions = new List<QdfDealPosition>
            //                    //{
            //                    //    GetQdfDealsToAdd(qdfDealPositionGrouping, snapShotTimes, index).ToList();
            //                    //},
            //                    QdfDealPositions = qdfDealPositionGrouping.QdfDealPositions,
            //                    Server = qdfDealPositionGrouping.Server
            //                });
            //            }
            //        }                    
            //    }

            //}

            #endregion

        }

        private Dictionary<DateTime,IEnumerable<Deal>> GroupQdfDealsByDay(List<DateTime> snapShotTimes)
        {
            var datedDealsDictionary = new Dictionary<DateTime, IEnumerable<Deal>>();
            for (int i = 0; i < snapShotTimes.Count - 1; i++)
            {
                int index = i;
                IEnumerable<Deal> deals =
                    QdfDeals.Where(
                        deal => deal.TimeStamp >= snapShotTimes[index] && deal.TimeStamp <= snapShotTimes[index + 1]);
                        //.Select(x => x);
                    //from qdfDeal in QdfDeals
                    //where qdfDeal.TimeStamp >= snapShotTimes[index]
                    //where qdfDeal.TimeStamp <= snapShotTimes[index + 1]
                    //select qdfDeal;
                datedDealsDictionary.Add(snapShotTimes[index],deals );
                
            }
            return datedDealsDictionary;
        }

        private static IEnumerable<Deal> GetQdfDealsToAdd(QdfDealPositionGrouping qdfDealPositionGrouping, List<DateTime> snapShotTimes, int index)
        {
            return qdfDealPositionGrouping.QdfDealPositions.SelectMany(
                x =>
                    x.QdfDeals.Where(
                        y =>
                            y.TimeStamp >= snapShotTimes[index] ||
                            y.TimeStamp <= snapShotTimes[index + 1]));
        }


        public void AggregateCcToolData()
        {
            CalculateCcVolumeSize();
            CcToolPositionGroupings = CombineCcSectionData();
            //RemapCcServerIdsToQdfServerIds();
            CalculateCcDeltas();
            //Console.WriteLine("Print CC Deltas");
            //Console.WriteLine("PositionName, Position, PositionDelta");
            //CcToolPositions.ForEach(
            //    x =>
            //        Console.WriteLine("{0} {1} {2}", x.PositionName, x.Position,
            //            x.PositionDelta));
            CcToolPositions.EnumerableToCsv(string.Format("{0}CalculateCcDeltas.csv", FileOutputDirectory),true);
        }

        private static decimal[] GetDeltas(IEnumerable<decimal> positionValues)
        {
            decimal[] deltas = positionValues.CalculateDeltas().ToArray();
            return deltas;
        }

        private List<QdfDealPositionGrouping> GetAggregatedQdfDeals()
        {
            List<QdfDealPosition> aggregatedDeals = (from deal in QdfDeals
                let groupTimeStamp =
                    new DateTime(deal.TimeStamp.Year, deal.TimeStamp.Month, deal.TimeStamp.Day, deal.TimeStamp.Hour,
                        deal.TimeStamp.Minute,
                        0)
                group deal by new {deal.Book, deal.Instrument, deal.Server, groupTimeStamp}
                into dealGroup
                select new QdfDealPosition
                {
                    PositionName =
                        String.Format("{0} {1} {2} {3}", dealGroup.Key.Book, dealGroup.Key.Instrument,
                            dealGroup.Key.Server,
                            dealGroup.Key.groupTimeStamp.ConvertDateTimeToMySqlDateFormatToSeconds()),
                    Book = dealGroup.Key.Book,
                    Instrument = dealGroup.Key.Instrument,
                    Server = dealGroup.Key.Server,
                    TimeStamp = dealGroup.Key.groupTimeStamp,
                    QdfDeals = dealGroup.ToList()
                }).ToList();


            //foreach (QdfDealPosition position in aggregatedDeals)
            //{
            //    position.CalculatePosition();
            //    Console.WriteLine("QDF position {0} contains {1} deals and has a value of {2}", position.PositionName,
            //        position.QdfDeals.Count, position.Position);
            //}
            aggregatedDeals.ForEach(position=>position.CalculatePosition());
            //aggregatedDeals.EnumerableToCsv(string.Format("{0}GroupedQdfDeals.csv", FileOutputDirectory),true);

            //group the positions by the above factors except Timestamp
            var groupedPositions = CreateQdfGroupedPositions(aggregatedDeals);

            return groupedPositions;
        }

        private static List<QdfDealPositionGrouping> CreateQdfGroupedPositions(List<QdfDealPosition> aggregatedDeals)
        {
            var groupedAggregation = aggregatedDeals.GroupBy(x => new
            {
                PositionGroupingName = String.Format("{0} {1} {2}", x.Book, x.Instrument, x.Server),
                x.Book,
                x.Instrument,
                x.Server
            }
                );

            List<QdfDealPositionGrouping> groupedPositions = groupedAggregation.Select(x => new QdfDealPositionGrouping
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

        private void CalculateQdfCumulativePosition()
        {
            foreach (QdfDealPositionGrouping grouping in QdfDealPositionGroupings)
            {
                //Console.WriteLine("get position values for {0}", grouping.PositionGroupingName);
                List<decimal> positions = grouping.QdfDealPositions.Select(deal => deal.Position).ToList();
                //foreach (decimal item in positions)
                //{
                //    Console.WriteLine(item);
                //}
                //Console.WriteLine();

                //Console.WriteLine("get cumulative position values");
                List<decimal> cumulativePositions = positions.CumulativeSum().ToList();
                //IEnumerable<double> cumulativePositions = positions.CumulativeSum<decimal>();
                //foreach (decimal item in cumulativePositions)
                //{
                //    Console.WriteLine(item);
                //}
                //Console.WriteLine();

                for (int i = 0; i < cumulativePositions.Count(); i++)
                {
                    grouping.QdfDealPositions[i].CumulativePosition = cumulativePositions[i];
                }
            }
        }

        private void CalculateQdfDeltas()
        {
            foreach (QdfDealPositionGrouping positionGrouping in QdfDealPositionGroupings)
            {
                var deltas = GetDeltas(positionGrouping.QdfDealPositions.Select(position => position.Position));
                List<QdfDealPosition> positions = positionGrouping.QdfDealPositions.Select(position => position).ToList();
                for (int i = 0; i < positions.Count(); i++)
                {
                    positions[i].PositionDelta = deltas[i];
                }
            }
        }

        /// <summary>
        ///     Add a column called VolumeSize to hold the calculated value of the Volume
        ///     TODO:- add to the CCTool Data table definiton so that code from this pont on can still be strongly typed
        /// </summary>
        private void CalculateCcVolumeSize()
        {
            CcToolDataTable.Columns.Add(new DataColumn("VolumeSize", typeof (decimal)));

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

            IEnumerable<DataRow> rowQuery = (from DataRow row in CcToolDataTable.Rows
                select row);
            foreach (DataRow row in rowQuery)
            {
                row["VolumeSize"] = (decimal) row["Volume"]*(decimal) row["ContractSize"];
            }

            //foreach (DataRow row in rowQuery)
            //{
            //    Console.WriteLine("CC position {0} has a value of {1}",
            //        GetCcToolPositionName(row),
            //        row["VolumeSize"]);
            //}
            //rowQuery.EnumerableToCsv(string.Format("{0}CalculateCcVolumeSize.csv", FileOutputDirectory), true);
        }

        private List<CcToolPositionGrouping> CombineCcSectionData()
        {
            IEnumerable<DataRow> rowQuery = (from DataRow row in CcToolDataTable.Rows
                select row);

            List<CcToolPosition> aggregatedPositions = (from row in rowQuery
                let timeStamp = (DateTime) row["UpdateDateTime"]
                let groupTimeStamp =
                    new DateTime(timeStamp.Year, timeStamp.Month, timeStamp.Day, timeStamp.Hour, timeStamp.Minute, 0)
                group row by new
                {
                    Book = ((ulong) row["IsBookA"] == 0 ? Book.A : Book.B),
                    Instrument = row["SymbolCode"].ToString(),
                    ServerId = row["ServerName"].ToString(),
                    TimeStamp = groupTimeStamp
                }
                into snapshotGroup
                select new CcToolPosition
                {
                    PositionName =
                        String.Format("{0} {1} {2} {3}", snapshotGroup.Key.Book, snapshotGroup.Key.Instrument,
                            RemapCcServerIdToQdfServerId(snapshotGroup.Key.ServerId),
                            snapshotGroup.Key.TimeStamp.ConvertDateTimeToMySqlDateFormatToSeconds()),//.ToString(DateTimeUtils.MySqlDateFormatToSeconds)),
                    Book = snapshotGroup.Key.Book,
                    Instrument = snapshotGroup.Key.Instrument,
                    ServerId = RemapCcServerIdToQdfServerId(snapshotGroup.Key.ServerId),
                    TimeStamp = snapshotGroup.Key.TimeStamp,
                    Positions = snapshotGroup.ToList()
                }).OrderBy(x => x.PositionName).ThenBy(x => x.TimeStamp).ToList();

            //foreach (CcToolPosition position in aggregatedPositions)
            //{
            //    position.CalculatePosition();
            //    Console.WriteLine("CCTool position {0} contains {1} positions and has a value of {2}",
            //        position.PositionName, position.Positions.Count, position.Position);
            //}
            aggregatedPositions.ForEach(position=>position.CalculatePosition());
            CcToolPositions = aggregatedPositions;
            var positionGroupingQuery = (from position in aggregatedPositions
                group position by new
                {
                    PositionGroupingName =
                        String.Format("{0} {1} {2}", position.Book, position.Instrument, position.ServerId),
                    position.Book, position.Instrument, position.ServerId
                }
                into positionGroup
                select new CcToolPositionGrouping
                {
                    PositionGroupingName = positionGroup.Key.PositionGroupingName,
                    Book = positionGroup.Key.Book,
                    Instrument = positionGroup.Key.Instrument,
                    ServerId = positionGroup.Key.ServerId,
                    CcToolPositions = positionGroup.ToList()
                }
                );
            return positionGroupingQuery.ToList();
        }

        private string RemapCcServerIdToQdfServerId(string ccToolServer)
        {
            return ReferenceData.Instance.CcToQdfServerMapping[ccToolServer];
        }

        private void CalculateCcDeltas()
        {
            foreach (CcToolPositionGrouping grouping in CcToolPositionGroupings)
            {
                var deltas = GetDeltas(grouping.CcToolPositions.Select(position => position.Position));
                List<CcToolPosition> positions = grouping.CcToolPositions.Select(position => position).ToList();
                for (int i = 0; i < positions.Count(); i++)
                {
                    positions[i].PositionDelta = deltas[i];
                }
            }
        }

        //private void RemapCcServerIdsToQdfServerIds()
        //{
        //    foreach (CcToolPosition ccToolPosition in CcToolPositions)
        //    {
        //        ccToolPosition.ServerId = ReferenceData.Instance.CcToQdfServerMapping[ccToolPosition.ServerId];
        //    }
        //}
        
//// ReSharper disable once UnusedMember.Local- used in code that is currently commented out, but will be more generally applicable
//        private static string GetCcToolPositionName(DataRow row)
//        {
//            return String.Format("{0} {1} {2} {3}", row["IsBookA"], row["SymbolCode"], row["ServerName"],
//                Convert.ToDateTime(row["UpdateDateTime"]).ToString(DateTimeUtils.MySqlDateFormatToSeconds));
//        }

        //check console output by dumping to excel, sorting and applying this formula =IF(CONCATENATE(C2,D2,E2,F2,G2)<>CONCATENATE(C1,D1,E1,F1,G1),"ok","dup")
    }

    /// <summary>
    /// common fields between QDF and CC Data needed for anaylysis
    /// </summary>
    public interface IAnalyzeablePosition
    {
        string PositionName { get; set; }
        Book Book { get; set; }
        string Instrument { get; set; }
        string ServerId { get; set; }
        DateTime TimeStamp { get; set; }
        decimal Position { get; }
        decimal PositionDelta { get; }
        void CalculatePosition();
    }

    public interface IAnalyzeablePositionGrouping
    {
        Book Book { get; set; }
        string Instrument { get; set; }
        string PositionGroupingName { get; set; }
        //List<IAnalyzeablePosition> Positions { get; set; }
    }
    
    public class QdfDealPositionGrouping : IAnalyzeablePositionGrouping
    {
        //private List<IAnalyzeablePosition> _positions;
        public Book Book { get; set; }

        public string Instrument { get; set; }

        public TradingServer Server { [UsedImplicitly] get; set; }

        public List<QdfDealPosition> QdfDealPositions { get; set; }

        public string PositionGroupingName { get; set; }

        //public List<IAnalyzeablePosition> Positions
        //{
        //    get
        //    {
        //        if (_positions != null) return _positions;
        //        _positions = (List<IAnalyzeablePosition>) QdfDealPositions;
        //        return null;
        //    }
        //    set { _positions = value; }
        //}
    }

    public class CcToolPositionGrouping : IAnalyzeablePositionGrouping
    {
        public Book Book { get; set; }

        public string Instrument { get; set; }

        public string ServerId { [UsedImplicitly] get; set; }

        public List<CcToolPosition> CcToolPositions { get; set; }

        public string PositionGroupingName { get; set; }
    }
}