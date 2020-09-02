namespace Qkmaxware.Units.Frequency {
	/// <summary>
	/// Unit of measurement for PicoHertz (pHz)
	/// </summary>
	public struct PicoHertz : IFrequency {
        public static string Name => "PicoHertz";
        public static string Symbol => "pHz";
    }
	
	/// <summary>
	/// Extension method factory for generating PicoHertz (pHz)
	/// </summary>
	public static class PicoHertzFactory {
		/// <summary>
        /// Create a quantity measured in PicoHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PicoHertz> pHz<T>(this T value) {
            return new Quantity<T, PicoHertz> (value);
        }
	}
}