using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ExtentionMethods
{

    public static class OptionMenuExtention
    {
        public static bool IsCorrectMenuOption(this string opcionMenu)
        {
            string yesOrNo = opcionMenu.ToUpper();
            bool resultado = (yesOrNo.Contains("A") || yesOrNo.Contains("B") || yesOrNo.Contains("C") || yesOrNo.Contains("D") || yesOrNo.Contains("S"));
            return resultado;
        }
    }
}
