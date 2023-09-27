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
            bool casado, string camara, int NumAsientoBaja) : base(partidoPolitico, departamento, despacho, nombre, apellido, edad, casado, camara) 
        {
            this.NumAsientoBaja = NumAsientoBaja;
        }
                

        public int GetAsientoBaja() { return  NumAsientoBaja;}
        public void SetAsientoBaja(int asientoBaja) { this.NumAsientoBaja = asientoBaja; }

        //CLASE ABSTRACT
        public override string Votar()
        {
            return nombre + " " + apellido + " votó";

        }
        //POLI DE SOBRECARGA
        public string PresentarPropuesta()
        {
            return "Diputado " + nombre + " " + apellido + " presenta una propuesta";
        }
       
        //CLASE VIRTUAL
        public override string ParticiparDebate()
        {
            return "Diputado " + nombre + " " + apellido + " participa en el próximo debate";
        }
    }
}
