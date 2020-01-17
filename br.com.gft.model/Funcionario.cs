using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04cs.br.com.gft.model
{
    public class Funcionario
    {
        public string nome { get; set; }
        public int idade {get; set;}
        public int salario { get; set; }

        public Funcionario(string nome, int idade, int salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
        }

        
    }
}
