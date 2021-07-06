using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Rest.Orders
{
    public class Product : AuditedEntity<Guid>
    {
        public string Name { get; set; }
    }
}