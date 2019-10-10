namespace System.Units.Frequency {
	/// <summary>
	/// Unit of measurement for the DeciHertz (dHz)
	/// </summary>
	public struct DeciHertz : IFrequency {
        public static string Name => "DeciHertz";
        public static string Symbol => "dHz";
    }
	
	public static class DeciHertzFactory {
		/// <summary>
        /// Create a quantity measured in DeciHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DeciHertz> dHz<T>(this T value) {
            return new Quantity<T, DeciHertz> (value);
        }
	}
}