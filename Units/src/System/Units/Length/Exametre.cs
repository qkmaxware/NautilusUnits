namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for the ExaMetre (Em)
	/// </summary>
	public struct ExaMetre : ILength {
        public static string Name => "ExaMetre";
        public static string Symbol => "Em";
    }
	
	public static class ExaMetreFactory {
		/// <summary>
        /// Create a quantity measured in ExaMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ExaMetre> Em<T>(this T value) {
            return new Quantity<T, ExaMetre> (value);
        }
	}
}