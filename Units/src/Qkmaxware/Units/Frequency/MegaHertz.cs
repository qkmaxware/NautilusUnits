namespace Qkmaxware.Units.Frequency {
	/// <summary>
	/// Unit of measurement for the MegaHertz (MHz)
	/// </summary>
	public struct MegaHertz : IFrequency {
        public static string Name => "MegaHertz";
        public static string Symbol => "MHz";
    }
	
	/// <summary>
	///Extension method factory for generating MegaHertz (MHz)
	/// </summary>
	public static class MegaHertzFactory {
		/// <summary>
        /// Create a quantity measured in MegaHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MegaHertz> MHz<T>(this T value) {
            return new Quantity<T, MegaHertz> (value);
        }
	}
}