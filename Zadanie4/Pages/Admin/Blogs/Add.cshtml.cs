using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie4.Data;
using Zadanie4.Models;
using Zadanie4.Pages.Login;

namespace Zadanie4.Pages.Admin.Blogs
{
    [Authorize]
    public class AddModel : PageModel
    {
        private readonly PostsDbContext postDbContext;

        [BindProperty]
        public AddPost AddMessageRequest { get; set; }

        public AddModel(PostsDbContext postDbContext)
        {
            this.postDbContext = postDbContext;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var Post = new Post()
            {
                Text = AddMessageRequest.Text,
                Author = this.User.Identity.Name,
                Recipient = AddMessageRequest.Recipient
            };
            postDbContext.Posts.Add(Post);
            postDbContext.SaveChanges();

            return RedirectToPage("History");
        }
    }
}