namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Hectometre (hm)
	/// </summary>
	public struct Hectometre : ILength {
        public static string Name => "Hectometre";
        public static string Symbol => "hm";
    }
	
	public static class HectometreFactory {
		/// <summary>
        /// Create a quantity measured in Hectometres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Hectometre> hm<T>(this T value) {
            return value.As<Hectometre, T>();
        }
	}
}