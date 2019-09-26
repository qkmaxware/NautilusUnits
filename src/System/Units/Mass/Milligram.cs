namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Milligram (mg)
	/// </summary>
	public struct Milligram : IMass {
        public static string Name => "Milligram";
        public static string Symbol => "mg";
    }
	
	public static class MilligramFactory {
		/// <summary>
        /// Create a quantity measured in Milligrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Milligram> mg<T>(this T value) {
            return value.As<T, Milligram>();
        }
	}
}