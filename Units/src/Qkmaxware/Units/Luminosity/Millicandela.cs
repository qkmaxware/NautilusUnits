namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the MilliCandela (mcd)
	/// </summary>
	public struct MilliCandela : ILuminosity {
        public static string Name => "MilliCandela";
        public static string Symbol => "mcd";
    }
	
	/// <summary>
	///Extension method factory for generating MilliCandela (mcd)
	/// </summary>
	public static class MilliCandelaFactory {
		/// <summary>
        /// Create a quantity measured in MilliCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MilliCandela> mcd<T>(this T value) {
            return new Quantity<T, MilliCandela> (value);
        }
	}
}