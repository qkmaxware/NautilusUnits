namespace System.Units.Power {
	/// <summary>
	/// Unit of measurement for the NanoWatt (nW)
	/// </summary>
	public struct NanoWatt : IPower {
        public static string Name => "NanoWatt";
        public static string Symbol => "nW";
    }
	
	/// <summary>
	///Extension method factory for generating NanoWatt (nW)
	/// </summary>
	public static class NanoWattFactory {
		/// <summary>
        /// Create a quantity measured in NanoWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, NanoWatt> nW<T>(this T value) {
            return new Quantity<T, NanoWatt> (value);
        }
	}
}