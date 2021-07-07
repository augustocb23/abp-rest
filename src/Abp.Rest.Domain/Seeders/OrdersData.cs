using System;
using System.Collections.Generic;
using Abp.Rest.Orders;

namespace Abp.Rest.Seeders
{
    public static class OrdersData
    {
        public static IEnumerable<Order> GetData() => new[]
        {
            new Order(new Guid("9c75b96b-525e-4285-a835-0f8de4f402a7"))
            {
                Client = new Client(new Guid("e59c9928-a88c-4a8d-98a8-32840a3cec38")) {FullName = "Clarke Leon"},
                Items = new[]
                {
                    new OrderItem(new Guid("86082398-47ff-42eb-88b5-1804a9ef264f"))
                    {
                        Product = new Product(new Guid("86ccf18c-a151-4012-81fa-3de07faa1b25"))
                            {Name = "Mediocre Wooden Watch"},
                        Quantity = 3
                    },
                    new OrderItem(new Guid("9c78813f-80d3-4bd1-8a05-a3e94c67ad39"))
                    {
                        Product = new Product(new Guid("ab7370cd-b34a-4902-bf4f-9ca71461a01a"))
                            {Name = "Rustic Leather Plate"},
                        Quantity = 4
                    }
                }
            },
            new Order(new Guid("20031b4c-d591-4c9f-a55a-01b01896fb8c"))
            {
                Client = new Client(new Guid("178f8688-04c8-49c9-a144-e65618524499")) {FullName = "Terry Achey"},
                Items = new[]
                {
                    new OrderItem(new Guid("15f6d7dc-7f01-4aff-9299-ca6f3b58bd25"))
                    {
                        Product = new Product(new Guid("33420b11-c0c5-4b5c-aafd-e324877d7fb5"))
                            {Name = "Sleek Plastic Wallet"},
                        Quantity = 9
                    }
                }
            },
            new Order(new Guid("d3a72aef-d71b-484a-afde-56b103cf46ca"))
            {
                Client = new Client(new Guid("6e578db5-1843-475a-a238-b11225a55581")) {FullName = "Myra Maines"},
                Items = new[]
                {
                    new OrderItem(new Guid("d43f5e88-66e3-40e1-98fc-2139fc5ab821"))
                    {
                        Product = new Product(new Guid("14d159f4-57f1-4b52-b8cf-d2daeeba688c"))
                            {Name = "Lightweight Silk Hat"},
                        Quantity = 4
                    },
                    new OrderItem(new Guid("5d961a45-9c39-47ea-84ff-22df98ce8b80"))
                    {
                        Product = new Product(new Guid("0498a934-f446-4a99-b83a-28a41910059c"))
                            {Name = "Incredible Granite Computer"},
                        Quantity = 1
                    }
                }
            }
        };
    }
}