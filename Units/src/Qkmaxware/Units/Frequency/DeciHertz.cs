namespace Qkmaxware.Units.Frequency {
	/// <summary>
	/// Unit of measurement for DeciHertz (dHz)
	/// </summary>
	public struct DeciHertz : IFrequency {
        public static string Name => "DeciHertz";
        public static string Symbol => "dHz";
    }
	
	/// <summary>
	/// Extension method factory for generating DeciHertz (dHz)
	/// </summary>
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