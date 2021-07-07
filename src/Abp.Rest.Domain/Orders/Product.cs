using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Rest.Orders
{
    public class Product : AuditedEntity<Guid>
    {
        public Product()
        {
        }

        public Product(Guid id) : base(id)
        {
        }

        public string Name { get; set; }
    }
}