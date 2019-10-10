namespace System.Units.Frequency {
	/// <summary>
	/// Unit of measurement for the Hertz (Hz)
	/// </summary>
	public struct Hertz : IFrequency {
        public static string Name => "Hertz";
        public static string Symbol => "Hz";
    }
	
	public static class HertzFactory {
		/// <summary>
        /// Create a quantity measured in Hertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Hertz> Hz<T>(this T value) {
            return new Quantity<T, Hertz> (value);
        }
	}
}