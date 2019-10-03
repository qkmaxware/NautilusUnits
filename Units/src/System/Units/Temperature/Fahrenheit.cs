namespace System.Units.Temperature {

    public struct Fahrenheit : ITemperature {
        public static string Name => "Fahrenheit";
        public static string Symbol => "°F";
    }

    public static class FahrenheitFactory {
        /// <summary>
        /// Create a quantity measured in Fahrenheit
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Fahrenheit> F<T>(this T value) {
            return value.As<Fahrenheit, T>();
        }
    }

}