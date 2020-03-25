using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aula 04 Loops

            //Idosos
            var idososSemVacina = 10;
            var idososVacinados = 0;
            var totalIdosos = idososSemVacina;

            //Jovens
            var jovensSemVacina = 33;
            var jovensVacinados = 0;
            var totalJovens = jovensSemVacina;
            
            //Crianças
            var criancasVacinados = 0;
            var criancasSemVacina = 20;
            var totalCrianças = criancasSemVacina;

            var vacinasDadas = 0;
            var grupos = new[] { "idosos", "jovens", "criancas" };

            //Loop while e do while

            //while (idososSemVacina > 0)
            //{
            //    if (idososSemVacina == 2)
            //    {
            //        break;
            //    }
            //    vacinasDadas++;
            //    idososVacinados++;
            //    idososSemVacina--;

            //}

            do
            {
                if (idososSemVacina == 2)
                {
                    break;
                }
                vacinasDadas++;
                idososVacinados++;
                idososSemVacina--;

            } while (idososSemVacina != 0);

                while (jovensSemVacina > 0)
            {
                vacinasDadas++;
                jovensVacinados++;
                jovensSemVacina--;
            }

            //Loop for
            for (var contatem = criancasSemVacina; contatem > 0; contatem--)
            {
                vacinasDadas++;
                criancasVacinados++;
                criancasSemVacina--;
            }

            //Loop foreach
            Console.WriteLine("Os grupos para vacinação são: ");
            foreach (string grupo in grupos)
            {
                Console.WriteLine($"{grupo}");
            }

            Console.WriteLine("");

            //Função recursiva

            looping(1);



            Console.WriteLine("Sistema de controle de vacinas");
            Console.WriteLine($"Total de idosos {totalIdosos}");
            Console.WriteLine($"Total de jovens {totalJovens}");
            Console.WriteLine($"Total de crianças {totalCrianças}");

            //Resultado das vacinas idosos
            if (idososSemVacina == 0) Console.WriteLine($"Todos os idosos foram vacinados, total de idosos vacinados {idososVacinados}");
            else Console.WriteLine($"Nem todos os idosos foram vacinados, total de idosos vacinados {idososVacinados}");

            //Resultado das vacinas jovens
            if (jovensSemVacina == 0) Console.WriteLine($"Todos os jovens foram vacinados, total de idosos vacinados {jovensVacinados}");
            else Console.WriteLine($"Nem todos os jovens foram vacinados, total de jovens vacinados {jovensVacinados}");
           
            //Resultado das vacinas crianças
            if (criancasSemVacina == 0) Console.WriteLine($"Todos as crianças foram vacinados, total de crianças vacinados {criancasVacinados}");
            else Console.WriteLine($"Nem todos as crianças foram vacinados, total de crianças vacinados {criancasVacinados}");

            Console.WriteLine($"Vacinas dadas {vacinasDadas} ");
            Console.Read();

        }

        public static void looping(int a)
        {
            if (a < 3)
            {
                looping(a++);
            }
        }
    }
}
