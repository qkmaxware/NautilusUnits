namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for the MicroMetre (um)
	/// </summary>
	public struct MicroMetre : ILength {
        public static string Name => "MicroMetre";
        public static string Symbol => "um";
    }
	
	public static class MicroMetreFactory {
		/// <summary>
        /// Create a quantity measured in MicroMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MicroMetre> um<T>(this T value) {
            return new Quantity<T, MicroMetre> (value);
        }
	}
}