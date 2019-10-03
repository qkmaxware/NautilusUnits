namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Zettagram (Zg)
	/// </summary>
	public struct Zettagram : IMass {
        public static string Name => "Zettagram";
        public static string Symbol => "Zg";
    }
	
	public static class ZettagramFactory {
		/// <summary>
        /// Create a quantity measured in Zettagrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Zettagram> Zg<T>(this T value) {
            return value.As<Zettagram, T>();
        }
	}
}