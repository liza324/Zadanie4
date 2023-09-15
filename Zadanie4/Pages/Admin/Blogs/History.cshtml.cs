using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using Zadanie4.Data;
using Zadanie4.Models;

namespace Zadanie4.Pages.Admin.Blogs
{
    [Authorize]
    public class HistoryModel : PageModel
    {
        private readonly PostsDbContext postsDbContext;
        public List<Post> BlogPosts { get; set; }

        public HistoryModel(PostsDbContext postsDbContext)
        {
            this.postsDbContext = postsDbContext;
        }
        public void OnGet()
        {
           BlogPosts = postsDbContext.Posts.ToList();
        }
    }
}
