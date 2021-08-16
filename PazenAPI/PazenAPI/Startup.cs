using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PazenAPI.Data;
using PazenAPI.Mapper;
using PazenAPI.Models;
using PazenAPI.Repository;
using PazenAPI.Repository.IRepository;

namespace PazenAPI
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
            services.AddControllers();

            #region DBContext
            services.AddDbContext<DataContext>
                (options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            #endregion

            #region Repository DI Container
            services.AddTransient<IGenCRUDRepository<MarketType>, GenCRUDRepository<MarketType>>();
            services.AddTransient<IGenCRUDRepository<Photo>, GenCRUDRepository<Photo>>();
            services.AddTransient<IGenCRUDRepository<Property>, GenCRUDRepository<Property>>();
            services.AddTransient<IGenCRUDRepository<PropertyType>, GenCRUDRepository<PropertyType>>();
            services.AddTransient<IGenCRUDRepository<Room>, GenCRUDRepository<Room>>();
            services.AddTransient<IGenCRUDRepository<Mandate>, GenCRUDRepository<Mandate>>();
            services.AddTransient<IGenCRUDRepository<Address>, GenCRUDRepository<Address>>();
            services.AddTransient<IGenCRUDRepository<PropertyOwner>, GenCRUDRepository<PropertyOwner>>();

            #endregion

            #region AutoMapper
            services.AddAutoMapper(typeof(Mappings));
            #endregion

            #region CORS 
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder => builder.AllowAnyOrigin());
            });
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
