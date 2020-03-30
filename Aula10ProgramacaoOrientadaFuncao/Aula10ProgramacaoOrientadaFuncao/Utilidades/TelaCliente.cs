using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    class TelaCliente
    {
        public const int SAIDA_PROGRAMA = 0;

        public static void Chamar()
        {
            var clientes = new Cliente().Ler();

            Console.WriteLine("========================== Cadastro de cliente ======================");

            while (true)
            {
                var mensagemMenu = "Digite uma das opções abaixo:" +
                    "\n0 - Sair do cadastro" +
                    "\n1 - Cadastrar clientes" +
                    "\n2 - Listar clientes" ;

                Console.WriteLine(mensagemMenu);

                var valorDigitado = int.Parse(Console.ReadLine());
                if (valorDigitado == SAIDA_PROGRAMA) break;


                switch (valorDigitado)
                {
                    case 1:
                        var cliente1 = new Cliente();

                        Console.WriteLine("Digite o nome do cliente: ");
                        cliente1.nome = Console.ReadLine();

                        Console.WriteLine("Digite o cpf do cliente: ");
                        cliente1.cpf = Console.ReadLine();

                        Console.WriteLine("Digite o telefone do cliente: ");
                        cliente1.telefone = Console.ReadLine();
                        cliente1.Gravar();
                        break;
                    case 2:
                        foreach (Cliente c in clientes)
                        {
                            Console.WriteLine(c.nome);
                            Console.WriteLine(c.telefone);
                            Console.WriteLine(c.cpf);
                            Console.WriteLine("=============================");
                        }
                        break;
                   
                }
            }
        }
    }
}
