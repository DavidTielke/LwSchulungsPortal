using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Participant
    {
        public Participant(int id, string firstname, string lastname, string email, string website, string company)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Website = website;
            Company = company;
        }

        public Participant(string firstname, string lastname, string email, string website, string company)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Website = website;
            Company = company;
        }

        public Participant()
        {
            
        }
        
        public int Id { get; set; }

        [DisplayName("Vorname")]
        [Required]
        [MinLength(3)]
        public string Firstname { get; set; }

        [DisplayName("Nachname")]
        [Required]
        [MinLength(3)]
        public string Lastname { get; set; }

        [DisplayName("Email")]
        [Required]
        [MinLength(5)]
        public string Email { get; set; }

        [DisplayName("Webseite")]
        [Required]
        [MinLength(10)]
        public string Website { get; set; }

        [DisplayName("Firma")]
        [Required]
        [MinLength(3)]
        public string Company { get; set; }

        [UIHint("File")]
        public byte[] ProfilePicture { get; set; }
    }
}