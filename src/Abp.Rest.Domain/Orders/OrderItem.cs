using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Rest.Orders
{
    public class OrderItem : AuditedEntity<Guid>
    {
        public OrderItem()
        {
        }

        public OrderItem(Guid id) : base(id)
        {
        }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}