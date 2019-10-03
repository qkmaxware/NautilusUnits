namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Microgram (ug)
	/// </summary>
	public struct Microgram : IMass {
        public static string Name => "Microgram";
        public static string Symbol => "ug";
    }
	
	public static class MicrogramFactory {
		/// <summary>
        /// Create a quantity measured in Micrograms
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Microgram> ug<T>(this T value) {
            return value.As<Microgram, T>();
        }
	}
}