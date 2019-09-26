namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Kilogram (kg)
	/// </summary>
	public struct Kilogram : IMass {
        public static string Name => "Kilogram";
        public static string Symbol => "kg";
    }
	
	public static class KilogramFactory {
		/// <summary>
        /// Create a quantity measured in Kilograms
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Kilogram> kg<T>(this T value) {
            return value.As<T, Kilogram>();
        }
	}
}