using LearningDDD.Domain.Entities;
using LearningDDD.Domain.Interfaces.Repository;
using LearningDDD.Domain.Interfaces.Services;
using LearningDDD.Repository.Infra.Repository.RepositoryBase;

namespace LearningDDD.Repository.Infra.Repository
{
    public class FuncionarioRepository : RepositoryBase<Funcionario>, IRepositoryFuncionario
    {
        //private readonly IServiceBase<Funcionario> _service;
        //public FuncionarioRepository(IServiceBase<Funcionario> service) : base()
        //{
        //    _service = service;
        //}
    }
}
