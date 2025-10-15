using Microsoft.AspNetCore.Mvc;
using Midterm.DTOs;
using Midterm.Interfaces;

namespace Midterm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        [HttpPost("AddArticle")]
        public void AddArticle(ArticleDto articleDto)
        {
            _articleService.AddArticle(articleDto);
        }

        [HttpGet("GetArticleInfoByMapping")]
        public List<ArticleDto> GetArticleInfoByMapping()
        {
            var articles = _articleService.GetArticleInfoByMapping();

            return articles;
        }
    }
}
