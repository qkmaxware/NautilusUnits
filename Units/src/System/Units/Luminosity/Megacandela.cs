namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the MegaCandela (Mcd)
	/// </summary>
	public struct MegaCandela : ILuminosity {
        public static string Name => "MegaCandela";
        public static string Symbol => "Mcd";
    }
	
	/// <summary>
	///Extension method factory for generating MegaCandela (Mcd)
	/// </summary>
	public static class MegaCandelaFactory {
		/// <summary>
        /// Create a quantity measured in MegaCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MegaCandela> Mcd<T>(this T value) {
            return new Quantity<T, MegaCandela> (value);
        }
	}
}