using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class LinksController : BaseController
    {
        private readonly Repository<Link> _repository;

        public LinksController()
        {
            _repository = new Repository<Link>();
        }

        public ActionResult Index(int page = 1)
        {
            var pageSize = 2;

            var viewModel = new LinkIndexViewModel
            {
                Links = _repository.Query.OrderBy(l => l.Id).Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                Pagination = new PaginationViewModel
                {
                    Action = RouteData.Values["Action"] as String,
                    Controller = RouteData.Values["Controller"] as String,
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalCount = _repository.Query.Count()
                }
            };
            return View(viewModel);
        }

        public ActionResult Create()
        {
            var model = new Link();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Link model)
        {
            var isModelValid = ModelState.IsValid;
            if (isModelValid)
            {
                var partiRepo = new Repository<Participant>();
                var participant = partiRepo.Query.First();
                model.CreatedBy = participant;
                model.CreatedAt = DateTime.Now;
                _repository.Insert(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Update(int id)
        {
            var model = _repository.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Link model)
        {
            var isModelValid = ModelState.IsValid;
            if (isModelValid)
            {
                _repository.Update(model);
                return RedirectToAction("Index");
            }
            return View(model);
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