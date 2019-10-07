namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the CentiCandela (ccd)
	/// </summary>
	public struct CentiCandela : ILuminosity {
        public static string Name => "CentiCandela";
        public static string Symbol => "ccd";
    }
	
	public static class CentiCandelaFactory {
		/// <summary>
        /// Create a quantity measured in CentiCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, CentiCandela> ccd<T>(this T value) {
            return new Quantity<T, CentiCandela> (value);
        }
	}
}