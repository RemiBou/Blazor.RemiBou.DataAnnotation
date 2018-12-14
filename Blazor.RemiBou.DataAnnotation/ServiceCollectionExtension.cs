using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.RemiBou.DataAnnotation
{
    public static class ServiceCollectionExtension
    {
        public static void AddDataAnnotationValidation(this IServiceCollection services)
        {
            services.AddSingleton<IModelValidator, ModelValidator>();

        }
    }
}
