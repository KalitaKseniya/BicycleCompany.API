﻿using BicycleCompany.Models.Request;
using BicycleCompany.Models.Request.RequestFeatures;
using BicycleCompany.Models.Response;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BicycleCompany.BLL.Services.Contracts
{
    public interface IClientService
    {
        Task<List<ClientForReadModel>> GetClientListAsync(ClientParameters clientParameters, HttpResponse response);
        Task<ClientForReadModel> GetClientAsync(Guid id, ClaimsPrincipal user = null);
        Task<Guid> CreateClientAsync(ClientForCreateOrUpdateModel model);
        Task UpdateClientAsync(Guid id, ClientForCreateOrUpdateModel model);
        Task DeleteClientAsync(Guid id);
        Task<ClientForCreateOrUpdateModel> GetClientForUpdateModelAsync(Guid id);

        Task<List<ProblemForReadModel>> GetProblemListForClientAsync(Guid clientId, ProblemParameters problemParameters, ClaimsPrincipal user, HttpResponse response);
        Task<ProblemForReadModel> GetProblemForClientAsync(Guid clientId, Guid problemId, ClaimsPrincipal user);
        Task<Guid> CreateProblemForClientAsync(Guid clientId, ProblemForCreateModel model);
        Task DeleteProblemForClientAsync(Guid clientId, Guid problemId);
    }
}
