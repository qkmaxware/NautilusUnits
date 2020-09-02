namespace Qkmaxware.Units.Length {
	/// <summary>
	/// Unit of measurement for YoctoMetre (ym)
	/// </summary>
	public struct YoctoMetre : ILength {
        public static string Name => "YoctoMetre";
        public static string Symbol => "ym";
    }
	
	/// <summary>
	/// Extension method factory for generating YoctoMetre (ym)
	/// </summary>
	public static class YoctoMetreFactory {
		/// <summary>
        /// Create a quantity measured in YoctoMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YoctoMetre> ym<T>(this T value) {
            return new Quantity<T, YoctoMetre> (value);
        }
	}
}