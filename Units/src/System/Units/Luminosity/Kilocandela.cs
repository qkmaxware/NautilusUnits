namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the KiloCandela (kcd)
	/// </summary>
	public struct KiloCandela : ILuminosity {
        public static string Name => "KiloCandela";
        public static string Symbol => "kcd";
    }
	
	/// <summary>
	///Extension method factory for generating KiloCandela (kcd)
	/// </summary>
	public static class KiloCandelaFactory {
		/// <summary>
        /// Create a quantity measured in KiloCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, KiloCandela> kcd<T>(this T value) {
            return new Quantity<T, KiloCandela> (value);
        }
	}
}