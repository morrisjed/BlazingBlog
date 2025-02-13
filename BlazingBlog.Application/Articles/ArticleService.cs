using BlazingBlog.Domain.Articles;

namespace BlazingBlog.Application.Articles;

public class ArticleService : IArticleService
{
    public List<Article> GetAllArticles()
    {
        return new List<Article>
        {
            new Article
            {
                Id = 1,
                Title = "My First Article",
                Content = "This is my first article.",
            },
            new Article
            {
                Id = 2,
                Title = "My Second Article",
                Content = "This is my second article",
            }
        };

    }
}