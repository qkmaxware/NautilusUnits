namespace Qkmaxware.Units.Length {
	/// <summary>
	/// Unit of measurement for the MegaMetre (Mm)
	/// </summary>
	public struct MegaMetre : ILength {
        public static string Name => "MegaMetre";
        public static string Symbol => "Mm";
    }
	
	/// <summary>
	///Extension method factory for generating MegaMetre (Mm)
	/// </summary>
	public static class MegaMetreFactory {
		/// <summary>
        /// Create a quantity measured in MegaMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MegaMetre> Mm<T>(this T value) {
            return new Quantity<T, MegaMetre> (value);
        }
	}
}