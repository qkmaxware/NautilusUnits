namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the ZeptoPascal (zPa)
	/// </summary>
	public struct ZeptoPascal : IPressure {
        public static string Name => "ZeptoPascal";
        public static string Symbol => "zPa";
    }
	
	public static class ZeptoPascalFactory {
		/// <summary>
        /// Create a quantity measured in ZeptoPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZeptoPascal> zPa<T>(this T value) {
            return new Quantity<T, ZeptoPascal> (value);
        }
	}
}