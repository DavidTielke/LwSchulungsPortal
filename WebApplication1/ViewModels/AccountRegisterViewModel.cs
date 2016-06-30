using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class AccountRegisterViewModel
    {
        public Participant Participant { get; set; }
        [UIHint("Password")]
        [MinLength(5)]
        public string PasswordRepeat { get; set; }
    }
}