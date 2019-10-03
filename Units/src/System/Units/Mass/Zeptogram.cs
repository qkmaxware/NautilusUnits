namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Zeptogram (zg)
	/// </summary>
	public struct Zeptogram : IMass {
        public static string Name => "Zeptogram";
        public static string Symbol => "zg";
    }
	
	public static class ZeptogramFactory {
		/// <summary>
        /// Create a quantity measured in Zeptograms
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Zeptogram> zg<T>(this T value) {
            return value.As<Zeptogram, T>();
        }
	}
}