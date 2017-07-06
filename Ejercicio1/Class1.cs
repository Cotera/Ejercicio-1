using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class DataClass
    {
		private int n1;

		private int n2;

		private string text;

		public void SetN1 (int valor)
		{
			this.n1 = valor;
		}

		public void SetN2(int valor)
		{
			this.n2 = valor;
		}

		public void SetText(string valor)
		{
			this.text = valor;
		}

		public int GetN1()
		{
			return this.n1;
		}

		public int GetN2()
		{
			return this.n2;
		}

		public string GetText()
		{
			return this.text;
		}
	}


	public class OperationClass
	{
		private DataClass datos;

		public void initialice (int n1, int n2, string text)
		{
			datos = new DataClass();
			datos.SetN1(n1);
			datos.SetN2(n2);
			datos.SetText(text);
		}

		public string composeText()
		{
			return datos.GetText() + " " + datos.GetN1() + ", " + datos.GetN2() + ".";
		}
	}
}
