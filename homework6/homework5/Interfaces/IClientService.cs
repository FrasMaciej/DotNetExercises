using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework5.Dtos.Client;
using homework5.Models;

namespace homework5.Interfaces
{
    public interface IClientService
    {
        GetAllClientsDto GetAll();

        GetClientByIdDto Get(int id);
        int Create(CreateClientDto client);
        bool Update(int id, UpdateClientDto client);
        bool Delete(int id);
    }
}
