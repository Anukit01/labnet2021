using Models.Exceptions;
using Models.ExtentionMethods;
using Models.Helpers;
using System;
using System.Windows.Forms;

namespace TrabajoPractico2
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcionMenu = "";
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("¡Bienvenido al menú! Eliga sabiamente. :) ");
                    Console.WriteLine("Si desea realizar una division por cero, ingrese A.");
                    Console.WriteLine("Si desea realizar una division ingresando dos valores, ingrese B.");
                    Console.WriteLine("Si desesa llamar a una excepcion, ingrese C");
                    Console.WriteLine("Si desea llamar a la NoeException ingrese D");
                    Console.WriteLine("Para salir presione S");
                    opcionMenu = Console.ReadLine();

                    switch(opcionMenu.ToUpper())
                    {
                        case "A":
                            Helper.ResolutionA(opcionMenu);
                            break;
                        case "B":
                            Helper.ResolutionB(opcionMenu);
                            break;
                        case "C":
                            Helper.ResolutionC(opcionMenu);
                            break;
                        case "D":
                            Helper.ResolutionD(opcionMenu);
                            break;
                    }

                } while (opcionMenu.IsCorrectMenuOption() == false);                       
            } while (opcionMenu.ToUpper() != "S");          
        }
    }
}

