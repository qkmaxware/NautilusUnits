namespace Qkmaxware.Units.Frequency {
	/// <summary>
	/// Unit of measurement for KiloHertz (kHz)
	/// </summary>
	public struct KiloHertz : IFrequency {
        public static string Name => "KiloHertz";
        public static string Symbol => "kHz";
    }
	
	/// <summary>
	/// Extension method factory for generating KiloHertz (kHz)
	/// </summary>
	public static class KiloHertzFactory {
		/// <summary>
        /// Create a quantity measured in KiloHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, KiloHertz> kHz<T>(this T value) {
            return new Quantity<T, KiloHertz> (value);
        }
	}
}