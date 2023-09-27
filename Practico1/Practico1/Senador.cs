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

        public int GetAsientoAlta() => NumAsientoAlta;

        public void SetAsientoAlta(int asientoAlta) => asientoAlta = NumAsientoAlta;

        List<string> propuestasSenadores = new List<string>
        {
            "P. N°1: Animales", "P. N°2: Medio ambiente", "P. N°3: Agua"
        };


        //CLASE ABSTRACT
        public override string Votar()
        {
          return nombre + " " + apellido + " votó";
        }

        //POLI DE SOBRECARGA
        public List<string> obtenerPropuestas()
        {
            return propuestasSenadores;
        }


    }
}
