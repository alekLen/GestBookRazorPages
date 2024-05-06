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
            try
            {             
                var ms = await rep.GetMessage();
                list = ms;
            }
            catch (Exception ex)
            {
                list = new List<Message>();
                Message m=new Message();
                m.MessageDate = "0/0/0";
                m.Text = ex.Message;
                User u=new User();
                u.Name = "admin";
                m.user = u;
                list.Add(m);
            }
            return Page();
        }
    }
}