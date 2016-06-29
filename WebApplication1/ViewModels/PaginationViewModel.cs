using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.ViewModels
{
    public class PaginationViewModel
    {
        public int CurrentPage { get; set; }
        public int TotalCount { get; set; }
        public int ItemsPerPage { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
    }
}