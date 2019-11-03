namespace System.Units.Current {
	/// <summary>
	/// Unit of measurement for the FemtoAmpere (fA)
	/// </summary>
	public struct FemtoAmpere : ICurrent {
        public static string Name => "FemtoAmpere";
        public static string Symbol => "fA";
    }
	
	/// <summary>
	///Extension method factory for generating FemtoAmpere (fA)
	/// </summary>
	public static class FemtoAmpereFactory {
		/// <summary>
        /// Create a quantity measured in FemtoAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, FemtoAmpere> fA<T>(this T value) {
            return new Quantity<T, FemtoAmpere> (value);
        }
	}
}