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
        public int CreateClient(Client client)
        {
            return 0;
        }

        public int EditClient(Client client)
        {
            return 0;
        }

        public List<Client> GetAll()
        {
            List<Client> clients = new List<Client>();

            Client vasia = new Client()
            {
                FirstName = "Вася",
                LastName = "Вася"
            };
            Client masha = new Client()
            {
                FirstName = "Mаша",
                LastName = "Маша"
            };

            clients.Add(vasia);
            clients.Add(masha);

            return clients;
        }

        public Client GetById(int id)
        {
            return new Client();
        }
    }
}
