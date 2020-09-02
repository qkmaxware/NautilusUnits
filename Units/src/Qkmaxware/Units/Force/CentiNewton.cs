namespace Qkmaxware.Units.Force {
	/// <summary>
	/// Unit of measurement for CentiNewton (cN)
	/// </summary>
	public struct CentiNewton : IForce {
        public static string Name => "CentiNewton";
        public static string Symbol => "cN";
    }
	
	/// <summary>
	/// Extension method factory for generating CentiNewton (cN)
	/// </summary>
	public static class CentiNewtonFactory {
		/// <summary>
        /// Create a quantity measured in CentiNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, CentiNewton> cN<T>(this T value) {
            return new Quantity<T, CentiNewton> (value);
        }
	}
}