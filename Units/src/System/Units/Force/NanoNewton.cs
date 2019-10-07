namespace System.Units.Force {
	/// <summary>
	/// Unit of measurement for the NanoNewton (nN)
	/// </summary>
	public struct NanoNewton : IForce {
        public static string Name => "NanoNewton";
        public static string Symbol => "nN";
    }
	
	public static class NanoNewtonFactory {
		/// <summary>
        /// Create a quantity measured in NanoNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, NanoNewton> nN<T>(this T value) {
            return new Quantity<T, NanoNewton> (value);
        }
	}
}