namespace System.Units.Current {
	/// <summary>
	/// Unit of measurement for the ExaAmpere (EA)
	/// </summary>
	public struct ExaAmpere : ICurrent {
        public static string Name => "ExaAmpere";
        public static string Symbol => "EA";
    }
	
	public static class ExaAmpereFactory {
		/// <summary>
        /// Create a quantity measured in ExaAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ExaAmpere> EA<T>(this T value) {
            return new Quantity<T, ExaAmpere> (value);
        }
	}
}