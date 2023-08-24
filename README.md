# OBT.Maths
 A library for Maths of all kinds, WIP.
 
 1. [Maths](https://github.com/OpenBrainTrust/OBT.Maths#maths)
   * [Extension Methods](https://github.com/OpenBrainTrust/OBT.Maths#extension-methods)
   * [Constants](https://github.com/OpenBrainTrust/OBT.Maths#constants)
   * [Physics Constants](https://github.com/OpenBrainTrust/OBT.Maths#physics-constants)
 
 2. [MathsF](https://github.com/OpenBrainTrust/OBT.Maths#mathsf) 

## Maths
 Static class so it can be accessed anywhere in your solution.

### Extension Methods
 Extension methods for conversion between float, double, and decimal types. Standard _value.ToType()_ usage. Most constants are stored as a decimal, so these extension methods make it shorter to code the return type you want.
 
 * *ToDouble(decimal)*
 * *ToDouble(float)* 
 * *ToFloat(decimal)*
 * *ToFloat(double)*
 * *ToDecimal(double)*
 * *ToDecimal(float)*
 
 [Top](https://github.com/OpenBrainTrust/OBT.Maths#obtmaths) 

### Constants
 Constants not found in the standard Math or Mathf libraries, stored as decimal for high precision.
 
 | Constant Name         | Symbol              | Constant Name            | Symbol  |
 | --------------------- | ------------------- | ------------------------ | ------- |
 | 1.  Glaisher-Kinkelin | _A_GlaisherKinkelin | 14. Khinchin's           | _L      |
 | 2.  Mills'            | _A_Mills            | 15. Lieb's Square Ice    | _Lieb   |
 | 3.  Feigenbaum Alpha  | _α                  | 16. Meissel-Mertens      | _M      |
 | 4.  Backhouse's       | _B                  | 17. Ramanujan-Soldner    | _μ      |
 | 5.  Landau-Ramanujan  | _b                  | 18. Omega                | _Ω      |
 | 6.  Cahen's           | _C_Cahen            | 19. Universal Parabolic  | _P      |
 | 7.  Porter's          | _C_Porter           | 20. Phi                  | _φ      |
 | 8.  Feigenbaum Delta  | _δ                  | 21. Reciprocal Fibonacci | _ψ      |
 | 9.  Erdős–Borwein     | _E                  | 22. Plastic Number       | _ρ      |
 | 10. Catalan           | _G                  | 23. √2                   | _Root2  |
 | 11. Euler-Mascheroni  | _γ                  | 24. √3                   | _Root3  |
 | 12. Conway's          | _λ_Conway           | 25. √5                   | _Root5  |
 | 13. Golomb-Dickman    | _λ_GolombDickman    | 26. Apéry’s              | _ζ3     |
  
 [Top](https://github.com/OpenBrainTrust/OBT.Maths#obtmaths) 
 
### Physics Constants
 Physics constants, stored as decimal for high precision, excepting Planck Temperature and Planck Time, which use float since the Exponent values are so large. Pulled from the NIST-accepted values, most of the good ones are here.
 
 | Constant Name                             | Symbol                                     |
 | ----------------------------------------- | ------------------------------------------ |
 | 1.   Absolute Zero, Celsius               | AbsZero_C                                  |
 | 2.   Absolute Zero, Fahrenheit            | AbsZero_F                                  |
 | 3.   Absolute Entropy, STP                | AbsoluteEntropy_STP                        |
 | 4.   Absolute Entropy, 1 Atm              | AbsoluteEntropy_Atm                        |
 | 5.   Angstrom Star                        | AngstromStar                               |
 | 6.   Atomic Mass                          | AtomicMass_mu                              |
 | 7.   Avogadro's Number                    | Avogadro_NA                                |
 | 8.   Bohr Magneton                        | BohrMagneton_μB                            |
 | 9.   Bohr Magneton                        | BohrMagnetonIneVPerT_μB                    |
 | 10.  Bohr Radius                          | BohrRadius_a0                              |
 | 11.  Boltzmann                            | Boltzmann_kB                               |
 | 12.  Classical Electron Radius            | ClassicalElectronRadius_re                 |
 | 13.  Conductance Quantum                  | ConductanceQuantum_G0                      |
 | 14.  Conductance Quantum (e^2/Joule)      | ConductanceQuantumIneSquaredPerJoule_G0    |
 | 15.  Coulomb                              | Coulomb_ke                                 |
 | 16.  Deuteron Mass                        | DeuteronMass_md                            |
 | 17.  Efimov Factor                        | EfimovFactor_                              |
 | 18.  Electron G Factor                    | ElectronGFactor_ge                         |
 | 19.  Electron Magnetic Moment             | ElectronMagneticMoment_μe                  |
 | 20.  Electron Mass                        | ElectronMass_me                            |
 | 21.  Electron-Proton Mass Ratio           | ElectronProtonMassRatio_memp               |
 | 22.  Electron-Neutron Mass Ratio          | ElectronNeutronMassRatio_memn              |
 | 23.  Elementary Charge                    | ElementaryCharge_e                         |
 | 24.  Faraday Constant                     | Faraday_F                                  |
 | 25.  Fermi Coupling Constant              | FermiCoupling_GF                           |
 | 26.  Fine Structure Constant              | FineStructure_α                            |
 | 27.  First Radiation Constant             | FirstRadiation_c1                          |
 | 28.  First Radiation Constant (Spectral)  | FirstRadiationSpectral_c1L                 |
 | 29.  Gravitational Constant               | Gravitational_G                            |
 | 30.  Hartree Energy                       | HartreeEnergy_Eh                           |
 | 31.  Hydrogen Mass                        | HydrogenMass_mH                            |
 | 32.  Hyperfine Transition Frequency Cs133 | HyperfineTransitionFrequencyCesium133_ΔνCs |
 | 33.  Inverse Conductance Quantum          | InverseConductanceQuantum_G0Inv            |
 | 34.  Inverse Fine Structure Constant      | InverseFineStructure_αInv                  |
 | 35.  Josephson Constant                   | Josephson_KJ                               |
 | 36.  Loschmidt Constant                   | Loschmidt_n0                               |
 | 37.  Luminous Efficacy (Ideal Source)     | LuminousEfficacy_Kcd                       |
 | 38.  Magnetic Flux Quantum                | MagneticFluxQuantum_Φ0                     |
 | 39.  Magnetic Flux Quantum (e^2/Joule)    | MagneticFluxQuantumIneSquaredPerJoule_Φ0   |
 | 40.  Magnetic Moment of Electron          | MagneticMomentOfElectron_μe                |
 | 41.  Magnetic Moment of Neutron           | MagneticMomentOfNeutron_μn                 |
 | 42.  Magnetic Moment of Proton            | MagneticMomentOfProton_μp                  |
 | 43.  Molar Gas Constant                   | MolarGas_R                                 |
 | 44.  Molar Mass                           | MolarMass_Mu                               |
 | 45.  Molar Mass Of Carbon-12              | MolarMassOfCarbon12_M12C                   |
 | 46.  Molar Planck Constant                | MolarPlanck_NAh                            |
 | 47.  Muon Compton Wavelength              | MuonComptonWavelength_λCμ                  |
 | 48.  Muon Electron Mass Ratio             | MuonElectronMassRatio_mμme                 |
 | 49.  Muon Magnetic Moment                 | MuonMagneticMoment_μμ                      |
 | 50.  Muon Mass                            | MuonMass_mμ                                |
 | 51.  Muon Mass Energy Equivalent          | MuonMassEnergyEquivalent_mμc2              |
 | 52.  Muon Mass Inu                        | MuonMassInu_mμu                            |
 | 53.  Muon Molar Mass                      | MuonMolarMass_Mμ                           |
 | 54.  Molar Volume Of Ideal Gas (Atm)      | MolarVolumeOfIdealGas_Vm_Atm               |
 | 55.  Molar Volume Of Ideal Gas (STP)      | MolarVolumeOfIdealGas_Vm_STP               |
 | 56.  Muon Proton Mass Ratio               | MuonProtonMassRatio_mμmp                   |
 | 57.  Neutron Electron Mass Ratio          | NeutronElectronMassRatio_mnme              |
 | 58.  Neutron Magnetic Moment              | NeutronMagneticMoment_μn                   |
 | 59.  Neutron Proton Mass Ratio            | NeutronProtonMassRatio_mnmp                |
 | 60.  Neutron Mass                         | NeutronMass_mn                             |
 | 61.  Nuclear Magneton                     | NuclearMagneton_μN                         |
 | 62.  Planck Constant                      | Planck_h                                   |
 | 63.  Planck Constant Reduced              | PlanckReduced_ħ                            |
 | 64.  Planck Length                        | PlanckLength_lP                            |
 | 65.  Planck Mass                          | PlanckMass_mP                              |
 | 66.  Planck Temperature                   | PlanckTemperature_TP                       |
 | 67.  Planck Time                          | PlanckTime_tP                              |
 | 68.  Proton Electron Mass Ratio           | ProtonElectronMassRatio_mpme               |
 | 69.  Proton Mass                          | ProtonMass_mp                              |
 | 70.  Proton Neutron Mass Ratio            | ProtonNeutronMassRatio_mpmn                |
 | 71.  Proton Magnetic Moment               | ProtonMagneticMoment_μp                    |
 | 72.  Quantum Of Circulation               | QuantumOfCirculation_Γ                     |
 | 73.  Rydberg Constant                     | Rydberg_Rꚙ                                 |
 | 74.  Rydberg Constant Times C in Hz       | RydbergTimesCinHz_Rꚙc                      |
 | 75.  Rydberg Energy Equivalent            | RydbergEnergyEquivalent_Rꚙhc               |
 | 76.  Rydberg Energy Equivalent in eV      | RydbergEnergyEquivalentIneV_Rꚙhc           |
 | 77.  Second Radiation Constant            | SecondRadiation_c2                         |
 | 78.  Speed Of Light                       | SpeedOfLight_c                             |
 | 79.  Standard Atmosphere                  | StandardAtmosphere_atm                     |
 | 80.  Standard State Pressure              | StandardStatePressure_Pa                   |
 | 81.  Stefan Boltzmann Constant            | StefanBoltzmannConstant_σ                  |
 | 82.  Vacuum Impedance                     | VacuumImpedance_Z0                         |
 | 83.  Vacuum Permeability                  | VacuumPermeability_μ0                      |
 | 84.  Vacuum Permittivity                  | VacuumPermittivity_ε0                      |
 | 85.  Von Klitzing Constant                | VonKlitzingConstant_RK                     |
 | 86.  Weak Mixing Angle                    | WeakMixingAngle_θW                         |
 | 87.  Wien Displacement Constant           | WienDisplacement_b                 |
 
 [Top](https://github.com/OpenBrainTrust/OBT.Maths#obtmaths) 
 
## MathsF
 Library of Maths functions. Static class so it can be accessed anywhere in your solution.
   
 [Top](https://github.com/OpenBrainTrust/OBT.Maths#obtmaths)