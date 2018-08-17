namespace VFS.Common.Configuration.Models
{
    public class ConfigurationSettings
    {
        public string ConfigDbConnectionString { get; set; }
        public string MasterApiBaseUrl { get; set; }
        public string MasterApi { get; set; }
        public string MasterVersion { get; set; }
        public string MasterPort { get; set; }        
    }
}
