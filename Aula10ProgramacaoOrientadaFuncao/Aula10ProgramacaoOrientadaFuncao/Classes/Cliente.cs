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

        public void Gravar()
        {
            //to do
        }

        private static string caminhoDoArquivo()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();

            if (File.Exists(caminhoDoArquivo()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoDoArquivo()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;

                        var clienteDadosSeparados = linha.Split(';');
                        var cliente = new Cliente();
                        cliente.nome = clienteDadosSeparados[0];
                        cliente.nome = clienteDadosSeparados[1];
                        cliente.nome = clienteDadosSeparados[2];

                        clientes.Add(cliente);

                    }
                }
            }

            return clientes;
        }




    }
}
