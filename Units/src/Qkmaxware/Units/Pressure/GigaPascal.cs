namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for GigaPascal (GPa)
	/// </summary>
	public struct GigaPascal : IPressure {
        public static string Name => "GigaPascal";
        public static string Symbol => "GPa";
    }
	
	/// <summary>
	/// Extension method factory for generating GigaPascal (GPa)
	/// </summary>
	public static class GigaPascalFactory {
		/// <summary>
        /// Create a quantity measured in GigaPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, GigaPascal> GPa<T>(this T value) {
            return new Quantity<T, GigaPascal> (value);
        }
	}
}