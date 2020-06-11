namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the CentiLumen (clm)
	/// </summary>
	public struct CentiLumen : ILuminosity {
        public static string Name => "CentiLumen";
        public static string Symbol => "clm";
    }
	
	/// <summary>
	///Extension method factory for generating CentiLumen (clm)
	/// </summary>
	public static class CentiLumenFactory {
		/// <summary>
        /// Create a quantity measured in CentiLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, CentiLumen> clm<T>(this T value) {
            return new Quantity<T, CentiLumen> (value);
        }
	}
}