namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Nanocandela (ncd)
	/// </summary>
	public struct Nanocandela : ILuminosity {
        public static string Name => "Nanocandela";
        public static string Symbol => "ncd";
    }
	
	public static class NanocandelaFactory {
		/// <summary>
        /// Create a quantity measured in Nanocandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Nanocandela> ncd<T>(this T value) {
            return value.As<Nanocandela, T>();
        }
	}
}