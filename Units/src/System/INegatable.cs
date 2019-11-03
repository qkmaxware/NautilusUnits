namespace System {

/// <summary>
/// Interface representing a quantity than can be negated
/// </summary>
/// <typeparam name="R">Type after negation</typeparam>
public interface INegateable<R> {
    R Negate();
}

}