namespace Qkmaxware.Units.Temperature {

    public struct Fahrenheit : ITemperature {
        public static string Name => "Fahrenheit";
        public static string Symbol => "°F";
    }

    /// <summary>
	///Extension method factory for generating Fahrenheit (°F)
	/// </summary>
	public static class FahrenheitFactory {
        /// <summary>
        /// Create a quantity measured in Fahrenheit
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Fahrenheit> degF<T>(this T value) {
            return value.As<Fahrenheit, T>();
        }
    }

}