namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Yottagram (Yg)
	/// </summary>
	public struct Yottagram : IMass {
        public static string Name => "Yottagram";
        public static string Symbol => "Yg";
    }
	
	public static class YottagramFactory {
		/// <summary>
        /// Create a quantity measured in Yottagrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Yottagram> Yg<T>(this T value) {
            return value.As<T, Yottagram>();
        }
	}
}