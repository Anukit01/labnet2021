namespace TrabajoPractico04.LOGIC
{

    public static class OptionMenuExtension
    {
        public static bool IsCorrectMenuOption(this string menuOption)
        {
            string yesOrNo = menuOption.ToUpper();
            bool result = (yesOrNo.Contains("A") || yesOrNo.Contains("B") || yesOrNo.Contains("C") || yesOrNo.Contains("D") || yesOrNo.Contains("S"));
            return result;                      
        }
      
    }
}

