namespace System.Units.Current {
	/// <summary>
	/// Unit of measurement for the KiloAmpere (kA)
	/// </summary>
	public struct KiloAmpere : ICurrent {
        public static string Name => "KiloAmpere";
        public static string Symbol => "kA";
    }
	
	public static class KiloAmpereFactory {
		/// <summary>
        /// Create a quantity measured in KiloAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, KiloAmpere> kA<T>(this T value) {
            return new Quantity<T, KiloAmpere> (value);
        }
	}
}