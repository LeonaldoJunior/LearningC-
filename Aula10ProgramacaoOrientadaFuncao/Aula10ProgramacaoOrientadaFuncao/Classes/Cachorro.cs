using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cachorro : Animal
    {
        public int idade;

        public int idade2
        {
            get
            {
                return idadePreDefinida;
            }
        }

        private int idadePreDefinida = 2;

        public override void latir()
        {
            Console.WriteLine("Au Au eu sou um cachorro");
        }
    }
}
