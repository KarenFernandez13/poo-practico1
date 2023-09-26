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
        public List <Legislador> ListaLegisladores;

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

        public void ListarCamaras(List<Legislador> Lista)
        {
            foreach (var x in Lista)
            {
                Console.WriteLine("Legislador : " + x.GetNombre() + " " + x.GetApellido() + "Cámara: " + x.GetCamara() + " Numero de despacho: " + x.GetDespacho());
            }
        }
        private int contador = 0;
        
        public void CantidadPorTipo(List<Legislador> Lista)
        {
            foreach (var y in  Lista) 
            {
                if((y.GetCamara() == "Diputado") || (y.GetCamara() == "diputado"))
                {
                    contador++;
                }                
            }
            Console.WriteLine("Cantidad de diputados: " +contador);
            Console.WriteLine("Cantidad de Senadores: " + (ListaLegisladores.Count - contador));
        }

       




    }
}
