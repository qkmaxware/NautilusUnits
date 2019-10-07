namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the ExaLumen (Elm)
	/// </summary>
	public struct ExaLumen : ILuminosity {
        public static string Name => "ExaLumen";
        public static string Symbol => "Elm";
    }
	
	public static class ExaLumenFactory {
		/// <summary>
        /// Create a quantity measured in ExaLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ExaLumen> Elm<T>(this T value) {
            return new Quantity<T, ExaLumen> (value);
        }
	}
}