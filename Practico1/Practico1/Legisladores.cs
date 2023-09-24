﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    abstract class Legisladores
    {
        protected string partidoPolitico;
        protected string departamento;
        protected int despacho;
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected bool casado;
        protected string camara;

        public Legisladores(string partidoPolitico, string departamento, int despacho, string nombre, string apellido, int edad, bool casado, string camara) 
        {
            this.partidoPolitico = partidoPolitico;
            this.departamento = departamento;
            this.despacho = despacho;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.casado = casado;
            this.camara = camara;
        }

        public string getCamara() { return camara; } 
        public bool getCasado() { return casado; }
        public int getEdad() { return edad; }
        public string getNombre() { return nombre; }
        public string getApellido() {  return apellido; }
        public int getDespacho() { return despacho; }
        public string getDepartamento() { return departamento; }
        public string getPartidoPolitico() { return partidoPolitico; }

        public abstract void Votar();

        public virtual void participarDebate()
        {
            Console.WriteLine("Participaré en el próximo debate");
        }

    }
}
