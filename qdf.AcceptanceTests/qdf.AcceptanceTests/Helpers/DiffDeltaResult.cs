﻿using System;

namespace qdf.AcceptanceTests.Helpers
{
    public class DiffDeltaResult
    {

        public string HiSource { get; set; }

        public string LoSource { get; set; }

        public decimal Diff { get; set; }

        public decimal Delta { get; set; }

        public long Id { get; set; }

        public decimal Position { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}