# OBT.Maths
 A library for Maths of all kinds, WIP.
 
 * [Maths](https://github.com/OpenBrainTrust/OBT.Maths#maths)
 ..* [Extension Methods](https://github.com/OpenBrainTrust/OBT.Maths#extension-methods)
 ..* [Constants](https://github.com/OpenBrainTrust/OBT.Maths#constants)
 ..* [Physics Constants](https://github.com/OpenBrainTrust/OBT.Maths#physics-constants)
 
 * [MathsF](https://github.com/OpenBrainTrust/OBT.Maths#mathsf) 

## Maths
 Static class so it can be accessed anywhere in your solution.

### Extension Methods
 Extension methods for conversion between float, double, and decimal types. Standard _value.ToType()_ usage.

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
 
### Physics Constants
 Physics constants, stored as decimal for high precision, excepting Planck Temperature and Planck Time, which use float since the Exponent values are so large. Pulled from the NIST-accepted values, most of the good ones are here.
 
 | Constant Name                        | Symbol                                     |
 | ------------------------------------ | ------------------------------------------ |
 | Absolute Zero, Celsius               | AbsZero_C                                  |
 | Absolute Zero, Fahrenheit            | AbsZero_F                                  |
 | Absolute Entropy, STP                | AbsoluteEntropy_STP                        |
 | Absolute Entropy, 1 Atm              | AbsoluteEntropy_Atm                        |
 | Angstrom Star                        | AngstromStar                               |
 | Atomic Mass                          | AtomicMass_mu                              |
 | Avogadro's Number                    | Avogadro_NA                                |
 | Bohr Magneton                        | BohrMagneton_μB                            |
 | Bohr Magneton                        | BohrMagnetonIneVPerT_μB                    |
 | Bohr Radius                          | BohrRadius_a0                              |
 | Boltzmann                            | Boltzmann_kB                               |
 | Classical Electron Radius            | ClassicalElectronRadius_re                 |
 | Conductance Quantum                  | ConductanceQuantum_G0                      |
 | Conductance Quantum (e^2/Joule)      | ConductanceQuantumIneSquaredPerJoule_G0    |
 | Coulomb                              | Coulomb_ke                                 |
 | Deuteron Mass                        | DeuteronMass_md                            |
 | Efimov Factor                        | EfimovFactor_                              |
 | Electron G Factor                    | ElectronGFactor_ge                         |
 | Electron Magnetic Moment             | ElectronMagneticMoment_μe                  |
 | Electron Mass                        | ElectronMass_me                            |
 | Electron-Proton Mass Ratio           | ElectronProtonMassRatio_memp               |
 | Electron-Neutron Mass Ratio          | ElectronNeutronMassRatio_memn              |
 | Elementary Charge                    | ElementaryCharge_e                         |
 | Faraday Constant                     | Faraday_F                                  |
 | Fermi Coupling Constant              | FermiCoupling_GF                           |
 | Fine Structure Constant              | FineStructure_α                            |
 | First Radiation Constant             | FirstRadiation_c1                          |
 | First Radiation Constant (Spectral)  | FirstRadiationSpectral_c1L                 |
 | Gravitational Constant               | Gravitational_G                            |
 | Hartree Energy                       | HartreeEnergy_Eh                           |
 | Hydrogen Mass                        | HydrogenMass_mH                            |
 | Hyperfine Transition Frequency Cs133 | HyperfineTransitionFrequencyCesium133_ΔνCs |
 | Inverse Conductance Quantum          | InverseConductanceQuantum_G0Inv            |
 | Inverse Fine Structure Constant      | InverseFineStructureConstant_αInv          |
 | Josephson Constant                   | Josephson_KJ                               |
 | Loschmidt Constant                   | Loschmidt_n0                               |
 | Luminous Efficacy (Ideal Source)     | LuminousEfficacy_Kcd                       |
 | Magnetic Flux Quantum                | MagneticFluxQuantum_Φ0                     |
 | Magnetic Flux Quantum (e^2/Joule)    | MagneticFluxQuantumIneSquaredPerJoule_Φ0   |
 | Magnetic Moment of Electron          | MagneticMomentOfElectron_μe                |
 | Magnetic Moment of Neutron           | MagneticMomentOfNeutron_μn                 |
 | Magnetic Moment of Proton            | MagneticMomentOfProton_μp                  |
 | Molar Gas Constant                   | MolarGas_R                                 |
 | Molar Mass                           | MolarMass_Mu                               |
 | Molar Mass Of Carbon-12              | MolarMassOfCarbon12_M12C                   |
 | Molar Planck Constant                | MolarPlanckConstant_NAh                    |
 | Muon Compton Wavelength              | MuonComptonWavelength_λCμ                  |
 | Muon Electron Mass Ratio             | MuonElectronMassRatio_mμme                 |
 | Muon Magnetic Moment                 | MuonMagneticMoment_μμ                      |
 | Muon Mass                            | MuonMass_mμ                                |
 | Muon Mass Energy Equivalent          | MuonMassEnergyEquivalent_mμc2              |
 | Muon Mass Inu                        | MuonMassInu_mμu                            |
 | Muon Molar Mass                      | MuonMolarMass_Mμ                           |
 | Molar Volume Of Ideal Gas (Atm)      | MolarVolumeOfIdealGas_Vm_Atm               |
 | Molar Volume Of Ideal Gas (STP)      | MolarVolumeOfIdealGas_Vm_STP               |
 | Muon Proton Mass Ratio               | MuonProtonMassRatio_mμmp                   |
 | Neutron Electron Mass Ratio          | NeutronElectronMassRatio_mnme              |
 | Neutron Magnetic Moment              | NeutronMagneticMoment_μn                   |
 | Neutron Proton Mass Ratio            | NeutronProtonMassRatio_mnmp                |
 | Neutron Mass                         | NeutronMass_mn                             |
 | Nuclear Magneton                     | NuclearMagneton_μN                         |
 | Planck Constant                      | PlanckConstant_h                           |
 | Planck Constant Reduced              | PlanckConstantReduced_ħ                    |
 | Planck Length                        | PlanckLength_lP                            |
 | Planck Mass                          | PlanckMass_mP                              |
 | Planck Temperature                   | PlanckTemperature_TP                       |
 | Planck Time                          | PlanckTime_tP                              |
 | Proton Electron Mass Ratio           | ProtonElectronMassRatio_mpme               |
 | Proton Mass                          | ProtonMass_mp                              |
 | Proton Neutron Mass Ratio            | ProtonNeutronMassRatio_mpmn                |
 | Proton Magnetic Moment               | ProtonMagneticMoment_μp                    |
 | Quantum Of Circulation               | QuantumOfCirculation_Γ                     |
 | Rydberg Constant                     | RydbergConstant_Rꚙ                         |
 | Rydberg Constant Times C in Hz       | RydbergConstantTimesCinHz_Rꚙc              |
 | Rydberg Energy Equivalent            | RydbergEnergyEquivalent_Rꚙhc               |
 | Rydberg Energy Equivalent in eV      | RydbergEnergyEquivalentIneV_Rꚙhc           |
 | Second Radiation Constant            | SecondRadiationConstant_c2                 |
 | Speed Of Light                       | SpeedOfLight_c                             |
 | Standard Atmosphere                  | StandardAtmosphere_atm                     |
 | Standard State Pressure              | StandardStatePressure_Pa                   |
 | Stefan Boltzmann Constant            | StefanBoltzmannConstant_σ                  |
 | Vacuum Impedance                     | VacuumImpedance_Z0                         |
 | Vacuum Permeability                  | VacuumPermeability_μ0                      |
 | Vacuum Permittivity                  | VacuumPermittivity_ε0                      |
 | Von Klitzing Constant                | VonKlitzingConstant_RK                     |
 | Weak Mixing Angle                    | WeakMixingAngle_θW                         |
 | Wien Displacement Constant           | WienDisplacementConstant_b                 |
 
## MathsF
 Library of Maths functions. Static class so it can be accessed anywhere in your solution.