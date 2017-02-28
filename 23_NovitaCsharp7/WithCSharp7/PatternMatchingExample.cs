using System;
using System.Collections.Generic;
using System.Text;
using WithCSharp7.Model;

namespace WithCSharp7
{
	public class PatternMatchingExample
	{
		public static PowerTypeEnum? GetCarPowerType_WithIsExpression(List<Vehicle> vehicles)
		{
			foreach (Vehicle item in vehicles)
			{
				if (item is Car c1)
					return c1.PowerType;
			}
			return null;
		}

		public static List<Vehicle> GetVehicle_WithSwitchStatement(List<Vehicle> vehicles)
		{
			List<Vehicle> vehiclesFiltered = new List<Vehicle>();
			foreach (var item in vehicles)
			{
				switch (item)
				{
					case Car car when (car.PowerType == PowerTypeEnum.Hybrid):
						vehiclesFiltered.Add(car);
						break;
					case Camper camper when (camper.NumberOfBeds > 2):
						vehiclesFiltered.Add(camper);
						break;
					case Bicycle bicycle when (bicycle.Weight <25):
						vehiclesFiltered.Add(bicycle);
						break;
					default:
						break;
				}
			}
			return vehiclesFiltered;
		}
	}
}
