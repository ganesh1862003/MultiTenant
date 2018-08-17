using System;
using System.Collections.Generic;
using System.Text;

namespace VFS.Common.Configuration.Models
{
    public class SystemConfiguration
    {
        public int Id { get; set; }
        public Guid? MissionId { get; set; }
        public Guid? CountryOpsId { get; set; }
        public Guid? UnitOpsId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
