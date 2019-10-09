namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the YoctoPascal (yPa)
	/// </summary>
	public struct YoctoPascal : IPressure {
        public static string Name => "YoctoPascal";
        public static string Symbol => "yPa";
    }
	
	public static class YoctoPascalFactory {
		/// <summary>
        /// Create a quantity measured in YoctoPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YoctoPascal> yPa<T>(this T value) {
            return new Quantity<T, YoctoPascal> (value);
        }
	}
}