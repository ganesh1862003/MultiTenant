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
        public ApplicationContext AppContext
        {
            get
            {
                if (Context != null)
                {
                    var appContext = Context.Items[ServiceBaseConstant.ApplicationContext];

                    if (appContext != null)
                    {
                        return appContext as ApplicationContext;
                    }
                }

                return null;
            }
        }

        /// <summary>
        /// This method returns the EnigmaUrl   
        /// </summary>
        public ApplicationUrl AppRedirectionUrl
        {
            get
            {
                if (Context != null)
                {
                    var _AppUrl = Context.Items[ServiceBaseConstant.ApplicationRedirectionUrl];

                    if (_AppUrl != null)
                    {
                        return _AppUrl as ApplicationUrl;
                    }
                }

                return null;
            }
        }
    }
}
