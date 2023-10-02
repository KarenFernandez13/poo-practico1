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

        public Legislador(string partidoPolitico, string departamento, int despacho, string nombre, string apellido, 
            int edad, bool casado, string camara) 
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

      
        public string GetCamara() => camara; 
        public bool GetCasado() => casado; 
        public int GetEdad() => edad; 
        public string GetNombre() => nombre; 
        public string GetApellido() => apellido; 
        public int GetDespacho() => despacho; 
        public string GetDepartamento() => departamento; 
        public string GetPartidoPolitico() => partidoPolitico; 

        
        public void SetCamara(string camara) => this.camara = camara;
        public void SetCasado(bool casado) => this.casado = casado;
        public void SetEdad (int edad) => this.edad = edad;
        public void SetNombre(string nombre) => this.nombre = nombre; 
        public void SetApellido(string apellido) => this.apellido = apellido; 
        public void SetDespacho(int despacho) => this.despacho = despacho;      
        public void SetDepartamento(string departamento) => this.departamento = departamento; 
        public void SetPartido(string partido) => partido = partidoPolitico; 
                   
        
        //METODOS
        public abstract string Votar();

        
        public virtual string ParticiparDebate()
        {
            return "Senador " + nombre + " " + apellido + " participa en el próximo debate";
        }

        public virtual string PresentarPropuesta()
        {
            return "Senador " + nombre + " " + apellido + " presenta una propuesta";
        }

      
    }
}
