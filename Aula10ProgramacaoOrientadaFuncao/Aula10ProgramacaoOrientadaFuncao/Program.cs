﻿using Calculo;
using Classes;
using Diretorio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Aula10ProgramacaoOrientadaFuncao
{
    public static class Program
    {
        static void Main(string[] args)
        {
          //  Selecao.Menu();

            Usuario u = new Usuario();
            u.nome = "junior";
            u.telefone = "123";
            u.cpf = "000000";
            u.Gravar();

            Console.WriteLine("=====================Cadastro de Usuario ===================");
            foreach (Usuario us in Usuario.LerUsuario())
            {
                Console.WriteLine(u.nome);
                Console.WriteLine(u.telefone);
                Console.WriteLine(u.cpf);
                Console.WriteLine("============================");
            }
            Console.WriteLine("=====================Cadastro de Cliente ===================");

            foreach (Cliente cl in Cliente.LerClientes())
            {
                Console.WriteLine(cl.nome);
                Console.WriteLine(cl.telefone);
                Console.WriteLine(cl.cpf);
                Console.WriteLine("============================");
            }
            Console.ReadLine();
        }
    }
}
