using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Usuario: Cliente
    {
        public Usuario(string _nome = null, string _telefone = null, string _cpf = null)
        {
            this.nome = _nome;
            this.telefone = _telefone;
            this.cpf = _cpf;
        }
    }
}



