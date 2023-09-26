using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    abstract class Legislador
    {
        protected string partidoPolitico;
        protected string departamento;
        protected int despacho;
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected bool casado;
        protected string camara;

        public Legislador(string partidoPolitico, string departamento, int despacho, string nombre, string apellido, int edad, 
            bool casado, string camara) 
        {
            this.camara = camara;
            this.casado = casado;
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
            this.despacho = despacho;
            this.departamento = departamento;
            this.partidoPolitico = partidoPolitico;

        }



        //GETTERS
        public string GetCamara() { return camara; } 
        public bool GetCasado() { return casado; }
        public int GetEdad() { return edad; }
        public string GetNombre() { return nombre; }
        public string GetApellido() {  return apellido; }
        public int GetDespacho() { return despacho; }
        public string GetDepartamento() { return departamento; }
        public string GetPartidoPolitico() { return partidoPolitico; }

        //SETTERS
        public void SetCamara(string camara){ this.camara = camara;}
        public void SetCasado(bool casado) { this.casado = casado;}
        public void SetEdad (int edad) { this.edad = edad;}
        public void SetNombre(string nombre) { this.nombre = nombre; }
        public void SetApellido(string apellido) { this.apellido = apellido; }
        public void SetDespacho(int despacho) { this.despacho = despacho; }        
        public void SetDepartamento(string departamento) { this.departamento = departamento; }
        public void SetPartido(string partido) { partido = partidoPolitico; }



        //METODOS
        public abstract void Votar();

        public virtual void ParticiparDebate()
        {
            Console.WriteLine("Participaré en el próximo debate");
        }

    }
}
