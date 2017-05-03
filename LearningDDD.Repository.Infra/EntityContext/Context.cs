using LearningDDD.Domain.Entities;
using LearningDDD.Repository.Infra.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDDD.Repository.Infra.EntityContext
{
    public class Context : DbContext
    {
        public DbSet<Pessoa> Pessoa;
        public DbSet<Funcionario> Funcionario;
        public Context() : base("Home")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PessoaConfig());
            modelBuilder.Configurations.Add(new FuncionarioConfig());
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
