using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models;

namespace WebApi.Repositories.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, Title = "Bilim", Price = 150 },
                new Book { Id = 2, Title = "Tarih", Price = 200 },
                new Book { Id = 3, Title = "Sanat", Price = 220 },
                new Book { Id = 4, Title = "Fizik", Price = 250 }
                );
                
        }
    }
}
