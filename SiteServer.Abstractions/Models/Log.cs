﻿using System;
using Datory;


namespace SiteServer.Abstractions
{
    [Serializable]
    [DataTable("siteserver_Log")]
    public class Log: Entity
    {
        [DataColumn]
        public string UserName { get; set; }

        [DataColumn]
        public string IpAddress { get; set; }

        [DataColumn]
        public DateTime? AddDate { get; set; }

        [DataColumn]
        public string Action { get; set; }

        [DataColumn]
        public string Summary { get; set; }
    }
}