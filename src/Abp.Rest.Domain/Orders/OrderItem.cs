using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Rest.Orders
{
    public class OrderItem : AuditedEntity<Guid>
    {
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
    }
}