namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Femtometre (fm)
	/// </summary>
	public struct Femtometre : ILength {
        public static string Name => "Femtometre";
        public static string Symbol => "fm";
    }
	
	public static class FemtometreFactory {
		/// <summary>
        /// Create a quantity measured in Femtometres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Femtometre> fm<T>(this T value) {
            return value.As<Femtometre, T>();
        }
	}
}