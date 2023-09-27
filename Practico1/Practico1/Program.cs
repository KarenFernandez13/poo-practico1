using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parlamento Legisladores = new Parlamento();
            Diputado Diputado1 = new Diputado("Verde", "Maldonado", 403, "Juan", "Perez", 56, true, "Diputado", 8);
            Legisladores.IngresarLegislador(Diputado1);
            Senador Senador1 = new Senador("Azul", "Canelones", 203, "Jose", "Gomez", 40, false, "Senador", 10);
            Legisladores.IngresarLegislador(Senador1);


            List<Legislador> lista = Legisladores.obtenerLegisladores();
            List<string> propuestasDiputados = Diputado1.obtenerPropuestas();
            List<string> propuestasSenadores = Senador1.obtenerPropuestas();
            string nombre;
            string apellido;
            string partido;
            string departamento;
            int despacho;
            int edad;
            int numAsiento;
            bool casado;
            string camara;
           
            //MENU
            Console.WriteLine("SISTEMA DE INFORMACIÓN PARLAMENTARIA");
            Console.WriteLine("");
            Console.WriteLine("Menú Principal: ");
            Console.WriteLine("");
            Console.WriteLine("Elige una opción: ");          
            Console.WriteLine("1 - Ingresar / Eliminar Legislador ");
            Console.WriteLine("2 - Ver Listados de Cámaras");
            Console.WriteLine("3 - Propuestas Legislativas "); 
            Console.WriteLine("4 - Registrar participación en debate"); 
            Console.WriteLine("5 - Registrar Voto");     
            Console.WriteLine("0 - Salir");

            int seleccion;
            seleccion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            while (seleccion != 0)
            {
                if(seleccion == 1) 
                {
                    Console.WriteLine("1 - para ingresar nuevo legislador ");
                    Console.WriteLine("2 - para eliminar un legislador ");
                    seleccion = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (seleccion == 1)
                    {
                        Console.WriteLine("1 - nuevo Senador ");
                        Console.WriteLine("2 - nuevo Diputado");
                        seleccion = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("Ingrese Partido Politico: ");
                        partido = Console.ReadLine();
                        Console.WriteLine("Ingrese Nombre: ");
                        nombre = (Console.ReadLine());
                        Console.WriteLine("Ingrese Apellido: ");
                        apellido = (Console.ReadLine());
                        Console.WriteLine("Ingrese Edad: ");
                        edad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Numero de Asiento: ");
                        numAsiento = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Despacho: ");
                        despacho = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Departamento: ");
                        departamento = (Console.ReadLine());
                        Console.WriteLine("Estado civil: 0 para soltero / 1 para casado");
                        int EstadoCivil = Convert.ToInt32(Console.ReadLine());
                        if (EstadoCivil == 1) => casado = true;
                        else => casado = false;

                        if (seleccion == 1)
                        {
                            Senador1.SetPartido(partido);
                            Senador1.SetNombre(nombre);
                            Senador1.SetApellido(apellido);                          
                            Senador1.SetEdad(edad);                         
                            Senador1.SetAsientoAlta(numAsiento);                           
                            Senador1.SetDespacho(despacho);                       
                            Senador1.SetDepartamento(departamento);
                            camara = "Senadores";
                            Senador1.SetCamara(camara);                         
                            Senador1.SetCasado(casado);
                            Senador1 = new Senador(partido, departamento,despacho,nombre, apellido, edad, casado, camara, numAsiento);
                            Legisladores.IngresarLegislador(Senador1);
                        }
                        else if (seleccion == 2)
                        {
                            Diputado1.SetPartido(partido);
                            Diputado1.SetNombre(nombre);
                            Diputado1.SetApellido(apellido);
                            Diputado1.SetEdad(edad);
                            Diputado1.SetAsientoBaja(numAsiento);
                            Diputado1.SetDespacho(despacho);
                            Diputado1.SetDepartamento(departamento);
                            camara = "Diputados";
                            Diputado1.SetCamara(camara);
                            Diputado1.SetCasado(casado);
                            Diputado1 = new Diputado(partido, departamento, despacho, nombre, apellido, edad, casado, camara, numAsiento);
                            Legisladores.IngresarLegislador(Diputado1);

                        }
                        Console.WriteLine("Se agregó correctamente el nuevo legislador!");
                    }
                    else if(seleccion == 2) 
                    {
                        Console.WriteLine("Ingrese número de despacho para eliminar");
                        Legisladores.ListarCamaras();
                        seleccion = Convert.ToInt32(Console.ReadLine());
                        Legisladores.EliminarLegislador(seleccion);
                        Console.WriteLine("Legislador eliminado!");
                    }
                }
                else if(seleccion == 2)
                {
                    Console.WriteLine("1 - para listar cámaras");
                    Console.WriteLine("2 - para ver la cantidad de legisladores por tipo");
                    seleccion = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (seleccion == 1)
                    {
                        Legisladores.ListarCamaras();
                    }
                    else if (seleccion == 2)
                    {
                        Console.WriteLine("Cantidad de Diputados: " + Legisladores.CantidadPorTipo(0));
                        Console.WriteLine("Cantidad de Senadores: " + Legisladores.CantidadPorTipo(1));
                    }
                }
                else if(seleccion == 3)
                {
                    Console.WriteLine("1 - para ver propuestas");
                    Console.WriteLine("2 - para ingresar propuesta de un legislador");
                    seleccion = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (seleccion == 1)
                    {
                        Console.WriteLine("PROPUESTAS DE LA CÁMARA DE SENADORES");
                        foreach (var x in propuestasSenadores)
                        {
                          Console.WriteLine(x);  
                        }
                        Console.WriteLine("");
                        Console.WriteLine("PROPUESTAS DE LA CÁMARA DE DIPUTADOS");
                        foreach (var x in propuestasDiputados)
                        {
                            Console.WriteLine(x);
                        }
                    }
                    else if (seleccion == 2)
                    {
                        Console.WriteLine("Ingrese número de despacho para seleccionar Legislador");
                        Legisladores.ListarCamaras();
                        seleccion = Convert.ToInt32(Console.ReadLine());
                        foreach (var x in lista)
                        {
                            if (x.GetDespacho() == seleccion)
                            {
                                Console.WriteLine(x.PresentarPropuesta());
                            }
                        }
                    }
                }
                else if(seleccion == 4)
                {
                    Console.WriteLine("Ingrese número de despacho para seleccionar Legislador");
                    Legisladores.ListarCamaras();
                    seleccion = Convert.ToInt32(Console.ReadLine());
                    foreach (var x in lista)
                    {
                        if (x.GetDespacho() == seleccion)
                        {
                            Console.WriteLine(x.ParticiparDebate());
                        }
                    }
                }
                else if (seleccion == 5)
                {
                    Console.WriteLine("Ingrese número de despacho para seleccionar Legislador");
                    Legisladores.ListarCamaras();
                    seleccion = Convert.ToInt32(Console.ReadLine());
                    foreach (var x in lista)
                    {
                        if (x.GetDespacho() == seleccion)
                        {
                            Console.WriteLine(x.Votar());
                        }
                    }
                }
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Elige una opción: ");
                Console.WriteLine("1 - Ingresar / Eliminar Legislador ");
                Console.WriteLine("2 - Ver Listados de Cámaras");
                Console.WriteLine("3 - Propuestas Legislativas ");
                Console.WriteLine("4 - Registrar participación en debate"); 
                Console.WriteLine("5 - Registrar voto");           
                Console.WriteLine("0 - Salir");
                seleccion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
