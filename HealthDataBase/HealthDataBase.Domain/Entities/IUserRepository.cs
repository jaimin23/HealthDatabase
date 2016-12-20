using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
    /// <summary>
    /// Jaimin Patel
    /// This interface contains the operation related to user and provides a 
    /// read-only list of users
    /// </summary>
    public interface IUserRepository
    {
        IEnumerable<users> UserList { get; }

        void SaveUser(users user);

        void DeleteUser(int userId);
    }
}
