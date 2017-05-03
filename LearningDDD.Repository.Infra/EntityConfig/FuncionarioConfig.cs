using LearningDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace LearningDDD.Repository.Infra.EntityConfig
{
    class FuncionarioConfig : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfig()
        {
            HasKey(x => x.Id);
            Property(x => x.PIS).IsRequired();
            Property(x => x.Salario).IsRequired();
            ToTable(nameof(Funcionario));
        }
    }
}
