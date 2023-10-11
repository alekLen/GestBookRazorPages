using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GestBookRazorPages.Repositpry;
using GestBookRazorPages.Models;
using System.Security.Cryptography;
using System.Text;

namespace GestBookRazorPages.Pages
{
    public class RegistrationModel : PageModel
    {
        [BindProperty]
        public RegisterModel reg { get; set; }
        IRepository rep;
        public RegistrationModel(IRepository context)
        {
            rep = context;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                User u = new();
                u.Name = reg.Login;
                byte[] saltbuf = new byte[16];
                RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
                randomNumberGenerator.GetBytes(saltbuf);
                StringBuilder sb = new StringBuilder(16);
                for (int i = 0; i < 16; i++)
                    sb.Append(string.Format("{0:X2}", saltbuf[i]));
                string salt = sb.ToString();
                Salt s = new();
                s.salt = salt;
                string password = salt + reg.Password;
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                //bool passwordsMatch = BCrypt.Net.BCrypt.Verify(enteredPassword, hashedPasswordFromDatabase); для проверки совпадения           
                u.Password = hashedPassword;
                try
                {
                    await rep.AddUser(u);
                    await rep.Save();
                    s.user = u;
                    await rep.AddSalt(s);
                    await rep.Save();
                }
                catch { }
                return RedirectToPage("Login");
            }
            return Page();
        }
    }
}
