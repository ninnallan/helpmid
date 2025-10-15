using Microsoft.AspNetCore.Mvc;
using Midterm.Interfaces;

namespace Midterm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost("AddCourse")]
        public void AddCourse(string course)
        {
            _courseService.AddCourse(course);
        }

        [HttpGet("GetCourses")]
        public List<string> GetCourses(int pageIndex, int elementCount)
        {
            return _courseService.GetCourses(pageIndex, elementCount);
        }
    }
}
