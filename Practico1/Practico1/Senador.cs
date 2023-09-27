using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Senador : Legislador
    {
        private int NumAsientoAlta;

        public Senador(string partidoPolitico, string departamento, int despacho, string nombre, string apellido, int edad, 
            bool casado, string camara, int NumAsientoAlta) : base(partidoPolitico, departamento, despacho, nombre, apellido, edad, casado, camara) 
        {
            this.NumAsientoAlta = NumAsientoAlta;
        }

        public int GetAsientoAlta() { return NumAsientoAlta;}

        public void SetAsientoAlta(int asientoAlta) { asientoAlta = NumAsientoAlta; }

                 
        //CLASE ABSTRACT
        public override string Votar()
        {
            return nombre + " " + apellido + " Votó";
        }

        //POLI DE SOBRECARGA
        public string PresentarPropuesta() 
        {
            return "Senador: " +nombre + " " + apellido  + " Presenta una propuesta";
        }

        //CLASE VIRTUAL
        public override string ParticiparDebate()
        {
            return "Senador " +nombre + " " + apellido + " Participa en el proximo debate";
        }

    }
}
