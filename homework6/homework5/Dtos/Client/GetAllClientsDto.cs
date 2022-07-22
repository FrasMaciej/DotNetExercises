using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework5.Dtos.Client
{
    public class GetAllClientsDto
    {
        public ICollection<ClientForGetAllClientsDto> Clients { get; set; }          
    }
    public class ClientForGetAllClientsDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int PhoneNumber { get; set; }
    }
}
