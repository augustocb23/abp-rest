using Abp.Rest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.Rest.Permissions
{
    public class RestPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(RestPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(RestPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<RestResource>(name);
        }
    }
}
