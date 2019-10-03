namespace System.Units.Temperature {

    public struct Celsius : ITemperature {
        public static string Name => "Celsius";
        public static string Symbol => "°C";
    }

    public static class CelsiusFactory {
        /// <summary>
        /// Create a quantity measured in Celsius
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Celsius> F<T>(this T value) {
            return value.As<Celsius, T>();
        }
    }

}