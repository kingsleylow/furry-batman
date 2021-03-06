﻿using Alpari.QDF.Domain;
using BookSleeve;
using System.Collections.Generic;

namespace Alpari.QDF.UIClient.App
{
    /// <summary>
    ///     warning - repeated this code in qdf.AcceptanceTests.Helpers
    /// </summary>
    public class RedisConnectionHelper
    {
        public RedisConnectionHelper(string redisHost)
        {
            RedisHost = redisHost;
            Connection = new RedisConnection(RedisHost);
            Connection.Open();
            RedisDealSearches = new RedisDealSearches(this);
            RedisQuoteSearches = new RedisQuoteSearches(this);
            PerformanceStats = new PerformanceStats(this);
        }

        public RedisConnectionHelper(string redisHost, int port = 6379, int ioTimeout = -1, string password = null, int maxUnsent = 2147483647, bool allowAdmin = false, int syncTimeout = 10000)
        {
            RedisHost = redisHost;
            Connection = new RedisConnection(redisHost, port, ioTimeout, password,maxUnsent,allowAdmin,syncTimeout);
            Connection.Open();
            RedisDealSearches = new RedisDealSearches(this);
            RedisQuoteSearches = new RedisQuoteSearches(this);
            PerformanceStats = new PerformanceStats(this);
        }

        public RedisDataStore DealsStore { get; set; }
        public List<Deal> RetrievedDeals { get; set; }
        public RedisDataStore QuoteStore { get; set; }
        public List<LevelQuote> RetrievedQuotes { get; set; }
        public RedisConnection Connection { get; private set; }
        public string RedisHost { get; private set; }

        public RedisDealSearches RedisDealSearches { get; private set; }

        public RedisQuoteSearches RedisQuoteSearches { get; private set; }

        public PerformanceStats PerformanceStats { get; private set; }

        /// <summary>
        /// bit hacky, should really be usingthe exporter and just reset the whole connection
        /// </summary>
        public void ResetPerformanceStats()
        {
            DealsStore = null;
            if (RetrievedDeals != null)
            {
                RetrievedDeals.Clear();
            }
            
            QuoteStore = null;
            if (RetrievedQuotes != null)
            {
                RetrievedQuotes.Clear();
            }

            RedisDealSearches = new RedisDealSearches(this);
            RedisQuoteSearches = new RedisQuoteSearches(this);
            PerformanceStats = new PerformanceStats(this);
        }
    }
}