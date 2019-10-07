namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for the MilliMetre (mm)
	/// </summary>
	public struct MilliMetre : ILength {
        public static string Name => "MilliMetre";
        public static string Symbol => "mm";
    }
	
	public static class MilliMetreFactory {
		/// <summary>
        /// Create a quantity measured in MilliMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MilliMetre> mm<T>(this T value) {
            return new Quantity<T, MilliMetre> (value);
        }
	}
}