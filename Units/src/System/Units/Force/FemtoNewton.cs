namespace System.Units.Force {
	/// <summary>
	/// Unit of measurement for the FemtoNewton (fN)
	/// </summary>
	public struct FemtoNewton : IForce {
        public static string Name => "FemtoNewton";
        public static string Symbol => "fN";
    }
	
	public static class FemtoNewtonFactory {
		/// <summary>
        /// Create a quantity measured in FemtoNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, FemtoNewton> fN<T>(this T value) {
            return new Quantity<T, FemtoNewton> (value);
        }
	}
}