using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05ArrayCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aula 05 Array e Collections
            //Exemplo Array
            string[] nomes1 = new string[5];
            var      nomes2 = new string[5];

            int nomes1Size = nomes1.Length;
            Console.WriteLine($"Tamanho da string nomes1 = {nomes1Size}");

            nomes1[0] = "Leonaldo";
            nomes1[1] = "<3 Gian <3";
            nomes1[2] = "Betina";
            nomes1[3] = "Victor";
            nomes1[4] = "Patrik";

            foreach(string nome in nomes1)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine();
            //Exemplo Collections
            List<string> nomes3 = new List<string>();
            nomes3.Add("Leonaldo");
            nomes3.Add("<3 Gian <3");
            nomes3.Add("Betina");
            nomes3.Add("Victor");
            nomes3.Add("Patrik");

            int nome3Size = nomes3.Count;
            Console.WriteLine($"Tamanho da string nomes3 = {nome3Size}");

            foreach (string nome in nomes3)
            {
                Console.WriteLine(nome);
            }



            Console.Read();
        }
    }
}
