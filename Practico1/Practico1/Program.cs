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
            
            

            //MENU
            Console.WriteLine("SISTEMA DE INFORMACIÓN PARLAMENTARIA");
            Console.WriteLine("");
            Console.WriteLine("Menú Principal: ");
            Console.WriteLine("");
            Console.WriteLine("Elige una opción: ");          
            Console.WriteLine("1 - Ingresar / Eliminar Legislador ");//Sen-Dip
            Console.WriteLine("2 - Ingresar Voto");
            Console.WriteLine("3 - Ingresar una Propuesta Legislativa ");
            Console.WriteLine("4 - Participación en Debates "); //ingresar o ver lista
            Console.WriteLine("5 - Ver Listados de Cámaras"); //total o por tipo            
            Console.WriteLine("0 - Salir");

            string nombre;
            string apellido;
            string partido;
            string departamento;
            int despacho;
            int edad;
            int numAsiento;
            bool casado = false;
            string camara;

            int seleccion;
            seleccion = Convert.ToInt32(Console.ReadLine());
            while (seleccion != 0)
            {
                if(seleccion == 1) 
                {
                    Console.WriteLine("1 para ingresar nuevo legislador ");
                    Console.WriteLine("2 para eliminar un legislador ");
                    seleccion = Convert.ToInt32(Console.ReadLine());
                    if(seleccion == 1)
                    {
                        Console.WriteLine("1 - nuevo Senador ");
                        Console.WriteLine("2 - nuevo Diputado");
                        seleccion = Convert.ToInt32(Console.ReadLine());
                        if(seleccion == 1)
                        {
                            Console.WriteLine("Ingrese Partido Politico: ");
                            partido = Console.ReadLine();
                            Senador1.SetPartido(partido);
                            Console.WriteLine("Ingrese Nombre: ");
                            nombre = (Console.ReadLine());
                            Senador1.SetNombre(nombre);
                            Console.WriteLine("Ingrese Apellido: ");
                            apellido = (Console.ReadLine());
                            Senador1.SetApellido(apellido);
                            Console.WriteLine("Ingrese Edad: ");
                            edad = Convert.ToInt32(Console.ReadLine());
                            Senador1.SetEdad(edad);
                            Console.WriteLine("Ingrese Numero de Asiento: ");
                            numAsiento = Convert.ToInt32(Console.ReadLine());
                            Senador1.SetAsientoAlta(numAsiento);
                            Console.WriteLine("Ingrese Despacho: ");
                            despacho = Convert.ToInt32(Console.ReadLine());
                            Senador1.SetDespacho(despacho);
                            Console.WriteLine("Ingrese Departamento: ");
                            departamento = (Console.ReadLine());
                            Senador1.SetDepartamento(departamento);

                            camara = "Senadores";
                            Senador1.SetCamara(camara);

                            Console.WriteLine("Estado civil: 0 para soltero / 1 para casado");
                            int EstadoCivil = Convert.ToInt32(Console.ReadLine());
                            if(EstadoCivil == 1)
                            {
                                casado = true;
                            }
                            else {}

                            Senador1.SetCasado(casado);
                            Senador1 = new Senador(partido, departamento,despacho,nombre, apellido, edad, casado, camara, numAsiento);
                            Legisladores.IngresarLegislador(Senador1);
                        }
                        else if (seleccion == 2)
                        {
                            Console.WriteLine("Ingrese Partido Politico: ");
                            partido = Console.ReadLine();
                            Diputado1.SetPartido(partido);
                            Console.WriteLine("Ingrese Nombre: ");
                            nombre = (Console.ReadLine());
                            Diputado1.SetNombre(nombre);
                            Console.WriteLine("Ingrese Apellido: ");
                            apellido = (Console.ReadLine());
                            Diputado1.SetApellido(apellido);
                            Console.WriteLine("Ingrese Edad: ");
                            edad = Convert.ToInt32(Console.ReadLine());
                            Diputado1.SetEdad(edad);
                            Console.WriteLine("Ingrese Numero de Asiento: ");
                            numAsiento = Convert.ToInt32(Console.ReadLine());
                            Diputado1.SetAsientoBaja(numAsiento);
                            Console.WriteLine("Ingrese Despacho: ");
                            despacho = Convert.ToInt32(Console.ReadLine());
                            Diputado1.SetDespacho(despacho);
                            Console.WriteLine("Ingrese Departamento: ");
                            departamento = (Console.ReadLine());
                            Diputado1.SetDepartamento(departamento);

                            camara = "Diputados";
                            Diputado1.SetCamara(camara);

                            Console.WriteLine("Estado civil: 0 para soltero / 1 para casado");
                            int EstadoCivil = Convert.ToInt32(Console.ReadLine());
                            if (EstadoCivil == 1)
                            {
                                casado = true;
                            }
                            else { }

                            Diputado1.SetCasado(casado);
                            Diputado1 = new Diputado(partido, departamento, despacho, nombre, apellido, edad, casado, camara, numAsiento);
                            Legisladores.IngresarLegislador(Diputado1);

                        }
                    }
                    else if(seleccion == 2) 
                    {
                        Console.WriteLine("Eliminar");
                    }
                }
                else if(seleccion == 2)
                {
                    Console.WriteLine("Ingrese Numero de Despacho para seleccionar Legislador");
                    Legisladores.ListarCamaras();
                    seleccion = Convert.ToInt32(Console.ReadLine());
                    //FALTA COMPLETAR QUE AL INGRESAR NUM DESPACHO SE EFECTUE EL VOTO DE ESE LEGISLADOR
                  
                    
                }
                else if(seleccion == 3)
                {
                    Legisladores.ListarCamaras();
                    seleccion = Convert.ToInt32(Console.ReadLine());
                    //FALTA QUE ELIJA UN LEGISLADOR PARA PRESENTAR PROPUESTA
                }
                else if(seleccion == 4)
                {
                    Legisladores.ListarCamaras();
                    seleccion = Convert.ToInt32(Console.ReadLine());
                    //FALTA QUE ELIJA UN LEGISLADOR PARA Participar en debate
                }
                else if (seleccion == 5)
                {
                    int numero = Convert.ToInt32(Console.ReadLine());
                    Legisladores.ListarCamaras();
                    Console.WriteLine("Cantidad de diputados: " +Legisladores.CantidadPorTipo(numero));

                    //MOSTRAR LISTADOS DE CAMARAS Y CANTIDAD DE LEG. EN CADA UNA - creo que está pronto
                }
                
                else if (seleccion == 6)
                {
                    //SALIR
                }















                Console.WriteLine("Elige una opción: ");
                Console.WriteLine("1 - Ingresar / Eliminar Legislador ");//Sen-Dip
                Console.WriteLine("2 - Ingresar Voto");
                Console.WriteLine("3 - Ingresar una Propuesta Legislativa ");
                Console.WriteLine("4 - Debates "); //ingresar o ver lista
                Console.WriteLine("5 - Ver Listados de Cámaras"); //total o por tipo            
                Console.WriteLine("0 - Salir");
                seleccion = Convert.ToInt32(Console.ReadLine());

            }






        }
    }
}
