using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Rest.Orders
{
    public class Order : AuditedAggregateRoot<Guid>
    {
        public Client Client { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }
    }
}