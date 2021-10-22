namespace NET6.CrossCutting.IoC;

public static class DomainResolver
{
    public static void AddDomain(this IServiceCollection services)
    {
        services.RegisterAssemblyPublicNonGenericClasses(Assembly.Load("NET6.Domain"))
            .Where(x => x.Name.EndsWith("Service"))
            .AsPublicImplementedInterfaces(ServiceLifetime.Scoped);
    }
}
