using System;
using System.Collections.Generic;
using System.Text;

namespace WithCSharp7
{
    public class RefExample
    {
		public static ref string GetNameByPosition(int position,  string[] names)
		{
			if (names.Length >=  position)
			{
				return ref names[position]; 
			}
			throw new Exception("Not found");
		}
    }
}
