using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VFS.Common.BaseService.Models;
using VFS.Common.Configuration.Models;

namespace VFS.Common.BaseService
{
    [ApiVersion("1.0")]
    [EnableCors("CorsPolicy")]
    public class BaseService : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        protected HttpContext Context => _httpContextAccessor.HttpContext;

        public BaseService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// EnigmaContext method returns mission, unitops and country of operation guid
        /// </summary>
        public AppContext AppContext
        {
            get
            {
                if (Context != null)
                {
                    var appContext = Context.Items[ServiceBaseConstant.AppContext];

                    if (appContext != null)
                    {
                        return appContext as AppContext;
                    }
                }

                return null;
            }
        }

        /// <summary>
        /// This method returns the EnigmaUrl   
        /// </summary>
        public AppUrl EnigmaRedirectionUrl
        {
            get
            {
                if (Context != null)
                {
                    var _AppUrl = Context.Items[ServiceBaseConstant.AppRedirectionUrl];

                    if (_AppUrl != null)
                    {
                        return _AppUrl as AppUrl;
                    }
                }

                return null;
            }
        }
    }
}
