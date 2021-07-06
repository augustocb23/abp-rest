using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Rest.Orders
{
    public class Client : AuditedEntity<Guid>
    {
        public string FullName { get; set; }
    }
}