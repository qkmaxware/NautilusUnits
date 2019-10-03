namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Millicandela (mcd)
	/// </summary>
	public struct Millicandela : ILuminosity {
        public static string Name => "Millicandela";
        public static string Symbol => "mcd";
    }
	
	public static class MillicandelaFactory {
		/// <summary>
        /// Create a quantity measured in Millicandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Millicandela> mcd<T>(this T value) {
            return value.As<Millicandela, T>();
        }
	}
}