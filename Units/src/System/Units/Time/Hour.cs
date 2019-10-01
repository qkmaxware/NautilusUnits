namespace System.Units.Time {

    public struct Hour : ITime {
        public static string Name => "Hour";
        public static string Symbol => "hr";
    }

    public static class HourFactory {
        /// <summary>
        /// Create a quantity measured in Hours
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Hour> hr<T>(this T value) {
            return value.As<T, Hour>();
        }
    }

}