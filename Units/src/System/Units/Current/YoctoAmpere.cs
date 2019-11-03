namespace System.Units.Current {
	/// <summary>
	/// Unit of measurement for the YoctoAmpere (yA)
	/// </summary>
	public struct YoctoAmpere : ICurrent {
        public static string Name => "YoctoAmpere";
        public static string Symbol => "yA";
    }
	
	/// <summary>
	///Extension method factory for generating YoctoAmpere (yA)
	/// </summary>
	public static class YoctoAmpereFactory {
		/// <summary>
        /// Create a quantity measured in YoctoAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YoctoAmpere> yA<T>(this T value) {
            return new Quantity<T, YoctoAmpere> (value);
        }
	}
}