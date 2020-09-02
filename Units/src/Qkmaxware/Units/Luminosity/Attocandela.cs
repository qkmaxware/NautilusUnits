namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for AttoCandela (acd)
	/// </summary>
	public struct AttoCandela : ILuminosity {
        public static string Name => "AttoCandela";
        public static string Symbol => "acd";
    }
	
	/// <summary>
	/// Extension method factory for generating AttoCandela (acd)
	/// </summary>
	public static class AttoCandelaFactory {
		/// <summary>
        /// Create a quantity measured in AttoCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, AttoCandela> acd<T>(this T value) {
            return new Quantity<T, AttoCandela> (value);
        }
	}
}