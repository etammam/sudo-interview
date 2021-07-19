using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Sudo.Application.Persistence;
using Sudo.Application.Services.ClientService;

namespace Sudo.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection service)
        {
            service.AddSingleton<IFileProvider>(new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));
            service.AddHttpContextAccessor();
            service.AddSingleton<IStore, StoreManager>();
            service.AddScoped<IClient, ClientManager>();
            return service;
        }
        public static IApplicationBuilder UseApplication(this IApplicationBuilder app)
        {
            app.UseStaticFiles();
            return app;
        }
    }
}
