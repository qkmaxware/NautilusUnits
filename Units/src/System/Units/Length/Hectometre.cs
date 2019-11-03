namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for the HectoMetre (hm)
	/// </summary>
	public struct HectoMetre : ILength {
        public static string Name => "HectoMetre";
        public static string Symbol => "hm";
    }
	
	/// <summary>
	///Extension method factory for generating HectoMetre (hm)
	/// </summary>
	public static class HectoMetreFactory {
		/// <summary>
        /// Create a quantity measured in HectoMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, HectoMetre> hm<T>(this T value) {
            return new Quantity<T, HectoMetre> (value);
        }
	}
}