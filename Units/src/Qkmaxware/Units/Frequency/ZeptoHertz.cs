namespace Qkmaxware.Units.Frequency {
	/// <summary>
	/// Unit of measurement for the ZeptoHertz (zHz)
	/// </summary>
	public struct ZeptoHertz : IFrequency {
        public static string Name => "ZeptoHertz";
        public static string Symbol => "zHz";
    }
	
	/// <summary>
	///Extension method factory for generating ZeptoHertz (zHz)
	/// </summary>
	public static class ZeptoHertzFactory {
		/// <summary>
        /// Create a quantity measured in ZeptoHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZeptoHertz> zHz<T>(this T value) {
            return new Quantity<T, ZeptoHertz> (value);
        }
	}
}