using System.Units.Mass;
using System.Units.Length;
using System.Units.Velocity;

namespace System.Units {

public static class Constants {
    public static readonly Quantity<double, KiloGram> AtomicMassUnit = new Quantity<double, KiloGram>(1.660538782e-27);
    // public static readonly double AvogadroNumber = 6.02214179e23;
    // TODO BohrMagneton
    public static readonly Quantity<double, Metre> BohrRadius = new Quantity<double, Metre>(5.2917720859e-11);
    // TODO BoltzmannConstant
    public static readonly Quantity<double, Metre> ComptonWavelength = new Quantity<double, Metre>(2.4263102175e-12);
    // TODO CoulombConstant
    public static readonly Quantity<double, KiloGram> DeuteronMass = new Quantity<double, KiloGram>(3.34358320e-27);
    public static readonly Quantity<double, KiloGram> ElectronMass = new Quantity<double, KiloGram>(9.10938215e-31);
    // TODO ElectronVolt
    // TODO ElementaryCharge
    // TODO GasConstant
    // TODO GravitationalConstant
    public static readonly Quantity<double, KiloGram> NeutronMass = new Quantity<double, KiloGram>(1.674927211e-27);
    // TODO NuclearMagneton
    // TODO PermeabilityOfFreeSpace
    // TODO PermittivityOfFreeSpace
    // TODO PlankConstant
    public static readonly Quantity<double, KiloGram> ProtonMass = new Quantity<double, KiloGram>(1.672621637e-27);
    // TODO RydbergConstant
    public static readonly Quantity<double, MetrePerSecond> SpeedOfLightInVacuum = new Quantity<double, MetrePerSecond>(2.99792458e8);

    // TODO Planetary constants (mass, mean orbit radius, etc...)
}
    
}