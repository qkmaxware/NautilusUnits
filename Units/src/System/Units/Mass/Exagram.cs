namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Exagram (Eg)
	/// </summary>
	public struct Exagram : IMass {
        public static string Name => "Exagram";
        public static string Symbol => "Eg";
    }
	
	public static class ExagramFactory {
		/// <summary>
        /// Create a quantity measured in Exagrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Exagram> Eg<T>(this T value) {
            return value.As<Exagram, T>();
        }
	}
}