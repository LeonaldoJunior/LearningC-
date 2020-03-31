using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Email
    {
        private Email()
        { }

        private static Email instancia;
        public string origin;
        public string destino;
        public string titulo;
        public string corpo;

        public void EnviarEmail() {
            Console.WriteLine($"Enviando email para {destino} \nCom o título {titulo} \nCorpo: {corpo}");
        }

        public static Email Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Email();
                }
                return instancia;
            }
        }
    }
}

