namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the DekaLumen (dalm)
	/// </summary>
	public struct DekaLumen : ILuminosity {
        public static string Name => "DekaLumen";
        public static string Symbol => "dalm";
    }
	
	public static class DekaLumenFactory {
		/// <summary>
        /// Create a quantity measured in DekaLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DekaLumen> dalm<T>(this T value) {
            return new Quantity<T, DekaLumen> (value);
        }
	}
}