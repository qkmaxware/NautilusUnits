namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for the PetaMetre (Pm)
	/// </summary>
	public struct PetaMetre : ILength {
        public static string Name => "PetaMetre";
        public static string Symbol => "Pm";
    }
	
	public static class PetaMetreFactory {
		/// <summary>
        /// Create a quantity measured in PetaMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PetaMetre> Pm<T>(this T value) {
            return new Quantity<T, PetaMetre> (value);
        }
	}
}