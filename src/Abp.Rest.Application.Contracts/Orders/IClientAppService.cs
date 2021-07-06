using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Rest.Orders
{
    public interface IClientAppService :
        ICrudAppService<ClientDto, Guid, PagedAndSortedResultRequestDto, ClientEditDto>
    {
    }
}