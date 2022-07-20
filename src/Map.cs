using System;

namespace Intermediate {
	public class Map<T>
	where T : Pair {
		private T[] _pairs;
		public Map(int max) {
			_pairs = new T[max];
		}

		public void Put(int i, T t) {
			_pairs[i] = t;
		}

		public T GetAt(int i) {
			return _pairs[i];
		}

		public T Get(string key) {
			foreach (T pair in _pairs) {
				if (pair != null && pair.Key == key)
					return pair;
			}

			throw new Exception("Key not found!");
		}
	}
}