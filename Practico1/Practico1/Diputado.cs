using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Diputado : Legislador
    {
        public Diputado(string partidoPolitico, string departamento, int despacho, string nombre, string apellido, int edad,
            bool casado, string camara) : base(partidoPolitico, departamento, despacho, nombre, apellido, edad, casado, camara) { }


        private int NumAsientoBaja;

        public int GetAsientoBaja() { return  NumAsientoBaja;}
        public void SetAsientoAlta(int asientoBaja) { asientoBaja = NumAsientoBaja; }

        public override void Votar()
        {
            Console.WriteLine("Mi voto es: ");
        }

        public void PresentarPropuesta()
        {
            Console.WriteLine("Propuesta Legislativa de Diputado.... ");
        }
    }
}
