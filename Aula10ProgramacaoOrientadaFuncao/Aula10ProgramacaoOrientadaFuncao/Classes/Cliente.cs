using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cliente: Base
    {
        public Cliente(string nome = null, string telefone = null, string cpf = null)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
        }

        public int Calculo3()
        {
            return 1 + 2;
        }

        internal int Calculo4()
        {
            return 1 + 2;
        }

        public virtual void Gravar2() { }
    }
}
