namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Attometre (am)
	/// </summary>
	public struct Attometre : ILength {
        public static string Name => "Attometre";
        public static string Symbol => "am";
    }
	
	public static class AttometreFactory {
		/// <summary>
        /// Create a quantity measured in Attometres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Attometre> am<T>(this T value) {
            return value.As<T, Attometre>();
        }
	}
}