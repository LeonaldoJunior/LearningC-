using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cliente
    {
        public string nome;
        public string telefone;
        public string cpf;

        //public Cliente(string nome, string telefone, string cpf)
        //{
        //    this.nome = nome;
        //    this.telefone = telefone;
        //    this.cpf = cpf;
        //}

        public virtual void Gravar()
        {
            var clientes = Cliente.LerClientes();
            clientes.Add(this);
            if (File.Exists(caminhoBaseDeDados()))
            {
                string conteudo = "nome;telefone;cpf\n";
                foreach (Cliente c in clientes)
                {
                    conteudo += c.nome + ";" + c.telefone + ";" + c.cpf + ";\n";
                }

                File.WriteAllText(caminhoBaseDeDados(), conteudo);
            }      
        }


        public virtual void olhar()
        {
            Console.WriteLine("O cliente " + this.nome + " esta olhando pra mim");
        }

        private static string caminhoBaseDeDados()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }



        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();

            if (File.Exists(caminhoBaseDeDados()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseDeDados()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;//para ignorar a primeira linha do arquivo pois é uma linha de cabeçalho

                        var clienteDadosSeparados = linha.Split(';');
                        var cliente = new Cliente
                        {
                            nome = clienteDadosSeparados[0],
                            telefone = clienteDadosSeparados[1],
                            cpf = clienteDadosSeparados[2]
                        };

                        clientes.Add(cliente);

                    }
                }
            }

            return clientes;
        }
    }
}
