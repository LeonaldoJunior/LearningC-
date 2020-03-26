using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    public static class Tabuada
    {
        public static void Calcular(int numero)
        {
            Console.WriteLine($"======= Tabuada do {numero} =======");
            for (int multiplo = 0; multiplo <= 10; multiplo++)
                Console.WriteLine($"\t{numero} X {multiplo} = { numero * multiplo }");
        }

    }
}
