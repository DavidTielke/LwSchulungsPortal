using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Data;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    // localhost.de/Participants/Delete
    public class ParticipantsController : Controller
    {
        private readonly ParticipantsRepository _repository;

        public ParticipantsController()
        {
            _repository = new ParticipantsRepository();
        }

        public ActionResult Index()
        {

            var viewModel = new ParticipantsIndexViewModel
            {
                Participants = _repository.Query.ToList()
            };

            return View(viewModel);
        }
    }
}