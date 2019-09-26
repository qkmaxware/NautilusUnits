namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Petametre (Pm)
	/// </summary>
	public struct Petametre : ILength {
        public static string Name => "Petametre";
        public static string Symbol => "Pm";
    }
	
	public static class PetametreFactory {
		/// <summary>
        /// Create a quantity measured in Petametres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Petametre> Pm<T>(this T value) {
            return value.As<T, Petametre>();
        }
	}
}