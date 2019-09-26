namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Femtogram (fg)
	/// </summary>
	public struct Femtogram : IMass {
        public static string Name => "Femtogram";
        public static string Symbol => "fg";
    }
	
	public static class FemtogramFactory {
		/// <summary>
        /// Create a quantity measured in Femtograms
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Femtogram> fg<T>(this T value) {
            return value.As<T, Femtogram>();
        }
	}
}