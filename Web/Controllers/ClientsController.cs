using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repositories;
using Models;
using Web.Models;

namespace Web.Controllers
{
    public class ClientsController : Controller
    {
        //
        // GET: /Clients/
        public ActionResult Index(string search)
        {
            ClientRepository repository = new ClientRepository();
            List<Client> clients = repository.GetAllClients(search);
            ClientListViewModel model = new ClientListViewModel();

            model.Clients = new List<ClientInfoViewModel>();

            foreach (var client in clients)
            {
                ClientInfoViewModel clientInfoviewModel = new ClientInfoViewModel()
                {
                    Id = client.Id,
                    FirstName = client.FirstName,
                    LastName = client.LastName,
                    VisitCount = client.Visits.Count
                };

                model.Clients.Add(clientInfoviewModel);
            }

            return View(model);
        }

        //
        // GET: /Clients/Details/5
        public ActionResult Details(int id)
        {

            ClientRepository repository = new ClientRepository();
            Client client = repository.GetClientById(id);

            ClientDetailsViewModel model = new ClientDetailsViewModel();
            model.Id = client.Id;
            model.FirstName = client.FirstName;
            model.LastName = client.LastName;
            model.DateOfBirth = client.DateOfBirth;
            model.Address = client.Address;
            model.Phone = client.Phone;
            model.Email = client.Email;
            model.LeftEye = client.LeftEye;
            model.RightEye = client.RightEye;

            List<Visit> visits = repository.GetAllVisitsByClientId(client.Id);

            foreach (var visit in visits)
            {
                VisitDetailsViewModel visitModel = new VisitDetailsViewModel();

                visitModel.Id = visit.Id;
                visitModel.VisitData = visit.VisitData;
                visitModel.OrderAmount = visit.OrderAmount;
                visitModel.OrderStatus = visit.OrderStatus;

                model.Visits.Add(visitModel);                
            }

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
                ClientRepository repository = new ClientRepository();

                Client client = new Client();
                client.FirstName = model.FirstName;
                client.LastName = model.LastName;
                client.DateOfBirth = model.DateOfBirth;
                client.Address = model.Address;
                client.Phone = model.Phone;
                client.Email = model.Email;
                client.LeftEye = model.LeftEye;
                client.RightEye = model.RightEye;

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
            ClientRepository repository = new ClientRepository();
            Client client = repository.GetClientById(id);

            ClientViewModel model = new ClientViewModel();
            model.FirstName = client.FirstName;
            model.LastName = client.LastName;
            model.DateOfBirth = client.DateOfBirth;
            model.Address = client.Address;
            model.Phone = client.Phone;
            model.Email = client.Email;
            model.LeftEye = client.LeftEye;
            model.RightEye = client.RightEye;

            return View(model);
        }

        //
        // POST: /Clients/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ClientViewModel model)
        {
            if (ModelState.IsValid)
            {
                ClientRepository repository = new ClientRepository();

                Client client = repository.GetClientById(id);
 
                client.FirstName = model.FirstName;
                client.LastName = model.LastName;
                client.DateOfBirth = model.DateOfBirth;
                client.Address = model.Address;
                client.Phone = model.Phone;
                client.Email = model.Email;
                client.LeftEye = model.LeftEye;
                client.RightEye = model.RightEye;

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
            ClientRepository repository = new ClientRepository();
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
