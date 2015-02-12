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
                LastName = "Вася",
                Id = 1
            };
            Client masha = new Client()
            {
                FirstName = "Mаша",
                LastName = "Маша",
                Id = 2
            };

            clients.Add(vasia);
            clients.Add(masha);

            return clients;
        }

        public Client GetById(int id)
        {
            if (id == 1)
            {
                return new Client()
                {
                    FirstName = "Вася",
                    LastName = "Вася",
                    Id = 1
                };
            }

            if (id == 2)
            {
                return new Client()
                {
                    FirstName = "Mаша",
                    LastName = "Маша",
                    Id = 2
                };
            }

            return new Client();
        }
    }
}
