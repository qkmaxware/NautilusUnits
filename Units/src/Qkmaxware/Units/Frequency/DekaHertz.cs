namespace Qkmaxware.Units.Frequency {
	/// <summary>
	/// Unit of measurement for the DekaHertz (daHz)
	/// </summary>
	public struct DekaHertz : IFrequency {
        public static string Name => "DekaHertz";
        public static string Symbol => "daHz";
    }
	
	/// <summary>
	///Extension method factory for generating DekaHertz (daHz)
	/// </summary>
	public static class DekaHertzFactory {
		/// <summary>
        /// Create a quantity measured in DekaHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DekaHertz> daHz<T>(this T value) {
            return new Quantity<T, DekaHertz> (value);
        }
	}
}