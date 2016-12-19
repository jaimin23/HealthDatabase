using HealthDataBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Persistence
{
   public interface Iillness
    {
        IEnumerable<illness> illnessTable { get; }
        void SaveIllness(illness ill);
    }
}
