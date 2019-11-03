namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the AttoBar (abar)
	/// </summary>
	public struct AttoBar : IPressure {
        public static string Name => "AttoBar";
        public static string Symbol => "abar";
    }
	
	/// <summary>
	///Extension method factory for generating AttoBar (abar)
	/// </summary>
	public static class AttoBarFactory {
		/// <summary>
        /// Create a quantity measured in AttoBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, AttoBar> abar<T>(this T value) {
            return new Quantity<T, AttoBar> (value);
        }
	}
}