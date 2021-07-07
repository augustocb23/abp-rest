using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Rest.Orders
{
    public class Client : AuditedEntity<Guid>
    {
        public Client()
        {
        }

        public Client(Guid id) : base(id)
        {
        }

        public string FullName { get; set; }
    }
}