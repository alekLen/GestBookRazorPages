using System.ComponentModel.DataAnnotations;

namespace GestBookRazorPages.Models
{
    public class Login_Model
    {
        [Required]
        [Display(Name = "введите логин: ")]
        public string? Login { get; set; }

        [Required]
        [Display(Name = "Пароль: ")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
