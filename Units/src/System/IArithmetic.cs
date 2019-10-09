namespace System {

public interface IArithmetic<R,T> : IAddable<R,T>, ISubtractable<R,T>, IMultipliable<R,T>, IDivisible<R,T> {}

}