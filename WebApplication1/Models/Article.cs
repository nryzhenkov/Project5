using System;
namespace WebApplication1.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Theme { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
