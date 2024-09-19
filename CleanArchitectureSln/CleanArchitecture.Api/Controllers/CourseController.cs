using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ILogger<CourseController> _logger;
        private readonly ICourseService _courseService;

        public CourseController(ILogger<CourseController> logger,
            ICourseService courseService)
        {
            _logger = logger;
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CourseVM courseVM)
        {
            _courseService.Create(courseVM);

            return Ok(courseVM);
        }

    }
}
