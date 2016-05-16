using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestUnit6.Models.Views
{
    public class AccountViewModel
    {
        [Display(Name ="Логин")]
        public string Username { get; set; }

        [Display(Name ="Пароль")]
        public string Password { get; set; }

        [Display(Name ="Запомнить меня")]
        public bool RememberMe { get; set; }

    }
}
