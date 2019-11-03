namespace System.Units.Force {
	/// <summary>
	/// Unit of measurement for the TeraNewton (TN)
	/// </summary>
	public struct TeraNewton : IForce {
        public static string Name => "TeraNewton";
        public static string Symbol => "TN";
    }
	
	/// <summary>
	///Extension method factory for generating TeraNewton (TN)
	/// </summary>
	public static class TeraNewtonFactory {
		/// <summary>
        /// Create a quantity measured in TeraNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, TeraNewton> TN<T>(this T value) {
            return new Quantity<T, TeraNewton> (value);
        }
	}
}