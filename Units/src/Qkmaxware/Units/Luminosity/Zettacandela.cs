namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for ZettaCandela (Zcd)
	/// </summary>
	public struct ZettaCandela : ILuminosity {
        public static string Name => "ZettaCandela";
        public static string Symbol => "Zcd";
    }
	
	/// <summary>
	/// Extension method factory for generating ZettaCandela (Zcd)
	/// </summary>
	public static class ZettaCandelaFactory {
		/// <summary>
        /// Create a quantity measured in ZettaCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZettaCandela> Zcd<T>(this T value) {
            return new Quantity<T, ZettaCandela> (value);
        }
	}
}