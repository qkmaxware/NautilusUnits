namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Yoctocandela (ycd)
	/// </summary>
	public struct Yoctocandela : ILuminosity {
        public static string Name => "Yoctocandela";
        public static string Symbol => "ycd";
    }
	
	public static class YoctocandelaFactory {
		/// <summary>
        /// Create a quantity measured in Yoctocandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Yoctocandela> ycd<T>(this T value) {
            return value.As<T, Yoctocandela>();
        }
	}
}