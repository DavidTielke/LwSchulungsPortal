using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Link : IIdentifyableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public Participant CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}