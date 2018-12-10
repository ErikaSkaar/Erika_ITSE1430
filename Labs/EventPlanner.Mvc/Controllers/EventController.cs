using EventPlanner.Mvc.Models;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventPlanner;

namespace EventPlanner.Mvc.Controllers
{
    public class EventController : Controller
    {
        public EventController()
        {
        }

        [HttpGet]
        public ActionResult My()
        {
            var items = _database.GetAll();
            //if (items !== IsPublic)
            return View(items.Select(i => new Model(i)));
        }

        [HttpGet]
        public ActionResult MyPublic()
        {
            var items = _database.GetAll();
            //if (items == IsPublic)
            return View(items.Select(i => new Model(i)));
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var item = _database.GetAll().FirstOrDefault(i => i.Id == id);
            if (item == null)
                return HttpNotFound();

            return View(new Model(item));
        }

        [HttpGet]
        public ActionResult Create()
        {
            var model = new Model();

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Model model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var item = model.ToDomain();

                    _database.Add(item);

                    return RedirectToAction("My");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                };
            };

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var item = _database.GetAll().FirstOrDefault(i => i.Id == id);
            if (item == null)
                return HttpNotFound();
            return View(new Model(item));
        }

        [HttpPost]
        public ActionResult Edit(Model model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var item = model.ToDomain();
                    var existing = _database.GetAll().FirstOrDefualt(i => i.Id == model.Id);
                    if (existing == null)
                        return HttpNotFound();

                    _database.Edit(existing.Name, item);

                    return RedirectToAction("My");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                };
            };

            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var item = _database.GetAll().FirstOrDefault(i => i.Id == id);
            if (item == null)
                return HttpNotFound();

            return View(new Model(item));
        }

        [HttpPost]
        public ActionResult Delete(Model model)
        {
            try
            {
                var existing = _database.GetAll().FirstOrDefault(i => i.Id == model.Id);
                if (existing == null)
                    return HttpNotFound();

                _database.Remove(existing.Name);

                return RedirectToAction("My");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(model);
            };
        }

        private readonly IEventDatabase _database;
    }
}