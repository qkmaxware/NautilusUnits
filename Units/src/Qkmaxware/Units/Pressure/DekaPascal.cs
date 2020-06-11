namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the DekaPascal (daPa)
	/// </summary>
	public struct DekaPascal : IPressure {
        public static string Name => "DekaPascal";
        public static string Symbol => "daPa";
    }
	
	/// <summary>
	///Extension method factory for generating DekaPascal (daPa)
	/// </summary>
	public static class DekaPascalFactory {
		/// <summary>
        /// Create a quantity measured in DekaPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DekaPascal> daPa<T>(this T value) {
            return new Quantity<T, DekaPascal> (value);
        }
	}
}