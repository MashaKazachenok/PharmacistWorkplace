using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repositories;
using Models;
using Web.Models;
using AutoMapper;



namespace Web.Controllers
{
    public class ClientsController : Controller
    {
        ClientRepository repository;

        public ClientsController()
        {
            repository = new ClientRepository();
        }

        //
        // GET: /Clients/
        public ActionResult Index(string search)
        {
            List<Client> clients = repository.GetAllClients(search);

            ClientListViewModel model = new ClientListViewModel
            {
                Clients = Mapper.Map<List<ClientInfoViewModel>>(clients)
            };

            return View(model);
        }

        //
        // GET: /Clients/Details/5
        public ActionResult Details(int id)
        {
            Client client = repository.GetClientById(id);

            ClientDetailsViewModel model = new ClientDetailsViewModel();

            model = Mapper.Map<ClientDetailsViewModel>(client);

            List<Visit> visits = repository.GetAllVisitsByClientId(client.Id);
            model.Visits = Mapper.Map<List<VisitDetailsViewModel>>(visits);
            return View(model);
        }

        //
        // GET: /Clients/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Clients/Create
        [HttpPost]
        public ActionResult Create(ClientViewModel model)
        {
            if (ModelState.IsValid)
            {
                Client client = new Client();

                client = Mapper.Map<Client>(model);

                repository.CreateClient(client);

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        //
        // GET: /Clients/Edit/5
        public ActionResult Edit(int id)
        {
            Client client = repository.GetClientById(id);

            ClientViewModel model = new ClientViewModel();

            model = Mapper.Map<ClientViewModel>(client);

            return View(model);
        }

        //
        // POST: /Clients/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ClientViewModel model)
        {
            if (ModelState.IsValid)
            {
                Client client = repository.GetClientById(id);

                client = Mapper.Map<ClientViewModel, Client>(model, client);

                repository.EditClient(client);

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        //
        // GET: /Clients/Delete/5
        public ActionResult Delete(int id)
        {
            repository.RemoveClient(id);

            return RedirectToAction("Index");
        }

        //
        // POST: /Clients/Delete/5
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
