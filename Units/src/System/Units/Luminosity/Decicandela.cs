namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Decicandela (dcd)
	/// </summary>
	public struct Decicandela : ILuminosity {
        public static string Name => "Decicandela";
        public static string Symbol => "dcd";
    }
	
	public static class DecicandelaFactory {
		/// <summary>
        /// Create a quantity measured in Decicandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Decicandela> dcd<T>(this T value) {
            return value.As<T, Decicandela>();
        }
	}
}