using System;
using System.ComponentModel.DataAnnotations;

namespace Abp.Rest.Orders
{
    public class ProductEditDto
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}