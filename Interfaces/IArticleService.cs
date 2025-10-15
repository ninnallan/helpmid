using Midterm.DTOs;

namespace Midterm.Interfaces
{
    public interface IArticleService
    {
        public List<ArticleDto> GetArticleInfoByMapping();
        public void AddArticle(ArticleDto articleDto);
    }
}
