using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class Startup
{

    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(conf => conf.RegisterServicesFromAssembly(GetApplicationAssembly()));
        services.AddValidatorsFromAssembly(GetApplicationAssembly());

        return services;
    }
    public static Assembly GetApplicationAssembly()
    {
        return typeof(Startup).Assembly;
    }
}

public static class ApplicationProject
{
    public static Assembly Assembly => typeof(Startup).Assembly;
    
}
