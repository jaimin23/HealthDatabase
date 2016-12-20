﻿using HealthDataBase.Domain.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
    /// <summary>
    /// Jaimin Patel
    /// The implementation class for the interface IUserRepository
    /// which is being inherited and contains the code which 
    /// makes all the operations possible
    /// </summary>
    class UserRepository : IUserRepository
    {
        private IRegisteredUserRepository _repo;

        public IEnumerable<users> UserList { get; } 

        public UserRepository(IRegisteredUserRepository repo)
        {
            _repo = repo;
            this.UserList = _repo.ListOfUsers;
        }

        public void SaveUser(users user)
        {
            _repo.SaveUser(user);
        }

        public void DeleteUser(int userId)
        {
            _repo.DeleteUser(userId);
        }
    }
}
