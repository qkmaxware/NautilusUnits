namespace Qkmaxware.Units.Mass {
	/// <summary>
	/// Unit of measurement for the KiloGram (kg)
	/// </summary>
	public struct KiloGram : IMass {
        public static string Name => "KiloGram";
        public static string Symbol => "kg";
    }
	
	/// <summary>
	///Extension method factory for generating KiloGram (kg)
	/// </summary>
	public static class KiloGramFactory {
		/// <summary>
        /// Create a quantity measured in KiloGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, KiloGram> kg<T>(this T value) {
            return new Quantity<T, KiloGram> (value);
        }
	}
}