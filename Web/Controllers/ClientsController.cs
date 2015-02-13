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
        public ActionResult Index()
        {
            ClientRepository repository = new ClientRepository();
            List<Client> clients = repository.GetAll();

            return View(clients);
        }

        //
        // GET: /Clients/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
            Client client = repository.GetById(id);

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

                Client client = repository.GetById(id);
 
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
            return View();
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
