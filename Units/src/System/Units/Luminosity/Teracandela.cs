namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Teracandela (Tcd)
	/// </summary>
	public struct Teracandela : ILuminosity {
        public static string Name => "Teracandela";
        public static string Symbol => "Tcd";
    }
	
	public static class TeracandelaFactory {
		/// <summary>
        /// Create a quantity measured in Teracandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Teracandela> Tcd<T>(this T value) {
            return value.As<T, Teracandela>();
        }
	}
}