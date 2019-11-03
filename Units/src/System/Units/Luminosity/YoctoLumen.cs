namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the YoctoLumen (ylm)
	/// </summary>
	public struct YoctoLumen : ILuminosity {
        public static string Name => "YoctoLumen";
        public static string Symbol => "ylm";
    }
	
	/// <summary>
	///Extension method factory for generating YoctoLumen (ylm)
	/// </summary>
	public static class YoctoLumenFactory {
		/// <summary>
        /// Create a quantity measured in YoctoLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YoctoLumen> ylm<T>(this T value) {
            return new Quantity<T, YoctoLumen> (value);
        }
	}
}