namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Exametre (Em)
	/// </summary>
	public struct Exametre : ILength {
        public static string Name => "Exametre";
        public static string Symbol => "Em";
    }
	
	public static class ExametreFactory {
		/// <summary>
        /// Create a quantity measured in Exametres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Exametre> Em<T>(this T value) {
            return value.As<T, Exametre>();
        }
	}
}