using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithCSharp7;

namespace WithCSharp7Test
{
	[TestClass]
	public class DeconstructorTests
	{
		[TestMethod]
		public void DeconstructTupleExplicitTest()
		{
			var _listName = new List<string>() { "Anna", "Elisabetta", "Giuseppe", "Laura", "Eugenio", "Ilaria", "Ugo", "Osvaldo", "Ada" };

			(List<string> startWithLetter, int countA, int countI, string firstEName, int countU, string firstOName) = TuplesExample.CounterList(_listName);

			Assert.AreEqual(2, countA);
			Assert.AreEqual(1, countI);
			Assert.AreEqual("elisabetta", firstEName);
			Assert.AreEqual(1, countU);
			Assert.AreEqual("osvaldo", firstOName);
			Assert.AreEqual(2, startWithLetter.Count);

		}

		[TestMethod]
		public void DeconstructTupleVarTest()
		{
			var _listName = new List<string>() { "Anna", "Elisabetta", "Giuseppe", "Laura", "Eugenio", "Ilaria", "Ugo", "Osvaldo", "Ada" };

			var (startWithLetter, countA, countI, firstEName, countU, firstOName) = TuplesExample.CounterList(_listName);

			Assert.AreEqual(2, countA);
			Assert.AreEqual(1, countI);
			Assert.AreEqual("elisabetta", firstEName);
			Assert.AreEqual(1, countU);
			Assert.AreEqual("osvaldo", firstOName);
			Assert.AreEqual(2, startWithLetter.Count);
		}
	}
}
