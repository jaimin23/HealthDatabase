using HealthDataBase.Domain.Entities;
using HealthDataBase.Domain.Persistence;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain
{
    public class DomainFactoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRegisteredUserRepository>().To<DatabaseUserRepository>();
            Bind<IUserRepository>().To<UserRepository>();
            Bind<ISymptoms>().To <SymptomRepository> ();
            Bind<ISymptomR>().To<SymRepository>();
            Bind<Iillness>().To<illnessRepository>();
            Bind<IillnessInterface>().To<IllnessRepository>();
            Bind<IMainManager>().To<MainManager>();
        }
    }
}
