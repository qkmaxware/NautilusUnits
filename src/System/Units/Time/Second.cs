namespace System.Units.Time {

    public struct Second : ITime {
        public static string Name => "Second";
        public static string Symbol => "s";
    }

    public static class SecondFactory {
        /// <summary>
        /// Create a quantity measured in Seconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Second> s<T>(this T value) {
            return value.As<T, Second>();
        }
    }

}