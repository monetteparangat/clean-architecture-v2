using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.CommandHandlers;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Bus;
using CleanArchitecture.Infrastructure.Data.Context;
using CleanArchitecture.Infrastructure.Data.Repository;
using MediatR;
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
            services.AddScoped<ICourseService, CourseService>();

            //Domain - Infra.Data
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDbContext>();

            //Domain IMediatr
            services.AddScoped<IMediatorHandler, InMemoryBus>();
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();
        }
    }
}
