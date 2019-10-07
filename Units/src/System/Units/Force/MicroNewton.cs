namespace System.Units.Force {
	/// <summary>
	/// Unit of measurement for the MicroNewton (uN)
	/// </summary>
	public struct MicroNewton : IForce {
        public static string Name => "MicroNewton";
        public static string Symbol => "uN";
    }
	
	public static class MicroNewtonFactory {
		/// <summary>
        /// Create a quantity measured in MicroNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MicroNewton> uN<T>(this T value) {
            return new Quantity<T, MicroNewton> (value);
        }
	}
}