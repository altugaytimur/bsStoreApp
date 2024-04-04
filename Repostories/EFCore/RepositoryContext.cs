using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repostories.EFCore.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repostories.EFCore;

public class RepositoryContext:DbContext
{
    public RepositoryContext(DbContextOptions options):base(options)
    {
        
    }
    public DbSet<Book> Books { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BookConfig());
    }
}



