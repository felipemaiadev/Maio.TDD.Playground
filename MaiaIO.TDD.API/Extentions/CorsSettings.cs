namespace MaiaIO.TDD.API.Extentions
{
    public static class CorsSettings
    {

        public static IServiceCollection CorsSettingsConfiguration(this IServiceCollection services)
        {
            services.AddCors(p => p.AddPolicy("AllowAll", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            return services;
        }
    }
}
