namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Femtocandela (fcd)
	/// </summary>
	public struct Femtocandela : ILuminosity {
        public static string Name => "Femtocandela";
        public static string Symbol => "fcd";
    }
	
	public static class FemtocandelaFactory {
		/// <summary>
        /// Create a quantity measured in Femtocandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Femtocandela> fcd<T>(this T value) {
            return value.As<T, Femtocandela>();
        }
	}
}