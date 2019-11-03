namespace System.Units.Force {
	/// <summary>
	/// Unit of measurement for the PicoNewton (pN)
	/// </summary>
	public struct PicoNewton : IForce {
        public static string Name => "PicoNewton";
        public static string Symbol => "pN";
    }
	
	/// <summary>
	///Extension method factory for generating PicoNewton (pN)
	/// </summary>
	public static class PicoNewtonFactory {
		/// <summary>
        /// Create a quantity measured in PicoNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PicoNewton> pN<T>(this T value) {
            return new Quantity<T, PicoNewton> (value);
        }
	}
}