using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VFS.Common.Configuration.Models;
using VFS.Common.BaseService;
using VFS.Common.BaseService.Models;
using VFS.MicroServices.Master.Models;
using VFS.MicroServices.Master.Manager;

namespace VFS.MicroServices.Master
{
    [Route("api/v{version}/{missionCode}/{countryOpsCode}/{unitOpsCode}/Master")]
    public class MasterService : BaseService
    {
        private readonly IMasterManager _masterManager = null;

        /// <summary>
        /// Default parameterize class constructor. 
        /// It takes IMasterManager and IHttpContextAccessor type object as input parameter
        /// </summary>
        /// <param name="IMasterManager"></param>
        /// <param name="IHttpContextAccessor"></param>
        public MasterService(IMasterManager masterManager, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            _masterManager = masterManager;
        }

        /// <summary>
        /// This method returns generic master data by passing formmetadata params like formid, formcatid, fieldid
        /// </summary>
        /// <param name="FormMetadataContext"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetGenericMasterData")]
        public async Task<IActionResult> FetchMasterDataAsync([FromBody]FormMetadataContext formMetadataContext)
        {
            try
            {
                var response = new AppServiceResponse<IDictionary<string, object>>();
                var result = await _masterManager.FetchMasterMetaDataAsync(AppContext, formMetadataContext);
                if (result == null) return NotFound();
                response.Data = result;
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }
    }
}
