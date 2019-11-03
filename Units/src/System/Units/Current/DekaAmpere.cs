namespace System.Units.Current {
	/// <summary>
	/// Unit of measurement for the DekaAmpere (daA)
	/// </summary>
	public struct DekaAmpere : ICurrent {
        public static string Name => "DekaAmpere";
        public static string Symbol => "daA";
    }
	
	/// <summary>
	///Extension method factory for generating DekaAmpere (daA)
	/// </summary>
	public static class DekaAmpereFactory {
		/// <summary>
        /// Create a quantity measured in DekaAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DekaAmpere> daA<T>(this T value) {
            return new Quantity<T, DekaAmpere> (value);
        }
	}
}