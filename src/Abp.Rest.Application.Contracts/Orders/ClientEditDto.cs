using System;
using System.ComponentModel.DataAnnotations;

namespace Abp.Rest.Orders
{
    public class ClientEditDto
    {
        public Guid Id { get; set; }

        [Required]
        public string FullName { get; set; }
    }
}