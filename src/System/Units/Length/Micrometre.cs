namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Micrometre (um)
	/// </summary>
	public struct Micrometre : ILength {
        public static string Name => "Micrometre";
        public static string Symbol => "um";
    }
	
	public static class MicrometreFactory {
		/// <summary>
        /// Create a quantity measured in Micrometres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Micrometre> um<T>(this T value) {
            return value.As<T, Micrometre>();
        }
	}
}