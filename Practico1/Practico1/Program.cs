using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diputado Diputado1 = new Diputado("Verde", "Maldonado", 403, "Juan", "Perez", 56, true, "Diputado");
            Parlamento Legisladores = new Parlamento();
            Legisladores.IngresarLegislador(Diputado1);
            Senador Senador1 = new Senador("Azul", "Canelones", 203, "Jose", "Gomez", 40, false, "Senador");
            Legisladores.IngresarLegislador(Senador1);
            Senador1 = new Senador("Rosadito", "Piraraja", 111, "Brad", "Pitt", 60, false, "Senador");
            Legisladores.IngresarLegislador(Senador1);




            Legisladores.ListarCamaras(ListaLegisladores);
            





        }
    }
}
