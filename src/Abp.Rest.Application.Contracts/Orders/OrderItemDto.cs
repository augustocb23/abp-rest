using System;

namespace Abp.Rest.Orders
{
    public class OrderItemDto
    {
        public Guid ProductId { get; set; }
        public decimal Quantity { get; set; }
    }
}