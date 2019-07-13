using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicShop.Business.Abstract;
using BasicShop.Business.Concrete;
using BasicShop.DataAccess.Abstract;
using BasicShop.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BasicShop.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSingleton<IProductDal, EfProductDal>();
            services.AddSingleton<ICategoryDal, EfCategoryDal>();
            services.AddSingleton<IUserDal, EfUserDal>();
            services.AddSingleton<IOrderDal, EfOrderDal>();

            services.AddSingleton<IProductService, ProductManager>();
            services.AddSingleton<IOrderService, OrderManager>();
            services.AddSingleton<ICategoryService, CategoryManager>();
            services.AddSingleton<IUserService, UserManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseMvc();
        }
    }
}