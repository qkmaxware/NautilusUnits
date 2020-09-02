namespace Qkmaxware.Units.Frequency {
	/// <summary>
	/// Unit of measurement for NanoHertz (nHz)
	/// </summary>
	public struct NanoHertz : IFrequency {
        public static string Name => "NanoHertz";
        public static string Symbol => "nHz";
    }
	
	/// <summary>
	/// Extension method factory for generating NanoHertz (nHz)
	/// </summary>
	public static class NanoHertzFactory {
		/// <summary>
        /// Create a quantity measured in NanoHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, NanoHertz> nHz<T>(this T value) {
            return new Quantity<T, NanoHertz> (value);
        }
	}
}