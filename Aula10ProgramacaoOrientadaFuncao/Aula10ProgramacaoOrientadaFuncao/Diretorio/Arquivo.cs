using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio
{
    public static class Arquivo
    {
        private static string caminhoDoArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"];
        }

        public static void Ler(int numeroArquivo)
        {
            Console.WriteLine($"======= Ler o arquivo número {numeroArquivo} =======");

            string caminhoArquivo = caminhoDoArquivo() + "arq" + numeroArquivo + ".txt";
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
            string caminhoArquivo2 = caminhoDoArquivo() + "arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(caminhoArquivo2))
            {
                Ler(numeroArquivo + 1);
            }
        }

    }
}
