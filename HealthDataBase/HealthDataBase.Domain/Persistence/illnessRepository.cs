using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthDataBase.Domain.Entities;

namespace HealthDataBase.Domain.Persistence
{
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
                illness illEntity = _dbContext.Illness.Find(ill.Name);
                illEntity.Change(ill); 
            }
            _dbContext.SaveChanges();
        }
    }
}
