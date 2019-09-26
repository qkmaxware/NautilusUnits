namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Millimetre (mm)
	/// </summary>
	public struct Millimetre : ILength {
        public static string Name => "Millimetre";
        public static string Symbol => "mm";
    }
	
	public static class MillimetreFactory {
		/// <summary>
        /// Create a quantity measured in Millimetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Millimetre> mm<T>(this T value) {
            return value.As<T, Millimetre>();
        }
	}
}