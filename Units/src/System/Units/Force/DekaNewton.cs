namespace System.Units.Force {
	/// <summary>
	/// Unit of measurement for the DekaNewton (daN)
	/// </summary>
	public struct DekaNewton : IForce {
        public static string Name => "DekaNewton";
        public static string Symbol => "daN";
    }
	
	public static class DekaNewtonFactory {
		/// <summary>
        /// Create a quantity measured in DekaNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DekaNewton> daN<T>(this T value) {
            return new Quantity<T, DekaNewton> (value);
        }
	}
}