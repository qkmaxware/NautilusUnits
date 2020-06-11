namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the PetaCandela (Pcd)
	/// </summary>
	public struct PetaCandela : ILuminosity {
        public static string Name => "PetaCandela";
        public static string Symbol => "Pcd";
    }
	
	/// <summary>
	///Extension method factory for generating PetaCandela (Pcd)
	/// </summary>
	public static class PetaCandelaFactory {
		/// <summary>
        /// Create a quantity measured in PetaCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PetaCandela> Pcd<T>(this T value) {
            return new Quantity<T, PetaCandela> (value);
        }
	}
}