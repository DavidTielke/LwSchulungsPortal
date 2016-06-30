using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.ViewModels
{
    public class AccountRegisterViewModel
    {
        [Required]
        [MinLength(3)]
        public string Email { get; set; }
        [UIHint("Password")]
        [MinLength(5)]
        public string Password { get; set; }
        [UIHint("Password")]
        [MinLength(5)]
        public string PasswordRepeat { get; set; }
    }
}