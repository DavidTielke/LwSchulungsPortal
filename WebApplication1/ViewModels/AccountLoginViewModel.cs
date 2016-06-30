using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.ViewModels
{
    public class AccountLoginViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [UIHint("Password")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}