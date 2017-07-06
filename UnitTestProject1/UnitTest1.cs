using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio1;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		private OperationClass sut;

		[TestInitialize]  // Atributo para ejecutar antes de los métodos de test.
		public void TestInicial()
		{
			sut = new OperationClass();
			sut.initialice(1, 2, "Mis numeros");
		}

		[TestMethod]
		public void TestMethod1()
		{
			string message = sut.composeText();
			Assert.AreEqual("Mis numeros 1, 2.", message);
		}

		/*
		 [TestInitialize]  // Atributo para ejecutar antes de los métodos de test.
        public void TestInicial()
        {
            sut = new Class1();
        }

        [TestMethod] // Atributo (anotación Java) que indica que es un método de prueba, es la forma de que el código sepa que es tal, y no un código normal.
        public void TestResta()
        {
            int res = sut.Resta(5, 2);

            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestRestaNegativa()
        {
            int res = sut.Resta(-5,-2);

            Assert.AreEqual(-3, res);
        }
		 
		 */
	}
}
