namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the DekaCandela (dacd)
	/// </summary>
	public struct DekaCandela : ILuminosity {
        public static string Name => "DekaCandela";
        public static string Symbol => "dacd";
    }
	
	public static class DekaCandelaFactory {
		/// <summary>
        /// Create a quantity measured in DekaCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DekaCandela> dacd<T>(this T value) {
            return new Quantity<T, DekaCandela> (value);
        }
	}
}