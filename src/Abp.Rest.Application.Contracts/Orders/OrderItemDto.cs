namespace Abp.Rest.Orders
{
    public class OrderItemDto
    {
        public ProductDto Product { get; set; }
        public decimal Quantity { get; set; }
    }
}