namespace Qkmaxware.Units.Frequency {
	/// <summary>
	/// Unit of measurement for ZettaHertz (ZHz)
	/// </summary>
	public struct ZettaHertz : IFrequency {
        public static string Name => "ZettaHertz";
        public static string Symbol => "ZHz";
    }
	
	/// <summary>
	/// Extension method factory for generating ZettaHertz (ZHz)
	/// </summary>
	public static class ZettaHertzFactory {
		/// <summary>
        /// Create a quantity measured in ZettaHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZettaHertz> ZHz<T>(this T value) {
            return new Quantity<T, ZettaHertz> (value);
        }
	}
}