using System;
using System.Collections.Generic;

namespace TrabajoTransporte01
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TransportePublico> transportesPublico = new List<TransportePublico>();

            Console.WriteLine("Bienvenido a nuestro sistema de conteo de pasajeros.");

            agregarOmnibus(transportesPublico);

            agregarTaxi(transportesPublico);
                           
            
            foreach (var item in transportesPublico)
            {
               if (item.GetType() == typeof(Omnibus))
                    Console.WriteLine("Omnibus n" + (transportesPublico.IndexOf(item) + 1) + " " + item.pasajeros);
               else if (item.GetType() == typeof(Taxi))
                    Console.WriteLine("Taxi n" + (transportesPublico.IndexOf(item) + 1) + " " + item.pasajeros);
            }

            Console.ReadLine();
        }

    private static void agregarOmnibus(List<TransportePublico> transportesPublico)
        {
            bool repetir = false;



            string salida = "";

            do
            {
                do
                {
                    repetir = false;
                    Console.WriteLine("Ingrese la cantidad de pasajeros del OMNIBUS.");
                    string retorno = Console.ReadLine();

                    int cantidadPasajeros;

                    if (int.TryParse(retorno, out cantidadPasajeros) != false)
                    {

                        transportesPublico.Add(new Omnibus(cantidadPasajeros));
                        do
                        {


                            Console.WriteLine("¿Desea agregar la información de otro OMNIBUS?  y / n ");
                            salida = Console.ReadLine();
                        } while (salida != "y" && salida != "n");
                    }
                    else
                    {
                        Console.WriteLine("Ingresó un caracter invalido. Ingrese un número. ");
                        repetir = true;
                    }
                } while (repetir == true);
            } while (salida != "n");
        }

        private static void agregarTaxi(List<TransportePublico> transportesPublico)
        {
            bool repetir = false;



            string salida = "";

            do
            {
                do
                {
                    repetir = false;
                    Console.WriteLine("Ingrese la cantidad de pasajeros del TAXI.");
                    string retorno = Console.ReadLine();

                    int cantidadPasajeros;

                    if (int.TryParse(retorno, out cantidadPasajeros) != false)
                    {

                        transportesPublico.Add(new Taxi(cantidadPasajeros));
                        do
                        {


                            Console.WriteLine("¿Desea agregar la información de otro TAXI?  y / n ");
                            salida = Console.ReadLine();
                        } while (salida != "y" && salida != "n");
                    }
                    else
                    {
                        Console.WriteLine("Ingresó un caracter invalido. Ingrese un número. ");
                        repetir = true;
                    }
                } while (repetir == true);
            } while (salida != "n");
        }
    }
}
    

