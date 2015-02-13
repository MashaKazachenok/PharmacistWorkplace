using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace Repositories
{
    public class ClientRepository
    {
        public void CreateClient(Client client)
        {
            DatabaseContext databaseContext = new DatabaseContext();
            databaseContext.Clients.Add(client);
            databaseContext.SaveChanges();
        }

        public void EditClient(Client client)
        {
            DatabaseContext databaseContext = new DatabaseContext();
            databaseContext.SaveChanges();
        }

        public void RemoveClient(int id)
        {
            DatabaseContext databaseContext = new DatabaseContext();
            Client client = databaseContext.Clients.FirstOrDefault(x => x.Id == id);
            databaseContext.Clients.Remove(client);
            databaseContext.SaveChanges();
        }

        public List<Client> GetAllClients()
        {
            DatabaseContext databaseContext = new DatabaseContext();
            List<Client> spisok = databaseContext.Clients.ToList();
            return spisok;
        }

        public Client GetClientById(int id)
        {
            DatabaseContext databaseContext = new DatabaseContext();
            Client client = databaseContext.Clients.FirstOrDefault(x => x.Id == id);

            return client;
        }

        public void CreateVisit(Visit visit)
        {
            DatabaseContext databaseContext = new DatabaseContext();
            databaseContext.Visits.Add(visit);
            databaseContext.SaveChanges();
        }

        public void RemoveVisit(int id)
        {
            DatabaseContext databaseContext = new DatabaseContext();
            Visit visit = databaseContext.Visits.FirstOrDefault(x => x.Id == id);
            databaseContext.Visits.Remove(visit);
            databaseContext.SaveChanges();
        }
    }
}
