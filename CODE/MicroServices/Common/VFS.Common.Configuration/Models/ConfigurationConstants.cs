
namespace VFS.Common.Configuration.Models
{
    /// <summary>
    /// This model class is used to store the configuration key
    /// </summary>
    public class ConfigurationConstants
    {
        public const string SHARED_DB_CONFIGURATION_KEY = "SharedDB";
        public const string TRANSACTION_DB_CONFIGURATION_KEY = "TransactionDB";
    }
    /// <summary>
    /// This model class is used to store SP's related to Configuration
    /// </summary>
    public class ConfigurationSPConstants
    {
        public const string GetSystemConfiguration = "dbo.usp_GetSystemConfiguration";
    }
}
