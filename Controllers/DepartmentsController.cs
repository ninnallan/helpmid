using Microsoft.AspNetCore.Mvc;
using Midterm.Interfaces;

namespace Midterm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private IDepartmentService _departmentsService;

        public DepartmentsController(IDepartmentService departmentsService)
        {
            _departmentsService = departmentsService;
        }

        [HttpGet("GetAllProductsFromCache")]
        public List<string> GetAllProductsFromCache()
        {
            return _departmentsService.GetDepartmentsFromCache();
        }

        [HttpPost("AddProductsToCache")]
        public List<string> AddProductsToCache()
        {
            return _departmentsService.AddDepartmentsToCache();
        }
    }
}
