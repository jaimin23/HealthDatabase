using HealthDataBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Persistence
{
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
                users userEntity = _dbContext.Users.Find(user.UserName);
                userEntity.Change(user);
            }

            _dbContext.SaveChanges();
        }
    }
}
