# OBT.Maths
 A library for Maths of all kinds, WIP.

## Maths
 Static class so it can be accessed anywhere in your solution.

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
 
### Extension Methods
 Extension methods for conversion between float, double, and decimal types. Standard _value.ToType()_ usage.
 
### Physics Constants
 Physics constants, stored as decimal for high precision, excepting Planck Temperature and Planck Time, which use float since the Exponent values are so large. Pulled from the NIST-accepted values.
 
 | Constant Name | Symbol |
 | ------------- | ------ |
 | AbsZero | C |
 | AbsZero | F |
 | AbsoluteEntropy | STP |
 | AbsoluteEntropy | Atm |
 | AngstromStar  |
 | AtomicMass | mu | 
 | Avogadro | NA |
 | BohrMagneton | μB |
 | BohrMagnetonIneVPerT | μB |
 | BohrRadius | a0 |
 | Boltzmann | kB |
 | ClassicalElectronRadius | re |
 | ConductanceQuantum | G0 |
 | ConductanceQuantumIneSquaredPerJoule | G0 |
 | Coulomb | ke |
 | DeuteronMass | md |
 | EfimovFactor |   |
 | ElectronGFactor | ge |
 | ElectronMagneticMoment | μe |
 | ElectronMass | me |
 | ElectronProtonMassRatio | memp |
 | ElectronNeutronMassRatio | memn |
 | ElementaryCharge | e |
 | FaradayConstant | F |
 | FermiCouplingConstant | GF |
 | FineStructureConstant | α |
 | FirstRadiationConstant | c1 |
 | FirstRadiationConstantSpectral | c1L |
 | GasConstant | R |
 | GravitationalConstant | G |
 | HartreeEnergy | Eh |
 | HydrogenMass | mH |
 | HyperfineTransitionFrequencyCesium133 | ΔνCs |
 | InverseConductanceQuantum | G0Inv |
 | InverseFineStructureConstant | αInv |
 | JosephsonConstant | KJ |
 | LoschmidtConstant | n0 |
 | LuminousEfficacy | Kcd |
 | MagneticFluxQuantum | Φ0 |
 | MagneticFluxQuantumIneSquaredPerJoule | Φ0 |
 | MagneticMomentOfElectron | μe |
 | MagneticMomentOfNeutron | μn |
 | MagneticMomentOfProton | μp |
 | MolarGasConstant | R |
 
## MathsF
 Library of Maths functions. Static class so it can be accessed anywhere in your solution.