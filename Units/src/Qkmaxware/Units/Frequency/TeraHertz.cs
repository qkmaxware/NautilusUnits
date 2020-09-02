namespace Qkmaxware.Units.Frequency {
	/// <summary>
	/// Unit of measurement for TeraHertz (THz)
	/// </summary>
	public struct TeraHertz : IFrequency {
        public static string Name => "TeraHertz";
        public static string Symbol => "THz";
    }
	
	/// <summary>
	/// Extension method factory for generating TeraHertz (THz)
	/// </summary>
	public static class TeraHertzFactory {
		/// <summary>
        /// Create a quantity measured in TeraHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, TeraHertz> THz<T>(this T value) {
            return new Quantity<T, TeraHertz> (value);
        }
	}
}