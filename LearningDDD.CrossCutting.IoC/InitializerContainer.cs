using LearningDDD.Aplication;
using LearningDDD.Aplication.AplicationBase;
using LearningDDD.Aplication.Interface;
using LearningDDD.Aplication.Interface.InterfaceBase;
using LearningDDD.Domain.Interfaces.Repository;
using LearningDDD.Domain.Interfaces.Repository.RepositoryBase;
using LearningDDD.Domain.Interfaces.Services;
using LearningDDD.Domain.Services;
using LearningDDD.Repository.Infra.EntityContext;
using LearningDDD.Repository.Infra.Repository;
using LearningDDD.Repository.Infra.Repository.RepositoryBase;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDDD.CrossCutting.IoC
{
    public class InitializerContainer
    {
        public static Container Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>), Lifestyle.Scoped);
            container.Register<IRepositoryFuncionario, FuncionarioRepository>(Lifestyle.Scoped);

            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>), Lifestyle.Scoped);
            container.Register<IServiceFuncionario, ServiceFuncionario>(Lifestyle.Scoped);

            container.Register(typeof(IAplicationBase<>), typeof(AplicationBase<>), Lifestyle.Scoped);
            container.Register<IAplicationFuncionario, AplicationFuncionario>(Lifestyle.Scoped);

            container.Register<Context>(Lifestyle.Scoped);
            container.Verify();
            return container;
        }
    }
}
