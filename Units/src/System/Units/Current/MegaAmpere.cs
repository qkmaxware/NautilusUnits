namespace System.Units.Current {
	/// <summary>
	/// Unit of measurement for the MegaAmpere (MA)
	/// </summary>
	public struct MegaAmpere : ICurrent {
        public static string Name => "MegaAmpere";
        public static string Symbol => "MA";
    }
	
	public static class MegaAmpereFactory {
		/// <summary>
        /// Create a quantity measured in MegaAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MegaAmpere> MA<T>(this T value) {
            return new Quantity<T, MegaAmpere> (value);
        }
	}
}