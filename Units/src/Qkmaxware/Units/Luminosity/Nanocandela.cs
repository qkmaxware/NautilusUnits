namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the NanoCandela (ncd)
	/// </summary>
	public struct NanoCandela : ILuminosity {
        public static string Name => "NanoCandela";
        public static string Symbol => "ncd";
    }
	
	/// <summary>
	///Extension method factory for generating NanoCandela (ncd)
	/// </summary>
	public static class NanoCandelaFactory {
		/// <summary>
        /// Create a quantity measured in NanoCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, NanoCandela> ncd<T>(this T value) {
            return new Quantity<T, NanoCandela> (value);
        }
	}
}