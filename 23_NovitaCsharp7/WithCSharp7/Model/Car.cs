using System;
using System.Collections.Generic;
using System.Text;

namespace WithCSharp7.Model
{
   public  class Car: Vehicle
    {
		public int HorsePower { get; set; }
		public PowerTypeEnum PowerType{ get; set; }
	}
}
