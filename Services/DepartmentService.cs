using Microsoft.Extensions.Caching.Memory;
using Midterm.Interfaces;

namespace Midterm.Services
{
    public class DepartmentService : IDepartmentService
    {
        private IMemoryCache _cache;

        public DepartmentService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public List<string> AddDepartmentsToCache()
        {
            var departments =
                new List<string> { "HR", "Marketing", "Finance" };

            _cache.Set("departments", departments);

            return departments;
        }

        public List<string> GetDepartmentsFromCache()
        {
            _cache.TryGetValue("departments", out List<string> departments);

            if (departments != null)
            {
                return departments;
            }
            else
            {
                return new List<string>();
            }
        }
    }
}
