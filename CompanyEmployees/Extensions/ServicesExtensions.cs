namespace CompanyEmployees.Extensions;

public static class ServicesExtensions
{
    public static void ConfigureCors(this IServiceCollection services) => services.AddCors(options =>
    {
        options.AddPolicy("CorsPolicy", builder =>
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
    });

    public static void ConfigureISSIntegration(this IServiceCollection services) =>
        services.Configure<IISOptions>(options =>
        {

        });
}
