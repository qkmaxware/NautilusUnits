namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Nanogram (ng)
	/// </summary>
	public struct Nanogram : IMass {
        public static string Name => "Nanogram";
        public static string Symbol => "ng";
    }
	
	public static class NanogramFactory {
		/// <summary>
        /// Create a quantity measured in Nanograms
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Nanogram> ng<T>(this T value) {
            return value.As<T, Nanogram>();
        }
	}
}