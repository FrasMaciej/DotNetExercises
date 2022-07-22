using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using homework5.Dtos.Client;
using homework5.Interfaces;
using homework5.Models;
using Microsoft.Extensions.Logging;

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

        private readonly IMapper _mapper;
        private readonly ILogger _logger;


        public ClientService(IMapper mapper, ILogger<CarService> logger)
        {
            _logger = logger;
            _mapper = mapper;
        }

        public GetAllClientsDto GetAll()
        {
            var allClients = _clients.ToList();

            var dto = new GetAllClientsDto
            {
                Clients = _mapper.Map<List<ClientForGetAllClientsDto>>(allClients)
            };

            return dto;
        }

        public int Create(CreateClientDto client)
        {
            var id = _clients.Count > 0
                ? _clients.Max(c => c.Id) + 1
                : 0;

            var clientToAdd = _mapper.Map<Client>(client);

            clientToAdd.Id = id;

            _clients.Add(clientToAdd);
            return id;
        }

        public GetClientByIdDto Get(int id)
        {
            var client = _clients.FirstOrDefault(c => c.Id == id);

            var dto = _mapper.Map<GetClientByIdDto>(client);

            return dto;
        }


        public bool Update(int id, UpdateClientDto client)
        {
            var clientToUpdate = _clients.FirstOrDefault(c => c.Id == id);

            if (clientToUpdate == null)
                return false;

            _mapper.Map<UpdateClientDto, Client>(client);

            return true;
        }

        public bool Delete(int id)
        {
            var clientToDelete = _clients.FirstOrDefault(c => c.Id == id);

            if (clientToDelete == null)
                return false;

            bool isDeleted = _clients.Remove(clientToDelete);

            if (isDeleted)
                _logger.LogWarning("Deleted client with id: {Id}", clientToDelete.Id);

            return isDeleted;

        }

    }
}
