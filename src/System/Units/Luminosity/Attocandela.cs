namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Attocandela (acd)
	/// </summary>
	public struct Attocandela : ILuminosity {
        public static string Name => "Attocandela";
        public static string Symbol => "acd";
    }
	
	public static class AttocandelaFactory {
		/// <summary>
        /// Create a quantity measured in Attocandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Attocandela> acd<T>(this T value) {
            return value.As<T, Attocandela>();
        }
	}
}