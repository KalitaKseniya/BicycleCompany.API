﻿using BicycleCompany.Models.Request;
using BicycleCompany.Models.Request.RequestFeatures;
using BicycleCompany.Models.Response;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BicycleCompany.BLL.Services.Contracts
{
    public interface IBicycleService
    {
        Task<List<BicycleForReadModel>> GetBicycleListAsync(BicycleParameters bicycleParameters, HttpResponse response);
        Task<BicycleForReadModel> GetBicycleAsync(Guid id);
        Task<Guid> CreateBicycleAsync(BicycleForCreateOrUpdateModel model);
        Task UpdateBicycleAsync(Guid id, BicycleForCreateOrUpdateModel model);
        Task DeleteBicycleAsync(Guid id);
        Task<BicycleForCreateOrUpdateModel> GetBicycleForUpdateModelAsync(Guid id);
    }
}
