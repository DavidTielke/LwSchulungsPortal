using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class LinkIndexViewModel
    {
        public List<Link> Links { get; set; }
        public PaginationViewModel Pagination { get; set; }

        public LinkIndexViewModel()
        {
            Links = new List<Link>();
        }
    }
}