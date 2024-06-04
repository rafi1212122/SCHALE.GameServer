using Microsoft.EntityFrameworkCore;
using SCHALE.Common.Database;

namespace SCHALE.GameServer.Utils
{
    public static class ServicesExtesions
    {
        public static Exception NoConnectionStringException = new ArgumentNullException($"ConnectionString in appsettings is missing");

        public static void AddDbProvider(this IServiceCollection services, IConfiguration conf)
        {
            var sqlProvider = conf.GetValue<string>("SQL Provider");
            switch (sqlProvider)
            {
                case "SQLite3":
                    services.AddDbContext<SCHALEContext, SCHALESqliteContext>(opt =>
                        opt
                        .UseSqlite(conf.GetConnectionString("SQLite3") ?? throw NoConnectionStringException)
                        .UseLazyLoadingProxies()
                    , ServiceLifetime.Singleton, ServiceLifetime.Singleton);
                    break;
                case "SQLServer":
                    services.AddDbContext<SCHALEContext>(opt =>
                       opt
                       .UseSqlServer(conf.GetConnectionString("SQLServer") ?? throw NoConnectionStringException)
                       .UseLazyLoadingProxies()
                    , ServiceLifetime.Singleton, ServiceLifetime.Singleton);
                    break;
                default: throw new ArgumentException($"SQL Provider '{sqlProvider}' is not valid");
            }
        }
    }
}