﻿using BicycleCompany.DAL.Contracts;
using BicycleCompany.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleCompany.DAL.Repository
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }

        public Task CreateClientAsync(Client client) => CreateAsync(client);

        public Task DeleteClientAsync(Client client) => DeleteAsync(client);

        public Task UpdateClientAsync(Client client) => UpdateAsync(client);

        public async Task<Client> GetClientAsync(Guid id) => 
            await FindByCondition(c => c.Id.Equals(id)).SingleOrDefaultAsync();

        public async Task<IEnumerable<Client>> GetClientsAsync() => 
            await FindAll()
            .OrderBy(c => c.Name)
            .ToListAsync();
    }
}
