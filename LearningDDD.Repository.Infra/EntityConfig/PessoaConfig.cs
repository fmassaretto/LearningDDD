using LearningDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace LearningDDD.Repository.Infra.EntityConfig
{
    internal class PessoaConfig : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfig()
        {
            HasKey(x => x.Id);
            Property(x => x.Nome).IsRequired();
            Property(x => x.SobreNome).IsRequired();
            Property(x => x.Email).IsRequired();
            ToTable(nameof(Pessoa));
        }
    }
}
