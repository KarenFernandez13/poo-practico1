﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Parlamento
    {
        List <Legislador> ListaLegisladores;

        public Parlamento()
        {
            ListaLegisladores = new List<Legislador>();
        }

        public void IngresarLegislador(Legislador Legislador)
        {
            ListaLegisladores.Add(Legislador);
        }
        
        public void EliminarLegislador(Legislador Legislador)
        {
            ListaLegisladores.Remove(Legislador);
        }

        public void ListarCamaras()
        {
            foreach (var x in ListaLegisladores)
            {
                Console.WriteLine("Legislador : " + x.GetNombre() + " " + x.GetApellido() + " Cámara: " + x.GetCamara() + " Numero de despacho: " + x.GetDespacho());
            }
        }
        private int contador = 0;
        
        public int CantidadPorTipo(int numero)
        {

            if (numero == 0)
            {
                foreach (var y in ListaLegisladores)
                {
                    if ((y.GetCamara() == "Diputado"))
                    {
                        contador++;
                    }
                }
            }else if (numero == 1)
            {
                foreach (var y in ListaLegisladores)
                {
                    if ((y.GetCamara() == "Senador"))
                    {
                        contador++;
                    }
                }

            }
                          
            return contador;
            
        }

        

       




    }
}
