using Abp.Rest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.Rest.Permissions
{
    public class RestPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var defaultGroup = context.AddGroup(RestPermissions.GroupName);

            var ordersGroup = context.AddGroup(OrdersPermissions.GroupName);
            var orders = ordersGroup.AddPermission(OrdersPermissions.Default, L("Permissions:Orders.Default"));
            orders.AddChild(OrdersPermissions.Clients, L("Permissions:Orders.Clients"));
            orders.AddChild(OrdersPermissions.Products, L("Permissions:Orders.Products"));
            orders.AddChild(OrdersPermissions.Orders, L("Permissions:Orders.Orders"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<RestResource>(name);
        }
    }
}