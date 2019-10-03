namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Yoctogram (yg)
	/// </summary>
	public struct Yoctogram : IMass {
        public static string Name => "Yoctogram";
        public static string Symbol => "yg";
    }
	
	public static class YoctogramFactory {
		/// <summary>
        /// Create a quantity measured in Yoctograms
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Yoctogram> yg<T>(this T value) {
            return value.As<Yoctogram, T>();
        }
	}
}