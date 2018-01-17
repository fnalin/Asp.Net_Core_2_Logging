using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Reflection;

namespace DemoConsoleApp
{
    //logging.apache.org/log4net/release/manual/configuration.html
    //docs.microsoft.com/pt-br/aspnet/core/fundamentals/logging/?tabs=aspnetcore2x
    class Program
    {
        static void Main(string[] args)
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            var logger = LogManager.GetLogger(typeof(Program));
            logger.Error($"Hello World {new Random().Next(10)}!");

            Console.WriteLine("FIM");
        }
    }
}
