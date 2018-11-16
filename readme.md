# Dependency Injection + Reflection in .Net Core 2.0

## Dependency Injection 
Dependency injection is a programming technique that makes a class independent of its dependencies. It achieves that by decoupling the usage of an object from its creation. This helps you to follow SOLID’s dependency inversion and single responsibility principles.

Dependency Injection uses classes with the following roles:
1. The service you want to use.
2. The client that uses the service.
3. An interface that’s used by the client and implemented by the service.
4. The injector which creates a service instance and injects it into the client.

In this example, the classes which fulfill the previous roles are:
1. Dog, Cat
2. Program
3. IAnimal
4. ServiceCollection

## Reflection

Reflection provides objects that describe assemblies, modules and types. You can use reflection to dynamically create an instance of a type, bind the type to an existing object, or get the type from an existing object and invoke its methods or access its fields and properties.

## Example implementation

This example shows how to implement the dependency inversion principle using Dependency Injection in C#. This example also uses reflection to allow get the implementation class from a settings file to allow configure which class will execute the action without recompile the app.

To execute this example:
- dotnet restore
- dotnet run
