namespace System.Units.Frequency {
	/// <summary>
	/// Unit of measurement for the GigaHertz (GHz)
	/// </summary>
	public struct GigaHertz : IFrequency {
        public static string Name => "GigaHertz";
        public static string Symbol => "GHz";
    }
	
	/// <summary>
	///Extension method factory for generating GigaHertz (GHz)
	/// </summary>
	public static class GigaHertzFactory {
		/// <summary>
        /// Create a quantity measured in GigaHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, GigaHertz> GHz<T>(this T value) {
            return new Quantity<T, GigaHertz> (value);
        }
	}
}