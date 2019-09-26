namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Kilocandela (kcd)
	/// </summary>
	public struct Kilocandela : ILuminosity {
        public static string Name => "Kilocandela";
        public static string Symbol => "kcd";
    }
	
	public static class KilocandelaFactory {
		/// <summary>
        /// Create a quantity measured in Kilocandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Kilocandela> kcd<T>(this T value) {
            return value.As<T, Kilocandela>();
        }
	}
}