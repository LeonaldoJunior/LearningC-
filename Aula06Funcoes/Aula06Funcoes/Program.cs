//Sintaxe função 
//Local  - Tipo   - Retorno - nome       - parametros
//Public   Static   void      nomeFuncao   (string nomeParametro)
//Public            int       calcular     ()
//                  int       calcular     ()

//Local:
//Public    -> função publica pode ser acessada de qualquer lugar do programa
//Private   -> privada para o escopo do programa, por semplo se for transformado em umalib ninguem pode acessar essa função
//Internal  -> Internal somente para o namespace
//Protected -> publica para todo o seu programa, mas é protegida so o seu programa pode utilizar

//Tipo:
//static    
//não static

//Retorno:
//Void
//Int
//String
//Double
//Bool

//nome:
//Melhor nome possivel para ficar claro o que a fumção ira realizar no seu programa

//Parâmetros:
//Tipo do parâmetro e o nome do parâmetro

//Retorno:
//Return

//Exemplo de função
//public static int calcular(){
//    var valor1 = 1;
//    var valor2 = 2;
//    var soma   = 0;

//    soma = valor1 + valor2;

//    return soma;
//}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06Funcoes
{
    class Program
    {
        static int Calcular()
        {
            var valor1 = 1;
            var valor2 = 2;
            var soma   = 0;

            soma = valor1 + valor2;

            return soma;
        }

        public static void MostrarMensagemNaTela()
        {
            Console.WriteLine(Calcular());
        }

        public static void Tabuada(int numero)
        {
            Console.WriteLine($"Tabuada do {numero}:");
            Console.WriteLine("===============");


            for (int multiplos = 0; multiplos <= 10; multiplos++)
            {
                Console.WriteLine($"{numero} X {multiplos} = { numero * multiplos }" );

            }
            Console.WriteLine("===============");

        }



        static void Main(string[] args)
        {
            Tabuada(1);
            Tabuada(2);
            Tabuada(3);
            Tabuada(4);
            Tabuada(5);

            Console.Read();

        }
    }
}
