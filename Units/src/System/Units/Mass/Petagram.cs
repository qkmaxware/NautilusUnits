namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Petagram (Pg)
	/// </summary>
	public struct Petagram : IMass {
        public static string Name => "Petagram";
        public static string Symbol => "Pg";
    }
	
	public static class PetagramFactory {
		/// <summary>
        /// Create a quantity measured in Petagrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Petagram> Pg<T>(this T value) {
            return value.As<Petagram, T>();
        }
	}
}