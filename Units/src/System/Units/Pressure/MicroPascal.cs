namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the MicroPascal (uPa)
	/// </summary>
	public struct MicroPascal : IPressure {
        public static string Name => "MicroPascal";
        public static string Symbol => "uPa";
    }
	
	/// <summary>
	///Extension method factory for generating MicroPascal (uPa)
	/// </summary>
	public static class MicroPascalFactory {
		/// <summary>
        /// Create a quantity measured in MicroPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MicroPascal> uPa<T>(this T value) {
            return new Quantity<T, MicroPascal> (value);
        }
	}
}