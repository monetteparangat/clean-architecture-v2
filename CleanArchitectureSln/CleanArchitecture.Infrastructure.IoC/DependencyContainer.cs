using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application
            services.AddScoped<ICourseService, ICourseService>();

            //Domain
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
