using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repostories.EFCore.Config
{
    public class BookConfig: IEntityTypeConfiguration<Book>
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
