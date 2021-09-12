using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Exceptions;
using Models.Logics;
using System;
using Models.Helpers;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ShouldThrowDivideByZeroException()
        {
            //arrange
            int dividendo = 7;
            //act
            ExceptionsTrabajoPractico2.DivideByZero(dividendo);
            //Assert
        }

        [TestMethod]
        public void ShouldDivide()
        {
            //arrenge
            decimal i = 7;
            decimal j = 3;
            decimal resultado;
            //act
            resultado = ExceptionsTrabajoPractico2.Divide(i, j);
            //Assert
            Assert.AreEqual(resultado, i / j);
        }

        [TestMethod]
        public void ShouldThrowExceptionWhenDivide()
        {
            //arrenge
            decimal i = 7;
            decimal j = 0;
            //act
            //Assert
            Assert.ThrowsException<DivideByZeroException>(() => ExceptionsTrabajoPractico2.Divide(i, j));
        }

        [TestMethod]
        public void ShouldThrowExceptionJustBecause()
        {
            Assert.ThrowsException<Exception>(() => Logic.ThrowException());
        }
        
    }

}
