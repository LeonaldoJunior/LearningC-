using Calculo;
using Classes;
using Diretorio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Aula10ProgramacaoOrientadaFuncao
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var clientes = Cliente.LerClientes();


            var cliente1 = new Cliente();
            cliente1.nome = "Gian";
            cliente1.cpf = "111111111";
            cliente1.telefone = "1111111110";
            //cliente1.Gravar();

            var cliente2 = new Cliente();
            cliente2.nome = "Betina";
            cliente2.cpf = "222222222";
            cliente2.telefone = "222222220";
            //cliente2.Gravar();

            foreach (Cliente c in clientes)
            {
                Console.WriteLine(c.nome);
            }

            Console.ReadLine();

        }
    }
}
