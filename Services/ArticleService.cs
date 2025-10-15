using Mapster;
using Midterm.AppDbContext;
using Midterm.DTOs;
using Midterm.Interfaces;
using Midterm.Models;
using System;

namespace Midterm.Services
{
    public class ArticleService : IArticleService
    {
        public ArticleDbContext _articleDbContext;

        public ArticleService(ArticleDbContext articleDbContext)
        {
            _articleDbContext = articleDbContext;
        }

        public void AddArticle(ArticleDto articleDto)
        {
            _articleDbContext.Articles.Add(new Article
            {
                Title = articleDto.Title,
                Pages = articleDto.Pages
            });

            _articleDbContext.SaveChanges();
        }

        public List<ArticleDto> GetArticleInfoByMapping()
        {
            var articles = _articleDbContext.Articles.ToList();

            var articlesDto = articles.Adapt<List<ArticleDto>>();

            return articlesDto;
        }
    }
}
