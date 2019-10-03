namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Centigram (cg)
	/// </summary>
	public struct Centigram : IMass {
        public static string Name => "Centigram";
        public static string Symbol => "cg";
    }
	
	public static class CentigramFactory {
		/// <summary>
        /// Create a quantity measured in Centigrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Centigram> cg<T>(this T value) {
            return value.As<Centigram, T>();
        }
	}
}