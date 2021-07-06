using System;
using Volo.Abp.Application.Dtos;

namespace Abp.Rest.Orders
{
    public class ProductDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
    }
}