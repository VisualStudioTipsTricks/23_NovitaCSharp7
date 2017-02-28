using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WithCSharp7;

namespace WithCSharp7Test
{
	[TestClass]
	public class TuplesExampleTests
	{
		[TestMethod]
		public void CounterListTest()
		{
			var listName = new List<string>() { "Anna", "Elisabetta", "Giuseppe", "Laura", "Eugenio", "Ilaria", "Ugo", "Osvaldo", "Ada" };

			var result = TuplesExample.CounterList(listName);

			Assert.AreEqual(2, result.countA);
			Assert.AreEqual(1, result.countI);
			Assert.AreEqual("elisabetta", result.firstEName);
			Assert.AreEqual(1, result.countU);
			Assert.AreEqual("osvaldo", result.firstOName);
			Assert.AreEqual(2, result.startWithLetter.Count);
		}

		[TestMethod]
		public void CounterListAnonymusTest()
		{
			var listName = new List<string>() { "Anna", "Elisabetta", "Giuseppe", "Laura", "Eugenio", "Ilaria", "Ugo", "Osvaldo", "Ada" };

			var result = TuplesExample.CounterListAnonymus(listName);

			Assert.AreEqual(2, result.Item1.Count);
			Assert.AreEqual(2, result.Item2);
			Assert.AreEqual(1, result.Item3);
			Assert.AreEqual("elisabetta", result.Item4);
			Assert.AreEqual(1, result.Item5);
			Assert.AreEqual("osvaldo", result.Item6);
		}
	}
}
