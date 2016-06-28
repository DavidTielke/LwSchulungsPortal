using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class ParticipantsIndexViewModel
    {
        public ParticipantsIndexViewModel()
        {
            Participants = new List<Participant>();
        }

        public List<Participant> Participants { get; set; }
    }
}