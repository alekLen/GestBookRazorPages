using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GestBookRazorPages.Repositpry;
using GestBookRazorPages.Models;
namespace GestBookRazorPages.Pages
{
    public class RegistrationModel : PageModel
    {
        [BindProperty]
        public RegisterModel reg { get; set; }
        public void OnGet()
        {
        }
    }
}
