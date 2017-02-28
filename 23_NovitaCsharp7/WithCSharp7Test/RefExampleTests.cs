using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WithCSharp7;

namespace WithCSharp7Test
{
	[TestClass]
	public class RefExampleTests
	{
		[TestMethod]
		public void GetNameByPositionTest()
		{
			var names = new string[]{ "Anna", "Elisabetta", "Giuseppe", "Laura", "Eugenio", "Ilaria", "Ugo", "Osvaldo", "Ada" };

			var expectedValud = "Eugenio";

			var result = RefExample.GetNameByPosition(4, names);

			Assert.AreEqual(expectedValud, result);

			//TODO verificare posizione memoria
		}
	}
}
