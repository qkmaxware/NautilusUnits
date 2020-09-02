namespace Qkmaxware.Units.Mass {
	/// <summary>
	/// Unit of measurement for Gram (g)
	/// </summary>
	public struct Gram : IMass {
        public static string Name => "Gram";
        public static string Symbol => "g";
    }
	
	/// <summary>
	/// Extension method factory for generating Gram (g)
	/// </summary>
	public static class GramFactory {
		/// <summary>
        /// Create a quantity measured in Grams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Gram> g<T>(this T value) {
            return new Quantity<T, Gram> (value);
        }
	}
}