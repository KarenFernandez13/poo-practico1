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
                if (!esNumero || (seleccion != 0 && seleccion != 1 && seleccion != 2 && seleccion != 3 && seleccion != 4 && seleccion != 5))
                {
                    Console.WriteLine("Incorrecto, vuelva a ingresar.");
                }
            } while (!esNumero || (seleccion != 0 && seleccion != 1 && seleccion != 2 && seleccion != 3 && seleccion != 4 && seleccion != 5));

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
                        if (!esNumero || (seleccion != 1 && seleccion != 2))
                        {
                            Console.WriteLine("Incorrecto, vuelva a ingresar.");
                        }
                    } while (!esNumero || (seleccion != 1 && seleccion != 2));
                    Console.Clear();

                    if (seleccion == 1)
                    {
                        Console.WriteLine("1 - Nuevo Senador ");
                        Console.WriteLine("2 - Nuevo Diputado");
                        do
                        {
                            esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                            if (!esNumero || (seleccion != 1 && seleccion != 2))
                            {
                                Console.WriteLine("Incorrecto, vuelva a ingresar.");
                            }
                        } while (!esNumero || (seleccion != 1 && seleccion != 2));
                        Console.Clear();

                        Console.WriteLine("Ingrese Nombre: ");
                        nombre = (Console.ReadLine());

                        Console.WriteLine("Ingrese Apellido: ");
                        apellido = (Console.ReadLine());

                        Console.WriteLine("Ingrese Partido Politico: ");
                        partido = Console.ReadLine();

                        Console.WriteLine("Ingrese Edad: ");
                        do
                        {
                            esNumero = int.TryParse(Console.ReadLine(), out edad);
                            if (!esNumero)
                            {
                                Console.WriteLine("No es un número, vuelva a ingresar.");
                            }
                        } while (!esNumero);

                        Console.WriteLine("Ingrese Departamento: ");
                        departamento = (Console.ReadLine());

                        Console.WriteLine("Estado civil: 0 para soltero / 1 para casado");
                        int EstadoCivil;
                        do
                        {
                            esNumero = int.TryParse(Console.ReadLine(), out EstadoCivil);
                            if (!esNumero || (EstadoCivil != 0 && EstadoCivil != 1))
                            {
                                Console.WriteLine("No es correcto, vuelva a ingresar.");
                            }
                        } while (!esNumero || (EstadoCivil != 0 && EstadoCivil != 1));

                        if (EstadoCivil == 1) { casado = true; }
                        else { casado = false; }


                        if (seleccion == 1) //INGRESAR SENADOR
                        {
                            Console.WriteLine("Ingrese Despacho (entre 1 y 30): ");
                            do
                            {
                                esNumero = int.TryParse(Console.ReadLine(), out despacho);
                                if (!esNumero || (despacho < 1 || despacho > 30))
                                {
                                    Console.WriteLine("Incorrecto, vuelva a ingresar.");
                                }
                            } while (!esNumero || (despacho < 1 || despacho > 30));

                            foreach (var x in lista)
                            {
                                while (x.GetDespacho() == despacho)
                                {
                                    Console.WriteLine("Ese despacho ya está ocupado. Ingrese otro: ");
                                    do
                                    {
                                        esNumero = int.TryParse(Console.ReadLine(), out despacho);
                                        if (!esNumero || (despacho < 1 || despacho > 30))
                                        {
                                            Console.WriteLine("No es correcto, vuelva a ingresar.");
                                        }
                                    } while (!esNumero || (despacho < 1 || despacho > 30));
                                }
                            }

                            Console.WriteLine("Ingrese Numero de Asiento (Entre 1 y 30): ");
                            do
                            {
                                esNumero = int.TryParse(Console.ReadLine(), out numAsiento);
                                if (!esNumero || (numAsiento < 1 || numAsiento > 30))
                                {
                                    Console.WriteLine("No es correcto, vuelva a ingresar.");
                                }
                            } while (!esNumero || (numAsiento < 1 || numAsiento > 30));

                            foreach (var x in lista)
                            {
                                while (Senador1.GetAsientoAlta() == numAsiento)
                                {
                                    Console.WriteLine("Ese asiento ya está ocupado. Ingrese otro: ");
                                    do
                                    {
                                        esNumero = int.TryParse(Console.ReadLine(), out numAsiento);
                                        if (!esNumero || (numAsiento < 1 || numAsiento > 99))
                                        {
                                            Console.WriteLine("Incorrecto, vuelva a ingresar.");
                                        }
                                    } while (!esNumero || (numAsiento < 1 || numAsiento > 30));
                                }
                            }

                            camara = "Senador";

                            Senador1 = new Senador(partido, departamento, despacho, nombre, apellido, edad, casado, camara, numAsiento);
                            Legisladores.IngresarLegislador(Senador1);
                        }
                        else if (seleccion == 2) //INGRESAR DIPUTADO
                        {
                            Console.WriteLine("Ingrese Despacho (entre 31 y 129): ");
                            do
                            {
                                esNumero = int.TryParse(Console.ReadLine(), out despacho);
                                if (!esNumero || (despacho < 31 || despacho >= 130))
                                {
                                    Console.WriteLine("Incorrecto, vuelva a ingresar.");
                                }
                            } while (!esNumero || (despacho < 31 || despacho > 130));

                            foreach (var x in lista)
                            {
                                while (x.GetDespacho() == despacho)
                                {
                                    Console.WriteLine("Ese despacho ya está ocupado. Ingrese otro: ");
                                    do
                                    {
                                        esNumero = int.TryParse(Console.ReadLine(), out despacho);
                                        if (!esNumero|| (despacho < 31 || despacho > 130))
                                        {
                                            Console.WriteLine("Incorrecto. Vuelva a ingresar.");
                                        }
                                    } while (!esNumero || (despacho < 31 || despacho > 130));
                                }
                            }

                            Console.WriteLine("Ingrese Numero de Asiento (De 1 a 99) : ");
                            do
                            {
                                esNumero = int.TryParse(Console.ReadLine(), out numAsiento);
                                if (!esNumero || (numAsiento < 1 || numAsiento > 99))
                                {
                                    Console.WriteLine("No es correcto, vuelva a ingresar.");
                                }
                            } while (!esNumero || (numAsiento > 99 || numAsiento < 1));

                            foreach (var x in lista)
                            {
                                while (Diputado1.GetAsientoBaja() == numAsiento)
                                {
                                    Console.WriteLine("Ese asiento ya está ocupado. Ingrese otro: ");
                                    do
                                    {
                                        esNumero = int.TryParse(Console.ReadLine(), out numAsiento);
                                        if (!esNumero || (numAsiento < 1 || numAsiento > 99))
                                        {
                                            Console.WriteLine("No es un correcto, vuelva a ingresar.");
                                        }
                                    } while (!esNumero || (numAsiento < 1 || numAsiento > 99));
                                }
                            }
                            camara = "Diputado";
                            Diputado1 = new Diputado(partido, departamento, despacho, nombre, apellido, edad, casado, camara, numAsiento);
                            Legisladores.IngresarLegislador(Diputado1);
                        }
                        Console.WriteLine("Se agregó correctamente el nuevo legislador!");
                        Console.WriteLine("");
                        Console.WriteLine("Presione enter para volver al menú");

                    }
                    else if (seleccion == 2)
                    {
                        Console.WriteLine("Ingrese número de despacho para eliminar (entre 1 y 129)");
                        Legisladores.ListarCamaras();

                        do
                        {
                            esNumero = int.TryParse(Console.ReadLine(), out despacho);
                            if (!esNumero || (despacho < 1 || despacho >= 130))
                            {
                                Console.WriteLine("Incorrecto, vuelva a ingresar.");
                            }
                        } while (!esNumero || (despacho < 1 || despacho >= 130));

                        Legislador objetoEncontrado = lista.Find(obj => obj.GetDespacho() == despacho);
                        while (objetoEncontrado == null)
                        {
                            Console.WriteLine("No existe un legislador ingresado con ese numero de despacho, ingrese otro");
                            esNumero = int.TryParse(Console.ReadLine(), out despacho);
                            if (!esNumero || (despacho < 1 || despacho >= 130))
                            {
                                Console.WriteLine("Incorrecto, vuelva a ingresar.");
                                esNumero = int.TryParse(Console.ReadLine(), out despacho);
                            }
                            objetoEncontrado = lista.Find(obj => obj.GetDespacho() == despacho);
                        }
                        Legisladores.EliminarLegislador(despacho);
                        Console.WriteLine("Legislador eliminado!");
                        Console.WriteLine("");
                        Console.WriteLine("Presione enter para volver al menú");
                    }
                    }
                    else if (seleccion == 2) //LISTADOS DE CAMARAS
                    {
                        Console.WriteLine("1 - Para listar cámaras");
                        Console.WriteLine("2 - Para ver la cantidad de legisladores por tipo");
                        do
                        {
                            esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                            if (!esNumero || (seleccion != 1 && seleccion != 2))
                            {
                                Console.WriteLine("Incorrecto, vuelva a ingresar.");
                            }
                        } while (!esNumero || (seleccion != 1 && seleccion != 2));
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
                        Console.WriteLine("");
                        Console.WriteLine("Presione enter para volver al menú");
                    }
                    else if (seleccion == 3)   //PROPUESTAS
                    {
                        Console.WriteLine("1 - Para ver propuestas existentes");
                        Console.WriteLine("2 - Para ingresar propuesta de un legislador");
                        do
                        {
                            esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                            if (!esNumero || (seleccion != 1 && seleccion != 2))
                            {
                                Console.WriteLine("Incorrecto, vuelva a ingresar.");
                            }
                        } while (!esNumero || (seleccion != 1 && seleccion != 2));
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
                            Console.WriteLine("Ingrese número de despacho para seleccionar Legislador (entre 1 y 129)");
                            Legisladores.ListarCamaras();
                            do
                            {
                                esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                                if (!esNumero || (seleccion < 1 || seleccion >= 130))
                                {
                                    Console.WriteLine("Incorrecto, vuelva a ingresar.");
                                }
                            } while (!esNumero || (seleccion < 1 || seleccion >= 130));

                            foreach (var x in lista)
                            {
                                if (x.GetDespacho() == seleccion)
                                {
                                    Console.WriteLine(x.PresentarPropuesta());
                                }
                            }
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Presione enter para volver al menú");
                    }
                    else if (seleccion == 4)   //PARTICIPAR DEBATE
                    {
                        Console.WriteLine("Ingrese número de despacho para seleccionar Legislador (entre 1 y 129)");
                        Legisladores.ListarCamaras();
                        do
                        {
                            esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                            if (!esNumero || (seleccion < 1 && seleccion >= 130))
                            {
                                Console.WriteLine("Incorrecto, vuelva a ingresar.");
                            }
                        } while (!esNumero || (seleccion < 1 || seleccion >= 130));

                        foreach (var x in lista)
                        {
                            if (x.GetDespacho() == seleccion)
                            {
                                Console.WriteLine(x.ParticiparDebate());
                            }
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Presione enter para volver al menú");
                    }
                    else if (seleccion == 5) // VOTAR
                    {
                        Console.WriteLine("Ingrese número de despacho para seleccionar Legislador (entre 1 y 129)");
                        Legisladores.ListarCamaras();
                        do
                        {
                            esNumero = int.TryParse(Console.ReadLine(), out seleccion);
                            if (!esNumero || (seleccion < 1 || seleccion >= 130))
                            {
                                Console.WriteLine("Incorrrecto, vuelva a ingresar.");
                            }
                        } while (!esNumero || (seleccion < 1 || seleccion >= 130));
                        foreach (var x in lista)
                        {
                            if (x.GetDespacho() == seleccion)
                            {
                                Console.WriteLine(x.Votar());
                            }
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Presione enter para volver al menú");
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
                        if (!esNumero && seleccion != 0 && seleccion != 1 && seleccion != 2 && seleccion != 3 && seleccion != 4 && seleccion != 5)
                        {
                            Console.WriteLine("Incorrecto, vuelva a ingresar.");
                        }
                    } while (!esNumero && seleccion != 0 && seleccion != 1 && seleccion != 2 && seleccion != 3 && seleccion != 4 && seleccion != 5);
                    Console.Clear();
                
            }
        }
    }
}

