namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for AttoPascal (aPa)
	/// </summary>
	public struct AttoPascal : IPressure {
        public static string Name => "AttoPascal";
        public static string Symbol => "aPa";
    }
	
	/// <summary>
	/// Extension method factory for generating AttoPascal (aPa)
	/// </summary>
	public static class AttoPascalFactory {
		/// <summary>
        /// Create a quantity measured in AttoPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, AttoPascal> aPa<T>(this T value) {
            return new Quantity<T, AttoPascal> (value);
        }
	}
}