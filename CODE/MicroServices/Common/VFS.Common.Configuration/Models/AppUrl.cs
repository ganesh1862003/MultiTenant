using System;

namespace VFS.Common.Configuration.Models
{
    public class AppUrl
    {
        public string MissionCode { get; set; }
        public string CountryOpsCode { get; set; }
        public string UnitOpsCode { get; set; }
        public AppUrl(string url)
        {
            var urlArray = url.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            if (urlArray.Length > 2)
                this.MissionCode = urlArray[2];

            if (urlArray.Length > 3)
                this.CountryOpsCode = urlArray[3];

            if (urlArray.Length > 4)
                this.UnitOpsCode = urlArray[4];
        }
    }
}
