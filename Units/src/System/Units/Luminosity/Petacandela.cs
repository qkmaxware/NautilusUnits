namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Petacandela (Pcd)
	/// </summary>
	public struct Petacandela : ILuminosity {
        public static string Name => "Petacandela";
        public static string Symbol => "Pcd";
    }
	
	public static class PetacandelaFactory {
		/// <summary>
        /// Create a quantity measured in Petacandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Petacandela> Pcd<T>(this T value) {
            return value.As<T, Petacandela>();
        }
	}
}