using Models.Exceptions;
using Models.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Models.Helpers
{
    public class Helper
    {
        public static void ResolutionA(string opcionMenu)
        {
          
           try
            {
                Console.WriteLine("Por favor, ingrese un número:");
                int divideByZeroNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"El resultado es {ExceptionsTrabajoPractico2.DivideByZero(divideByZeroNumber)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("No se puede dividir por cero. {0}", ex.Message));
            }
            finally
            {
                MessageBox.Show("Terminó la operacion. Presione cualquier tecla para volver al menú.");
            }
        }
        public static void ResolutionB(string opcionMenu)
        {
            try
            {
                Console.WriteLine("Por favor, ingrese su dividendo:");
                int dividendo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Por favor, ingrese su divisor:");
                int divisor = Convert.ToInt32(Console.ReadLine());
                MessageBox.Show($"El resultado es {ExceptionsTrabajoPractico2.Divide(dividendo, divisor)}.");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("¡NOOOOOOO! ¡INTENTASTE DIVIDIR POR CERO! ¡OCHO MATEMATICOS HAN MUERTO POR TU CULPA! :'(");
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Seguro ingresó una letra o no ingresó nada.  {ex.Message}");
            }
            finally
            {
                MessageBox.Show("Terminó la operación. Presione cualquier tecla para volver al menú.");
            }
        }
        public static void ResolutionC(string opcionMenu)
        {
            try
            {
                Logic.ThrowException();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}.   Esta excepción enojada es del tipo: {ex.GetType()}");
            }
        }
        public static void ResolutionD(string opcionMenu)
        {
            try
            {
                throw new NoeException("Deberias estar poniendome un 100. ¿Por qué seguis viendo esto ?");
            }
            catch (NoeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}