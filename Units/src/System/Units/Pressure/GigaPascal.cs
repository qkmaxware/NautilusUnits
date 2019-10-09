namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the GigaPascal (GPa)
	/// </summary>
	public struct GigaPascal : IPressure {
        public static string Name => "GigaPascal";
        public static string Symbol => "GPa";
    }
	
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