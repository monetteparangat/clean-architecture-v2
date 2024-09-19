using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseVM GetCourses()
        {
            var courses = new CourseVM
            {
                Courses = _courseRepository.GetCourses()
            };

            return courses;
        }

        public void Create(CourseVM courseVM)
        {
            var createCourseCommand = new CreateCourseCommand(
                courseVM.Name,
                courseVM.Description,
                courseVM.ImageUrl
                );

            _bus.SendCommand(createCourseCommand);
        }
    }
}
