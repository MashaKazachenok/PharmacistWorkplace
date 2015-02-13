﻿using Models;
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
            VisitViewModel model = new VisitViewModel();
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
                visit.OrderAmount = model.OrderAmount;
                visit.OrderStatus = model.OrderStatus;
                visit.VisitData = model.VisitData;     
                visit.Owner = client;
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
            return View();
        }

        //
        // POST: /Visits/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Visits/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
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
