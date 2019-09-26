namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Nanometre (nm)
	/// </summary>
	public struct Nanometre : ILength {
        public static string Name => "Nanometre";
        public static string Symbol => "nm";
    }
	
	public static class NanometreFactory {
		/// <summary>
        /// Create a quantity measured in Nanometres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Nanometre> nm<T>(this T value) {
            return value.As<T, Nanometre>();
        }
	}
}