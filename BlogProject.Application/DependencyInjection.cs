using BlogProject.Application.Behavior;
using BlogProject.Domain;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BlogProject.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        services.AddAutoMapper(typeof(DependencyInjection).Assembly);

        services.AddMediatR(conf =>
        {
            conf.RegisterServicesFromAssemblies(
                typeof(DependencyInjection).Assembly,
                typeof(AppUser).Assembly);
            conf.AddOpenBehavior(typeof(ValidationBehavior<,>));
        });

        object value = services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

        return services;

    }
}
