using Aula10ProgramacaoOrientadaFuncao;
using Calculo;
using Diretorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static class Selecao
    {
        public const int NUMERO_ARQUIVO_INICIAL = 1;
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int QTD_NOTAS = 3;

        public static void Menu()
        {
            var mensagemInicial = "Olá usuário, bem vindo ao programa, utilizando programação funcional";
            var mensagemMenu =
                "\nDigite uma das opções abaixo:" +
                "\n0 - Sair do programa" +
                "\n1 - Ler arquivos" +
                "\n2 - Executar a tabuada" +
                "\n3 - Calcular soma";

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
                        Arquivo.Ler(NUMERO_ARQUIVO_INICIAL);
                        break;
                    case 2:
                        Console.WriteLine("Digite um número para fazer a tabuada: ");
                        var valorTabuada = int.Parse(Console.ReadLine());
                        Tabuada.Calcular(valorTabuada);
                        break;
                    case 3:
                        Media.CalculoMedia();
                        break;
                }
            }
        }
    }
}
