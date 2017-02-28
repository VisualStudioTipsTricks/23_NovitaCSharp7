using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithCSharp7;
using WithCSharp7.Model;

namespace WithCSharp7Test
{
	[TestClass]
	public class PatternMatchingExampleTests
	{

		[TestMethod]
		public void GetCarPowerType_WithIsExpressionTest()
		{
			List<Vehicle> vehicles = new List<Vehicle>()
			{
				new Car(){ Description= "My first car", HorsePower = 200, Name =  "Ford Fiesta", PowerType= PowerTypeEnum.Hybrid},
				new Bicycle () { Description = "My first bicycle", Name = "Atala", Weight = 27},
				new Camper () { Description = "My first camper", Name = "Sbirulino", NumberOfBeds = 3, NumberOfWindows = 6}
			};

			var result = PatternMatchingExample.GetCarPowerType_WithIsExpression(vehicles);
			Assert.AreEqual(PowerTypeEnum.Hybrid, result);

		}


		[TestMethod]
		public void GetVehicle_WithSwitchStatementTest()
		{
			List<Vehicle> vehicles = new List<Vehicle>()
			{
				new Car(){ Description= "My first car", HorsePower = 200, Name =  "Ford Fiesta", PowerType= PowerTypeEnum.Hybrid},
				new Bicycle () { Description = "My first bicycle", Name = "Atala", Weight = 27},
				new Camper () { Description = "My first camper", Name = "Sbirulino", NumberOfBeds = 3, NumberOfWindows = 6},
				new Car(){ Description= "My second car", HorsePower = 400, Name =  "Fiat Bravo", PowerType= PowerTypeEnum.Diesel},
				new Bicycle () { Description = "My second bicycle", Name = "Atala", Weight = 15},
				new Camper () { Description = "My second camper", Name = "Sbirulino", NumberOfBeds = 1, NumberOfWindows = 6}
			};
			var expectedResult = new List<Vehicle>()
			{
				new Car(){ Description= "My first car", HorsePower = 200, Name =  "Ford Fiesta", PowerType= PowerTypeEnum.Hybrid},
				new Bicycle () { Description = "My second bicycle", Name = "Atala", Weight = 15},
				new Camper () { Description = "My second camper", Name = "Sbirulino", NumberOfBeds = 1, NumberOfWindows = 6}
			};

			var result = PatternMatchingExample.GetVehicle_WithSwitchStatement(vehicles);

			Assert.AreEqual(expectedResult.Count, result.Count);
		}
	}
}
