using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework5.Interfaces;
using homework5.Models;

namespace homework5.Services
{
    public class ClientService : IClientService
    {
        private List<Client> _clients = new List<Client>
        {
            new Client
            {
                Id = 0,
                Name = "Adam",
                Surname = "Nowak",
                PhoneNumber = 123456789
            },
            new Client
            {
                Id = 1,
                Name = "Jan",
                Surname = "Kowalski",
                PhoneNumber = 111333555
            },
            new Client
            {
                Id = 2,
                Name = "Patryk",
                Surname = "Nowacki",
                PhoneNumber = 987654321
            },
            new Client
            {
                Id = 3,
                Name = "Jakub",
                Surname = "Nowik",
                PhoneNumber = 555444333
            },
        };

        public List<Client> GetAll()
        {
            return _clients.ToList();
        }

        public int Create(Client client)
        {
            client.Id = _clients.Count > 0
                ? _clients.Max(c => c.Id) + 1
                : 0;

            _clients.Add(client);
            return client.Id;
        }

        public Client Get(int id)
        {
            var client = _clients.FirstOrDefault(c => c.Id == id);
            return client;
        }


        public bool Update(int id, Client client)
        {
            var clientToUpdate = _clients.FirstOrDefault(c => c.Id == id);

            if (clientToUpdate == null)
                return false;

            clientToUpdate.Name = client.Name;
            clientToUpdate.Surname = client.Surname;
            clientToUpdate.PhoneNumber = client.PhoneNumber;
            return true;
        }

        public bool Delete(int id)
        {
            var clientToDelete = _clients.FirstOrDefault(c => c.Id == id);

            if (clientToDelete == null)
                return false;

            bool isDeleted = _clients.Remove(clientToDelete);
            return isDeleted;

        }

    }
}
