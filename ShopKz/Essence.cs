using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopKz
{
    public class Essence
    {
        public void ConfigureServices(IServiceCollection services)
        {
            string connection = "Server=(localdb)\\mssqllocaldb; Database=Shop.kz; Trusted_connection=true;";
            services.AddDbContext<ProductsContext>(options => options.UseSqlServer(connection));
            //services.AddControllersWithViews();
        }
    }
}
