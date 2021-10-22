namespace NET6.CrossCutting.IoC;

public static class InfraResolver
{
    public static void AddInfra(this IServiceCollection services)
    {
        services.RegisterAssemblyPublicNonGenericClasses(Assembly.Load("NET6.Infrastructure"))
            .Where(x => x.Name.EndsWith("Repository"))
            .AsPublicImplementedInterfaces(ServiceLifetime.Transient);
    }
}

