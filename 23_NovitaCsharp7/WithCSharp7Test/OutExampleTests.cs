using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WithCSharp7;

namespace WithCSharp7Test
{
	[TestClass]
	public class OutExampleTests
	{
		[TestMethod]
	
		public void CounterListTest()
		{
			var listName = new List<string>() { "Anna", "Eugenio", "Giuseppe", "Laura", "Elisabetta", "Ilaria", "Ugo", "Osvaldo", "Ada" };

			var expectedFirstEName = "eugenio";
			var expectedCountStartWithLetter = 2;

			OutExample.CounterList(listName, out string firstEName, out List<string> startWithLetter);


			Assert.AreEqual(expectedFirstEName, firstEName);
			Assert.AreEqual(expectedCountStartWithLetter, startWithLetter.Count);
			
		}
	}
}
