namespace Qkmaxware.Units.Temperature {

    public struct Kelvin : ITemperature {
        public static string Name => "Kelvin";
        public static string Symbol => "K";
    }

    /// <summary>
	///Extension method factory for generating Kelvin (K)
	/// </summary>
	public static class KelvinFactory {
        /// <summary>
        /// Create a quantity measured in Kelvins
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Kelvin> K<T>(this T value) {
            return value.As<Kelvin, T>();
        }
    }

}