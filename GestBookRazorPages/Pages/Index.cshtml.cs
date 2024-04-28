using GestBookRazorPages.Repositpry;
using GestBookRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GestBookRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        IRepository rep;
        public List<Message> list { set; get; }
        public Message message { set; get; }
        public IndexModel(IRepository context)
        {
            rep = context;
        }

        public async Task<IActionResult> OnGet()
        {
            var ms = await rep.GetMessage();
            list = ms;
            return Page();
        }
    }
}