﻿using HealthDataBase.Domain.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
    /// <summary>
/// Fahad Mirza
/// </summary>
    class IllnessRepository : IillnessInterface
    {
        private Iillness _illRepo;
        public IllnessRepository(Iillness illRepo)
        {
            _illRepo = illRepo;
        }
        public IEnumerable<illness> illnessTable
        {
            get
            {
                return _illRepo.illnessTable;
            }
        }

        public void DeleteIllness(int id)
        {
            _illRepo.DeleteIllness(id);
        }

        public void saveIllness(illness ill)
        {
            _illRepo.SaveIllness(ill);
        }
    }
}
