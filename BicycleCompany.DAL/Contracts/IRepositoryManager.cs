﻿using System.Threading.Tasks;

namespace BicycleCompany.DAL.Contracts
{
    public interface IRepositoryManager
    {
        IBicycleRepository Bicycle { get; }
        IClientRepository Client { get; }
        IPartRepository Part { get; }
        IProblemRepository Problem { get; }

        //TODO: ask Anya
        //Task SaveAsync(); 
    }
}
