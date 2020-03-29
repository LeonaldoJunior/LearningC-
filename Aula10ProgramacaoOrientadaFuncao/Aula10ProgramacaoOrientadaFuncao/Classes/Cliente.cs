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

        public void Gravar()
        {
            if (this.GetType() == typeof(Cliente))
            {
                var clientes = Cliente.LerClientes();
                clientes.Add(this);
                if (File.Exists(caminhoDoArquivoClientes()))
                {
                    string conteudo = "nome;telefone;cpf\n";
                    foreach (Cliente c in clientes)
                    {
                        conteudo += c.nome + ";" + c.telefone + ";" + c.cpf + ";\n";
                    }

                    File.WriteAllText(caminhoDoArquivoClientes(), conteudo);
                }
            }
            else {
                var usuario = Usuario.LerUsuario();
                Usuario u = new Usuario ( this.nome, this.telefone, this.cpf);
                usuario.Add(u);
                if (File.Exists(caminhoDoArquivoUsuarios()))
                {
                    string conteudo = "nome;telefone;cpf\n";
                    foreach (Cliente c in usuario)
                    {
                        conteudo += c.nome + ";" + c.telefone + ";" + c.cpf + ";\n";
                    }

                    File.WriteAllText(caminhoDoArquivoUsuarios(), conteudo);
                }
            }


        }


        private void olhar()
        {
            Console.WriteLine("O cliente" + this.nome + "esta olhando pra mim");
        }

        private static string caminhoDoArquivoClientes()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        private static string caminhoDoArquivoUsuarios()
        {
            return ConfigurationManager.AppSettings["BaseDeUsuarios"];
        }


        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();

            if (File.Exists(caminhoDoArquivoClientes()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoDoArquivoClientes()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;//para ignorar a primeira linha do arquivo pois é uma linha de cabeçalho

                        var clienteDadosSeparados = linha.Split(';');
                        var cliente = new Cliente {
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

        public static List<Usuario> LerUsuario()
        {
            var usuarios = new List<Usuario>();

            if (File.Exists(caminhoDoArquivoUsuarios()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoDoArquivoUsuarios()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;//para ignorar a primeira linha do arquivo pois é uma linha de cabeçalho

                        var usuarioDadosSeparados = linha.Split(';');
                        var usuario = new Usuario
                        (
                            usuarioDadosSeparados[0],
                            usuarioDadosSeparados[1],
                            usuarioDadosSeparados[2]
                        );

                        usuarios.Add(usuario);

                    }
                }
            }

            return usuarios;
        }




    }
}
