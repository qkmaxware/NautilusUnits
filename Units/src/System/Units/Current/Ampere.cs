namespace System.Units.Current {
	/// <summary>
	/// Unit of measurement for the Ampere (A)
	/// </summary>
	public struct Ampere : ICurrent {
        public static string Name => "Ampere";
        public static string Symbol => "A";
    }
	
	public static class AmpereFactory {
		/// <summary>
        /// Create a quantity measured in Amperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Ampere> A<T>(this T value) {
            return new Quantity<T, Ampere> (value);
        }
	}
}