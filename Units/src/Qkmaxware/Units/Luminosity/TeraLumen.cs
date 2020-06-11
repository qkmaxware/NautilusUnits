namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the TeraLumen (Tlm)
	/// </summary>
	public struct TeraLumen : ILuminosity {
        public static string Name => "TeraLumen";
        public static string Symbol => "Tlm";
    }
	
	/// <summary>
	///Extension method factory for generating TeraLumen (Tlm)
	/// </summary>
	public static class TeraLumenFactory {
		/// <summary>
        /// Create a quantity measured in TeraLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, TeraLumen> Tlm<T>(this T value) {
            return new Quantity<T, TeraLumen> (value);
        }
	}
}