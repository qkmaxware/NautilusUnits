namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for Bar (bar)
	/// </summary>
	public struct Bar : IPressure {
        public static string Name => "Bar";
        public static string Symbol => "bar";
    }
	
	/// <summary>
	/// Extension method factory for generating Bar (bar)
	/// </summary>
	public static class BarFactory {
		/// <summary>
        /// Create a quantity measured in Bars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Bar> bar<T>(this T value) {
            return new Quantity<T, Bar> (value);
        }
	}
}