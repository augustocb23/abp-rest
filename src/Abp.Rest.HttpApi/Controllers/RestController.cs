using Abp.Rest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Rest.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class RestController : AbpController
    {
        protected RestController()
        {
            LocalizationResource = typeof(RestResource);
        }
    }
}