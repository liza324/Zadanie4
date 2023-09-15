using Microsoft.EntityFrameworkCore;
using Zadanie4.Models;

namespace Zadanie4.Data
{
    public class PostsDbContext : DbContext
    {
        public PostsDbContext(DbContextOptions options) : base(options)
        {

        }

        public  DbSet<Post> Posts { get; set; }
    }
}
