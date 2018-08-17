using System;

namespace VFS.Common.Configuration.Models
{
    public class AppContext
    {
        public Guid? MissionID { get; set; }
        public Guid? CountryOpsID { get; set; }
        public Guid? UnitOpsID { get; set; }
    }
}
