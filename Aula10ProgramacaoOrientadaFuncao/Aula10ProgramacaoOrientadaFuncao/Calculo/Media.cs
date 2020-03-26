using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    public static class Media
    {
        public const int QTD_NOTAS = 3;

        public static void CalculoMedia()
        {
            Console.Write("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();
            int somaNotas = 0;

            Console.WriteLine($"Digite as {QTD_NOTAS} do aluno");

            List<int> notas = new List<int>();
            for(int i = 1; i<= QTD_NOTAS; i++)
            {
                Console.Write($"Digite a nota {i}: ");
                Console.Write("\n");
                //notas[i] = int.Parse(Console.ReadLine());
                int nota = int.Parse(Console.ReadLine());
                notas.Add(nota);
                somaNotas += nota;
            }

            int media = somaNotas / QTD_NOTAS;
            //int media = somaNotas / notas.Count; 

            Console.WriteLine($"A média do aluno {nomeAluno} = {media}");
            Console.WriteLine("Suas notas são: ");
            foreach(int nota in notas)
            {
                Console.WriteLine(nota);
            }
        }
    }
}
