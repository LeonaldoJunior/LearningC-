using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08FuncoesRecursivas
{
    class Program
    {
        private static void LerArquivo(int numeroArquivo)
        {
            string caminhoArquivo = @"C:\Users\Leonaldo\Desktop\LearningC-\Arquivos\arq" + numeroArquivo + ".txt";
            if (File.Exists(caminhoArquivo))
            {
                using (StreamReader arquivo = File.OpenText(caminhoArquivo))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            string caminhoArquivo2 = @"C:\Users\Leonaldo\Desktop\LearningC-\Arquivos\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(caminhoArquivo2))
            {
                LerArquivo(numeroArquivo + 1);
            }


        }

        public const int NUMERO_ARQUIVO_INICIAL= 1;
        public const int SAIDA_PROGRAMA = 1;


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Digite {SAIDA_PROGRAMA} para começar a ler os arquivos");
                int valorDigitado = int.Parse(Console.ReadLine());
                if (valorDigitado == SAIDA_PROGRAMA) break;
            }

            LerArquivo(NUMERO_ARQUIVO_INICIAL);
            Console.Read();
        }
    }
}
