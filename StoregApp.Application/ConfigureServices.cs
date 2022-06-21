using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddAplicationServices(this IServiceCollection services)
        {
            //Registra automaticamente todos los mapping de Automapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            //Registra automaticamente todos los validadores de Fluent Validation
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }


    }
}
