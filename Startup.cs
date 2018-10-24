using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Data.SqlClient;

namespace WebApplication3
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            var con = @"Server=(localdb)\\USER-PC;Database=Bank;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(con));

           

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();

            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            var con = new SqlConnection("Server=(localdb)\\USER-PC;Database=Bank;Trusted_Connection=True;ConnectRetryCount=0");

            app.UseStaticFiles();
            app.UseMvc(routes =>
                        {
                            routes.MapRoute(
                            name: "default",
                            template: "{controller=Home}/{action=Index}/{id?}");
                        });

           

        }
    }


}
