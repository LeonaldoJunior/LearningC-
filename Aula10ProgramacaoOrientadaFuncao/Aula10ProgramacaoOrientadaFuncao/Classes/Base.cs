using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;


namespace Classes
{
    public abstract class Base: IPessoa
    {
        public string nome;
        public string telefone;
        public string cpf;

        public Base(string nome = null, string telefone = null, string cpf = null)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
        }

        public void SetNome(string nome) { this.nome = nome; }
        public void SetTelefone(string telefone) { this.telefone = telefone; }
        public void SetCpf(string cpf) { this.cpf = cpf;}

        public virtual void Gravar()
        {
            var dados =this.Ler();
            dados.Add(this);
            if (File.Exists(caminhoBaseDeDados()))
            {
                string conteudo = "nome;telefone;cpf\n";
                foreach (Base b in dados)
                {
                    conteudo += b.nome + ";" + b.telefone + ";" + b.cpf + ";\n";
                }

                File.WriteAllText(caminhoBaseDeDados(), conteudo);
            }
        }

        private string caminhoBaseDeDados()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"] + this.GetType().Name + ".txt";
        }

        public List<IPessoa> Ler()
        {
            var dados = new List<IPessoa>();

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

                        var DadosSeparados = linha.Split(';');

                        //var b = new Base();
                        var b = (IPessoa)Activator.CreateInstance(this.GetType());
                        b.SetNome(DadosSeparados[0]);
                        b.SetTelefone(DadosSeparados[1]);
                        b.SetCpf(DadosSeparados[2]);
                        dados.Add(b);

                    }
                }
            }

            return dados;
        }


        public virtual void olhar()
        {
            Console.WriteLine("O cliente " + this.nome + " esta olhando pra mim");
        }
    }
}
