using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04cs.br.com.gft.model
{
    class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, int salario) : base(nome, idade, salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;

        }
        public int bonificacao()
        {
            return salario + 3000;

        }
    }
}
