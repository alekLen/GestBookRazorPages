using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GestBookRazorPages.Repositpry;
using GestBookRazorPages.Models;
namespace GestBookRazorPages.Pages
{
    public class LoginModel : PageModel
    {
        public Login_Model log {  get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
