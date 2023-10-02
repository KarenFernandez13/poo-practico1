using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Diputado : Legislador
    {
        private int NumAsientoBaja;

        public Diputado(string partidoPolitico, string departamento, int despacho, string nombre, string apellido, int edad,
            bool casado, string camara, int numAsiento) : base(partidoPolitico, departamento, despacho, nombre, apellido, edad, casado, camara) 
        {
            this.NumAsientoBaja = numAsiento;
        }

        public int GetAsientoBaja() => NumAsientoBaja;
        public void SetAsientoBaja(int asientoBaja) => this.NumAsientoBaja = asientoBaja;

        List<string> propuestasDiputados = new List<string>
        {
            "P. N°1: Carreteras", "P. N°2: Estructuras abandonadas", "P. N°3: Iluminación", "P. Nº4: Accesibilidad"
        };

        public List<string> ObtenerPropuestas()
        {
            return propuestasDiputados;
        }

        
        public override string Votar()
        {
            return nombre + " " + apellido + " votó";

        }

        public override string ParticiparDebate()
        {
            return "Diputado " + nombre + " " + apellido + " participa en el próximo debate";
        }

        public override string PresentarPropuesta()
        {
            return "Diputado " + nombre + " " + apellido + " presenta una propuesta";
        }
    }
}
