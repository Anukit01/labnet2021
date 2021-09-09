using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico01
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Omnibus> listOmnibus = new List<Omnibus>
            {

            };

            List<Taxi> listTaxi = new List<Taxi>
            {

            };


            Console.WriteLine("¡Bienvenido al programa de asignacion de cantidad de pasajeros!");

            agregarOmnibus(listOmnibus);

            agregarTaxi(listTaxi);


            foreach (var item in listOmnibus)
            {
                Console.WriteLine("Omnibus N°" + (listOmnibus.IndexOf(item) + 1) + " " + item.pasajeros);
            }

            foreach (var item in listTaxi)
            {
                Console.WriteLine("Taxi N°" + (listTaxi.IndexOf(item) + 1) + " " + item.pasajeros);
            }
            Console.ReadLine();
        }

        private static void agregarOmnibus(List<Omnibus> listOmnibus)
        {
            int pasajeros;
            bool caracterInvalido = false;
            string seguir = "";

            do
            {
                Console.WriteLine("Por favor, ingrese la cantidad de pasajeros de OMNIBUS.");
                string respuesta = Console.ReadLine();
                caracterInvalido = false;

                if (int.TryParse(respuesta, out pasajeros) != false)
                {
                    listOmnibus.Add(new Omnibus(pasajeros));

                    do
                    {

                        Console.WriteLine("¿Desea agregar informacion de otro OMNIBUS?  s / n ");

                        seguir = Console.ReadLine();

                    } while (seguir != "n" && seguir != "s");

                }

                else
                {

                    Console.WriteLine("Se insertó un caracter invalido. Ingrese un número porfavor.");

                    caracterInvalido = true;
                }

            } while (caracterInvalido == true || seguir == "s");

        }
        private static void agregarTaxi(List<Taxi> listTaxi)
        {
            int pasajeros;
            bool caracterInvalido = false;
            string seguir = "";

            do
            {
                Console.WriteLine("Por favor, ingrese la cantidad de pasajeros de TAXI.");
                string respuesta = Console.ReadLine();
                caracterInvalido = false;

                if (int.TryParse(respuesta, out pasajeros) != false)
                {
                    listTaxi.Add(new Taxi(pasajeros));

                    do
                    {


                        Console.WriteLine("¿Desea agregar informacion de otro TAXI?  s / n ");

                        seguir = Console.ReadLine();

                    } while (seguir != "n" && seguir != "s") ;

                }

                else
                {

                    Console.WriteLine("Se insertó un caracter invalido. Ingrese un número porfavor.");

                    caracterInvalido = true;
                }

            } while (caracterInvalido == true || seguir == "s");
        }
    }
}
