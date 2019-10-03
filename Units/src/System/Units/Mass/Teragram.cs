namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Teragram (Tg)
	/// </summary>
	public struct Teragram : IMass {
        public static string Name => "Teragram";
        public static string Symbol => "Tg";
    }
	
	public static class TeragramFactory {
		/// <summary>
        /// Create a quantity measured in Teragrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Teragram> Tg<T>(this T value) {
            return value.As<Teragram, T>();
        }
	}
}