using AutoMapper;
using Classificacao.ApplicationCore.Interfaces.Repository;
using Classificacao.ApplicationCore.Interfaces.Services;
using Classificacao.ApplicationCore.Services;
using Classificacao.ApplicationLayer;
using Classificacao.ApplicationLayer.Interface;
using Classificacao.Infrastructure.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Classificacao.WebApiApplication
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddAutoMapper();

            services.AddSingleton(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            services.AddSingleton(typeof(IClienteAppService), typeof(ClienteAppService));
            services.AddSingleton(typeof(IFilaAppService), typeof(FilaAppService));
            services.AddSingleton(typeof(ICitacaoAppService), typeof(CitacaoAppService));

            services.AddSingleton(typeof(IClassificacaoService<>), typeof(ClassificacaoService<>));
            services.AddSingleton(typeof(IClienteService), typeof(ClienteService));
            services.AddSingleton(typeof(IFilaService), typeof(FilaService));
            services.AddSingleton(typeof(ICitacaoService), typeof(CitacaoService));

            services.AddSingleton(typeof(IClienteRepository), typeof(ClienteRepository));
            services.AddSingleton(typeof(IFilaRepository), typeof(FilaRepository));
            services.AddSingleton(typeof(ICitacaoRepository), typeof(CitacaoRepository));
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
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
