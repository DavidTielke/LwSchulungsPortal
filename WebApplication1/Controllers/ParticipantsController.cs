using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebApplication1.Data;
using WebApplication1.Models;
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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Participant model)
        {
            _repository.Insert(model);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var model = _repository.GetById(id);
            return View(model);
        }

        public ActionResult DeleteConfirmed(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}