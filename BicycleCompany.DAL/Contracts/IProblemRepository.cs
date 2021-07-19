﻿using BicycleCompany.DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BicycleCompany.DAL.Contracts
{
    public interface IProblemRepository
    {
        Task<IEnumerable<Problem>> GetProblemsAsync();
        Task<Problem> GetProblemAsync(Guid id);
        Task CreateProblemAsync(Problem problem);
        Task DeleteProblemAsync(Problem problem);
        Task UpdateProblemAsync(Problem problem);
    }
}
