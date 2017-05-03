using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDDD.Domain.Entities
{
    public class Funcionario : Pessoa
    {
        public string PIS { get; set; }
        public decimal Salario { get; set; }

    }
}
