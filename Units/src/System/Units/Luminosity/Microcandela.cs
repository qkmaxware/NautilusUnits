namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Microcandela (ucd)
	/// </summary>
	public struct Microcandela : ILuminosity {
        public static string Name => "Microcandela";
        public static string Symbol => "ucd";
    }
	
	public static class MicrocandelaFactory {
		/// <summary>
        /// Create a quantity measured in Microcandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Microcandela> ucd<T>(this T value) {
            return value.As<Microcandela, T>();
        }
	}
}