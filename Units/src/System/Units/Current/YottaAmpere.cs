namespace System.Units.Current {
	/// <summary>
	/// Unit of measurement for the YottaAmpere (YA)
	/// </summary>
	public struct YottaAmpere : ICurrent {
        public static string Name => "YottaAmpere";
        public static string Symbol => "YA";
    }
	
	/// <summary>
	///Extension method factory for generating YottaAmpere (YA)
	/// </summary>
	public static class YottaAmpereFactory {
		/// <summary>
        /// Create a quantity measured in YottaAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YottaAmpere> YA<T>(this T value) {
            return new Quantity<T, YottaAmpere> (value);
        }
	}
}