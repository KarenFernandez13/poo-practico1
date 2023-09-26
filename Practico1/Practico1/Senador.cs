using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Senador : Legislador
    {
        private int NumAsientoAlta;

        public Senador(string partidoPolitico, string departamento, int despacho, string nombre, string apellido, int edad, 
            bool casado, string camara) : base(partidoPolitico, departamento, despacho, nombre, apellido, edad, casado, camara) {}

        public int GetAsientoAlta() { return NumAsientoAlta;}

        public void SetAsientoAlta(int asientoAlta) { asientoAlta = NumAsientoAlta; }

        public override void Votar()
        {
            Console.WriteLine("Mi voto es: ");
        }

        public void PresentarPropuesta() 
        {
            Console.WriteLine("Propuesta Legislativa de Senador.... ");
        }

        
    }
}
