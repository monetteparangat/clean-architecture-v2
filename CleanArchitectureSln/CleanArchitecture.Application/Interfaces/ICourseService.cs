using CleanArchitecture.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ICourseService
    {
        public CourseVM GetCourses();
        public void Create(CourseVM course);
    }
}
