namespace Qkmaxware.Units {

/// <summary>
/// Interface representing an abstract unit of measurement
/// </summary>
public interface IUnit {

    /// <summary>
    /// The name of the unit
    /// </summary>
    /// <value></value>
    public static string Name {get;}

    /// <summary>
    /// The symbol used to represent the unit
    /// </summary>
    /// <value></value>
    public static string Symbol {get;}

}

}