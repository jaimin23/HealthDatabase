using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
    public interface IillnessInterface
    {
        IEnumerable<illness> illnessTable { get; }
        void saveIllness(illness ill);
    }
}
