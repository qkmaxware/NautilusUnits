namespace Qkmaxware.Units.Frequency {
	/// <summary>
	/// Unit of measurement for MilliHertz (mHz)
	/// </summary>
	public struct MilliHertz : IFrequency {
        public static string Name => "MilliHertz";
        public static string Symbol => "mHz";
    }
	
	/// <summary>
	/// Extension method factory for generating MilliHertz (mHz)
	/// </summary>
	public static class MilliHertzFactory {
		/// <summary>
        /// Create a quantity measured in MilliHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MilliHertz> mHz<T>(this T value) {
            return new Quantity<T, MilliHertz> (value);
        }
	}
}