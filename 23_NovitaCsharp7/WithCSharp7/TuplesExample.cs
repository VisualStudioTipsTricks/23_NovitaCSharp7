using System;
using System.Collections.Generic;
using System.Linq;

namespace WithCSharp7
{
    public class TuplesExample
	{
		public static (List<string> startWithLetter,  int countA, int countI, string firstEName, int countU, string firstOName) CounterList(List<string> listName)
		{
			List<char> vocal = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
			var lowerName =  listName.Select(e => e.ToLower());
			return (
					lowerName.Where(e => !vocal.Contains(e[0])).ToList(),
					lowerName.Where(e => e[0] == 'a').Count(),
					lowerName.Where(e => e[0] == 'i').Count(),
					lowerName.First(e => e[0] == 'e'),
					lowerName.Where(e => e[0] == 'u').Count(),
					lowerName.First(e => e[0] == 'o')
				);	
		}

		public static (List<string>, int , int , string , int , string ) CounterListAnonymus(List<string> listName)
		{
			List<char> vocal = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
			var lowerName = listName.Select(e => e.ToLower());
			return (
					lowerName.Where(e => !vocal.Contains(e[0])).ToList(),
					lowerName.Where(e => e[0] == 'a').Count(),
					lowerName.Where(e => e[0] == 'i').Count(),
					lowerName.First(e => e[0] == 'e'),
					lowerName.Where(e => e[0] == 'u').Count(),
					lowerName.First(e => e[0] == 'o')
				);
		}


		public static (List<string> startWithLetter, int countA, int countI, string firstEName, int countU, string firstOName) CounterListWithLocalFunction(List<string> listName)
		{
			List<char> vocal = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
			IEnumerable<string> lowerName = ToLowerList(listName);
			return (
					lowerName.Where(e => !vocal.Contains(e[0])).ToList(),
					lowerName.Where(e => e[0] == 'a').Count(),
					lowerName.Where(e => e[0] == 'i').Count(),
					lowerName.First(e => e[0] == 'e'),
					lowerName.Where(e => e[0] == 'u').Count(),
					lowerName.First(e => e[0] == 'o')
				);
			IEnumerable<string> ToLowerList(List<string> list)
			{
				return list.Select(e => e.ToLower());
			}
		}
	}
}
