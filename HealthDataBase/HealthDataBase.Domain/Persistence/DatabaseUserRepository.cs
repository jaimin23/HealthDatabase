using HealthDataBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Persistence
{
    /// <summary>
    /// Jaimin Patel
    /// This class is reposible for doing the data base work which
    /// is being done through the use of entity framework and contains the implementation 
    /// of the IRegistereUserRepository
    /// </summary>
    class DatabaseUserRepository : IRegisteredUserRepository
    {
        private HealthDbContext _dbContext;

        public DatabaseUserRepository()
        {
            _dbContext = new HealthDbContext();
        }

        public IEnumerable<users> ListOfUsers
        {
            get
            {
                return _dbContext.Users;
            }
        }

        public void SaveUser(users user)
        {
            if(user.UserId == 0)
            {
                _dbContext.Users.Add(user);
            }
            else
            {
                users userEntity = _dbContext.Users.Find(user.UserId);
                userEntity.Change(user);
            }

            _dbContext.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            users user = _dbContext.Users.Find(userId);
            if(user != null)
            {
                _dbContext.Users.Remove(user);
            }
            _dbContext.SaveChanges();
        }
    }
}
