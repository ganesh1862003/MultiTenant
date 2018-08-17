using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VFS.Common.Configuration.Models;
using VFS.Common.Configuration.Repository;

namespace VFS.Common.Configuration
{
    public class ConfigurationManager : IConfigurationManager
    {
        private readonly IConfigurationRepository _configurationRepository;

        public ConfigurationManager(IConfigurationRepository configurationRepository)
        {
            _configurationRepository = configurationRepository;
        }

        /// <summary>
        /// This method is used to get System ConfigurationValue (DB connection details)
        /// </summary>
        /// <param name="context"></param>
        /// <param name="configurationKey"></param>
        /// <returns>It returns Configuration Value based on enigmacontext and configurationkey</returns>
        public async Task<SystemConfiguration> GetSystemConfigurationAsync(AppContext context, string configurationKey)
        {
            var configurations = await _configurationRepository.GetSystemConfigurationAsync(context, configurationKey);

            return SelectConfiguration(configurations, context);
        }

        /// <summary>
        /// Returns system configuration on basis of enigma context 
        /// </summary>
        /// <param name="configurations"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        private SystemConfiguration SelectConfiguration(IList<SystemConfiguration> configurations, AppContext context)
        {
            if (configurations == null && configurations.Count <= 0) return null;

            var configuration = configurations.FirstOrDefault(x => x.UnitOpsId.HasValue && context.UnitOpsID.HasValue &&
                                                                        x.UnitOpsId == context.UnitOpsID);
            if (configuration != null) return configuration;


            configuration = configurations.FirstOrDefault(x => !x.UnitOpsId.HasValue && !context.UnitOpsID.HasValue &&
                                                                        x.CountryOpsId.HasValue && context.CountryOpsID.HasValue &&
                                                                        x.MissionId.HasValue && context.MissionID.HasValue &&
                                                                        x.CountryOpsId == context.CountryOpsID && x.MissionId == context.MissionID);
            if (configuration != null) return configuration;


            configuration = configurations.FirstOrDefault(x => !x.UnitOpsId.HasValue && !context.UnitOpsID.HasValue &&
                                                                        !x.CountryOpsId.HasValue && !context.CountryOpsID.HasValue &&
                                                                        x.MissionId.HasValue && context.MissionID.HasValue &&
                                                                        x.MissionId == context.MissionID);
            if (configuration != null) return configuration;


            configuration = configurations.FirstOrDefault(x => !x.UnitOpsId.HasValue && !context.UnitOpsID.HasValue &&
                                                                        !x.CountryOpsId.HasValue && !context.CountryOpsID.HasValue &&
                                                                        !x.MissionId.HasValue && !context.MissionID.HasValue);
            if (configuration != null) return configuration;

            return null;
        }
    }
}
