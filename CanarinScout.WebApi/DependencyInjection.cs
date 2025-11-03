using CanarinScout.Application.Interfaces;
using CanarinScout.Application.Services;
using CanarinScout.Infrastructure.Interface;
using CanarinScout.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CanarinScout.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Postgres")
                                   ?? Environment.GetEnvironmentVariable("Postgres");

            var herokuDatabaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");

            if (!string.IsNullOrEmpty(herokuDatabaseUrl))
            {
                var databaseUri = new Uri(herokuDatabaseUrl);
                var userInfo = databaseUri.UserInfo.Split(':');

                connectionString =
                    $"Host={databaseUri.Host};Port={databaseUri.Port};Database={databaseUri.LocalPath.Substring(1)};" +
                    $"Username={userInfo[0]};Password={userInfo[1]};SSL Mode=Require;Trust Server Certificate=true";
            }

            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(connectionString));
            return services;
        }

        public static IServiceCollection AddService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<IStatsService, StatsService>();
            services.AddScoped<IAnalysisService, AnalysisService>();
            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<IStatsRepository, StatsRepository>();
            services.AddScoped<IAnalysisRepository, AnalysisRepository>();
            return services;
        }
    }
}
