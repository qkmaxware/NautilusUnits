namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Yoctometre (ym)
	/// </summary>
	public struct Yoctometre : ILength {
        public static string Name => "Yoctometre";
        public static string Symbol => "ym";
    }
	
	public static class YoctometreFactory {
		/// <summary>
        /// Create a quantity measured in Yoctometres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Yoctometre> ym<T>(this T value) {
            return value.As<Yoctometre, T>();
        }
	}
}