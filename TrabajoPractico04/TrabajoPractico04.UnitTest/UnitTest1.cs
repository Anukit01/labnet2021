using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrabajoPractico04.DATA;
using TrabajoPractico04.LOGIC;

namespace TrabajoPractico04.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestExtensionMethod_WhenImput_IsInvalid()
        {
            /*Arrange*/
            string optionMenu = "M";
            /*Act*/
            bool result = OptionMenuExtension.IsCorrectMenuOption(optionMenu);
            /*Assert*/
            Assert.AreEqual(result, false);
            
        }
        public void TestExtensionMethod_WhenImput_Isvalid()
        {
            /*Arrange*/
            string optionMenu = "A";
            /*Act*/
            bool result = OptionMenuExtension.IsCorrectMenuOption(optionMenu);
            /*Assert*/
            Assert.AreEqual(result, true);

        }
    }
}
