namespace Qkmaxware.Units.Frequency {
	/// <summary>
	/// Unit of measurement for CentiHertz (cHz)
	/// </summary>
	public struct CentiHertz : IFrequency {
        public static string Name => "CentiHertz";
        public static string Symbol => "cHz";
    }
	
	/// <summary>
	/// Extension method factory for generating CentiHertz (cHz)
	/// </summary>
	public static class CentiHertzFactory {
		/// <summary>
        /// Create a quantity measured in CentiHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, CentiHertz> cHz<T>(this T value) {
            return new Quantity<T, CentiHertz> (value);
        }
	}
}