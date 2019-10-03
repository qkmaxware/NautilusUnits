namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Hectocandela (hcd)
	/// </summary>
	public struct Hectocandela : ILuminosity {
        public static string Name => "Hectocandela";
        public static string Symbol => "hcd";
    }
	
	public static class HectocandelaFactory {
		/// <summary>
        /// Create a quantity measured in Hectocandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Hectocandela> hcd<T>(this T value) {
            return value.As<Hectocandela, T>();
        }
	}
}