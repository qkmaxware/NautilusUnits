namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Megagram (Mg)
	/// </summary>
	public struct Megagram : IMass {
        public static string Name => "Megagram";
        public static string Symbol => "Mg";
    }
	
	public static class MegagramFactory {
		/// <summary>
        /// Create a quantity measured in Megagrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Megagram> Mg<T>(this T value) {
            return value.As<T, Megagram>();
        }
	}
}