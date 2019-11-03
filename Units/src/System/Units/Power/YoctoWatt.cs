namespace System.Units.Power {
	/// <summary>
	/// Unit of measurement for the YoctoWatt (yW)
	/// </summary>
	public struct YoctoWatt : IPower {
        public static string Name => "YoctoWatt";
        public static string Symbol => "yW";
    }
	
	/// <summary>
	///Extension method factory for generating YoctoWatt (yW)
	/// </summary>
	public static class YoctoWattFactory {
		/// <summary>
        /// Create a quantity measured in YoctoWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YoctoWatt> yW<T>(this T value) {
            return new Quantity<T, YoctoWatt> (value);
        }
	}
}