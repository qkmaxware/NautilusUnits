namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for the NanoMetre (nm)
	/// </summary>
	public struct NanoMetre : ILength {
        public static string Name => "NanoMetre";
        public static string Symbol => "nm";
    }
	
	/// <summary>
	///Extension method factory for generating NanoMetre (nm)
	/// </summary>
	public static class NanoMetreFactory {
		/// <summary>
        /// Create a quantity measured in NanoMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, NanoMetre> nm<T>(this T value) {
            return new Quantity<T, NanoMetre> (value);
        }
	}
}