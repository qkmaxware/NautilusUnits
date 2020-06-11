using Qkmaxware.Units.Mass;
using Qkmaxware.Units.Length;
using Qkmaxware.Units.Velocity;
using Qkmaxware.Units.Time;
using Qkmaxware.Units.Pressure;

using Qkmaxware.Units.CompoundUnits;

namespace Qkmaxware.Units {

/// <summary>
/// Read-only constant definitions
/// </summary>
public static class Constants {
    // Physical Constants
    public static readonly Quantity<double, KiloGram> AtomicMassUnit = new Quantity<double, KiloGram>(1.660538782e-27);
    public static readonly Quantity<double, ParticlesPerMol> AvogadroNumber = new Quantity<double, ParticlesPerMol>(6.02214179e23);
    public static readonly Quantity<double, JoulePerTesla> BohrMagneton = new Quantity<double, JoulePerTesla>(9.27400915e-24);
    public static readonly Quantity<double, Metre> BohrRadius = new Quantity<double, Metre>(5.2917720859e-11);
    // TODO BoltzmannConstant
    public static readonly Quantity<double, Metre> ComptonWavelength = new Quantity<double, Metre>(2.4263102175e-12);
    // TODO CoulombConstant
    public static readonly Quantity<double, KiloGram> DeuteronMass = new Quantity<double, KiloGram>(3.34358320e-27);
    public static readonly Quantity<double, KiloGram> ElectronMass = new Quantity<double, KiloGram>(9.10938215e-31);
    // TODO ElementaryCharge
    // TODO GasConstant
    public static readonly Quantity<double, NewtonMetreSqPerKiloGramSq> GravitationalConstant = new Quantity<double, NewtonMetreSqPerKiloGramSq>(6.67428e-11);
    public static readonly Quantity<double, KiloGram> NeutronMass = new Quantity<double, KiloGram>(1.674927211e-27);
    // TODO NuclearMagneton
    // TODO PermeabilityOfFreeSpace
    // TODO PermittivityOfFreeSpace
    public static readonly Quantity<double, JouleSecond> PlankConstant = new Quantity<double, JouleSecond>(6.62606896e-34);
    public static readonly Quantity<double, KiloGram> ProtonMass = new Quantity<double, KiloGram>(1.672621637e-27);
    // TODO RydbergConstant
    public static readonly Quantity<double, MetrePerSecond> SpeedOfLightInVacuum = new Quantity<double, MetrePerSecond>(2.99792458e8);

    // Solar System Data Constants
    public static readonly Quantity<double, Metre> AverageEarthMoonDistance = new Quantity<double, Metre>(3.84e8);
    public static readonly Quantity<double, Metre> AverageEarthSunDistance = new Quantity<double, Metre>(1.496e11);
    public static readonly Quantity<double, Pascal> StandardAtmosphericPressure = new Quantity<double, Pascal>(1.013e5);

    public static readonly Quantity<double, KiloGram> MercuryMass = new Quantity<double, KiloGram>(3.30e23);
    public static readonly Quantity<double, Metre> MercuryMeanRadius = new Quantity<double, Metre>(2.44e6);
    public static readonly Quantity<double, Second> MercuryOrbitalPeriod = new Quantity<double, Second>(7.60e6);
    public static readonly Quantity<double, Metre> MercuryMeanDistanceFromSun = new Quantity<double, Metre>(5.79e10);

    public static readonly Quantity<double, KiloGram> VenusMass = new Quantity<double, KiloGram>(4.87e24);
    public static readonly Quantity<double, Metre> VenusMeanRadius = new Quantity<double, Metre>(6.05e6);
    public static readonly Quantity<double, Second> VenusOrbitalPeriod = new Quantity<double, Second>(1.94e7);
    public static readonly Quantity<double, Metre> VenusMeanDistanceFromSun = new Quantity<double, Metre>(1.08e11);

    public static readonly Quantity<double, KiloGram> EarthMass = new Quantity<double, KiloGram>(5.97e24);
    public static readonly Quantity<double, Metre> EarthMeanRadius = new Quantity<double, Metre>(6.37e6);
    public static readonly Quantity<double, Second> EarthOrbitalPeriod = new Quantity<double, Second>(3.156e7);
    public static readonly Quantity<double, Metre> EarthMeanDistanceFromSun = new Quantity<double, Metre>(1.496e11);

    public static readonly Quantity<double, KiloGram> MarsMass = new Quantity<double, KiloGram>(6.42e23);
    public static readonly Quantity<double, Metre> MarsMeanRadius = new Quantity<double, Metre>(3.39e6);
    public static readonly Quantity<double, Second> MarsOrbitalPeriod = new Quantity<double, Second>(5.94e7);
    public static readonly Quantity<double, Metre> MarsMeanDistanceFromSun = new Quantity<double, Metre>(2.28e11);

    public static readonly Quantity<double, KiloGram> JupiterMass = new Quantity<double, KiloGram>(1.90e27);
    public static readonly Quantity<double, Metre> JupiterMeanRadius = new Quantity<double, Metre>(6.99e7);
    public static readonly Quantity<double, Second> JupiterOrbitalPeriod = new Quantity<double, Second>(3.74e8);
    public static readonly Quantity<double, Metre> JupiterMeanDistanceFromSun = new Quantity<double, Metre>(7.78e11);

    public static readonly Quantity<double, KiloGram> SaturnMass = new Quantity<double, KiloGram>(5.68e26);
    public static readonly Quantity<double, Metre> SaturnMeanRadius = new Quantity<double, Metre>(5.82e7);
    public static readonly Quantity<double, Second> SaturnOrbitalPeriod = new Quantity<double, Second>(9.29e8);
    public static readonly Quantity<double, Metre> SaturnMeanDistanceFromSun = new Quantity<double, Metre>(1.43e12);

    public static readonly Quantity<double, KiloGram> UranusMass = new Quantity<double, KiloGram>(8.68e25);
    public static readonly Quantity<double, Metre> UranusMeanRadius = new Quantity<double, Metre>(2.54e7);
    public static readonly Quantity<double, Second> UranusOrbitalPeriod = new Quantity<double, Second>(2.65e9);
    public static readonly Quantity<double, Metre> UranusMeanDistanceFromSun = new Quantity<double, Metre>(2.87e12);

    public static readonly Quantity<double, KiloGram> NeptuneMass = new Quantity<double, KiloGram>(1.02e26);
    public static readonly Quantity<double, Metre> NeptuneMeanRadius = new Quantity<double, Metre>(2.46e7);
    public static readonly Quantity<double, Second> NeptuneOrbitalPeriod = new Quantity<double, Second>(5.18e9);
    public static readonly Quantity<double, Metre> NeptuneMeanDistanceFromSun = new Quantity<double, Metre>(4.50e12);

    public static readonly Quantity<double, KiloGram> MoonMass = new Quantity<double, KiloGram>(7.35e22);
    public static readonly Quantity<double, Metre> MoonMeanRadius = new Quantity<double, Metre>(1.74e6);
    public static readonly Quantity<double, Metre> MoonMeanDistanceFromEarth = new Quantity<double, Metre>(384400);

    public static readonly Quantity<double, KiloGram> SunMass = new Quantity<double, KiloGram>(1.989e30);
    public static readonly Quantity<double, Metre> SunMeanRadius = new Quantity<double, Metre>(6.96e8);
}
    
}