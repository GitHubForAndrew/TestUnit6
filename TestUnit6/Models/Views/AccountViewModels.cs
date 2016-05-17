using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestUnit6.Models.Views
{
    public class AccountViewModel
    {
        [Required]
        [Display(Name ="Логин")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Пароль")]
        public string Password { get; set; }

        [Display(Name ="Запомнить меня")]
        public bool RememberMe { get; set; }

    }
}
