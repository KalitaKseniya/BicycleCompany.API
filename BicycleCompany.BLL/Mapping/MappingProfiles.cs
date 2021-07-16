﻿using AutoMapper;
using BicycleCompany.DAL.Models;
using BicycleCompany.Models.Request;
using BicycleCompany.Models.Response;

namespace BicycleCompany.BLL.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Client, ClientForReadModel>();
            CreateMap<ClientForCreationModel, Client>();
            CreateMap<ClientForUpdateModel, Client>().ReverseMap();
        }
    }
}
