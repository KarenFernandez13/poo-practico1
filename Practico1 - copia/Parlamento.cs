using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Parlamento
    {
        private List <Legislador> ListaLegisladores;

        public Parlamento()
        {
            ListaLegisladores = new List<Legislador>();
        }


        public List<Legislador> ObtenerLegisladores()
        {
            return ListaLegisladores;
        }


        public void IngresarLegislador(Legislador Legislador)
        {
            ListaLegisladores.Add(Legislador);
        }
        

        public void EliminarLegislador(int numero)
        {
            Legislador eliminarLegislador = ListaLegisladores.Find(x => x.GetDespacho() == numero);
            ListaLegisladores.Remove(eliminarLegislador);
        }


        public void ListarCamaras()
        {
            foreach (var x in ListaLegisladores)
            {
                Console.WriteLine("Legislador: " + x.GetNombre() + " " + x.GetApellido() + " - " +"Cámara: " + x.GetCamara() + " - " + "Numero de despacho: " + x.GetDespacho());
            }
        }
        
                    
        public int CantidadPorTipo(int numero)
        {
            int contador = 0;
            if (numero == 0)
            {
                foreach (var y in ListaLegisladores)
                {
                    if ((y.GetCamara() == "Diputado"))
                    {
                        contador++;
                    }
                }
            }
            else if (numero == 1)
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
