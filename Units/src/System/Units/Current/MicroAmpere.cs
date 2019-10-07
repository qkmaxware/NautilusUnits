namespace System.Units.Current {
	/// <summary>
	/// Unit of measurement for the MicroAmpere (uA)
	/// </summary>
	public struct MicroAmpere : ICurrent {
        public static string Name => "MicroAmpere";
        public static string Symbol => "uA";
    }
	
	public static class MicroAmpereFactory {
		/// <summary>
        /// Create a quantity measured in MicroAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MicroAmpere> uA<T>(this T value) {
            return new Quantity<T, MicroAmpere> (value);
        }
	}
}