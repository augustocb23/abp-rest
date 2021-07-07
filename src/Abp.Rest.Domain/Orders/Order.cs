using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Rest.Orders
{
    public class Order : AuditedAggregateRoot<Guid>
    {
        public Order()
        {
        }

        public Order(Guid id) : base(id)
        {
        }

        public Guid ClientId { get; set; }
        public Client Client { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }
    }
}