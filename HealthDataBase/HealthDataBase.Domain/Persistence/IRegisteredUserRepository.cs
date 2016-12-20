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
    /// </summary>
    public interface IRegisteredUserRepository
    {
        IEnumerable<users> ListOfUsers { get; }

        void SaveUser(users user);

        void DeleteUser(int userId);
    }
}
