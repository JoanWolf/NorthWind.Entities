
using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;
using Microsoft.Extensions.DependencyInjection;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();
Builder.Services.AddSingleton<IUserActionWriter, DebugWriter>();
Builder.Services.AddSingleton<IUserActionWriter, ConsoleWriter>();
Builder.Services.AddSingleton<IUserActionWriter, FileWriter>();
Builder.Services.AddSingleton<AppLogger>();
Builder.Services.AddSingleton<ProductService>();
using IHost AppHost = Builder.Build();

//IUserActionWriter Writer = new ConsoleWriter();
//AppLogger Logger = new AppLogger(Writer);


// ---------Implementación de la clase HostApplicationBuilder------------
AppLogger Logger = AppHost.Services.GetRequiredService<AppLogger>();
Logger.WriteLog("Application started");

//ProductService Service = new ProductService(Writer);
ProductService Service = AppHost.Services.GetService<ProductService>();
Service.Add("Demo", "Azucar refinada");


// --------------Implementación de FileWriter con instancia de objeto ----------------------

//IUserActionWriter DebugWriter = new DebugWriter();

//AppLogger LoggerDebugWriter = new AppLogger(DebugWriter);
//LoggerDebugWriter.WriteLog("Application started");

//ProductService ServiceDebugWriter = new ProductService(DebugWriter);
//ServiceDebugWriter.Add("Demo", "Azucar refinada");


//// --------------Implementación de FieWriter con instancia de objeto ----------------------

//IUserActionWriter FileWriter = new FileWriter();

//AppLogger LoggerFileWriter = new AppLogger(FileWriter);
//LoggerFileWriter.WriteLog("Application started");

//ProductService ServiceFileWriter = new ProductService(FileWriter);
//ServiceFileWriter.Add("Demo", "Azucar refinada");