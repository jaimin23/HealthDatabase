using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthDataBase.Domain.Entities;

namespace HealthDataBase.Domain.Persistence
{

    /// <summary>
    /// Fahad Mirza
    /// </summary>
    class illnessRepository : Iillness
    {
        private HealthDbContext _dbContext;

        public illnessRepository()
        {
            _dbContext = new HealthDbContext();
        }
        public IEnumerable<illness> illnessTable
        {
            get
            {
               return _dbContext.Illness;
            }
        }

        public void SaveIllness(illness ill)
        {
            if(ill.IllnessId == 0)
            {
                _dbContext.Illness.Add(ill);
            }
            else
            {
                illness illEntity = _dbContext.Illness.Find(ill.IllnessId);
                illEntity.Change(ill); 
            }
            _dbContext.SaveChanges();
        }

        public void DeleteIllness(int id)
        {
            illness ill = _dbContext.Illness.Find(id);
            if (ill != null)
            {
                _dbContext.Illness.Remove(ill);
            }
            _dbContext.SaveChanges();
        }
    }
}
