﻿using System.Net;
using XPloit.Core.Multi;

namespace XPloit.Core.Configs
{
    public class ListenSocketConfig : ClientSocketConfig
    {
        /// <summary>
        /// IP Filter
        /// </summary>
        public IPFilter IPFilter { get; set; }
    }
}