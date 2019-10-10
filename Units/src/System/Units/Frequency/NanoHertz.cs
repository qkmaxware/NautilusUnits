namespace System.Units.Frequency {
	/// <summary>
	/// Unit of measurement for the NanoHertz (nHz)
	/// </summary>
	public struct NanoHertz : IFrequency {
        public static string Name => "NanoHertz";
        public static string Symbol => "nHz";
    }
	
	public static class NanoHertzFactory {
		/// <summary>
        /// Create a quantity measured in NanoHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, NanoHertz> nHz<T>(this T value) {
            return new Quantity<T, NanoHertz> (value);
        }
	}
}