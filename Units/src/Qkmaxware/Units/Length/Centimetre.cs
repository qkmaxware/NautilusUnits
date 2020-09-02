namespace Qkmaxware.Units.Length {
	/// <summary>
	/// Unit of measurement for CentiMetre (cm)
	/// </summary>
	public struct CentiMetre : ILength {
        public static string Name => "CentiMetre";
        public static string Symbol => "cm";
    }
	
	/// <summary>
	/// Extension method factory for generating CentiMetre (cm)
	/// </summary>
	public static class CentiMetreFactory {
		/// <summary>
        /// Create a quantity measured in CentiMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, CentiMetre> cm<T>(this T value) {
            return new Quantity<T, CentiMetre> (value);
        }
	}
}