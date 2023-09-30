using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Diputados
    {
        private int numAsientoCamaraBaja;

        public int getAsientoBaja() { return  numAsientoCamaraBaja;}

        public abstract void Votar()
        {
            Console.WriteLine("Mi voto es: ")
        }

        public void presentarPropuesta()
        {
            Console.WriteLine("Propuesta Legislativa de Diputado.... ");
        }

        public override void participarDebate() 
        {
            Console.WriteLine("No participaré en el siguiente debate")
        }
    }
}
