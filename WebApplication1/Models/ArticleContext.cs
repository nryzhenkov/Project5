using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class ArticleContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public ArticleContext(DbContextOptions<ArticleContext> options)
            : base(options)
        {
        }
    }
}
