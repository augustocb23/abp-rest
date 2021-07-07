using Abp.Rest.Orders;
using AutoMapper;

namespace Abp.Rest
{
    public class RestApplicationAutoMapperProfile : Profile
    {
        public RestApplicationAutoMapperProfile()
        {
            CreateMap<Client, ClientDto>();
            CreateMap<ClientEditDto, Client>();
            
            CreateMap<Product, ProductDto>();
            CreateMap<ProductEditDto, Product>();

            CreateMap<Order, OrderDto>();
            CreateMap<OrderItem, OrderItemDto>();
        }
    }
}