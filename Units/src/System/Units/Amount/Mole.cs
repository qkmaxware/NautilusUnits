namespace System.Units.Amount {

    public struct Mole : IAmount {
        public static string Name => "Mole";
        public static string Symbol => "mol";
    }

    public static class MoleFactory {
        /// <summary>
        /// Create a quantity measured in Moles
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Mole> mol<T>(this T value) {
            return value.As<Mole, T>();
        }
    }

}