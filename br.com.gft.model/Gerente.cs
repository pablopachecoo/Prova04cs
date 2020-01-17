using System;
using System.Collections.Generic;
using System.Text;
using Ex04cs.br.com.gft.model;

namespace Ex04cs.br.com.gft.model
{
    class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, int salario) : base(nome, idade, salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;

        }

        public int bonificacao()
        {
            return salario + 10000;

        }

    }
}
