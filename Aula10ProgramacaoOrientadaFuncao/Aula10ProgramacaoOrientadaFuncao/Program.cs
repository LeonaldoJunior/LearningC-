using Calculo;
using Classes;
using Componentes;
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
    //class Animal {
    //    public virtual string teste()
    //    {
    //        return "teste";
    //    }
    //}

    //class Macaco : Animal
    //{
    //    public override string teste()
    //    {
    //        return "ssss";
    //    }
    //}

    partial class Animal
    {
        public string teste;
        partial void tt();
    }

    partial class Animal
    {
        public string teste2;
        partial void tt()
        {
            Console.WriteLine("Teste Partial");
        }

    }
    
   public static class Program
    {

        static void Main(string[] args)
        {

            Email.Instancia.corpo = "bla bla bla";
            Email.Instancia.titulo =  "Título do email";
            Email.Instancia.origin = "leonaldo@blabla.com";
            Email.Instancia.destino = "blabla@blalba.com";

            Email.Instancia.EnviarEmail();
            Console.ReadLine();
            //var x = new Animal();
           


            //var c = new Cachorro();
            //c.idade = 12;
            //Console.WriteLine(c.idade);

            //Console.WriteLine(c.idade2);

            //Console.ReadLine();

            //    //  Selecao.Menu();


            //    var cachorro = new Cachorro();
            //    cachorro.latir();

            //    Cliente cli = new Cliente();
            //    cli.nome = "Cliente";
            //    cli.telefone = "123";
            //    cli.cpf = "000000";
            //    cli.Gravar();

            //    Console.WriteLine("=====================Cadastro de Cliente ===================");
            //    foreach (Base cl in new Cliente().Ler())
            //    {
            //        Console.WriteLine(cl.nome);
            //        Console.WriteLine(cl.telefone);
            //        Console.WriteLine(cl.cpf);
            //        Console.WriteLine("============================");
            //    }


            //    Usuario u = new Usuario();
            //    u.nome = "xina";
            //    u.telefone = "123";
            //    u.cpf = "000000";
            //    u.Gravar();
            //    //u.olhar();

            //    Console.WriteLine("=====================Cadastro de Usuario ===================");
            //    foreach (Base us in new Usuario().Ler())
            //    {
            //        Console.WriteLine(us.nome);
            //        Console.WriteLine(us.telefone);
            //        Console.WriteLine(us.cpf);
            //        Console.WriteLine("============================");
            //    }




            //    //Ferramentas f = new Ferramentas();
            //    //bool d = f.ValidarCPF("1212312313");
            //    //Console.WriteLine(d);

            //    //f.MetodoParaTodosQueUtilizamAssembly();
            //    Console.ReadLine();


        }
    }
}
