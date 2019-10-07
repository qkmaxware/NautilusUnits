namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for the YoctoMetre (ym)
	/// </summary>
	public struct YoctoMetre : ILength {
        public static string Name => "YoctoMetre";
        public static string Symbol => "ym";
    }
	
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