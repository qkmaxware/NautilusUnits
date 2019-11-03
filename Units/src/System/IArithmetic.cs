namespace System {

/// <summary>
/// Interface representing a quantity that supports basic arithmetic with another type
/// </summary>
/// <typeparam name="R">Type which can be used in the arithmetic operations</typeparam>
/// <typeparam name="T">Type of the result from arithmetic operations</typeparam>
public interface IArithmetic<R,T> : IAddable<R,T>, ISubtractable<R,T>, IMultipliable<R,T>, IDivisible<R,T> {}

}