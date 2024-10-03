
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

IUserActionWriter Writer = new ConsoleWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application started");

ProductService Service = new ProductService(Writer);
Service.Add("Demo", "Azucar refinada");


// --------------Implementación de FieWriter ----------------------

IUserActionWriter DebugWriter = new DebugWriter();

AppLogger LoggerDebugWriter = new AppLogger(DebugWriter);
LoggerDebugWriter.WriteLog("Application started");

ProductService ServiceDebugWriter = new ProductService(DebugWriter);
ServiceDebugWriter.Add("Demo", "Azucar refinada");


// --------------Implementación de FieWriter ----------------------

IUserActionWriter FileWriter = new FileWriter();

AppLogger LoggerFileWriter = new AppLogger(FileWriter);
LoggerFileWriter.WriteLog("Application started");

ProductService ServiceFileWriter = new ProductService(FileWriter);
ServiceFileWriter.Add("Demo", "Azucar refinada");