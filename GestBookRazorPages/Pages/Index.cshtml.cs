using GestBookRazorPages.Repositpry;
using GestBookRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GestBookRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        //IRepository rep;
      // public List<Message> list { set; get; }
       // public Message message { set; get; }
        //public IndexModel(IRepository context)
       // {
            //try { 
          //  list = new List<Message>();
           // message = new Message();
            //rep = context;
            //}
            //catch (Exception ex)
            //{
            //    list = new List<Message>();
            //    message = new Message();
            //    message.MessageDate = "0/0/0";
            //    message.Text = ex.Message;
            //    User u = new User();
            //    u.Name = "admin";
            //    message.user = u;
            //    list.Add(message);
            //}
       // }

        public async Task<IActionResult> OnGet()
        {
            //try
            //{
            //    if (rep == null)
            //    {


            //        message.MessageDate = "00/00/00";
            //        message.Text = "репозиторий !";
            //        User u = new User();
            //        u.Name = "admin";
            //        message.user = u;
            //        list.Add(message);
            //    }
            //    else
            //    {
                   
            //        var ms = await rep.GetMessage();
            //        list = ms;
            //        if (ms.Count == 0)
            //        {

            //            message.MessageDate = "00/00/00";
            //            message.Text = "Пусто";
            //            User u = new User();
            //            u.Name = "admin";
            //            message.user = u;
            //            list.Add(message);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
               
            //    message.MessageDate = "0/0/0";
            //    message.Text = ex.Message;
            //    User u=new User();
            //    u.Name = "admin";
            //    message.user = u;
            //    list.Add(message);
            //}

            return Page();
        }
    }
}