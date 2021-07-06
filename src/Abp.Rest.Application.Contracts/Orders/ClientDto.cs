using System;
using Volo.Abp.Application.Dtos;

namespace Abp.Rest.Orders
{
    public class ClientDto : AuditedEntityDto<Guid>
    {
        public string FullName { get; set; }   
    }
}