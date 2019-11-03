namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the Candela (cd)
	/// </summary>
	public struct Candela : ILuminosity {
        public static string Name => "Candela";
        public static string Symbol => "cd";
    }
	
	/// <summary>
	///Extension method factory for generating Candela (cd)
	/// </summary>
	public static class CandelaFactory {
		/// <summary>
        /// Create a quantity measured in Candelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Candela> cd<T>(this T value) {
            return new Quantity<T, Candela> (value);
        }
	}
}