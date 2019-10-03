namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Hectogram (hg)
	/// </summary>
	public struct Hectogram : IMass {
        public static string Name => "Hectogram";
        public static string Symbol => "hg";
    }
	
	public static class HectogramFactory {
		/// <summary>
        /// Create a quantity measured in Hectograms
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Hectogram> hg<T>(this T value) {
            return value.As<Hectogram, T>();
        }
	}
}