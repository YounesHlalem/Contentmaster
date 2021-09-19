using AutoMapper;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace DAL
{
    public static class DALExtenstion
    {

        public static IServiceCollection AddContext(this IServiceCollection service, string conectionString, string migrationsAssembly)
        {
            service.AddDbContext<E4ProgressContext>(
                dbContextOptions => dbContextOptions
                    .UseMySql(conectionString, new MySqlServerVersion(new Version(8, 0, 21)), mySqlOptions => mySqlOptions.MigrationsAssembly(migrationsAssembly))
                    .UseLoggerFactory(LoggerFactory.Create(b => b
                        .AddFilter(level => level > LogLevel.Information)
                    ))
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors()
                );

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new DataMapper());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            service.AddSingleton(mapper);

            return service;
        }
    }
}
