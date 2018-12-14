using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace RemiBou.Blazor.DataAnnotation
{
    public static class ServiceCollectionExtension
    {
        public static void AddDataAnnotationValidation(this IServiceCollection services)
        {
            services.AddSingleton<IModelValidator, ModelValidator>();

        }
    }
}
