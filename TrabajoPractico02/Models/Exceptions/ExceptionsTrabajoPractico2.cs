using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Exceptions
{
    public class ExceptionsTrabajoPractico2
    {
        public static int DivideByZero(int i)
        {
            try
            {
                int byZeroDivision = i / 0;
                return byZeroDivision;
            }
            catch (Exception ex)
            {
                throw ex;            
            }            
        }
        public static decimal Divide(decimal i, decimal j)
        {
            try
            {
                return i /j;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
