namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Yottametre (Ym)
	/// </summary>
	public struct Yottametre : ILength {
        public static string Name => "Yottametre";
        public static string Symbol => "Ym";
    }
	
	public static class YottametreFactory {
		/// <summary>
        /// Create a quantity measured in Yottametres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Yottametre> Ym<T>(this T value) {
            return value.As<Yottametre, T>();
        }
	}
}