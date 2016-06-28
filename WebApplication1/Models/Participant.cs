using System;
using System.Collections.Generic;
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
        

        public Participant()
        {
            
        }
        
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Company { get; set; }
    }
}