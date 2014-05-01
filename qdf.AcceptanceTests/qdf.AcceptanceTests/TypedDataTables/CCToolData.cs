﻿using System;
using System.Data;
using System.Runtime.Serialization;
using Alpari.QualityAssurance.SpecFlowExtensions.TypeUtilities;

namespace qdf.AcceptanceTests.TypedDataTables
{
    /// <summary>
    ///     with thanks to
    ///     http://www.codeproject.com/Articles/30490/How-to-Manually-Create-a-Typed-DataTable
    ///     if the query used to populate this has more columns, they are ignored.
    ///     This is ok unless code tries to access these columns later (compile time error), but won't break creating the
    ///     table.
    ///     if the query doesn't return a column that is needed for the datatable, this won't cause any problem unless that
    ///     column is accessed in code at runtime
    ///     e.g.:-
    ///     'myRow.IsBookA' threw an exception of type 'System.InvalidCastException'
    /// </summary>
    [Serializable]
    public class CcToolData : TypedDataTable
    {
        public CcToolData()
        {
            SetupColumns();
        }

        protected override void SetupColumns()
        {
            Columns.Add(new DataColumn("Section", typeof (string)));
            Columns.Add(new DataColumn("ServerName", typeof (string)));
            //Columns.Add(new DataColumn("PlatformId", typeof(int)));
            //Columns.Add(new DataColumn("Id", typeof(int)));
            //Columns.Add(new DataColumn("DatabaseName", typeof(string)));
            Columns.Add(new DataColumn("SymbolCode", typeof (string)));
            Columns.Add(new DataColumn("IsBookA", typeof (ulong)));
            Columns.Add(new DataColumn("BidPrice", typeof (decimal)));
            Columns.Add(new DataColumn("AskPrice", typeof (decimal)));
            Columns.Add(new DataColumn("Volume", typeof (decimal)));
            Columns.Add(new DataColumn("ContractSize", typeof (decimal)));
            Columns.Add(new DataColumn("UpdateDateTime", typeof (DateTime)));
        }

        /// <summary>
        ///     Implemented to staisfy
        ///     CA2237: Mark ISerializable types with SerializableAttribute
        ///     and CA2229: Implement serialization constructors
        ///     If this overload is ever used, then an instance will be created with serialisation context
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected CcToolData(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            CcToolData serialisationInstance = this;
        }

        public CCtoolRow this[int idx]
        {
            get { return (CCtoolRow) Rows[idx]; }
        }

        public void Add(CCtoolRow row)
        {
            Rows.Add(row);
        }

        public void Remove(CCtoolRow row)
        {
            Rows.Remove(row);
        }

        public CCtoolRow GetNewRow()
        {
            var row = (CCtoolRow) NewRow();

            return row;
        }

        protected override Type GetRowType()
        {
            return typeof (CCtoolRow);
        }

        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new CCtoolRow(builder);
        }

        public override T ConvertIEnumerableToDataTable<T>(System.Collections.Generic.IEnumerable<T> enumeratedObjects)
        {
            throw new NotImplementedException();
        }

        public override T ConvertIEnumerableToDataTable<T>(System.Collections.Generic.IEnumerable<T> enumeratedObjects, string tableName, string[] primaryKeys)
        {
            throw new NotImplementedException();
        }
    }

    public class CCtoolRow : DataRow
    {
        internal CCtoolRow(DataRowBuilder builder) : base(builder)
        {
        }

        public string Section
        {
            get { return (string) base["Section"]; }
            set { base["Section"] = value; }
        }

        public string ServerName
        {
            get { return (string) base["ServerName"]; }
            set { base["ServerName"] = value; }
        }

        //public int PlatformId
        //{
        //    get { return (int)base["PlatformId"]; }
        //    set { base["PlatformId"] = value; }
        //}

        //public int Id
        //{
        //    get { return (int)base["Id"]; }
        //    set { base["Id"] = value; }
        //}

        //public string DatabaseName
        //{
        //    get { return (string)base["DatabaseName"]; }
        //    set { base["DatabaseName"] = value; }
        //}

        public string SymbolCode
        {
            get { return (string) base["SymbolCode"]; }
            set { base["SymbolCode"] = value; }
        }

        public ulong IsBookA
        {
            get { return (ulong) base["IsBookA"]; }
            set { base["IsBookA"] = value; }
        }

        public decimal BidPrice
        {
            get { return (decimal) base["BidPrice"]; }
            set { base["BidPrice"] = value; }
        }

        public decimal AskPrice
        {
            get { return (decimal) base["AskPrice"]; }
            set { base["AskPrice"] = value; }
        }

        public decimal Volume
        {
            get { return (decimal) base["Volume"]; }
            set { base["Volume"] = value; }
        }

        public decimal ContractSize
        {
            get { return (decimal) base["ContractSize"]; }
            set { base["ContractSize"] = value; }
        }

        public DateTime UpdateDateTime
        {
            get { return (DateTime) base["UpdateDateTime"]; }
            set { base["UpdateDateTime"] = value; }
        }
    }
}