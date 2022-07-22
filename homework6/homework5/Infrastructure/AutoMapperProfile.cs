using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using homework5.Dtos.Car;
using homework5.Dtos.Client;
using homework5.Models;

namespace homework5.Infrastructure
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Car, GetCarByIdDto>();
            CreateMap<CreateCarDto, Car>();
            CreateMap<UpdateCarDto, Car>();
            CreateMap<Car, CarForGetAllCarsDto>();

            CreateMap<Client, GetClientByIdDto>();
            CreateMap<CreateClientDto, Client>();
            CreateMap<UpdateClientDto, Client>();
            CreateMap<Client, ClientForGetAllClientsDto>();


        }
    }
}
