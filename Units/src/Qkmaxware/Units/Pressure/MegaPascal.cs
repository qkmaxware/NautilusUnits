namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for MegaPascal (MPa)
	/// </summary>
	public struct MegaPascal : IPressure {
        public static string Name => "MegaPascal";
        public static string Symbol => "MPa";
    }
	
	/// <summary>
	/// Extension method factory for generating MegaPascal (MPa)
	/// </summary>
	public static class MegaPascalFactory {
		/// <summary>
        /// Create a quantity measured in MegaPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MegaPascal> MPa<T>(this T value) {
            return new Quantity<T, MegaPascal> (value);
        }
	}
}