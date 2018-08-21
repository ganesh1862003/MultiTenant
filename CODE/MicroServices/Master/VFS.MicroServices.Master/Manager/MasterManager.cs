using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VFS.Common.Configuration.Models;
using VFS.MicroServices.Master.Models;
using VFS.MicroServices.Master.Repository;

namespace VFS.MicroServices.Master.Manager
{
    public class MasterManager : IMasterManager
    {
        private IMasterRepository _masterRepository = null;
        public MasterManager(IMasterRepository masterRepository) => _masterRepository = masterRepository;


        public async Task<IDictionary<string, object>> FetchMasterMetaDataAsync(ApplicationContext applicationContext, FormMetadataContext formMetadataContext)
        {
            var result = await _masterRepository.FetchMasterMetadataAsync<FormTableMetaData>(applicationContext, formMetadataContext);
            IDictionary<string, object> objMastersList = null;

            if (result == null || result.Count == 0)
                return objMastersList;

            objMastersList = new Dictionary<string, object>();

            foreach (var i in result)
            {
                //To get class object type dynamically 
                var asm = typeof(TempAssemblyType).Assembly;
                var tableName = i.TableName.Substring(4);
                var modelType = asm.GetType("VFS.MicroServices.Master.Models." + tableName);
                if (modelType == null)
                    continue;

                var modelClassType = _masterRepository.GetType();
                var methodInfo = modelClassType.GetMethod("FetchMasterDataAsync");
                Type[] genericArguments = new Type[] { modelType };
                var genericMethodInfo = methodInfo.MakeGenericMethod(genericArguments);
                object resultList = await (dynamic)genericMethodInfo.Invoke(_masterRepository, new object[] { applicationContext, i });
                objMastersList.Add(tableName, resultList);
            }

            return objMastersList;
        }
    }
}
