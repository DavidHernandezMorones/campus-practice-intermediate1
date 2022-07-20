using System;

namespace Intermediate {
	class Program {
		static void Main(string[] args) {
			// Operador ternario
			Console.WriteLine("Operador ternario: ");
			int random = new Random().Next(0, 1000);
			string compareRandom = random > 500 ? "Greater than 500" : "Less than 500";
			Console.WriteLine($"{compareRandom}: {random}\n");


			// Excepciones y nullables
			Console.WriteLine("\nExcepciones y nullables: ");
			try {
				string? myNullValue = random > 500 ? null : "not null";

				Console.WriteLine(myNullValue == null ? throw new CustomNullReferenceException() : "Valor valido");
			}
			catch (CustomNullReferenceException ex) {
				Console.WriteLine(ex.Message);
			}


			// tipos anonimos y dinamicos
			Console.WriteLine("\nTipos Anonimos: ");
			var myType = new {
								Name = "Carlitos",
								Age = 17
							};

			myType.Name.ToConsole("Anonymous name: ");
			myType.Age.ToConsole("Anonymous age: ");


			Console.WriteLine("\nTipos dinamicos: ");
			dynamic myDynamicType = 15.3;
			Console.WriteLine(myDynamicType);

			myDynamicType = "custom string";
			Console.WriteLine(myDynamicType);

			myDynamicType = new {
									Email = "abc@mail.com",
									Id = 6,
									Addres = "65 Street B"
								};
			Console.WriteLine(myDynamicType);


			// Generics
			Console.WriteLine("\nGenerics: ");
			const int max = 100;
			Map<MyCustomPair> map = new Map<MyCustomPair>(max);


			for (int i = 0; i < max; i++)
				if (i % 2 == 0)
					map.Put(i, new MyCustomPair($"myPairNumber_{i}", i * 5));
				else
					map.Put(i, new MyCustomPair($"impair_{random}", $"The number {i} is impair"));


			try {
				Console.WriteLine($"Using Map.Get(key) {map.Get("myPairNumber_18").Value}");
				Console.WriteLine($"Using Map.Get(key) {map.Get("NonExistingKey").Value}");
			}
			catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}

			Console.WriteLine($"Using Map.GetAt(i) {map.GetAt(85).Key}");


			// Extension methods
			Console.WriteLine("\nExtension methods: ");
			Console.WriteLine($"Primer valor del map\n" +
							$"{{{map.GetFirst().Key}: " +
							$"{map.GetFirst().Value}}}");


			// Regex
			Console.WriteLine("\nRegex: ");
			string toMatch = "Hola123";
			Console.WriteLine($"{toMatch} match? {toMatch.CustomMatch()}");
		}
	}
}