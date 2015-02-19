using AutoMapper;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class VisitsController : Controller
    {
        //
        // GET: /Visits/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Visits/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Visits/Create
        public ActionResult Create(int clientId)
        {
            ClientRepository repository = new ClientRepository();
            Client client = repository.GetClientById(clientId);

            VisitViewModel model = new VisitViewModel();
            model = Mapper.Map<VisitViewModel>(client);
            model.ClientId = clientId;
            model.VisitData = DateTime.Now;
            
            return View(model);
        }

        //
        // POST: /Visits/Create
        [HttpPost]
        public ActionResult Create(int clientId, VisitViewModel model)
        {
            if (ModelState.IsValid)
            {
                ClientRepository repository = new ClientRepository();

                Client client = repository.GetClientById(clientId);

                Visit visit = new Visit();
                visit = Mapper.Map<Visit>(model);
               
                client.Visits.Add(visit);

                repository.CreateVisit(visit);

                return RedirectToAction("Details", "Clients", new { id = clientId });
            }
            else
            {
                return View(model);
            }
        }

        //
        // GET: /Visits/Edit/5
        public ActionResult Edit(int id)
        {
            ClientRepository repository = new ClientRepository();

            Visit visit = repository.GetVisitById(id);
            VisitViewModel model = new VisitViewModel();
            model = Mapper.Map<VisitViewModel>(visit);
          
            return View(model);
        }

        //
        // POST: /Visits/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, int clientId, VisitViewModel model)
        {
            if (ModelState.IsValid)
            {
                ClientRepository repository = new ClientRepository();

                Visit visit = repository.GetVisitById(id);
                visit = Mapper.Map<Visit>(model);
              
                repository.EditVisit(visit);

                return RedirectToAction("Details", "Clients", new { id = clientId });
            }
            else
            {
                return View(model);
            }
        }

        //
        // GET: /Visits/Delete/5
        public ActionResult Delete(int id, int clientId)
        {
            ClientRepository repository = new ClientRepository();
            repository.RemoveVisit(id);

            return RedirectToAction("Details", "Clients", new { id = clientId });
        }

        //
        // POST: /Visits/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
