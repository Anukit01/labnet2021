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
                    Console.WriteLine("If you wish to retrive information, press D.");
                    Console.WriteLine("Press S to exit.");
                    menuOption = Console.ReadLine();
                    if (menuOption.ToUpper() == "S")
                    {
                        Environment.Exit(0);
                    }

                } while (menuOption.IsCorrectMenuOption() == false );
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
                    try
                    {
                        Helper.ExecuteMenu(menuOption + menuOption2);
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(string.Format("Oh oh! Something went wrong... [0] Press any key to return to main menu.", (ex.Message))) ;
                        Console.ReadKey();
                    }
                    catch (Exception ex)
                    {
                        var exception = ex;
                        MessageBox.Show($"Oh oh! Something went wrong... {ex.Message} Try again!  Press any key to return to main menu.");
                        Console.ReadKey();
                    }
                                        
                } while (menuOption2.IsCorrectMenuOption() == false);

            } while (menuOption.ToUpper() != "S");

        }
    }
}
