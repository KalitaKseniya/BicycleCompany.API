﻿using BicycleCompany.DAL.Contracts;
using BicycleCompany.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleCompany.DAL.Repository
{
    public class ProblemRepository : RepositoryBase<Problem>, IProblemRepository
    {
        public ProblemRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }

        public void CreateProblem(Problem problem) => Create(problem);

        public void DeleteProblem(Problem problem) => Delete(problem);

        public async Task<Problem> GetProblemAsync(Guid id, bool trackChanges) => 
            await FindByCondition(p => p.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public async Task<IEnumerable<Problem>> GetProblemsAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(p => p.Stage)
            .ToListAsync();
    }
}
