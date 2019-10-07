namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the DeciCandela (dcd)
	/// </summary>
	public struct DeciCandela : ILuminosity {
        public static string Name => "DeciCandela";
        public static string Symbol => "dcd";
    }
	
	public static class DeciCandelaFactory {
		/// <summary>
        /// Create a quantity measured in DeciCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DeciCandela> dcd<T>(this T value) {
            return new Quantity<T, DeciCandela> (value);
        }
	}
}