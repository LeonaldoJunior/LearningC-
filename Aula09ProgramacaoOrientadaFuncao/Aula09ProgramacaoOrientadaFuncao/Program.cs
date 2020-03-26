using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09ProgramacaoOrientadaFuncao
{
    class Program
    {
        public static int Soma(int numero1, int numero2)
        {
            Console.WriteLine($"======= Soma =======");
            return numero1 + numero2; 
        }
        public static void Tabuada(int numero)
        {
            Console.WriteLine($"======= Tabuada do {numero} =======");
            for (int multiplo = 0; multiplo <= 10; multiplo++)
                Console.WriteLine($"\t{numero} X {multiplo} = { numero * multiplo }");
        }
        private static void LerArquivo(int numeroArquivo)
        {
            Console.WriteLine($"======= Ler o arquivo número {numeroArquivo} =======");

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

        public const int NUMERO_ARQUIVO_INICIAL = 1;
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;




        static void Main(string[] args)
        {
            var mensagemInicial = "Olá usuário, bem vindo ao programa, utilizando programação funcional";
            var mensagemMenu =
                "\nDigite uma das opções abaixo:" +
                "\n0 - Sair do programa" +
                "\n1 - Ler arquivos" +
                "\n2 - Executar a tabuada" +
                "\n3 - Calcular média de alunos";

            Console.WriteLine(mensagemInicial);

            while (true)
            {
                Console.WriteLine(mensagemMenu);

                //Console.WriteLine($"Digite {SAIDA_PROGRAMA} para começar a ler os arquivos");
                var valorDigitado = int.Parse(Console.ReadLine());

                if (valorDigitado == SAIDA_PROGRAMA) break;

                switch (valorDigitado)
                {
                    case 1:
                        LerArquivo(NUMERO_ARQUIVO_INICIAL);
                        break;
                    case 2:
                        Console.WriteLine("Digite um número para fazer a tabuada: ");
                        var valorTabuada = int.Parse(Console.ReadLine());
                        Tabuada(valorTabuada);
                        break;
                    case 3:
                        Console.WriteLine("Digite 2 números para fazer a soma: ");
                        Console.WriteLine("Número 1: ");
                        var numeroDigitado1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Número 2: ");
                        var numeroDigitado2 = int.Parse(Console.ReadLine());

                        Console.WriteLine(Soma(numeroDigitado1, numeroDigitado2));
                        break;
                }
            }

        }
    }
}
