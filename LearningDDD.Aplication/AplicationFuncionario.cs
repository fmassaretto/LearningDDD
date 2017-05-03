using LearningDDD.Aplication.AplicationBase;
using LearningDDD.Aplication.Interface;
using LearningDDD.Aplication.Interface.InterfaceBase;
using LearningDDD.Domain.Entities;
using LearningDDD.Domain.Interfaces.Services;

namespace LearningDDD.Aplication
{
    public class AplicationFuncionario: AplicationBase<Funcionario>, IAplicationFuncionario
    {
        public AplicationFuncionario(IServiceBase<Funcionario> service) : base(service)
        {

        }
    }
}
