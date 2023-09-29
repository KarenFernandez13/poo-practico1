using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace Practico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parlamento Legisladores = new Parlamento();
            Diputado Diputado1 = new Diputado("Verde", "Maldonado", 103, "Juan", "Perez", 56, true, "Diputado", 8);
            Legisladores.IngresarLegislador(Diputado1);
            Senador Senador1 = new Senador("Azul", "Canelones", 10, "Maria", "Gomez", 40, false, "Senador", 10);
            Legisladores.IngresarLegislador(Senador1);


            List<Legislador> lista = Legisladores.ObtenerLegisladores();
            List<string> propuestasDiputados = Diputado1.ObtenerPropuestas();
            List<string> propuestasSenadores = Senador1.ObtenerPropuestas();            
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
            bool esNumero;
            do
            {
                esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                if (!esNumero)
                {
                    Console.WriteLine("No es un número, vuelva a ingresar.");
                }
            } while (!esNumero);

            while (seleccion != 0 && seleccion != 1 && seleccion != 2 && seleccion != 3 && seleccion != 4 && seleccion != 5)
            {
                Console.WriteLine("Número invalido. Ingrese nuevamente");
                seleccion = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();

            while (seleccion != 0)
            {
                if (seleccion == 1)
                {
                    Console.WriteLine("1 - Para ingresar nuevo legislador ");
                    Console.WriteLine("2 - Para eliminar un legislador ");
                    do
                    {
                        esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                        if (!esNumero)
                        {
                            Console.WriteLine("No es un número, vuelva a ingresar.");
                        }
                    } while (!esNumero);
                    while (seleccion != 1 && seleccion != 2)
                    {
                        Console.WriteLine("Número invalido. Ingrese nuevamente");
                        seleccion = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.Clear();

                    if (seleccion == 1)
                    {
                        Console.WriteLine("1 - Nuevo Senador ");
                        Console.WriteLine("2 - Nuevo Diputado");
                        do
                        {
                            esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                            if (!esNumero)
                            {
                                Console.WriteLine("No es un número, vuelva a ingresar.");
                            }
                        } while (!esNumero);
                        while (seleccion != 1 && seleccion != 2)
                        {
                            Console.WriteLine("Número invalido. Ingrese nuevamente");
                            seleccion = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Clear();


                        Console.WriteLine("Ingrese Nombre: ");
                        nombre = (Console.ReadLine());

                        Console.WriteLine("Ingrese Apellido: ");
                        apellido = (Console.ReadLine());

                        Console.WriteLine("Ingrese Partido Politico: ");
                        partido = Console.ReadLine();

                        Console.WriteLine("Ingrese Departamento: ");
                        departamento = (Console.ReadLine());

                        Console.WriteLine("Ingrese Edad: ");
                        do
                        {
                            esNumero = int.TryParse(Console.ReadLine(), out edad);
                            if (!esNumero)
                            {
                                Console.WriteLine("No es un número, vuelva a ingresar.");
                            }
                        } while (!esNumero);

                        Console.WriteLine("Ingrese Numero de Asiento: ");
                        do
                        {
                            esNumero = int.TryParse(Console.ReadLine(), out numAsiento);
                            if (!esNumero)
                            {
                                Console.WriteLine("No es un número, vuelva a ingresar.");
                            }
                        } while (!esNumero);

                        Console.WriteLine("Estado civil: 0 para soltero / 1 para casado");
                        int EstadoCivil;
                        do
                        {
                            esNumero = int.TryParse(Console.ReadLine(), out EstadoCivil);
                            if (!esNumero)
                            {
                                Console.WriteLine("No es un número, vuelva a ingresar.");
                            }
                        } while (!esNumero);

                        if (EstadoCivil == 1) { casado = true; }
                        else { casado = false; }

                        if (seleccion == 1) //INGRESAR SENADOR
                        {
                            Console.WriteLine("Ingrese Despacho: ");
                            do
                            {
                                esNumero = int.TryParse(Console.ReadLine(), out despacho);
                                if (!esNumero)
                                {
                                    Console.WriteLine("No es un número, vuelva a ingresar.");
                                }
                            } while (!esNumero);
                            while (despacho < 1 || despacho > 30)
                            {
                                Console.WriteLine("Numero incorrecto. Ingrese numero de 1 a 30");
                                do
                                {
                                    esNumero = int.TryParse(Console.ReadLine(), out despacho);
                                    if (!esNumero)
                                    {
                                        Console.WriteLine("No es un número, vuelva a ingresar.");
                                    }
                                } while (!esNumero);
                            }
                            foreach (var x in lista)
                            {
                                while (x.GetDespacho() == despacho)
                                {
                                    Console.WriteLine("Ese despacho ya está ocupado. Ingrese otro: ");
                                    do
                                    {
                                        esNumero = int.TryParse(Console.ReadLine(), out despacho);
                                        if (!esNumero)
                                        {
                                            Console.WriteLine("No es un número, vuelva a ingresar.");
                                        }
                                    } while (!esNumero);
                                }
                            }

                            camara = "Senador";
                            Senador1 = new Senador(partido, departamento, despacho, nombre, apellido, edad, casado, camara, numAsiento);
                            Legisladores.IngresarLegislador(Senador1);
                        }
                        else if (seleccion == 2) //INGRESAR DIPUTADO
                        { 
                            Console.WriteLine("Ingrese Despacho: ");
                            do
                            {
                                esNumero = int.TryParse(Console.ReadLine(), out despacho);
                                if (!esNumero)
                                {
                                    Console.WriteLine("No es un número, vuelva a ingresar.");
                                }
                            } while (!esNumero);

                            while (despacho < 31 || despacho > 130)
                            {
                                Console.WriteLine("Numero incorrecto. Ingrese numero de 31 al 130");
                                do
                                {
                                    esNumero = int.TryParse(Console.ReadLine(), out despacho);
                                    if (!esNumero)
                                    {
                                        Console.WriteLine("No es un número, vuelva a ingresar.");
                                    }
                                } while (!esNumero);
                            }

                            foreach (var x in lista)
                            {
                                while (x.GetDespacho() == despacho)
                                {
                                    Console.WriteLine("Ese despacho ya está ocupado. Ingrese otro: ");
                                    do
                                    {
                                        esNumero = int.TryParse(Console.ReadLine(), out despacho);
                                        if (!esNumero)
                                        {
                                            Console.WriteLine("No es un número, vuelva a ingresar.");
                                        }
                                    } while (!esNumero);
                                }
                            }
                            camara = "Diputado";
                            Diputado1 = new Diputado(partido, departamento, despacho, nombre, apellido, edad, casado, camara, numAsiento);
                            Legisladores.IngresarLegislador(Diputado1);
                        }
                        Console.WriteLine("Se agregó correctamente el nuevo legislador!");
                    }
                    else if (seleccion == 2)
                    {
                        Console.WriteLine("Ingrese número de despacho para eliminar");
                        Legisladores.ListarCamaras();
                        do
                        {
                            esNumero = int.TryParse(Console.ReadLine(), out despacho);
                            if (!esNumero)
                            {
                                Console.WriteLine("No es un número, vuelva a ingresar.");
                            }
                        } while (!esNumero);

                        while (despacho < 1 || despacho > 129)
                        {
                            Console.WriteLine("Numero incorrecto. Ingrese numero de 1 al 129");
                            do
                            {
                                esNumero = int.TryParse(Console.ReadLine(), out despacho);
                                if (!esNumero)
                                {
                                    Console.WriteLine("No es un número, vuelva a ingresar.");
                                }
                            } while (!esNumero);
                        }
                        Legisladores.EliminarLegislador(despacho);
                        Console.WriteLine("Legislador eliminado!");

                    }
                }
                else if (seleccion == 2) //LISTADOS DE CAMARAS
                {
                    Console.WriteLine("1 - Para listar cámaras");
                    Console.WriteLine("2 - Para ver la cantidad de legisladores por tipo");
                    do
                    {
                        esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                        if (!esNumero)
                        {
                            Console.WriteLine("No es un número, vuelva a ingresar.");
                        }
                    } while (!esNumero);
                    while (seleccion != 1 && seleccion != 2)
                    {
                        Console.WriteLine("Número invalido. Ingrese nuevamente");
                        seleccion = Convert.ToInt32(Console.ReadLine());
                    }
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
                else if (seleccion == 3)   //PROPUESTAS
                {
                    Console.WriteLine("1 - Para ver propuestas existentes");
                    Console.WriteLine("2 - Para ingresar propuesta de un legislador");
                    do
                    {
                        esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                        if (!esNumero)
                        {
                            Console.WriteLine("No es un número, vuelva a ingresar.");
                        }
                    } while (!esNumero);
                    while (seleccion != 1 && seleccion != 2)
                    {
                        Console.WriteLine("Número invalido. Ingrese nuevamente");
                        seleccion = Convert.ToInt32(Console.ReadLine());
                    }
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
                        do
                        {
                            esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                            if (!esNumero)
                            {
                                Console.WriteLine("No es un número, vuelva a ingresar.");
                            }
                        } while (!esNumero);
                        while (seleccion < 1 || seleccion > 129)
                        {
                            Console.WriteLine("Numero incorrecto. Ingrese numero de 1 al 129");
                            do
                            {
                                esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                                if (!esNumero)
                                {
                                    Console.WriteLine("No es un número, vuelva a ingresar.");
                                }
                            } while (!esNumero);
                        }
                        foreach (var x in lista)
                        {
                            if (x.GetDespacho() == seleccion)
                            {
                                Console.WriteLine(x.PresentarPropuesta());
                            }
                        }
                    }
                }
                else if (seleccion == 4)   //PARTICIPAR DEBATE
                {
                    Console.WriteLine("Ingrese número de despacho para seleccionar Legislador");
                    Legisladores.ListarCamaras();
                    do
                    {
                        esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                        if (!esNumero)
                        {
                            Console.WriteLine("No es un número, vuelva a ingresar.");
                        }
                    } while (!esNumero);
                    while (seleccion < 1 || seleccion > 129)
                    {
                        Console.WriteLine("Numero incorrecto. Ingrese numero de 1 al 129");
                        do
                        {
                            esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                            if (!esNumero)
                            {
                                Console.WriteLine("No es un número, vuelva a ingresar.");
                            }
                        } while (!esNumero);
                    }
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
                    do
                    {
                        esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                        if (!esNumero)
                        {
                            Console.WriteLine("No es un número, vuelva a ingresar.");
                        }
                    } while (!esNumero);
                    while (seleccion < 1 || seleccion > 129)
                    {
                        Console.WriteLine("Numero incorrecto. Ingrese numero de 1 al 129");
                        do
                        {
                            esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                            if (!esNumero)
                            {
                                Console.WriteLine("No es un número, vuelva a ingresar.");
                            }
                        } while (!esNumero);
                    }
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
                    do
                    {
                        esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                        if (!esNumero)
                        {
                            Console.WriteLine("No es un número, vuelva a ingresar.");
                        }
                    } while (!esNumero);
                    while (seleccion != 0 && seleccion != 1 && seleccion != 2 && seleccion != 3 && seleccion != 4 && seleccion != 5)
                    {
                        Console.WriteLine("Número invalido. Ingrese nuevamente");
                        seleccion = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.Clear();               
            }
        }
    }
}

