namespace Intermediate {
	public class MyCustomPair : Pair {
		public MyCustomPair(string key, dynamic value) {
			Key = key;
			Value = value;
		}

		public override string Key { get; set; }
		public override dynamic Value { get; set; }
	}
}