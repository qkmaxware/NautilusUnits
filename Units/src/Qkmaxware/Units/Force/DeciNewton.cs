namespace Qkmaxware.Units.Force {
	/// <summary>
	/// Unit of measurement for the DeciNewton (dN)
	/// </summary>
	public struct DeciNewton : IForce {
        public static string Name => "DeciNewton";
        public static string Symbol => "dN";
    }
	
	/// <summary>
	///Extension method factory for generating DeciNewton (dN)
	/// </summary>
	public static class DeciNewtonFactory {
		/// <summary>
        /// Create a quantity measured in DeciNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DeciNewton> dN<T>(this T value) {
            return new Quantity<T, DeciNewton> (value);
        }
	}
}