using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WithCSharp7
{
    public class OutExample
    {
		public static void CounterList(List<string> listName, out string firstEName, out List<string> startWithLetter)
		{
			List<char> vocal = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
			var lowerName = listName.Select(e => e.ToLower());
			firstEName = lowerName.First(e => e[0] == 'e');
			startWithLetter = lowerName.Where(e => !vocal.Contains(e[0])).ToList();
					
		}
	}
}
