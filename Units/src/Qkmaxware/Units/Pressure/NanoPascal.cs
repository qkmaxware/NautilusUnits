namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the NanoPascal (nPa)
	/// </summary>
	public struct NanoPascal : IPressure {
        public static string Name => "NanoPascal";
        public static string Symbol => "nPa";
    }
	
	/// <summary>
	///Extension method factory for generating NanoPascal (nPa)
	/// </summary>
	public static class NanoPascalFactory {
		/// <summary>
        /// Create a quantity measured in NanoPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, NanoPascal> nPa<T>(this T value) {
            return new Quantity<T, NanoPascal> (value);
        }
	}
}