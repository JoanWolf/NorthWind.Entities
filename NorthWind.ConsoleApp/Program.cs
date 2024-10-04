
using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;
using Microsoft.Extensions.DependencyInjection;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();


Builder.Services.AddNorthWindServices();


using IHost AppHost = Builder.Build();



IAppLogger Logger = AppHost.Services.GetRequiredService<IAppLogger>();
Logger.WriteLog("Application started");


IProductService Service = AppHost.Services.GetService<IProductService>();
Service.Add("Demo", "Azucar refinada");


