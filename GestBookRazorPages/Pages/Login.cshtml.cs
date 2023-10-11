using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GestBookRazorPages.Repositpry;
using GestBookRazorPages.Models;
using Microsoft.AspNetCore.Http;

namespace GestBookRazorPages.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Login_Model log {  get; set; }
        IRepository rep;
        public LoginModel(IRepository context)
        {
            rep = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {

                var u = await rep.GetUser(log.Login);
                var s = await rep.GetSalt(u);
                {
                    if (u != null && s != null)
                    {
                        string conf = s.salt + log.Password;
                        if (BCrypt.Net.BCrypt.Verify(conf, u.Password))
                        {
                            HttpContext.Session.SetString("login", log.Login); // создание сессионной переменной
                            return RedirectToPage("Index");
                        }
                        else
                        {
                            ModelState.AddModelError("", "не правильный логин или пароль");
                            return Page();
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "не правильный логин или пароль");
                        return Page();
                    }
                }
            }
            return Page();
        }
    }
}
