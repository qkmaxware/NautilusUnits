namespace Qkmaxware.Units.Frequency {
	/// <summary>
	/// Unit of measurement for the YottaHertz (YHz)
	/// </summary>
	public struct YottaHertz : IFrequency {
        public static string Name => "YottaHertz";
        public static string Symbol => "YHz";
    }
	
	/// <summary>
	///Extension method factory for generating YottaHertz (YHz)
	/// </summary>
	public static class YottaHertzFactory {
		/// <summary>
        /// Create a quantity measured in YottaHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YottaHertz> YHz<T>(this T value) {
            return new Quantity<T, YottaHertz> (value);
        }
	}
}