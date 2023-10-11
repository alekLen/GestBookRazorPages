using GestBookRazorPages.Models;
using GestBookRazorPages.Repositpry;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GestBookRazorPages.Pages
{
    public class MessageModel : PageModel
    {            

        IRepository rep;
        public MessageModel(IRepository context)
        {
            rep = context;
        }
        public async Task<IActionResult> OnPost(string text)
        {
            if (text!="")
            {
                Message mess = new();

                var u = await rep.GetUser(HttpContext.Session.GetString("login"));
                if (u != null)
                {
                    mess.user = u;
                    mess.Text = text;
                    mess.MessageDate = DateTime.Now.ToString();
                    try
                    {
                        await rep.AddMessage(mess);
                        await rep.Save();
                    }
                    catch { }
                    return RedirectToPage("Index");
                }
            }
            return RedirectToPage("Index");
        }
    }
}
