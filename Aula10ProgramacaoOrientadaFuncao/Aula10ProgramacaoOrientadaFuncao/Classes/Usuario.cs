using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Usuario : Cliente
    {
        public Usuario(string _nome = null, string _telefone = null, string _cpf = null)
        {
            this.nome = _nome;
            this.telefone = _telefone;
            this.cpf = _cpf;
        }


        private static string caminhoBaseDeDados()
        {
            return ConfigurationManager.AppSettings["BaseDeUsuarios"];
        }


        public override void Gravar()
        {

            var usuario = Usuario.LerUsuario();
            usuario.Add(this);
            if (File.Exists(caminhoBaseDeDados()))
            {
                string conteudo = "nome;telefone;cpf\n";
                foreach (Cliente c in usuario)
                {
                    conteudo += c.nome + ";" + c.telefone + ";" + c.cpf + ";\n";
                }

                File.WriteAllText(caminhoBaseDeDados(), conteudo);
            }
        }

        public static List<Usuario> LerUsuario()
        {
            var usuarios = new List<Usuario>();

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

        public override void olhar()
        {
            Console.WriteLine("O usuario " + this.nome + " não possui sobrenome pois é atributo privado da classe pai");
            Console.WriteLine("====================================");
            base.olhar();
        }

    
    }
}



