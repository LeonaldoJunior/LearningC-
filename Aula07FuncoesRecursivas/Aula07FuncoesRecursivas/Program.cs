using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07FuncoesRecursivas
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
            string caminhoArquivo2 = @"C:\Users\Leonaldo\Desktop\LearningC-\Arquivos\arq" + (numeroArquivo + 1)+ ".txt";
            if (File.Exists(caminhoArquivo2))
            {
                LerArquivo(numeroArquivo + 1);
            }

                
        } 

        static void Main(string[] args)
        {

            LerArquivo(1);
            Console.Read();
        }
    }
}
