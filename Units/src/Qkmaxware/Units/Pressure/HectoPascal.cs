namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for HectoPascal (hPa)
	/// </summary>
	public struct HectoPascal : IPressure {
        public static string Name => "HectoPascal";
        public static string Symbol => "hPa";
    }
	
	/// <summary>
	/// Extension method factory for generating HectoPascal (hPa)
	/// </summary>
	public static class HectoPascalFactory {
		/// <summary>
        /// Create a quantity measured in HectoPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, HectoPascal> hPa<T>(this T value) {
            return new Quantity<T, HectoPascal> (value);
        }
	}
}