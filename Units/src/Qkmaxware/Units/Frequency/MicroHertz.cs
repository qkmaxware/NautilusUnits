namespace Qkmaxware.Units.Frequency {
	/// <summary>
	/// Unit of measurement for the MicroHertz (uHz)
	/// </summary>
	public struct MicroHertz : IFrequency {
        public static string Name => "MicroHertz";
        public static string Symbol => "uHz";
    }
	
	/// <summary>
	///Extension method factory for generating MicroHertz (uHz)
	/// </summary>
	public static class MicroHertzFactory {
		/// <summary>
        /// Create a quantity measured in MicroHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MicroHertz> uHz<T>(this T value) {
            return new Quantity<T, MicroHertz> (value);
        }
	}
}