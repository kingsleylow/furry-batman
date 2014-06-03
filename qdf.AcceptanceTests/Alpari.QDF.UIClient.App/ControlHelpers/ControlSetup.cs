﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpari.QDF.UIClient.App.ControlHelpers
{
    public class ControlSetup
    {
        public ControlSetup(TradingServerControl tradingServerControl, BookControl bookControl)
        {
            TradingServerControl = tradingServerControl;
            BookControl = bookControl;
        }

        public TradingServerControl TradingServerControl { get; private set; }
        public BookControl BookControl { get; set; }
    }
}
