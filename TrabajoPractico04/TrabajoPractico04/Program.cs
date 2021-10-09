using System;
using TrabajoPractico04.LOGIC;
using System.Windows.Forms;

namespace TrabajoPractico04
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuOption = "";
            string menuOption2 = "";
            do
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to Northwind! What can we do for you ? ");
                    Console.WriteLine("If you wish to insert information, press A.");
                    Console.WriteLine("If you wish to upgrade information, press B.");
                    Console.WriteLine("If you wish to delete information, press C.");
                    Console.WriteLine("If you wish to retrieve information, press D.");
                    Console.WriteLine("Press S to exit.");
                    menuOption = Console.ReadLine();
                    if (menuOption.ToUpper() == "S")
                    {
                        Environment.Exit(0);
                    }

                } while (!menuOption.IsCorrectMenuOption());
                do
                {
                    Console.Clear();
                    Console.WriteLine("Please, choose a table");
                    Console.WriteLine("To choose Customers Press A.");
                    Console.WriteLine("To choose Categories Press B.");
                    Console.WriteLine("To return to the main manu Pess C.");
                    Console.WriteLine("Press S to exit.");
                    menuOption2 = Console.ReadLine();
                    if (menuOption2.ToUpper() == "S")
                    {
                        Environment.Exit(0);
                    }
                    Helper.ExecuteMenu(menuOption + menuOption2);
                } while (!menuOption.IsCorrectMenuOption());

            } while (menuOption.ToUpper() != "S");

        }
    }
}
