using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aula 03 Operadoes Lógicos

            //Operador lógico if/else:

            var nivelDoTanque = 100;
            var temperaturaDoTanque = 2;
            var produtoNoTanque = true;

            if (nivelDoTanque == 0) Console.WriteLine($"O tanque está vazio, nível = {nivelDoTanque}%");
            else if (nivelDoTanque <= 50) Console.WriteLine($"O tanque esta abaixo metade, nível = {nivelDoTanque}%");
            else Console.WriteLine($"O tanque está acima da metade {nivelDoTanque}%");


            //Operador lógico switch:
            switch (temperaturaDoTanque)
            {
                case 0:
                    Console.WriteLine($"A temperatura do tanque está muito baixa, temperatura = {temperaturaDoTanque}°C");
                    break;
                case 50:
                    Console.WriteLine($"A temperatura do tanque está ideal, temperatura = {temperaturaDoTanque}°C");
                    break;
                case 100:
                    Console.WriteLine($"A temperatura do tanque está muito alta, temperatura = {temperaturaDoTanque}°C");
                    break;
                default:
                    Console.WriteLine($"A temperatura do tanque fora dos parametros, temperatura = {temperaturaDoTanque}°C");
                    break;
            }

            //Operador lógico ternário:
            Console.WriteLine(produtoNoTanque ? "Existe produto dentro do tanque" : "Não existe produto dentro do tanque");
            Console.Read();
        }
    }
}
