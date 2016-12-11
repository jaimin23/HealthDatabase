using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
    public interface IUserRepository
    {
        IEnumerable<users> UserList { get; }

        void SaveUser(users user);
    }
}
