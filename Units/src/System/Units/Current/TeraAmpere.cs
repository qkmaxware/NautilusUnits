namespace System.Units.Current {
	/// <summary>
	/// Unit of measurement for the TeraAmpere (TA)
	/// </summary>
	public struct TeraAmpere : ICurrent {
        public static string Name => "TeraAmpere";
        public static string Symbol => "TA";
    }
	
	public static class TeraAmpereFactory {
		/// <summary>
        /// Create a quantity measured in TeraAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, TeraAmpere> TA<T>(this T value) {
            return new Quantity<T, TeraAmpere> (value);
        }
	}
}