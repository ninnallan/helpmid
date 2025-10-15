using Microsoft.EntityFrameworkCore;

namespace Midterm.AppDbContext
{
    public class CourseDbContext : DbContext
    {
        public DbSet<string> Courses { get; set; } //ამას inmemory ბაზაც შევუქმენი, რომ უფრო კარგად მენახა შედეგი(მაგრამ როგორც გითხარით პროექტი არ გაეშვა და ვერ გავარკვიე სამწუხაროდ რამდენად სწორად მუშაობდა)

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("CoursesDb");
        }
    }
}
