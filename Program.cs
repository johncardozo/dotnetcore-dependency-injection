using System;
using System.IO;
using System.Reflection;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

using iocExample.model;

// Agregar los paquetes al proyecto:
// dotnet add package Microsoft.Extensions.DependencyInjection
// dotnet add package Microsoft.Extensions.Configuration
// dotnet add package Microsoft.Extensions.Configuration.FileExtensions
// dotnet add package Microsoft.Extensions.Configuration.Json
// dotnet restore

namespace iocExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure the app. Setup the settings file
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();

            // Get the class name from settings file
            String nombreClase = configuration.GetSection("ImplementationClass:Animal").Value;
            
            // Create the type
            Type type = Assembly.GetEntryAssembly().GetType("iocExample.model." + nombreClase);

            // Configure the Dependency Injection
            var serviceProvider = new ServiceCollection()            
                //.AddTransient<IAnimal, Perro>() 
                .AddTransient<IAnimal>(implementacion => (IAnimal) Activator.CreateInstance(type))
                .BuildServiceProvider();

            // Get an instance of the object created dynamically
            var animal = serviceProvider.GetService<IAnimal>();

            // Execute the action
            animal.run();

        }
    }


}
