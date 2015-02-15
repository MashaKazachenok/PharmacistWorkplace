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
        private DatabaseContext databaseContext;

        public ClientRepository()
        {
            databaseContext = new DatabaseContext();
        }

        public void CreateClient(Client client)
        {
            databaseContext.Clients.Add(client);
            databaseContext.SaveChanges();
        }

        public void EditClient(Client client)
        {
            databaseContext.SaveChanges();
        }

        public void RemoveClient(int id)
        {
            Client client = databaseContext.Clients.FirstOrDefault(x => x.Id == id);
            databaseContext.Clients.Remove(client);
            databaseContext.SaveChanges();
        }

        public List<Client> GetAllClients(string search)
        {
            if (search == null || search == "")
            {
                List<Client> spisok = databaseContext.Clients
                    .Include("Visits")
                    .ToList();
                return spisok;
            }
            else
            {
                List<Client> spisok = databaseContext.Clients
                    .Include("Visits")
                    .Where(x => x.LastName.Contains(search) || x.FirstName.Contains(search))
                    .ToList();

                return spisok;
            }

           
        }

        public Client GetClientById(int id)
        {
            Client client = databaseContext.Clients.FirstOrDefault(x => x.Id == id);

            return client;
        }

        public void CreateVisit(Visit visit)
        {
            databaseContext.Visits.Add(visit);
            databaseContext.SaveChanges();
        }

        public void RemoveVisit(int id)
        {
            Visit visit = databaseContext.Visits.FirstOrDefault(x => x.Id == id);
            databaseContext.Visits.Remove(visit);
            databaseContext.SaveChanges();
        }

        public List<Visit> GetAllVisitsByClientId(int clientId)
        {
            List<Visit> visits = databaseContext.Visits.Where(x => x.Client.Id == clientId).ToList();

            return visits;
        }
        public void EditVisit(Visit visit)
        {
            databaseContext.SaveChanges();
        }
        public Visit GetVisitById(int id)
        {
            Visit visit = databaseContext.Visits.FirstOrDefault(x => x.Id == id);

            return visit;
        }
    }
}
