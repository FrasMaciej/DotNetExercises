using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework5.Models;

namespace homework5.Interfaces
{
    public interface IClientService
    {
        List<Client> GetAll();

        Client Get(int id);
        int Create(Client client);
        bool Update(int id, Client client);
        bool Delete(int id);
    }
}
