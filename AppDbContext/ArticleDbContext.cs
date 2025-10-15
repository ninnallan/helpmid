using Microsoft.EntityFrameworkCore;
using Midterm.Models;

namespace Midterm.AppDbContext
{
    public class ArticleDbContext : DbContext
    {
        public DbSet<Article> Articles { get; set; } //ამას inmemory ბაზაც შევუქმენი, რომ უფრო კარგად მენახა შედეგი(მაგრამ როგორც გითხარით პროექტი არ გაეშვა და ვერ გავარკვიე სამწუხაროდ რამდენად სწორად მუშაობდა)

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("ArticlesDb");
        }
    }
}
