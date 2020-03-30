using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Animal
    {
        public string coleira;
        public string pelo;
        public string olhos;

        public abstract void latir();

        public string Correr()
        {
            return "Animal está correndo";
        }
    }
}
