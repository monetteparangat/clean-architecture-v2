using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDbContext _context;
        public CourseRepository(UniversityDbContext context) 
        { 
            _context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
           return _context.Courses;
        }
    }
}
