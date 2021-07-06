using System;
using System.Collections.Generic;
using System.Text;
using Abp.Rest.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Rest
{
    /* Inherit your application services from this class.
     */
    public abstract class RestAppService : ApplicationService
    {
        protected RestAppService()
        {
            LocalizationResource = typeof(RestResource);
        }
    }
}
