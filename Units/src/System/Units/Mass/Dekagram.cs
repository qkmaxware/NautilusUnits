namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Dekagram (dag)
	/// </summary>
	public struct Dekagram : IMass {
        public static string Name => "Dekagram";
        public static string Symbol => "dag";
    }
	
	public static class DekagramFactory {
		/// <summary>
        /// Create a quantity measured in Dekagrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Dekagram> dag<T>(this T value) {
            return value.As<Dekagram, T>();
        }
	}
}