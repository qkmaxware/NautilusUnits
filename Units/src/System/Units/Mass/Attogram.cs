namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Attogram (ag)
	/// </summary>
	public struct Attogram : IMass {
        public static string Name => "Attogram";
        public static string Symbol => "ag";
    }
	
	public static class AttogramFactory {
		/// <summary>
        /// Create a quantity measured in Attograms
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Attogram> ag<T>(this T value) {
            return value.As<T, Attogram>();
        }
	}
}