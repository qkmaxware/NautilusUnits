namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for Pascal (Pa)
	/// </summary>
	public struct Pascal : IPressure {
        public static string Name => "Pascal";
        public static string Symbol => "Pa";
    }
	
	/// <summary>
	/// Extension method factory for generating Pascal (Pa)
	/// </summary>
	public static class PascalFactory {
		/// <summary>
        /// Create a quantity measured in Pascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Pascal> Pa<T>(this T value) {
            return new Quantity<T, Pascal> (value);
        }
	}
}