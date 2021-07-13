namespace Abp.Rest.Permissions
{
    public class OrdersPermissions
    {
        public const string GroupName = "Orders";

        public const string Default = GroupName + ".Default";
        public const string Clients = GroupName + ".Clients";
        public const string Products = GroupName + ".Products";
        public const string Orders = GroupName + ".Orders";
    }
}