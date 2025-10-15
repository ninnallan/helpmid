using Midterm.AppDbContext;
using Midterm.Interfaces;

namespace Midterm.Services
{
    public class CourseService : ICourseService
    {
        private CourseDbContext _dbContext;

        public CourseService(CourseDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public void AddCourse(string course)
        {
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
        }
        public List<string> GetCourses(int pageIndex, int pageSize)
        {
            var courses = _dbContext.Courses.Skip((pageIndex - 1) * pageSize)
                .Take(pageSize).ToList();

            return courses;
        }
    }
}
