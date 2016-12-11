﻿using HealthDataBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Persistence
{
    public interface IRegisteredUserRepository
    {
        IEnumerable<users> ListOfUsers { get; }

        void SaveUser(users user);
    }
}
