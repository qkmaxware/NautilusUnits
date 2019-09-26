namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Centicandela (ccd)
	/// </summary>
	public struct Centicandela : ILuminosity {
        public static string Name => "Centicandela";
        public static string Symbol => "ccd";
    }
	
	public static class CenticandelaFactory {
		/// <summary>
        /// Create a quantity measured in Centicandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Centicandela> ccd<T>(this T value) {
            return value.As<T, Centicandela>();
        }
	}
}