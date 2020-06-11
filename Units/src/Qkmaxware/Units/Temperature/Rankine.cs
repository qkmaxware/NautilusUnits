namespace Qkmaxware.Units.Temperature {

    public struct Rankine : ITemperature {
        public static string Name => "Rankine";
        public static string Symbol => "°R";
    }

    /// <summary>
	///Extension method factory for generating Rankine (°R)
	/// </summary>
	public static class RankineFactory {
        /// <summary>
        /// Create a quantity measured in Rankines
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Rankine> degR<T>(this T value) {
            return value.As<Rankine, T>();
        }
    }

}