namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Picocandela (pcd)
	/// </summary>
	public struct Picocandela : ILuminosity {
        public static string Name => "Picocandela";
        public static string Symbol => "pcd";
    }
	
	public static class PicocandelaFactory {
		/// <summary>
        /// Create a quantity measured in Picocandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Picocandela> pcd<T>(this T value) {
            return value.As<Picocandela, T>();
        }
	}
}