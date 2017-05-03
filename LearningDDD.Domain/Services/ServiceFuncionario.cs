using LearningDDD.Domain.Entities;
using LearningDDD.Domain.Interfaces.Repository.RepositoryBase;
using LearningDDD.Domain.Interfaces.Services;

namespace LearningDDD.Domain.Services
{
    public class ServiceFuncionario : ServiceBase<Funcionario>, IServiceFuncionario
    {
        public ServiceFuncionario(IRepositoryBase<Funcionario> repository) : base(repository)
        {

        }
    }
}
