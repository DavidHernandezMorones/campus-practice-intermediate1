using System;

namespace Intermediate {
	public class CustomNullReferenceException : NullReferenceException {
		public override string Message {
			get { return $"CustomNullReferenceException: {base.Message}"; }
		}
	}
}