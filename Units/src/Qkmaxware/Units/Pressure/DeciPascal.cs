namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the DeciPascal (dPa)
	/// </summary>
	public struct DeciPascal : IPressure {
        public static string Name => "DeciPascal";
        public static string Symbol => "dPa";
    }
	
	/// <summary>
	///Extension method factory for generating DeciPascal (dPa)
	/// </summary>
	public static class DeciPascalFactory {
		/// <summary>
        /// Create a quantity measured in DeciPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DeciPascal> dPa<T>(this T value) {
            return new Quantity<T, DeciPascal> (value);
        }
	}
}