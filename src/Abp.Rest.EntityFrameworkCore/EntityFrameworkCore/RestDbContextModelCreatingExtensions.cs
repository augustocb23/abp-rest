using Abp.Rest.Orders;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Abp.Rest.EntityFrameworkCore
{
    public static class RestDbContextModelCreatingExtensions
    {
        public static void ConfigureRest(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Client>(b =>
            {
                b.ToTable($"{RestConsts.DbTablePrefix}Clients", RestConsts.DbSchema);
                b.ConfigureByConvention();

                b.Property(client => client.FullName).IsRequired();
                b.HasIndex(client => client.FullName);
            });

            builder.Entity<Product>(b =>
            {
                b.ToTable($"{RestConsts.DbTablePrefix}Products", RestConsts.DbSchema);
                b.ConfigureByConvention();

                b.Property(product => product.Name).IsRequired();
                b.HasIndex(product => product.Name);
            });

            builder.Entity<OrderItem>(b =>
            {
                b.ToTable($"{RestConsts.DbTablePrefix}OrderItems", RestConsts.DbSchema);
                b.ConfigureByConvention();

                b.Property(item => item.Quantity).IsRequired();
            });
            
            builder.Entity<Order>(b =>
            {
                b.ToTable($"{RestConsts.DbTablePrefix}Orders", RestConsts.DbSchema);
                b.ConfigureByConvention();
            });
        }
    }
}