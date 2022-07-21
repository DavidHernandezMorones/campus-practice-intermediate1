using System;
using System.Text.RegularExpressions;

namespace Intermediate {
	public static class UtilsExtension {
		
		public static void ToConsole(this object o, string msg) {
			Console.WriteLine($"{msg}{o}");
		}

		public static bool CustomMatch(this string str) {
			return Regex.IsMatch(str, @"^[A-Z][a-z]{3}\d{4}");
		}
		
		public static T GetFirst<T>(this Map<T> map) where T : Pair {
			return map.GetAt(0);
		}

	}
}