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
	}

}
