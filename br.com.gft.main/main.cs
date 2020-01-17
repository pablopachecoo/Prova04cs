using System;
using System.Collections.Generic;
using System.Text;
using Ex04cs.br.com.gft.model;

namespace Ex04cs.br.com.gft.main
{
    class main
    {
        public static void Main(String[] args)
        {
            Gerente gerente = new Gerente("Fabio", 35, 10000);
            Supervisor supervisor = new Supervisor("Fernando", 32, 5000);
            Vendedor vendedor = new Vendedor("Vault", 27, 2000);

            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░Nome gerente: " + gerente.nome + "            ░" + "\n" + "░Idade gerente: " + gerente.idade + "              ░" +  "\n" + "░Gerente salario: " + gerente.bonificacao() + "         "+        "░");
            Console.WriteLine("░───────────────────────────────░");
            Console.WriteLine("░Nome supervisor: " + supervisor.nome + "      ░" + "\n" + "░Idade supervisor: " + supervisor.idade + "           ░" + "\n" + "░supervisor salario: " + supervisor.bonificacao() + "      " + "░");
            Console.WriteLine("░───────────────────────────────░");
            Console.WriteLine("░Nome vendedor: " + vendedor.nome + "           ░" + "\n" + "░Idade vendedor: " + vendedor.idade + "             ░" + "\n" + "░vendedor salario: " + vendedor.bonificacao() + "         ░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");

            Console.WriteLine("                         ______                    ");
            Console.WriteLine(" _________        .---------------" + "---.              ");
            Console.WriteLine(":______.-':      :  .--------------.  :             ");
            Console.WriteLine("| ______  |      | :                : |             ");
            Console.WriteLine("| ______  |      | :                : |             ");
            Console.WriteLine("|:______B:|      | |       GFT      | |             ");
            Console.WriteLine("|:______B:|      | |                | |             ");
            Console.WriteLine("|:______B:|      | |                | |             ");
            Console.WriteLine("|         |      | |                | |             ");
            Console.WriteLine("|:_____:  |      | |                | |             ");
            Console.WriteLine("|    ==   |      | :                : |             ");
            Console.WriteLine("|       O |      :  '--------------'  :             ");
            Console.WriteLine("|       o |      :'---...______...---'              ");

            Console.WriteLine("|'-.____o_|   '-.   '-...______...-'  `-._          ");
            Console.WriteLine(":_________:      `.____________________   `-.___.-. ");
            Console.WriteLine("                 .'.eeeeeeeeeeeeeeeeee.'.      :___:");
            Console.WriteLine("               .'.eeeeeeeeeeeeeeeeeeeeee.'.         ");
            Console.WriteLine("              :____________________________:");








            Console.ReadLine();
        }
    }
}
