namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Gigagram (Gg)
	/// </summary>
	public struct Gigagram : IMass {
        public static string Name => "Gigagram";
        public static string Symbol => "Gg";
    }
	
	public static class GigagramFactory {
		/// <summary>
        /// Create a quantity measured in Gigagrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Gigagram> Gg<T>(this T value) {
            return value.As<Gigagram, T>();
        }
	}
}