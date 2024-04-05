﻿using Microsoft.EntityFrameworkCore;
using Repostories.EFCore;

namespace WebApi.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
        }
    }
}