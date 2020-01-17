using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04cs.br.com.gft.model
{
    class Supervisor : Funcionario
    {

        public Supervisor(string nome, int idade, int salario) : base(nome, idade, salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;

        }
                          
        public int bonificacao()
        {
            return salario + 5000;

        }
    }
}
