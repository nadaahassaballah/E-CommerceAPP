using ecommerce.infastructure.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ecommerce.infastructure
{
    public static class infastructureservicesregestrition
    {
        public static IServiceCollection addinfastrucrureservice(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<storeDbcontext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefultConnection"));
            });
            return services;
        }
    }
}
