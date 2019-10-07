namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the MicroCandela (ucd)
	/// </summary>
	public struct MicroCandela : ILuminosity {
        public static string Name => "MicroCandela";
        public static string Symbol => "ucd";
    }
	
	public static class MicroCandelaFactory {
		/// <summary>
        /// Create a quantity measured in MicroCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MicroCandela> ucd<T>(this T value) {
            return new Quantity<T, MicroCandela> (value);
        }
	}
}