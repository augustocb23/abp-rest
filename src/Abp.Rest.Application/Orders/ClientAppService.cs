using System;
using Abp.Rest.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Rest.Orders
{
    public class ClientAppService :
        CrudAppService<Client, ClientDto, Guid, PagedAndSortedResultRequestDto, ClientEditDto>,
        IClientAppService
    {
        public ClientAppService(IRepository<Client, Guid> repository) : base(repository)
        {
            GetPolicyName = OrdersPermissions.Clients;
            GetListPolicyName = OrdersPermissions.Clients;
            CreatePolicyName = OrdersPermissions.Clients;
            UpdatePolicyName = OrdersPermissions.Clients;
            DeletePolicyName = OrdersPermissions.Clients;
        }
    }
}