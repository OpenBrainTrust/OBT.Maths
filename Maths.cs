using System;
using UnityEngine;

namespace OBT.Maths {
    public static class Maths {
        #region Mathemagical Constants
        /// <summary>
        /// <para>ζ(3) (Zeta3): Apéry's constant
        /// </para><para>The Apéry's constant, denoted by ζ(3), is a mathematical constant that appears in number theory and mathematical analysis.
        /// </para><para>It is related to the Riemann zeta function evaluated at 3: ζ(3) = 1.20205690315959428539973816151144999…
        /// </para><para>It is the sum of the series 1/1^3 + 1/2^3 + 1/3^3 + 1/4^3 + ...
        /// </para><para>The value of ζ(3) is of great interest in number theory and has connections to various unsolved problems, including the irrationality of certain numbers.
        /// </para><para>Despite being a special value of the Riemann zeta function, Apéry's constant arises naturally in a number of physical problems, including in the second- and third-order terms of the electron's gyromagnetic ratio, computed using quantum electrodynamics.
        /// </para>
        /// </summary>
        public const decimal _Zeta3 = 1.20205690315959428539973816151144999m;

        /// <summary>
        /// <para>B: Backhouse's constant
        /// </para><para>Backhouse's constant, denoted by B, is defined by using the Power Series such that the coefficients of successive terms are the Prime Numbers.
        /// </para><para>It is approximately 1.45607494858268967139959535111654356...
        /// </para>
        /// </summary>
        public const decimal _B = 1.45607494858268967139959535111654356m;

        /// <summary>
        /// <para>C: Cahen's constant
        /// </para><para>Cahen's constant is a mathematical constant that appears in the study of continued fractions and Diophantine approximation.
        /// </para><para>It is approximately 0.643410546288338025182254...
        /// </para><para>Cahen's constant is defined as the value of an infinite series of unit fractions.
        /// </para><para>It is named after Eugène Cahen, a French mathematician who studied continued fractions and Diophantine approximation.
        /// </para>
        /// </summary>
        public const decimal _Cahen = 0.643410546288338025182254m;

        /// <summary>
        /// <para>G: Catalan's constant
        /// </para><para>Catalan's constant G is a mathematical constant with significance in number theory and analysis.
        /// </para><para>It is approximately 0.915965594177219...
        /// </para><para>G appears in various mathematical problems, related to special functions, integrals, and series. 
        /// It's linked to unsolved questions and has applications in scientific fields.
        /// </para>
        /// </summary>
        public const decimal _G = 0.91596559417721901505460351493238411m;

        /// <summary>
        /// <para>λ (Lambda): Conway's constant
        /// </para><para>Conway's constant, denoted by λ, is a mathematical constant that appears in the study of look-and-say sequences.
        /// </para><para>It is approximately 1.30357726903429639125709911215255189...
        /// </para><para>Conway's constant is the unique real root of the cubic polynomial x^3 − x^2 − 2x − 1 = 0.
        /// </para><para>It is named after John Horton Conway, who discovered the connection between the look-and-say sequence and this constant.
        /// </para><para>Conway's constant is also related to the plastic number, which is the unique real root of the cubic polynomial x^3 − x − 1 = 0.
        /// </para>
        /// </summary>
        public const decimal _ConwayLambda = 1.30357726903429639125709911215255189m;

        /// <summary>
        /// <para>E: Erdős–Borwein constant
        /// </para><para>The Erdős–Borwein constant, denoted by E, is the sum of the reciprocals of the Mersenne numbers. The Erdős–Borwein constant is named after mathematicians Paul Erdős and Peter Borwein, who proved that the constant is irrational. Despite its irrationality, the binary representation of the Erdős–Borwein constant may be calculated efficiently.
        /// </para><para>It is approximately 1.60669515241529176378330152319092458...
        /// </para><para>The Erdős–Borwein constant comes up in the average case analysis of the heapsort algorithm, where it controls the constant factor in the running time for converting an unsorted array of items into a heap.
        /// </para>
        /// </summary>
        public const decimal _E = 1.60669515241529176378330152319092458m;

        /// <summary>
        /// <para>γ: Gamma
        /// </para><para>
        /// The Euler-Mascheroni constant, also known as Euler's constant or simply "gamma," is a constant that appears in many problems in analytic number theory and calculus.
        /// </para><para>It is denoted by γ, and the first few digits of this constant are as follows: γ ≈ 0.57721566490153286060651209008240243...
        /// </para><para>
        /// Gamma is strongly related to the natural logarithm function and the harmonic numbers, and is often defined in these terms. There is no closed form expression for the nthnth harmonic number, but gamma can be used to give an estimate of the nth harmonic number. Beyond this, the applications of gamma in mathematics and practical problems are wide and varied.
        /// For as much as gamma has been studied and applied to problems in mathematics, not much is known about the properties of the number itself. It is not known if gamma is algebraic or transcendental. It is not even known if gamma is irrational like other important mathematical constants such as ππ and e.e. 
        /// </para>
        /// </summary>
        public const decimal _Gamma = 0.5772156649015328606065120900824m;

        /// <summary>
        /// <para>α: Alpha
        /// </para><para>Feigenbaum's constant α is a mathematical constant that emerges in the study of chaos theory and bifurcation in dynamical systems.
        /// </para><para>It is approximately 2.50290787509589282228390287321821...
        /// </para><para>The value of α appears as a universal scaling factor in the period-doubling route to chaos and is integral in understanding the transition to chaotic behavior in various nonlinear systems.
        /// Beyond its significance in the field of chaos theory, α connects various mathematical properties and has intriguing relations with other constants.
        /// </para><para>δ: Delta
        /// </para><para>Feigenbaum's constant δ is another mathematical constant closely related to the study of chaos and bifurcation in dynamical systems.
        /// </para><para>It is approximately 4.66920160910299067185320382046620161...
        /// </para><para>The constant δ arises in the context of universality in the period-doubling route to chaos, similar to α. It represents the scaling factor for the horizontal displacement between successive bifurcation points.
        /// Just like α, δ holds implications for understanding the intricate behavior of chaotic systems and has connections to various areas of mathematics.
        /// </para>
        /// </summary>
        public const decimal _Alpha = 2.50290787509589282228390287321821m;

        /// <summary>
        /// <para>δ: Delta
        /// </para><para>Feigenbaum's constant δ is another mathematical constant closely related to the study of chaos and bifurcation in dynamical systems.
        /// </para><para>It is approximately 4.66920160910299067185320382046620161...
        /// </para><para>The constant δ arises in the context of universality in the period-doubling route to chaos, similar to α. It represents the scaling factor for the horizontal displacement between successive bifurcation points.
        /// Just like α, δ holds implications for understanding the intricate behavior of chaotic systems and has connections to various areas of mathematics.
        /// </para>
        /// </summary>
        public const decimal _Delta = 4.66920160910299067185320382046620161m;

        /// <summary>
        /// <para>A: Glaisher-Kinkelin constant
        /// </para><para> The Glaisher–Kinkelin constant A is a mathematical constant occurring in the asymptotic expansion of the partition function, which counts the number of ways of writing a positive integer as a sum of positive integers. It is named after James Whitbread Lee Glaisher and Joseph Kinkelin.
        /// </para><para>The constant is approximately 1.28242712910062263687534256886979172...
        /// </para><para>The Glaisher–Kinkelin constant is related to the Dedekind eta function by the formula η(i) = eπ√(2/3) / (2π)^(1/4) / Γ(1/4) / Γ(3/4) / ζ(3/2) / A, where A is the Glaisher–Kinkelin constant.
        /// </para><para>The Glaisher–Kinkelin constant is also related to the Barnes G-function by the formula G(1) = 2π^(1/4) / Γ(1/4) / Γ(3/4) / A.
        /// </para>
        /// </summary>
        public const decimal _A = 1.28242712910062263687534256886979172m;

        /// <summary>
        /// <para>λ (Lambda): Golomb-Dickman constant
        /// </para><para>The Golomb-Dickman constant λ is a mathematical constant that arises in the study of combinatorics and number theory.
        /// </para><para>It is approximately 0.62432998854355087099293638310083724...
        /// </para><para>The Golomb-Dickman constant is related to the Dickman function ρ(x) and the Riemann zeta function ζ(s) by the formula ρ(x) = ζ(λ) / ζ(λ + 1).
        /// </para>
        /// </summary>
        public const decimal _GolombDickmanLambda = 0.62432998854355087099293638310083724m;

        /// <summary>
        /// <para>K0: Khinchin's constant
        /// </para><para>Khinchin's constant K is a mathematical constant that arises in the study of continued fractions and plays a role in the modern formulation of the law of large numbers.
        /// </para><para>Khinchin's constant is approximately 2.68545200106530644530971483548179569...
        /// </para><para>Khinchin proved that for almost all real numbers, the sequence of partial quotients of its continued fraction representation tends to K in the mean.
        /// </para>
        /// </summary>
        public const decimal _K0 = 2.68545200106530644530971483548179569m;

        /// <summary>
        /// <para>b: Landau-Ramanujan constant
        /// </para><para>The Landau–Ramanujan constant is a mathematical constant occurring in the asymptotic expansion of the partition function, which counts the number of ways of writing a positive integer as a sum of positive integers. It is named after Edmund Landau and Srinivasa Ramanujan.
        /// </para><para>The constant is approximately 0.76422365358922066299069873125009232...
        /// </para><para>The Landau–Ramanujan constant is related to the Dedekind eta function by the formula η(i) = eπ√(2/3) / (2π)^(1/4) / Γ(1/4) / Γ(3/4) / ζ(3/2) / Λ, where Λ is the Landau–Ramanujan constant.
        /// </para>
        /// </summary>
        public const decimal _b = 0.76422365358922066299069873125009232m;

        /// <summary>
        /// <para>Lieb's square ice constant
        /// </para><para>Lieb's square ice constant is a mathematical constant occurring in the study of the square ice model in statistical mechanics. It is named after Elliott Lieb.
        /// </para><para>The constant is approximately 1.539600717839002038691063...
        /// </para><para>It is used in the field of combinatorics to quantify the number of Eulerian orientations of grid graphs.
        /// </para>
        /// </summary>
        public const decimal _LiebSquareIce = 1.539600717839002038691063m;

        /// <summary>
        /// <para>M: Meissel-Mertens constant
        /// </para><para>The Meissel–Mertens constant M is a mathematical constant occurring in the asymptotic expansion of the prime-counting function, which counts the number of prime numbers less than a given number. It is named after Ernst Meissel and Franz Mertens.
        /// </para><para>The constant is approximately 0.26149721284764278375542683860869585...
        /// </para><para>It is defined as the limiting difference between the harmonic series summed only over the prime numbers and the natural logarithm of the natural logarithm function, or equivalently as the limiting difference between the sum of the reciprocals of the prime numbers and the natural logarithm of the natural logarithm function.
        /// </para>
        /// </summary>
        public const decimal _M = 0.26149721284764278375542683860869585m;

        /// <summary>
        /// <para>A: Mills' constant
        /// </para><para>Mills' constant A is a mathematical constant occurring in a certain theorem about prime numbers that are generated by a deterministic finite-state machine. It is named after William H. Mills who proved in 1947 the existence of such a constant.
        /// </para><para>The constant is approximately 1.30637788386308069046861449260260571...
        /// </para><para>The theorem states that there is a positive real number A such that ⌊A^(3^n)⌋ is a prime number for all positive integers n. The smallest such A is given by Mills' constant.
        /// </para>
        /// </summary>
        public const decimal _MillsA = 1.30637788386308069046861449260260571m;

        /// <summary>
        /// <para>φ: Phi
        /// </para><para>The golden ratio Phi, often denoted by the Greek letter φ (phi), is a mathematical constant that appears in various fields of science, art, and nature.
        /// </para><para>It is defined as the positive solution to the quadratic equation x = 1 + 1/x, and its approximate value is φ ≈ 1.6180339887498948482045868343656...
        /// </para><para>The golden ratio is known for its aesthetic properties and has been used in art and architecture for centuries. It appears in the proportions of natural objects, such as the spirals in seashells and the arrangement of leaves on stems.
        /// Phi is also closely related to the Fibonacci sequence, where the ratio of consecutive Fibonacci numbers approaches Phi as the sequence progresses.
        /// Beyond its visual appeal, Phi has intriguing connections in mathematics, including its appearance in the solution to the quadratic equation, continued fractions, and various geometric shapes.
        /// </para>
        /// </summary>
        public const decimal _Phi = 1.6180339887498948482045868343656m;

        /// <summary>
        /// <para>ρ (Rho): Plastic number
        /// </para><para>The plastic number ρ is a mathematical constant that is the unique real solution of the cubic equation x^3 = x + 1. A plastic number is also known as the plastic constant, the minimal Pisot number, the platin number, the silver number, the bronze number, or the octonacci constant.
        /// </para><para>The constant is approximately 1.32471795724474602596090885447809734...
        /// </para><para>The plastic number is also known as the minimal Pisot number, because it is the smallest Pisot number. It is also the smallest possible Pisot–Vijayaraghavan number, and the smallest possible Pisot–Erdős number.
        /// </para><para>It is used in the plastic number base, a non-standard positional numeral system, for its good irrationality properties.
        /// </para>
        /// </summary>
        public const decimal _Rho = 1.32471795724474602596090885447809734m;

        /// <summary>
        /// <para>Porter's constant
        /// </para><para>Porter's constant is the constant appearing in formulas for the efficiency of the Euclidean algorithm.
        /// </para><para>It is approximately 1.467078079433975472897798...
        /// </para>
        /// </summary>
        public const decimal _C = 1.467078079433975472897798m;

        /// <summary>
        /// <para>Ω: Omega
        /// </para><para>Omega is the unique real number such that e^Ω = Ω + 1. It is also called the infinite thorn, since it is an infinitely large number that is also infinitely close to zero.
        /// </para><para>Omega is approximately 0.56714329040978387299996866221035555...
        /// </para><para>Omega is the limit of the sequence x_0 = 0, x_(n+1) = e^(-x_n), which converges to Omega for any starting value x_0 > -1.
        /// </para><para>Omega is also the unique fixed point of the Lambert W function, which is defined as the inverse of the function f(x) = xe^x.
        /// </para>
        /// </summary>
        public const decimal _Omega = 0.56714329040978387299996866221035555m;

        /// <summary>
        /// <para>μ (Mu): Ramanujan-Soldner constant
        /// </para><para>The Ramanujan–Soldner constant μ is a mathematical constant that is defined as the unique positive zero of the logarithmic integral function. It is named after Srinivasa Ramanujan and Johann Georg von Soldner.
        /// </para><para>The constant is approximately 1.45136923488338105028396848589202744...
        /// </para><para>The Ramanujan-Soldner constant is used for solving Lambert's problem in orbital mechanics, which is the problem of determining the time of flight to move between two points in space, given the positions and velocities at those two points.
        /// </para>
        /// </summary>
        public const decimal _Mu = 1.45136923488338105028396848589202744m;

        /// <summary>
        /// <para>ψ (Psi): Reciprocal Fibonacci constant
        /// </para><para>The reciprocal Fibonacci constant ψ is a mathematical constant defined as the sum of the reciprocals of the Fibonacci numbers.
        /// </para><para>The constant is approximately 3.35988566624317755317201130291892718...
        /// </para><para>The ratio of the successive terms tends to the reciprocal of the Golden Ratio.
        /// </para>
        /// </summary>
        public const decimal _Psi = 3.35988566624317755317201130291892718m;

        /// <summary>
        /// <para>√2: The Square Root of 2
        /// </para><para>The Square Root of 2 is the length of the hypotenuse of a right triangle with unit base and altitude, denoted mathematically as √2 or 2^(1/2). It has been proved that √2 is irrational.
        /// </para><para>It is also known as Pythagoras' constant, named after the ancient Greek mathematician.
        /// </para><para>It is approximately 1.41421356237309504880168872420969808...
        /// </para><para>The fraction √2/2 is the probability that, when two integers are chosen at random, they have no common divisors (other than 1). The square root of 2 is also the central value in the Gaussian distribution.
        /// </para>
        /// </summary>
        public const decimal _Root2 = 1.41421356237309504880168872420969808m;

        /// <summary>
        /// <para>√3: The Square Root of 3
        /// </para><para>The Square Root of 3 is the length of the diagonal of a cube with unit sides, and is the highest number which is the hypotenuse of two right-angled triangles with unit sides.
        /// </para><para>It is approximately 1.73205080756887729352744634150587236...
        /// </para><para>It is also known as Theodorus' constant, named after Theodorus of Cyrene, a Greek philosopher and mathematician.
        /// </para><para>The square root of 3 is also the central value in the Cauchy distribution.
        /// </para><para>√3 is the probability that, when three integers are chosen at random, they have no common divisors (other than 1).
        /// </para>
        /// </summary>
        public const decimal _Root3 = 1.73205080756887729352744634150587236m;

        /// <summary>
        /// <para>√5: The Square Root of 5
        /// </para><para>The Square Root of 5 is the length of the hypotenuse of right-angled triangles with unit sides 1 and 2.
        /// </para><para>It is approximately 2.23606797749978969640917366873127623...
        /// </para><para>This number appears in the expression for the golden ratio, and is also equal to the reciprocal of the golden ratio minus 1.
        /// </para>
        /// </summary>
        public const decimal _Root5 = 2.23606797749978969640917366873127623m;

        /// <summary>
        /// <para>P: Universal Parabolic Constant
        /// </para><para>The Universal Parabolic Constant is defined as the ratio, for any parabola, of the arc length of the parabolic segment formed by the latus rectum to the focal parameter.
        /// </para><para>It is approximately 2.29558714939263807403429804918949039...
        /// </para><para>The circle and parabola are unique among conic sections in that they have a universal constant. The analogous ratios for ellipses and hyperbolas depend on their eccentricities. This means that all circles are similar and all parabolas are similar, whereas ellipses and hyperbolas are not.
        /// </para>
        /// </summary>
        public const decimal _P = 2.29558714939263807403429804918949039m;
        #endregion

        #region ExtensionMethods
        /// <summary>
        /// Converts a decimal value to a double precision floating point value.
        /// </summary>
        /// <param name="value">The decimal value to convert.</param>        
        /// <returns>A double precision floating point value.</returns>
        public static double ToDouble( this decimal value ) {
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Converts a float value to a double precision floating point value.
        /// </summary>
        /// <param name="value">The float value to convert.</param>
        /// <returns>A double precision floating point value.</returns>
        public static double ToDouble( this float value ) {
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Converts a decimal value to a float value.
        /// </summary>
        /// <param name="value">The decimal value to convert.</param>
        /// <returns>A single precision floating point value.</returns>
        public static float ToFloat( this decimal value ) {
            return Convert.ToSingle(value);
        }

        /// <summary>
        /// Converts a double precision floating point value to a single precision floating point value.
        /// </summary>
        /// <param name="value">The double to convert.</param>
        /// <returns>A single precision floating point value.</returns>
        public static float ToFloat( this double value ) {
            return Convert.ToSingle(value);
        }

        /// <summary>
        /// Converts a double precision floating point value to a decimal.
        /// </summary>
        /// <param name="value">The double to convert.</param>
        /// <returns>A decimal value.</returns>
        public static decimal ToDecimal( this double value ) {
            return Convert.ToDecimal(value);
        }

        /// <summary>
        /// Converts a single precision floating point value to a decimal.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>A decimal value.</returns>
        public static decimal ToDecimal( this float value ) {
            return Convert.ToDecimal(value);
        }
        #endregion

        #region Physics-Related
        /// <summary>
        /// Physics Constants.
        /// </summary>
        public static class Physics {
            // Re: NIST Constants (2014)
            // The NIST constants are a set of fundamental physical constants maintained by the National Institute of Standards and Technology (NIST). They are recommended for international use by CODATA.
            // Others are also included here.

            /// <summary>
            /// <para>Absolute Zero: Celsius
            /// </para><para>Absolute zero is the lowest limit of the thermodynamic temperature scale, a state at which the enthalpy and entropy of a cooled ideal gas reach their minimum value, taken as 0.
            /// </para><para>The fundamental particles of nature have minimum vibrational motion, retaining only quantum mechanical, zero-point energy-induced particle motion.
            /// </para><para>The theoretical temperature is determined by extrapolating the ideal gas law; by international agreement, absolute zero is taken as −273.15° on the Celsius scale (International System of Units), which equals −459.67° on the Fahrenheit scale (United States customary units or Imperial units).
            /// </para><para>The corresponding Kelvin and Rankine temperature scales set their zero points at absolute zero by definition.
            /// </para><para>It is approximately −273.15 °C or −459.67 °F.
            /// </para>
            /// </summary>
            public const float AbsZero_C = -273.15f;

            /// <summary>
            /// <para>Absolute Zero: Fahrenheit
            /// </para><para>Absolute zero is the lowest limit of the thermodynamic temperature scale, a state at which the enthalpy and entropy of a cooled ideal gas reach their minimum value, taken as 0.
            /// </para><para>The fundamental particles of nature have minimum vibrational motion, retaining only quantum mechanical, zero-point energy-induced particle motion.
            /// </para><para>The theoretical temperature is determined by extrapolating the ideal gas law; by international agreement, absolute zero is taken as −273.15° on the Celsius scale (International System of Units), which equals −459.67° on the Fahrenheit scale (United States customary units or Imperial units).
            /// </para><para>The corresponding Kelvin and Rankine temperature scales set their zero points at absolute zero by definition.
            /// </para><para>It is approximately −273.15 °C or −459.67 °F.
            /// </para>
            /// </summary>
            public const float AbsZero_F = -459.67f;

            /// <summary>
            /// <para>Absolute Entropy: Standard Temperature and Pressure
            /// </para><para>The absolute entropy of a thermodynamic system is the sum of the entropy of the system and the ideal gas entropy of the surroundings divided by the temperature of the surroundings.
            /// </para><para>It is approximately -1.15170753706 at STP.
            /// </para>
            /// </summary>
            public const decimal AbsoluteEntropy_STP = -1.15170753706m;

            /// <summary>
            /// <para>Absolute Entropy: At 1 Atmosphere
            /// </para><para>The absolute entropy of a thermodynamic system is the sum of the entropy of the system and the ideal gas entropy of the surroundings divided by the temperature of the surroundings.
            /// </para><para>It is approximately -1.16487052358 at 1 Atmosphere.
            /// </para>
            /// </summary>
            public const decimal AbsoluteEntropy_Atm = -1.16487052358m;

            /// <summary>
            /// <para>Angstrom Star
            /// </para><para>The Angstrom star is a unit of length used to measure distances within the atom.
            /// </para><para>It is approximately 1.00001495×10^−10 m.
            /// </para><para>The Angstrom is a non-SI unit of length equal to 10^−10 m (one ten-billionth of a meter) or 0.1 nanometer.
            /// </para>
            /// </summary>
            public const decimal AngstromStar = 1.00001495e-10m;

            /// <summary>
            /// <para>Atomic Mass Constant
            /// </para><para>The atomic mass constant, denoted mu, is a physical constant, equal to one twelfth of the mass of an unbound atom of carbon-12 in its nuclear and electronic ground state.
            /// </para><para>It is approximately 1.66053906660×10^−27 kg.
            /// </para>
            /// </summary>
            public const decimal AtomicMass_mu = 1.66053906660e-27m;

            /// <summary>
            /// <para>Avogadro Constant
            /// </para><para>The Avogadro constant is the number of constituent particles, usually atoms or molecules, that are contained in the amount of substance given by one mole.<br></br>
            /// It is the proportionality factor that relates the molar mass of a substance to the mass of a sample, is designated with the symbol NA or L, and has the value 6.022140857(74)×10^23 mol−1 in the International System of Units (SI).
            /// </para><para>The Avogadro constant is named after the early 19th-century Italian scientist Amedeo Avogadro, who, in 1811, first proposed that the volume of a gas (at a given pressure and temperature) is proportional to the number of atoms or molecules regardless of the nature of the gas.
            /// </para><para>It is approximately 6.022140857×10^23 mol−1.
            /// </para>The Avogadro constant is a scaling factor between macroscopic and microscopic observations of nature.<br></br>
            /// As such, it provides the relationship between other physical constants and properties. For example, it provides the relationship between the gas constant R and the Boltzmann constant kB.<br></br>
            /// A related quantity is the molar volume of a substance, which is the volume of one mole of any substance, usually a gas, at standard temperature and pressure (STP).<br></br>
            /// It may be calculated as the substance's molar mass divided by its density. The volume of a mole of a substance is called the molar volume of that substance.
            /// </summary>
            public const decimal Avogadro = 602214108979663699470280m;

            /// <summary>
            /// <para>Bohr Magneton
            /// </para><para>The Bohr magneton is a physical constant and the natural unit for expressing the magnetic moment of an electron caused by either its orbital or spin angular momentum. 
            /// </para><para>Bohr magneton is defined in SI units by μB = eħ / 2me, where e is the elementary charge, ħ is the reduced Planck constant, and me is the electron rest mass.
            /// </para><para>The value of the Bohr magneton is approximately 9.274009994e-24 J/T or 5.7883818012e-5 eV/T.
            /// </para>
            /// </summary>
            public const decimal BohrMagneton_μB = 927.4009994e-26m;

            /// <summary>
            /// <para>Bohr Magneton in eV/T
            /// </para>
            /// </summary>
            public const decimal BohrMagnetonIneVPerT = 5.7883818012e-5m;

            /// <summary>
            /// <para>Bohr Radius
            /// </para><para>The Bohr radius is a physical constant, approximately equal to the most probable distance between the nucleus and the electron in a hydrogen atom in its ground state.<br></br>
            /// It is named after Niels Bohr, due to its role in the Bohr model of an atom.
            /// </para><para>The Bohr radius is defined as a0 = ħ / (αme), where ħ is the reduced Planck constant, α is the fine-structure constant, and me is the electron rest mass.
            /// </para><para>The value of the Bohr radius is approximately 5.29177210903e-11 m.
            /// </para><para>The Bohr radius is one of the most widely known constants in atomic physics. It is related to the Rydberg constant and the Rydberg unit of energy.
            /// </para>
            /// </summary>
            public const decimal BohrRadius_a0 = 5.29177210903e-11m;

            /// <summary>
            /// <para>kB: Boltzmann Constant
            /// </para><para>The Boltzmann constant, which is named after Ludwig Boltzmann, is a physical constant relating the average kinetic energy of particles in a gas with the temperature of the gas.<br></br>
            /// <para>It is the gas constant R divided by the Avogadro constant NA: k = R / NA
            /// </para><para>It is approximately 1.38064852×10−23 J/K.
            /// </para><para>The Boltzmann constant has the dimension energy divided by temperature, the same as entropy.
            /// </para><para>In principle, the Boltzmann constant is not needed, because it is redundant with the Boltzmann distribution factor kT/h, where h is the Planck constant, and the Kelvin temperature T.
            /// </para><para>However, the factor k/h is usually very small, on the order of 10−10 eV/K, so it is convenient to simply use k.
            /// </para><para>In statistical mechanics, the Boltzmann constant is often called simply Boltzmann, and is denoted kB or kB.
            /// </para>
            /// </summary>
            public const decimal Boltzmann_kB = 1.38064852e-23m;

            /// <summary>
            /// <para>Classical Electron Radius
            /// </para><para>The classical electron radius, also known as the classical Thomson scattering cross section, is a combination of fundamental physical quantities that define a length scale for problems involving scattering of electromagnetic radiation by charged particles such as electrons.
            /// </para><para>It is equal to about 2.8179403227e-15 m.
            /// </para><para>The classical electron radius is given by re = ke^2 / (4πε0me c^2), where ke is Coulomb's constant, e is the elementary charge, ε0 is the electric constant, me is the electron rest mass, and c is the speed of light in vacuum.
            /// </para><para>The classical electron radius is also known as the Thomson scattering length.
            /// </para>
            /// </summary>
            public const decimal ClassicalElectronRadius_re = 2.8179403227e-15m;

            /// <summary>
            /// <para>Conductance Quantum
            /// </para><para>The conductance quantum is the quantized version of electrical conductance. It is defined as the conductance of a metallic wire in the limit of low temperatures and long wires (compared to the electron mean free path) approaching the quantum regime.
            /// </para><para>It is equal to approximately 7.7480917310e-5 S.
            /// </para><para>The conductance quantum is given by G0 = 2e^2 / h, where e is the elementary charge and h is the Planck constant.
            /// </para><para>The conductance quantum is also known as the von Klitzing constant.
            /// </para>
            /// </summary>
            public const decimal ConductanceQuantum_G0 = 7.7480917310e-5m;

            /// <summary>
            /// <para>Conductance Quantum in e^2/h
            /// </para>
            /// </summary>
            public const decimal ConductanceQuantumIneSquaredPerJoule = 7.7480917310e-5m;

            /// <summary>
            /// <para>Coulomb Constant
            /// </para><para>The Coulomb constant, the electric force constant, or the electrostatic constant (denoted ke, k or K) is a proportionality constant in electrostatics equations.<br></br>
            /// It is named after Charles-Augustin de Coulomb, who introduced Coulomb's law.
            /// </para><para>In SI units it is equal to 8.9875517923e9 kg⋅m^3⋅s−4⋅A−2.
            /// </para><para>The Coulomb constant is given by ke = 1 / (4πε0), where ε0 is the electric constant.
            /// </para>
            /// </summary>
            public const decimal Coulomb_ke = 8.9875517873681764e9m;

            /// <summary>
            /// <para>Deuteron Mass
            /// </para><para>The deuteron is one of two stable nuclides of the chemical element hydrogen (the other being protium, or hydrogen-1).
            /// </para><para>The deuteron has a mass of 3.343583719e-27 kg. It is given by md = 2mp + mn − me, where mp is the proton rest mass, mn is the neutron rest mass, and me is the electron rest mass.
            /// </para><para>The deuteron is made up of one proton and one neutron, whereas the much more common hydrogen isotope, protium, has no neutrons in the nucleus.<br></br>
            /// The deuteron is frequently used as a target for accelerators that produce neutrons, protons, and other positively charged ions in nuclear physics experiments.<br></br>
            /// The deuteron was discovered and named in 1932 by Ernest Rutherford, who distinguished it from the proton by its mass, and from the alpha particle by its lack of charge.
            /// </para>
            /// </summary>
            public const decimal DeuteronMass_md = 3.343583719e-27m;

            /// <summary>
            /// <para>Efimov Factor
            /// </para><para>The Efimov factor is a dimensionless constant that appears in the Efimov effect, a quantum mechanical phenomenon in which three identical bosons interact in such a way that two of them bind together to form a loosely bound dimer, and the third particle orbits around this dimer at large distance.
            /// </para><para>The Efimov factor is equal to approximately 22.7.
            /// </para><para>The Efimov factor is given by 22.7 = exp(π / (2η)), where η is the Efimov parameter.
            /// </para>
            /// </summary>
            public const decimal EfimovFactor = 22.7m;

            /// <summary>
            /// <para>Electron G Factor
            /// </para><para>The electron g factor is the ratio of two magnetic moments associated with electron spin and electron orbital angular momentum, respectively.
            /// </para><para>It is equal to approximately 2.00231930436182.
            /// </para><para>The electron g factor is given by ge = 2 + α / (2π), where α is the fine-structure constant.
            /// </para>
            /// </summary>
            public const decimal ElectronGFactor_ge = 2.00231930436182m;

            /// <summary>
            /// <para>Electron Magnetic Moment
            /// </para><para>The electron magnetic moment, or more specifically the electron magnetic dipole moment, is the magnetic moment of an electron caused by its intrinsic properties of spin and electric charge.
            /// </para><para>It is equal to approximately −9.284764e-24 J⋅T−1.
            /// </para><para>The electron magnetic moment is given by μe = −geμB, where ge is the electron g factor and μB is the Bohr magneton.
            /// </para>
            /// </summary>
            public const decimal ElectronMagneticMoment_μe = -9.284764e-24m;

            /// <summary>
            /// <para>Electron Mass
            /// </para><para>The electron mass (symbol: me) is the mass of an electron.
            /// </para><para>It is equal to approximately 9.10938356e-31 kg.
            /// </para><para>The electron mass is given by me = m(12C) / 12, where m(12C) is the mass of a carbon-12 atom.
            /// </summary>
            public const decimal ElectronMass_me = 9.10938356e-31m;

            /// <summary>
            /// <para>Electron-Proton Mass Ratio
            /// </para><para>The electron-proton mass ratio, denoted by me/mp, is the ratio of the mass of an electron to the mass of a proton.
            /// </para>
            /// </summary>
            public const decimal ElectronProtonMassRatio_memp = 5.446170214876324e-4m;

            /// <summary>
            /// <para>Electron-Neutron Mass Ratio
            /// </para><para>The electron-neutron mass ratio, denoted by me/mn, is the ratio of the mass of an electron to the mass of a neutron.
            /// </para>
            /// </summary>
            public const decimal ElectronNeutronMassRatio_memn = 5.438673442386003e-4m;

            /// <summary>
            /// <para>Elementary Charge
            /// </para><para>The elementary charge, usually denoted as e or sometimes qe, is the electric charge carried by a single proton, or equivalently, the magnitude of the electric charge carried by a single electron, which has charge −1 e.
            /// </para><para>It is equal to approximately 1.6021766208e-19 C.
            /// </para><para>The elementary charge is given by e = |e|, where e is the elementary charge.
            /// </summary>
            public const decimal ElementaryCharge_e = 1.6021766208e-19m;

            /// <summary>
            /// <para>Faraday Constant
            /// </para><para>The Faraday constant, denoted by the symbol F and sometimes stylized as ℱ, is named after Michael Faraday.
            /// </para><para>It is equal to approximately 96485.33289 C⋅mol−1.
            /// </para><para>The Faraday constant is given by F = eNA, where e is the elementary charge and NA is the Avogadro constant.
            /// </summary>
            public const decimal FaradayConstant_F = 96485.33289m;

            /// <summary>
            /// <para>Fermi Coupling Constant
            /// </para><para>The Fermi coupling constant, usually denoted by GF, is a dimensionless constant characterizing the strength of the weak interaction.
            /// </para><para>It is equal to approximately 1.1663787e-5 GeV−2.
            /// </para><para>The Fermi coupling constant is given by GF = (hbar c)^3 / (4πv^2), where hbar is the reduced Planck constant, c is the speed of light in vacuum, and v is the Higgs vacuum expectation value.
            /// </para>
            /// </summary>
            public const decimal FermiCouplingConstant_GF = 1.1663787e-5m;

            /// <summary>
            /// <para>Fine Structure Constant
            /// </para><para>The fine-structure constant, also known as Sommerfeld's constant, commonly denoted by α (the Greek letter alpha), is a fundamental physical constant characterizing the strength of the electromagnetic interaction between elementary charged particles.
            /// </para><para>It is equal to approximately 7.2973525693e-3.
            /// </para><para>The fine-structure constant is given by α = e^2 / (4πε0ħc), where e is the elementary charge, ε0 is the electric constant, ħ is the reduced Planck constant, and c is the speed of light in vacuum.
            /// </para>
            /// </summary>
            public const decimal FineStructureConstant_α = 7.2973525693e-3m;

            /// <summary>
            /// <para>First Radiation Constant
            /// </para><para>The first radiation constant, also known as the Wien wavelength displacement law constant, is a physical constant relating the temperature of a black body to the wavelength at which it emits the most electromagnetic radiation.
            /// </para><para>It is equal to approximately 2.8977729e-3 m⋅K.
            /// </para><para>The first radiation constant is given by c1 = 2πhc^2, where h is the Planck constant and c is the speed of light in vacuum.
            /// </para>
            /// </summary>
            public const decimal FirstRadiationConstant_c1 = 3.741771790e-16m;

            /// <summary>
            /// <para>First Radiation Constant for Spectral Radiance
            /// </para><para>The first radiation constant for spectral radiance, also known as the first radiation constant for spectral radiance, is a physical constant relating the temperature of a black body to the wavelength at which it emits the most electromagnetic radiation.
            /// </para><para>It is equal to approximately 1.191042953e-16 m⋅K
            /// </para><para>The first radiation constant for spectral radiance is given by c1L = 2πhc^2, where h is the Planck constant and c is the speed of light in vacuum.
            /// </para><para>It was introduced by Max Planck in 1900, who proved that the spectral radiance of a body at absolute temperature T is given by Bλ(T) = c1Lλ−5 / (e^(c2 / (λT)) − 1), where c1L is the first radiation constant for spectral radiance, c2 is the second radiation constant for spectral radiance, λ is the wavelength, and T is the absolute temperature.
            /// </para>
            /// </summary>
            public const decimal FirstRadiationConstantSpectral_c1L = 1.191042953e-16m;

            /// <summary>
            /// <para>Gas Constant
            /// </para><para>The gas constant (also known as the molar, universal, or ideal gas constant, denoted by the symbol R or R) is a physical constant which is featured in many fundamental equations in the physical sciences, such as the ideal gas law and the Nernst equation.
            /// </para><para>It is equal to approximately 8.3144598 J⋅K−1⋅mol−1.
            /// </para><para>The gas constant is given by R = NAk, where NA is the Avogadro constant and k is the Boltzmann constant.
            /// </para>
            /// </summary>
            public const decimal GasConstant_R = 8.3144598m;

            /// <summary>
            /// <para>Gravitational Constant
            /// </para><para>The gravitational constant, usually denoted by the letter G, is an empirical physical constant involved in the calculation of gravitational effects in Sir Isaac Newton's law of universal gravitation and in Albert Einstein's general theory of relativity.
            /// </para><para>It is equal to approximately 6.67408e-11 m^3⋅kg−1⋅s−2.
            /// </para><para>The gravitational constant is given by G = (c^2 / 4πG)1/2, where c is the speed of light in vacuum and G is the Newtonian constant of gravitation.
            /// </para>
            /// </summary>
            public const decimal GravitationalConstant_G = 6.67408e-11m;

            /// <summary>
            /// <para>Hartree Energy: Joules
            /// </para><para>The Hartree energy, usually denoted by the symbol Eh, is the energy unit used in atomic physics.
            /// </para><para>It is equal to approximately 4.3597447222071e-18 J.
            /// </para><para>The Hartree energy is given by Eh = 2R∞hc, where R∞ is the Rydberg constant for infinite mass, h is the Planck constant, and c is the speed of light in vacuum.
            /// </para>
            /// </summary>
            public const decimal HartreeEnergy_Eh = 4.3597447222071e-18m;

            /// <summary>
            /// <para>Hydrogen Mass
            /// </para><para>The hydrogen mass, usually denoted by the symbol mH, is the mass of a hydrogen atom.
            /// </para><para>It is equal to approximately 1.673823232e-27 kg. 
            /// </para><para>The hydrogen mass is given by mH = mN / 1.00782503223, where mN is the neutron mass.
            /// </para><para>The value was first measured by Francis William Aston in 1927, who used a mass spectrograph to determine the relative masses of hydrogen and oxygen atoms.
            /// </para>
            /// </summary>
            public const decimal HydrogenMass_mH = 1.673823232e-27m;

            /// <summary>
            /// <para>Hyperfine Transition Frequency Cesium 133
            /// </para><para>The hyperfine transition frequency of cesium-133, usually denoted by the symbol ΔνCs, is the frequency of the hyperfine transition of the ground state of the cesium-133 atom.<br></br>
            /// Hyperfine transition is the splitting of the energy levels of atoms by the magnetic dipole-dipole interaction between the nuclear spin and the electronic spin.
            /// </para><para>It is equal to approximately 9192631770 Hz.
            /// </para><para>The hyperfine transition frequency of cesium-133 is given by ΔνCs = 2R∞hc / (1 + mN / mH), where R∞ is the Rydberg constant for infinite mass, h is the Planck constant, c is the speed of light in vacuum, mN is the neutron mass, and mH is the hydrogen mass.
            /// </para><para>The value was first measured by Louis Essen and Jack Parry in 1955, who used a caesium atomic clock to determine the frequency of the hyperfine transition of the ground state of the cesium-133 atom.
            /// </para>
            /// </summary>
            public const decimal HyperfineTransitionFrequencyCesium133_ΔνCs = 9192631770m;

            /// <summary>
            /// <para>Inverse Conductance Quantum
            /// </para><para>The inverse conductance quantum, usually denoted by the symbol G0^-1, is a physical constant relating to conductance.
            /// </para><para>It is equal to approximately 12906.4037278 Ω.
            /// </para>
            /// </summary>
            public const decimal InverseConductanceQuantum_G0Inv = 12906.4037278m;

            /// <summary>
            /// <para>Inverse Fine Structure Constant
            /// </para><para>The inverse fine-structure constant, usually denoted by the symbol α^-1, is a dimensionless physical constant characterizing the strength of the electromagnetic interaction between elementary charged particles.
            /// </para><para>It is equal to approximately 137.035999084.
            /// </para><para>The inverse fine-structure constant is given by α^-1 = 4πε0ħc / e^2, where ε0 is the electric constant, ħ is the reduced Planck constant, c is the speed of light in vacuum, and e is the elementary charge.
            /// </para>
            /// </summary>
            public const decimal InverseFineStructureConstant_αInv = 137.035999084m;

            /// <summary>
            /// <para>Josephson Constant
            /// </para><para>The Josephson constant, usually denoted by the symbol KJ, is a physical constant relating to the Josephson effect discovered by the British physicist Brian David Josephson.
            /// </para><para>It is equal to approximately 483597.8525 GHz⋅V−1.
            /// </para><para>The Josephson constant is given by KJ = 2e / h, where e is the elementary charge and h is the Planck constant.
            /// </para>
            /// </summary>
            public const decimal JosephsonConstant_KJ = 483597.8484e9m;

            /// <summary>
            /// <para>Loschmidt Constant
            /// </para><para>The Loschmidt constant, usually denoted by the symbol n0, is a physical constant relating to the number density of particles in an ideal gas.
            /// </para><para>It is equal to approximately 2.686780524e25 m−3.
            /// </para><para>The Loschmidt constant is given by n0 = p0 / (kT), where p0 is the standard pressure, k is the Boltzmann constant, and T is the standard temperature.
            /// </para>
            /// </summary>
            public const decimal LoschmidtConstant_n0 = 2.686780524e25m;

            /// <summary>
            /// <para>Luminous Efficacy
            /// </para><para>The luminous efficacy, usually denoted by the symbol Kcd, is a physical constant relating to the sensitivity of the human eye to light.
            /// </para><para>It is equal to approximately 683 lm⋅W−1.
            /// </para><para>The luminous efficacy is given by Kcd = 2πc^2h / λ^5, where c is the speed of light in vacuum, h is the Planck constant, and λ is the wavelength of light.
            /// </para>
            /// </summary>
            public const decimal LuminousEfficacy_Kcd = 683m;

            /// <summary>
            /// <para>Magnetic Flux Quantum
            /// </para><para>The magnetic flux quantum, usually denoted by the symbol Φ0, is a physical constant relating to superconductivity.
            /// </para><para>It is equal to approximately 2.067833831e-15 Wb.
            /// </para><para>The magnetic flux quantum is given by Φ0 = h / 2e, where h is the Planck constant and e is the elementary charge.
            /// </para>
            /// </summary>
            public const decimal MagneticFluxQuantum_Φ0 = 2.067833831e-15m;

            /// <summary>
            /// <para>Magnetic Flux Quantum In e Squared Per Joule
            /// </para>
            /// </summary>
            public const decimal MagneticFluxQuantumIneSquaredPerJoule = 2.067833831e-15m;

            /// <summary>
            /// <para>Magnetic Moment Of Electron
            /// </para><para>The magnetic moment of the electron, usually denoted by the symbol μe, is a physical constant relating to the magnetic moment of the electron.
            /// </para><para>It is equal to approximately 9.284764620e-24 J⋅T−1.
            /// </para><para>The magnetic moment of the electron is given by μe = eħ / 2me, where e is the elementary charge, ħ is the reduced Planck constant, and me is the electron mass.
            /// </para>
            /// </summary>
            public const decimal MagneticMomentOfElectron_μe = 9.284764620e-24m;

            /// <summary>
            /// <para>Magnetic Moment Of Neutron
            /// </para><para>The magnetic moment of the neutron, usually denoted by the symbol μn, is a physical constant relating to the magnetic moment of the neutron.
            /// </para><para>It is equal to approximately -9.6623645e-27 J⋅T−1.
            /// </para><para>The magnetic moment of the neutron is given by μn = −1.91304273μN, where μN is the nuclear magneton.
            /// </para>
            /// </summary>
            public const decimal MagneticMomentOfNeutron_μn = -9.6623645e-27m;

            /// <summary>
            /// <para>Magnetic Moment Of Proton
            /// </para><para>The magnetic moment of the proton, usually denoted by the symbol μp, is a physical constant relating to the magnetic moment of the proton.
            /// </para><para>It is equal to approximately 1.4106067873e-26 J⋅T−1.
            /// </para><para>The magnetic moment of the proton is given by μp = 2.79284734463μN, where μN is the nuclear magneton.
            /// </para>
            /// </summary>
            public const decimal MagneticMomentOfProton_μp = 1.4106067873e-26m;

            /// <summary>
            /// <para>Molar Gas Constant
            /// </para><para>The molar gas constant, usually denoted by the symbol R, describes the relationship between temperature and energy.
            /// </para><para>It is equal to approximately 8.314462618 J⋅K−1⋅mol−1.
            /// </para><para>The molar gas constant is given by R = NAk, where NA is the Avogadro constant and k is the Boltzmann constant.
            /// </para>
            /// </summary>
            public const decimal MolarGasConstant_R = 8.314462618m;

            /// <summary>
            /// <para>Molar Mass
            /// </para><para>The molar mass, usually denoted by the symbol Mu, describes the mass of one mole of a substance.
            /// </para><para>It is equal to approximately 0.99999999965e-3 kg⋅mol−1.
            /// </para><para>The molar mass is given by Mu = M(12C) / NA, where M(12C) is the molar mass of carbon-12 and NA is the Avogadro constant.
            /// </para>
            /// </summary>
            public const decimal MolarMass_Mu = 0.99999999965e-3m;

            /// <summary>
            /// <para>Molar Mass of Carbon 12
            /// </para><para>The molar mass of carbon-12, usually denoted by the symbol M(12C), is a physical constant relating to the molar mass of carbon-12.
            /// </para><para>It is equal to approximately 11.9999999958e-3 kg⋅mol−1.
            /// </para><para>The molar mass of carbon-12 is given by M(12C) = 12u / NA, where u is the unified atomic mass unit and NA is the Avogadro constant.
            /// </para>
            /// </summary>
            public const decimal MolarMassOfCarbon12_M12C = 11.9999999958e-3m;

            /// <summary>
            /// <para>Molar Planck Constant
            /// </para><para>The molar Planck constant, usually denoted by the symbol NAh, is the relationship between energy and frequency for a photon.
            /// </para><para>It is equal to approximately 3.990312717628e-10 J⋅s⋅mol−1.
            /// </para><para>The molar Planck constant is given by NAh = NAħ, where NA is the Avogadro constant and ħ is the reduced Planck constant.
            /// </para>
            /// </summary>
            public const decimal MolarPlanckConstant_NAh = 3.990312717628e-10m;

            /// <summary>
            /// <para>Muon Compton Wavelength
            /// </para><para>The muon Compton wavelength, usually denoted by the symbol λC,μ, is a physical constant derived from the muon mass.
            /// </para><para>It is equal to approximately 1.173444110e-14 m.
            /// </para><para>The muon Compton wavelength is given by λC,μ = ħ / mμc, where ħ is the reduced Planck constant, mμ is the muon mass, and c is the speed of light in vacuum.
            /// </para><para>The value was first measured by Louis Essen in 1948, who found λC,μ = 1.1734×10−14 m by studying the reaction γ + μ → e+ + e− and applying the conservation of energy and momentum.
            /// </para>
            /// </summary>
            public const decimal MuonComptonWavelength_λCμ = 1.173444110e-14m;

            /// <summary>
            /// <para>Muon Electron Mass Ratio
            /// </para><para>The muon-electron mass ratio, usually denoted by the symbol mμ / me, is a physical constant relating to the mass of the muon and electron.
            /// </para><para>It is equal to approximately 206.7682826.
            /// </para><para>The muon-electron mass ratio is given by mμ / me = mμ / me, where mμ is the muon mass and me is the electron mass.
            /// </para><para>The value was first measured by James Chadwick in 1935, who found mμ / me = 206.4 by studying the reaction γ + μ → e+ + e− and applying the conservation of energy and momentum.
            /// </para>
            /// </summary>
            public const decimal MuonElectronMassRatio_mμme = 206.7682826m;

            /// <summary>
            /// <para>Muon Magnetic Moment
            /// </para><para>The muon magnetic moment, usually denoted by the symbol μμ, is a physical constant relating to the magnetic moment of the muon.
            /// </para><para>It is equal to approximately -4.49044826e-26 J⋅T−1.
            /// </para><para>The muon magnetic moment is given by μμ = −2.0023318418μN, where μN is the nuclear magneton.
            /// </para><para>The value was first measured by I.I. Rabi in 1936, who found μμ = −2.0020μN by studying the reaction γ + μ → e+ + e− and applying the conservation of energy and momentum.
            /// </para>
            /// </summary>
            public const decimal MuonMagneticMoment_μμ = -4.49044826e-26m;

            /// <summary>
            /// <para>Muon Mass
            /// </para><para>The muon mass, usually denoted by the symbol mμ, is a physical constant relating to the muon mass.
            /// </para><para>It is equal to approximately 1.883531594e-28 kg.
            /// </para><para>The muon mass is given by mμ = 0.1134289256u, where u is the unified atomic mass unit.
            /// </para><para>The value was first measured by James Chadwick in 1932, who found mμ = 0.1134u by studying the reaction 4He + 9Be → 12C + n and applying the conservation of energy and momentum.
            /// </para>
            /// </summary>
            public const decimal MuonMass_mμ = 1.883531594e-28m;

            /// <summary>
            /// <para>Muon Mass Energy Equivalent
            /// </para><para>The muon mass energy equivalent, usually denoted by the symbol mμc2, is a physical constant relating to the muon mass.
            /// </para><para>It is equal to approximately 1.692833774e-11 J.
            /// </para><para>The muon mass energy equivalent is given by mμc2 = 105.6583745MeV, where MeV is the megaelectronvolt.
            /// </para>
            /// </summary>
            public const decimal MuonMassEnergyEquivalent_mμc2 = 1.692833774e-11m;

            /// <summary>
            /// <para>Muon Mass in u
            /// </para><para>The muon mass in u, usually denoted by the symbol mμu, is the muon mass expressed in unified atomic mass units.
            /// </para>
            /// </summary>
            public const decimal MuonMassInu_mμu = 0.1134289257m;

            /// <summary>
            /// <para>Muon Molar Mass
            /// </para><para>The muon molar mass, usually denoted by the symbol Mμ, is a physical constant defining the molar mass of muons.
            /// </para><para>It is equal to approximately 0.0001134289257 kg⋅mol−1.
            /// </para>
            /// </summary>
            public const decimal MuonMolarMass_Mμ = 0.0001134289257m;

            /// <summary>
            /// <para>Molar Volume of Ideal Gas (Vm) at 1 Atmosphere
            /// </para><para>The molar volume of ideal gas (Vm), usually denoted by the symbol Vm, is a physical constant relating to the molar volume of an ideal gas.            
            /// </para>
            /// </summary>
            public const decimal MolarVolumeOfIdealGas_Vm_Atm = 22.41396954e-3m;

            /// <summary>
            /// <para>Molar Volume of Ideal Gas (Vm) at 1 Bar
            /// </para><para>The molar volume of ideal gas (Vm), usually denoted by the symbol Vm, is a physical constant relating to the molar volume of an ideal gas.
            /// </para>
            /// </summary>
            public const decimal MolarVolumeOfIdealGas_Vm_STP = 22.71095464e-3m;

            /// <summary>
            /// <para>Muon to Proton Mass Ratio
            /// </para><para>The Muon to Proton Mass Ratio, usually denoted by the symbol mμ / mp, is a physical constant relating to the mass of the muon and proton.
            /// </para><para>It is equal to approximately 0.1126095262.
            /// </para><para>The muon to proton mass ratio is given by mμ / mp = mμ / mp, where mμ is the muon mass and mp is the proton mass.
            /// </para>
            /// </summary>
            public const decimal MuonProtonMassRatio_mμmp = 0.1126095262m;

            /// <summary>
            /// <para>Neutron-Electron Mass Ratio
            /// </para><para>The neutron-electron mass ratio, usually denoted by the symbol mn / me, is a physical constant relating to the mass of the neutron and electron.
            /// </para>
            /// </summary>
            public const decimal NeutronElectronMassRatio_mnme = 1838.68366173m;

            /// <summary>
            /// <para>Neutron Magnetic Moment
            /// </para><para>The neutron magnetic moment, usually denoted by the symbol μn, is a physical constant defining the magnetic moment of the neutron.
            /// </para><para>It is equal to approximately -9.6623647e-27 J⋅T−1.
            /// </para><para>The neutron magnetic moment is given by μn = −1.91304273μN, where μN is the nuclear magneton.
            /// </para><para>The value was first measured by Otto Stern in 1933, who found μn = −1.913μN by studying the reaction γ + n → p + e− and applying the conservation of energy and momentum.
            /// </para>
            /// </summary>
            public const decimal NeutronMagneticMoment_μn = -9.6623647e-27m;

            /// <summary>
            /// <para>Neutron-Proton Mass Ratio
            /// </para><para>The neutron-proton mass ratio, usually denoted by the symbol mn / mp, is a physical constant relating to the mass of the neutron and proton.
            /// </para>
            /// </summary>
            public const decimal NeutronProtonMassRatio_mnmp = 1.00137841931m;

            /// <summary>
            /// <para>Neutron Mass
            /// </para><para>The neutron mass, usually denoted by the symbol mn, is a physical constant relating to the neutron mass.
            /// </para><para>It is equal to approximately 1.674927471e-27 kg.
            /// </para><para>The neutron mass is given by mn = 1.00866491588u, where u is the unified atomic mass unit.
            /// </para><para>The value was first measured by James Chadwick in 1932, who found mn = 1.0089u by studying the reaction 4He + 9Be → 12C + n and applying the conservation of energy and momentum.
            /// </para>
            /// </summary>
            public const decimal NeutronMass_mn = 1.674927471e-27m;

            /// <summary>
            /// <para>Nuclear Magneton
            /// </para><para>The nuclear magneton, usually denoted by the symbol μN, is a physical constant that helps differentiate between the magnetic moments of subatomic particles.
            /// It defines the relationship between the magnetic moment and the angular momentum of a nucleus.
            /// </para><para>It is equal to approximately 5.050783699e-27 J⋅T−1.
            /// </para><para>The nuclear magneton is given by μN = eħ / 2mp, where e is the elementary charge, ħ is the reduced Planck constant, and mp is the proton mass.
            /// </para><para>It was first introduced by Werner Heisenberg in 1928, to explain how protons and neutrons could have magnetic moments of approximately the same magnitude, despite having different charges.
            /// </para>
            /// </summary>
            public const decimal NuclearMagneton_μN = 5.050783699e-27m;

            /// <summary>
            /// <para>Planck Constant
            /// </para><para>The Planck constant, usually denoted by the symbol h, is a physical constant derived from the energy of a photon divided by its frequency.
            /// </para><para>It is equal to approximately 6.62607004e-34 J⋅s.
            /// </para><para>The Planck constant is given by h = 2πħ, where ħ is the reduced Planck constant.
            /// </para><para>Planck discovered the constant by fitting the energy of the black-body radiation curve for an ideal body, and suggested that the energy in a beam of light could only be emitted in discrete packets of energy. This lead to the development of quantum mechanics.
            /// </para>
            /// </summary>
            public const decimal PlanckConstant_h = 6.62607004e-34m;

            /// <summary>
            /// <para>Reduced Planck Constant
            /// </para><para>The reduced Planck constant, usually denoted by the symbol ħ, is the Planck constant divided by 2π. It is used for the calculation of the quantum mechanical effects of the angular momentum of a particle.
            /// </para><para>It is equal to approximately 1.054571800e-34 J⋅s.
            /// </para><para>The reduced Planck constant is given by ħ = h / 2π, where h is the Planck constant.
            /// </para><para>The reduced Planck constant is also known as the reduced Dirac constant, or the reduced quantum of action.
            /// </para><p
            /// </summary>
            public const decimal PlanckConstantReduced_ħ = 1.054571800e-34m;

            /// <summary>
            /// <para>Planck Length
            /// </para><para>The Planck length, usually denoted by the symbol lP, is a physical constant defining the scale at which quantum effects become significant.
            /// </para><para>It is equal to approximately 1.616229e-35 m.
            /// </para><para>The Planck length is given by lP = √(ħG / c3), where ħ is the reduced Planck constant, G is the gravitational constant, and c is the speed of light in a vacuum.
            /// </para><para>The Planck length is the smallest length that can be measured, and is the scale at which the structure of spacetime becomes dominated by quantum effects.
            /// </para>
            /// </summary>
            public const decimal PlanckLength_lP = 1.616229e-35m;

            /// <summary>
            /// <para>Planck Mass
            /// </para><para>The Planck mass, usually denoted by the symbol mP, is a physical constant defining the scale at which quantum effects become significant.
            /// </para><para>It is equal to approximately 2.176470e-8 kg.
            /// </para><para>The Planck mass is given by mP = √(ħc / G), where ħ is the reduced Planck constant, c is the speed of light in a vacuum, and G is the gravitational constant.
            /// </para><para>The Planck mass is the smallest mass that can be measured, and is the scale at which the structure of spacetime becomes dominated by quantum effects.
            /// </para>
            /// </summary>
            public const decimal PlanckMass_mP = 2.176470e-8m;

            /// <summary>
            /// <para>Planck Temperature
            /// </para><para>The Planck temperature, usually denoted by the symbol TP, is a physical constant defining the temperature at which quantum effects become significant.
            /// </para><para>It is equal to approximately 1.416808e32 K.
            /// </para><para>The Planck temperature is given by TP = (mPc2 / kB), where mP is the Planck mass, c is the speed of light in a vacuum, and kB is the Boltzmann constant.
            /// </para><para>The Planck temperature is the highest temperature that can be measured, and is the scale at which the structure of spacetime becomes dominated by quantum effects.
            /// </para>
            /// </summary>
            public const float PlanckTemperature_TP = 1.416808e32f;

            /// <summary>
            /// <para>Planck Time
            /// </para><para>The Planck time, usually denoted by the symbol tP, is a physical constant defining time spans across which quantum effects become significant.
            /// </para><para>It is equal to approximately 5.39116e-44 s.
            /// </para><para>The Planck time is given by tP = √(ħG / c5), where ħ is the reduced Planck constant, G is the gravitational constant, and c is the speed of light in a vacuum.
            /// </para><para>The Planck time is the shortest span of time that can be measured, and is the scale at which the structure of spacetime becomes dominated by quantum effects.
            /// </para>
            /// </summary>
            public const float PlanckTime_tP = 5.39116e-44f;

            /// <summary>
            /// <para>Proton-Electron Mass Ratio
            /// </para><para>The proton-electron mass ratio, usually denoted by the symbol mp/me, is a physical constant defining the ratio of the mass of a proton to the mass of an electron.
            /// </para>
            /// </summary>
            public const decimal ProtonElectronMassRatio_mpme = 1836.15267343m;

            /// <summary>
            /// <para>Proton Mass
            /// </para><para>The proton mass, usually denoted by the symbol mp, is a physical constant relating to a proton's mass.
            /// </para><para>It is equal to approximately 1.672621898e-27 kg.
            /// </para><para>The proton mass is given by mp = 1.007276466879u, where u is the unified atomic mass unit.
            /// </para><para>The value was measured by Aston in 1927, using the mass spectrograph to separate the isotopes of neon and helium, determining the mass of the protons by comparison of the mass of the helium nuclei with the mass of the neon nuclei.
            /// </para>
            /// </summary>
            public const decimal ProtonMass_mp = 1.672621898e-27m;

            /// <summary>
            /// <para>Proton-Neutron Mass Ratio
            /// </para><para>The proton-neutron mass ratio, usually denoted by the symbol mp/mn, is a physical constant defining the ratio of the mass of a proton to the mass of a neutron.
            /// </para>
            /// </summary>
            public const decimal ProtonNeutronMassRatio_mpmn = 0.99862347844m;

            /// <summary>
            /// <para>Proton Magnetic Moment
            /// </para><para>The proton magnetic moment, usually denoted by the symbol μp, is a physical constant defining the magnetic moment of the proton.
            /// </para><para>It is equal to approximately 1.410606662e-26 J⋅T−1.
            /// </para><para>The proton magnetic moment is given by μp = 2.79284734463μN, where μN is the nuclear magneton.
            /// </para><para>The value was first measured by Otto Stern in 1933, who found μp = 2.792μN by studying the reaction γ + p → n + e+ and applying the conservation of energy and momentum.
            /// </para>
            /// </summary>
            public const decimal ProtonMagneticMoment_μp = 1.410606662e-26m;

            /// <summary>
            /// <para>Quantum Of Circulation
            /// </para><para>The quantum of circulation, usually denoted by the symbol Γ, is a physical constant relating to the circulation of a superfluid.
            /// </para><para>It is equal to approximately 3.636947552024e-4 m2⋅s−1.
            /// </para><para>The quantum of circulation is given by Γ = h / 2m, where h is the Planck constant and m is the mass of the superfluid.
            /// </para><para>The value was first measured by Onsager in 1949, who found Γ = h / 2m by studying the circulation of superfluid helium.
            /// </para>
            /// </summary>
            public const decimal QuantumOfCirculation_Γ = 3.636947552024e-4m;

            /// <summary>
            /// <para>Rydberg Constant
            /// </para><para>The Rydberg constant, usually denoted by the symbol R∞, is a physical constant derived from the Rydberg formula for the hydrogen spectral series.<br></br>
            /// It defines the relationship between the energy levels of the hydrogen atom, in that the energy of the emitted photon is equal to the difference in energy between the two levels.
            /// </para><para>It is equal to approximately 10973731.568508 m−1.
            /// </para><para>The Rydberg constant is given by R∞ = α2mc / 2h, where α is the fine-structure constant, mc is the electron mass, and h is the Planck constant.
            /// </para><para>Rydberg discovered the constant by fitting the spectral lines of hydrogen, and suggested that the energy levels of hydrogen were given by the formula E = −R∞ / n2, where n is the principal quantum number.
            /// </para>
            /// </summary>
            public const decimal RydbergConstant_Rꚙ = 10973731.568508m;

            /// <summary>
            /// <para>Rydberg Constant Times C in Hz
            /// </para><para>The Rydberg constant times c in Hz, usually denoted by the symbol R∞c, is a physical constant derived from the Rydberg formula for the hydrogen spectral series.
            /// </para><para>It is equal to approximately 3.289841960364e15 Hz.
            /// </para><para>The Rydberg constant times c in Hz is given by R∞c = α2mc2 / 2h, where α is the fine-structure constant, mc is the electron mass, and h is the Planck constant.
            /// </para><para>Rydberg discovered the constant by fitting the spectral lines of hydrogen, and suggested that the energy levels of hydrogen were given by the formula E = −R∞ / n2, where n is the principal quantum number.
            /// </para>
            /// </summary>
            public const decimal RydbergConstantTimesCinHz_Rꚙc = 3.289841960364e15m;

            /// <summary>
            /// <para>Rydberg Energy Equivalent in Joules
            /// </para><para>The Rydberg energy equivalent in joules, usually denoted by the symbol R∞hc, is a physical constant derived from the Rydberg formula for the hydrogen spectral series.
            /// </para><para>It is equal to approximately 2.179872325e-18 J.
            /// </para><para>The Rydberg energy equivalent in joules is given by R∞hc = α2mc2c / 2h, where α is the fine-structure constant, mc is the electron mass, and h is the Planck constant.
            /// </para>
            /// </summary>
            public const decimal RydbergEnergyEquivalent_Rꚙhc = 2.179872325e-18m;

            /// <summary>
            /// <para>Rydberg Energy Equivalent in eV
            /// </para><para>The Rydberg energy equivalent in eV, usually denoted by the symbol R∞hc, is a physical constant derived from the Rydberg formula for the hydrogen spectral series.
            /// </para><para>It is equal to approximately 13.605693122994 eV.
            /// </para><para>The Rydberg energy equivalent in eV is given by R∞hc = α2mc2c / 2h, where α is the fine-structure constant, mc is the electron mass, and h is the Planck constant.
            /// </para>
            /// </summary>
            public const decimal RydbergEnergyEquivalentIneV_Rꚙhc = 13.605693122994m;

            /// <summary>
            /// <para>Second Radiation Constant
            /// </para><para>The second radiation constant, usually denoted by the symbol c2, is a physical constant relating to black-body radiation. It defines the relationship between the temperature of a black body and the wavelength at which it emits the most radiation.
            /// </para><para>It is equal to approximately 1.43877736e-2 m⋅K.
            /// </para><para>The second radiation constant is given by c2 = hc / k, where h is the Planck constant, c is the speed of light, and k is the Boltzmann constant.
            /// </para><para>The value was measured by Lummer and Pringsheim in 1899, using a black-body cavity and a spectrometer to measure the wavelength of the emitted radiation from a sample of platinum.
            /// </para>
            /// </summary>
            public const decimal SecondRadiationConstant_c2 = 1.43877736e-2m;

            /// <summary>
            /// <para>Speed of Light
            /// </para><para>The speed of light, usually denoted by the symbol c, is a physical constant relating to the speed of light in vacuum. It is fundamental to many areas of physics.
            /// </para><para>It is equal to approximately 299792458 m⋅s−1.
            /// </para><para>The speed of light is given by c = 1 / √(μ0ε0), where μ0 is the vacuum permeability and ε0 is the vacuum permittivity.
            /// </para><para>The value was measured by Michelson in 1879, using a beam of light reflected between mirrors, and measuring the time taken for the light to travel a fixed distance.
            /// </para>
            /// </summary>
            public const decimal SpeedOfLight_c = 299792458m;

            /// <summary>
            /// <para>Standard Atmosphere
            /// </para><para>The standard atmosphere, usually denoted by the symbol atm, is a physical constant relating to atmospheric pressure. It is used as a reference pressure for many applications in meteorology and engineering.
            /// </para><para>It is equal to approximately 101325 Pa corresponding to the pressure exerted by a column of mercury 760 mm high, or the average atmospheric pressure at sea level. 
            /// </para>
            /// </summary>
            public const decimal StandardAtmosphere_atm = 101325m;

            /// <summary>
            /// <para>Standard State Pressure
            /// </para><para>The standard state pressure, usually denoted by the symbol p⦵, is a physical constant relating to atmospheric pressure. It is used as a reference pressure for many applications in chemistry.
            /// </para><para>It is equal to approximately 100000 Pa corresponding to the pressure exerted by a column of mercury 750 mm high.
            /// </para>
            /// </summary>
            public const decimal StandardStatePressure_Pa = 100000m;

            /// <summary>
            /// <para>Stefan-Boltzmann Constant
            /// </para><para>The Stefan-Boltzmann constant, usually denoted by the symbol σ, is a physical constant relating to black-body radiation. It defines the relationship between the temperature of a black body and the total energy radiated per unit surface area.
            /// </para><para>It is equal to approximately 5.670367e-8 W⋅m−2⋅K−4.
            /// </para><para>The Stefan-Boltzmann constant is given by σ = 2π5k4 / 15c2h3, where k is the Boltzmann constant, c is the speed of light, and h is the Planck constant.
            /// </para>
            /// </summary>
            public const decimal StefanBoltzmannConstant_σ = 5.670367e-8m;

            /// <summary>
            /// <para>Vacuum Impedance
            /// </para><para>The vacuum impedance, usually denoted by the symbol Z0, is a physical constant relating to the impedance of vacuum.
            /// </para><para>It is equal to approximately 376.73031346177 Ω.
            /// </para><para>The vacuum impedance is given by Z0 = μ0c, where μ0 is the vacuum permeability and c is the speed of light.
            /// </para><para>The value was measured by Weber and Kohlrausch in 1856, using a torsion balance to measure the force between two coils carrying a current.
            /// </para>
            /// </summary>
            public const decimal VacuumImpedance_Z0 = 376.73031346177m;

            /// <summary>
            /// <para>Vacuum Permeability
            /// </para><para>The vacuum permeability, usually denoted by the symbol μ0, is a physical constant relating to the magnetic permeability of vacuum.
            /// </para><para>It is equal to approximately 1.2566370614e-6 N⋅A−2.
            /// </para><para>The vacuum permeability is given by μ0 = 4π × 10−7 N⋅A−2.
            /// </para><para>The value was measured by Maxwell in 1861, using a ballistic galvanometer to measure the magnetic field produced by a current flowing through a coil.
            /// </para>
            /// </summary>
            public const decimal VacuumPermeability_μ0 = 1.2566370614e-6m;

            /// <summary>
            /// <para>Vacuum Permittivity
            /// </para><para>The vacuum permittivity, usually denoted by the symbol ε0, is a physical constant relating to the electric permittivity of vacuum. It was measured by Coulomb in 1785, who used a torsion balance to measure the force between two charged plates.
            /// </para><para>It is equal to approximately 8.854187817e-12 F⋅m−1.
            /// </para><para>The vacuum permittivity is given by ε0 = 1 / (μ0c2), where μ0 is the vacuum permeability and c is the speed of light.
            /// </summary>
            public const decimal VacuumPermittivity_ε0 = 8.854187817e-12m;

            /// <summary>
            /// <para>Von Klitzing Constant
            /// </para><para>The von Klitzing constant, usually denoted by the symbol RK, is a physical constant relating to the quantum Hall effect. It defines the relationship between the quantized Hall resistance and the fine-structure constant.
            /// </para><para>It is equal to approximately 25812.8074555 Ω.
            /// </para><para>The von Klitzing constant is given by RK = h / e2, where h is the Planck constant and e is the elementary charge.
            /// </para><para>The value was measured by von Klitzing in 1980, using a quantum Hall device to measure the Hall resistance of a sample of mercury cadmium telluride.
            /// </para>
            /// </summary>
            public const decimal VonKlitzingConstant_RK = 25812.8074555m;

            /// <summary>
            /// <para>Weak Mixing Angle
            /// </para><para>The weak mixing angle, usually denoted by the symbol θW, is a physical constant relating to the weak interaction. It defines the relationship between the masses of the W and Z bosons.
            /// </para><para>It is equal to approximately 0.222321.
            /// </para><para>The weak mixing angle is given by θW = arcsin(√(e2 / (e2 + g2))), where e is the elementary charge and g is the weak isospin coupling constant.
            /// </para><para>The value was measured by the Particle Data Group in 2014, using data from the Large Electron-Positron Collider and the Stanford Linear Collider to measure the cross-section of electron-positron collisions.
            /// </para>
            /// </summary>
            public const decimal WeakMixingAngle_θW = 0.222321m;

            /// <summary>
            /// <para>Wien Displacement Constant
            /// </para><para>The Wien displacement constant, usually denoted by the symbol b, is a physical constant relating to black-body radiation. It defines the relationship between the temperature of a black body and the wavelength at which it emits the most radiation.
            /// </para><para>It is equal to approximately 2.8977729e-3 m⋅K.
            /// </para><para>The Wien displacement constant is given by b = hc / (4.965114231e-3 k), where h is the Planck constant, c is the speed of light, and k is the Boltzmann constant.
            /// </para><para>The value was measured by Wien in 1893, using a black body with a small hole to measure the wavelength of the radiation emitted when heating a platinum filament. Platinum was chosen because it does not oxidize at high temperatures.
            /// </para>
            /// </summary>
            public const decimal WienDisplacementConstant_b = 2.8977729e-3m;
        }
        #endregion
    }

    public static class MathsF {
        #region MathFunctions

        /// <summary>
        /// <para>Derivative
        /// </para><para>Calculates the derivative of a function at a point using the central difference method.
        /// </para><para>The central difference method is a numerical method of estimating the derivative of a function at a point by evaluating the function at two points close to the point of interest.
        /// </para><para>It is given by f'(x) = (f(x + h) - f(x - h)) / (2h), where h is a small number (step size).
        /// </para><para>The smaller the step size, the more accurate the result.
        /// </para>
        /// </summary>
        /// <param name="function">The function to calculate the derivative of.</param>
        /// <param name="x">The point at which to calculate the derivative.</param>
        /// <param name="h">The step size to use when calculating the derivative. The smaller the step size, the more accurate the result. Defaults to 1e-5m.</param>
        /// <returns>The derivative of the function at the point x, as a decimal.</returns>
        public static decimal Derivative(Func<decimal, decimal> function, decimal x, decimal h = 1e-5m) {
            return (function(x + h) - function(x - h)) / (2 * h);
        }

        /// <summary>
        /// <para>Derivative
        /// </para><para>Calculates the derivative of a function at a point using the central difference method.
        /// </para><para>The central difference method is a numerical method of estimating the derivative of a function at a point by evaluating the function at two points close to the point of interest.
        /// </para><para>It is given by f'(x) = (f(x + h) - f(x - h)) / (2h), where h is a small number (step size).
        /// </para><para>The smaller the step size, the more accurate the result.
        /// </para>
        /// </summary>
        /// <param name="function">The function to calculate the derivative of.</param>
        /// <param name="x">The point at which to calculate the derivative.</param>
        /// <param name="h">The step size to use when calculating the derivative. The smaller the step size, the more accurate the result. Defaults to 1e-5.</param>
        /// <returns>The derivative of the function at the point x, as a double.</returns>
        public static double Derivative( Func<double, double> function, double x, double h = 1e-5d ) {
            double derivative = (function(x + h) - function(x - h)) / (2 * h);
            return derivative;
        }

        /// <summary>
        /// <para>Derivative
        /// </para><para>Calculates the derivative of a function at a point using the central difference method.
        /// </para><para>The central difference method is a numerical method of estimating the derivative of a function at a point by evaluating the function at two points close to the point of interest.
        /// </para><para>It is given by f'(x) = (f(x + h) - f(x - h)) / (2h), where h is a small number (step size).
        /// </para><para>The smaller the step size, the more accurate the result.
        /// </para>
        /// </summary>
        /// <param name="function">The function to calculate the derivative of.</param>
        /// <param name="x">The point at which to calculate the derivative.</param>
        /// <param name="h">The step size to use when calculating the derivative. The smaller the step size, the more accurate the result. Defaults to 1e-5f.</param>
        /// <returns>The derivative of the function at the point x, as a float.</returns>
        public static float Derivative( Func<float, float> function, float x, float h = 1e-5f ) {
            return (function(x + h) - function(x - h)) / (2 * h);
        }

        /// <summary>
        /// <para>Partial Derivative Function
        /// </para><para>Calculates the partial derivative of a function at a point with respect to x using the central difference method.
        /// </para><para>The central difference method is a numerical method of estimating the derivative of a function at a point by evaluating the function at two points close to the point of interest.
        /// </para><para>It is given by f'(x) = (f(x + h) - f(x - h)) / (2h), where h is a small number (step size).
        /// </para><para>The smaller the step size, the more accurate the result.
        /// </para>
        /// </summary>
        /// <param name="function">A function with two input decimals and one output decimal. The first input is the x value, the second input is the y value.</param>
        /// <param name="x">The x value at which to calculate the partial derivative.</param>
        /// <param name="y">The y value at which to calculate the partial derivative.</param>
        /// <param name="h">The step size to use when calculating the partial derivative. The smaller the step size, the more accurate the result. Defaults to 1e-5.</param>
        /// <returns>The partial derivative of the function at the point (x, y), with respect to x, as a decimal.</returns>
        public static decimal PartialDerivative( Func<decimal, decimal, decimal> function, decimal x, decimal y, decimal h = 1e-5m ) {
            return (function(x + h, y) - function(x - h, y)) / (2 * h);
        }

        /// <summary>
        /// <para>Partial Derivative Function
        /// </para><para>Calculates the partial derivative of a function at a point with respect to x using the central difference method.
        /// </para><para>The central difference method is a numerical method of estimating the derivative of a function at a point by evaluating the function at two points close to the point of interest.
        /// </para><para>It is given by f'(x) = (f(x + h) - f(x - h)) / (2h), where h is a small number (step size).
        /// </para><para>The smaller the step size, the more accurate the result.
        /// </para>
        /// </summary>
        /// <param name="function">A function with two input doubles and one output double. The first input is the x value, the second input is the y value.</param>
        /// <param name="x">The x value at which to calculate the partial derivative.</param>
        /// <param name="y">The y value at which to calculate the partial derivative.</param>
        /// <param name="h">The step size to use when calculating the partial derivative. The smaller the step size, the more accurate the result. Defaults to 1e-5.</param>
        /// <returns>The partial derivative of the function at the point (x, y), with respect to x, as a double.</returns>
        public static double PartialDerivative( Func<double, double, double> function, double x, double y, double h = 1e-5d ) {
            return (function(x + h, y) - function(x - h, y)) / (2 * h);
        }

        /// <summary>
        /// <para>Partial Derivative Function
        /// </para><para>Calculates the partial derivative of a function at a point with respect to x using the central difference method.
        /// </para><para>The central difference method is a numerical method of estimating the derivative of a function at a point by evaluating the function at two points close to the point of interest.
        /// </para><para>It is given by f'(x) = (f(x + h) - f(x - h)) / (2h), where h is a small number (step size).
        /// </para><para>The smaller the step size, the more accurate the result.
        /// </para>
        /// </summary>
        /// <param name="function">A function with two input float and one output float. The first input is the x value, the second input is the y value.</param>
        /// <param name="x">The x value at which to calculate the partial derivative.</param>
        /// <param name="y">The y value at which to calculate the partial derivative.</param>
        /// <param name="h">The step size to use when calculating the partial derivative. The smaller the step size, the more accurate the result. Defaults to 1e-5.</param>
        /// <returns>The partial derivative of the function at the point (x, y), with respect to x, as a float.</returns>
        public static float PartialDerivative( Func<float, float, float> function, float x, float y, float h = 1e-5f ) {
            return (function(x + h, y) - function(x - h, y)) / (2 * h);
        }

        /// <summary>
        /// <para>Square Root
        /// </para><para>Calculates the square root of a decimal, works with decimals up to decimal.MaxValue.
        /// </para>
        /// </summary>
        /// <param name="value">The decimal value to calculate the square root of.</param>
        /// <returns>The square root of the given value, as a decimal.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static decimal Sqrt( decimal value ) {
            if (value < 0) { throw new ArgumentException("Input value must be positive."); }
            if (value == 0) { return 0; }

            decimal root = value / 3;
            int precision = 50;
            for (int i = 0; i < precision; i++) {
                root = (root + value / root) / 2;
            }
            return root;
        }

        //square root for doubles
        //square root for floats

        #region Logarithms
        /// <summary>
        /// <para>Decimal Natural Log function
        /// </para><para>The Natural Log function is the inverse of the PowerE function. This version does it with decimals up to decimal.MaxValue.
        /// </para>
        /// </summary>
        /// <param name="value">The decimal value to calculate the Natural Log of.</param>
        /// <returns>The Natural Log of the given value, as a decimal.</returns>
        /// <exception cref="ArgumentException">Thrown when the input value is negative. </exception>
        public static decimal Log( decimal value ) {
            if (value <= 0) {
                throw new ArgumentException("Input value must be positive.");
            }

            int exponent = 0;
            for (exponent = 0; value >= 2.71828182845904523536028747135266249775724709369995m; exponent++) {
                value /= 2.71828182845904523536028747135266249775724709369995m;
            }

            decimal fractionalPart = value - 1;
            decimal logFractionalPart = fractionalPart / (1 + fractionalPart);
            decimal logValue = exponent + logFractionalPart;
            return logValue;
        }

        /// <summary>
        /// <para>Double Natural Log function
        /// </para><para>Standard Natural Log function, using the Math library.
        /// </para>
        /// </summary>
        /// <param name="value">The double value to calculate the Natural Log of.</param>
        /// <returns>The Natural Log of the given value, as a double.</returns>
        public static double Log( double value ) {
            return Math.Log(value);
        }

        /// <summary>
        /// <para>Float Natural Log function
        /// </para><para>Standard Natural Log function, using the Mathf library.
        /// </para>
        /// </summary>
        /// <param name="value">The float value to calculate the Natural Log of.</param>
        /// <returns>The Natural Log of the given value, as a float.</returns>
        public static float Log( float value ) {
            return Mathf.Log(value);
        }

        /// <summary>
        /// <para>Decimal Log function
        /// </para><para>The Log function is the inverse of the Power function. This version does it with a decimal baseValue and decimals up to decimal.MaxValue.
        /// </para>
        /// </summary>
        /// <param name="value">The decimal value to calculate the log of.</param>
        /// <param name="baseValue">The decimal base value to calculate the log by.</param>
        /// <returns>The Log(n) of the given value, as a decimal.</returns>
        /// <exception cref="ArgumentException">Thrown when the input value is negative. </exception>
        public static decimal Log( decimal value, decimal baseValue ) {
            return Log(value) / Log(baseValue);
        }

        /// <summary>
        /// <para>Double Log function
        /// </para><para>Standard Log function, using the Math library.
        /// </para>
        /// </summary>
        /// <param name="value">The double value to calculate the log of.</param>
        /// <param name="baseValue">The base value to calculate the log by.</param>
        /// <returns>The Log(n) of the given value, as a double.</returns>
        public static double Log( double value, double baseValue ) {
            return Log(value) / Log(baseValue);
        }

        /// <summary>
        /// <para>Float Log(n) function
        /// </para><para>Standard Log function, using the Mathf library.
        /// </para>
        /// </summary>
        /// <param name="value">The float value to calculate the log of.</param>
        /// <param name="baseValue">The base value to calculate the log by.</param>
        /// <returns>The Log(n) of the given value, as a float.</returns>
        public static float Log( float value, float baseValue ) {
            return Log(value) / Log(baseValue);
        }

        /// <summary>
        /// <para>Decimal Log10 function
        /// </para><para>The Log10 function is the inverse of the Power10 function. This version does it with decimals up to decimal.MaxValue.
        /// </para>
        /// </summary>
        /// <param name="value">The decimal value to calculate the log10 of.</param>
        /// <returns>The log10 of the given value, as a decimal.</returns>
        /// <exception cref="ArgumentException">Thrown when the input value is negative. </exception>
        public static decimal Log10( decimal value ) {
            if (value <= 0) {
                throw new ArgumentException("Input value must be positive.");
            }

            int exponent = 0;
            for (exponent = 0; value >= 10; exponent++) {
                value /= 10;
            }

            decimal fractionalPart = value - 1;
            decimal logFractionalPart = fractionalPart / (1 + fractionalPart);
            decimal logValue = exponent + logFractionalPart;
            return logValue;
        }

        /// <summary>
        /// <para>Double Log10 function
        /// </para><para>Standard Log10 function, using the Math library.
        /// </para>
        /// </summary>
        /// <param name="value">The double value to calculate the log10 of.</param>
        /// <returns>The log10 of the given value, as a double.</returns>
        public static double Log10( double value ) {
            return Math.Log10(value);
        }

        /// <summary>
        /// <para>Float Log10 function
        /// </para><para>Standard Log10 function, using the Mathf library.
        /// </para>
        /// </summary>
        /// <param name="value">The float value to calculate the log10 of.</param>
        /// <returns>The log10 of the given value, as a float.</returns>
        public static float Log10( float value ) {
            return Mathf.Log10(value);
        }

        /// <summary>
        /// <para>Decimal Log2 function
        /// </para><para>Log2 is the inverse of Squaring a value. This version does it with decimals up to decimal.MaxValue.
        /// </para>
        /// </summary>
        /// <param name="value">The decimal value to calculate the log2 of.</param>
        /// <returns>The log2 of the given value, as a decimal.</returns>
        public static decimal Log2( decimal value ) {
            return Log(value) / Log(2m);
        }

        /// <summary>
        /// <para>Double Log2 function
        /// </para><para>Standard Log2 function, using the Math library.
        /// </para>
        /// </summary>
        /// <param name="value">The double value to calculate the log2 of.</param>
        /// <returns>The log2 of the given value, as a double.</returns>
        public static double Log2( double value ) {
            return Log(value) / Log(2d);
        }

        /// <summary>
        /// <para>Float Log2 function
        /// </para><para>Standard Log2 function, using the Mathf library.
        /// </para>
        /// </summary>
        /// <param name="value">The float value to calculate the log2 of.</param>
        /// <returns>The log2 of the given value, as a float.</returns>
        public static float Log2( float value ) {
            return Log(value) / Log(2f);
        }
        #endregion

        /// <summary>
        /// <para>Sigmoid function
        /// </para><para>The sigmoid function, also called the logistic function, is often used in machine learning as an activation function for artificial neurons.
        /// </para><para>It is a bounded, differentiable, real function that is defined for all real input values and has a positive derivative at each point.
        /// </para><para>It is defined as: f(x) = 1 / (1 + e^-x)
        /// </para><para>The Sigmoid function can take any value and map it between 0 and 1. It is the inverse of the logit function.
        /// </para>
        /// </summary>
        /// <param name="x">The value to calculate the sigmoid of.</param>
        /// <returns>A float value between 0 and 1.</returns>
        public static float Sigmoid( float x ) {
            return 1 / (1 + Mathf.Exp(-x));
        }

        /// <summary>
        /// <para>Multivariate Sigmoid function
        /// </para><para>The sigmoid function, also called the logistic function, is often used in machine learning as an activation function for artificial neurons.
        /// </para><para>When Sigmoid functions have more than one input variable, they are called Multivariate Sigmoid functions.
        /// </para><para>The equation for Multivariate Sigmoid functions is: f(x) = 1 / (1 + e^-x), where x is an array of values.
        /// </para>
        /// </summary>
        /// <param name="x">The array of values to calculate the sigmoid of.</param>
        /// <returns>An aggregate float value between 0 and 1.</returns>
        public static float SigmoidMultivariate( float[] x ) {
            float sum = 0;
            for (int i = 0; i < x.Length; i++) {
                sum += x[i];
            }
            return 1 / (1 + Mathf.Exp(-sum));
        }

        /// <summary>
        /// <para>Logit function
        /// </para><para>The logit function is the inverse of the sigmoid function.
        /// </para><para>It is defined as: f(x) = ln(x / (1 - x))
        /// </para><para>The Logit function can take any value between 0 and 1 and map it to any value between -∞ and +∞.
        /// </para>
        /// </summary>
        /// <param name="x">The value to calculate the logit of.</param>
        /// <returns>The logit of the given value, as a float.</returns>
        public static float Logit( float x ) {
            return Mathf.Log(x / (1 - x));
        }

        /// <summary>
        /// <para>Multivariate Logit function
        /// </para><para>The logit function is the inverse of the sigmoid function.
        /// </para><para>When Logit functions have more than one input variable, they are called Multivariate Logit functions.
        /// </para><para>The equation for Multivariate Logit functions is: f(x) = ln(x / (1 - x)), where x is an array of values.
        /// </para>
        /// </summary>
        /// <param name="x">The array of values to calculate the logit of.</param>
        /// <returns>An aggregate float value between -∞ and +∞.</returns>
        public static float LogitMultivariate( float[] x ) {
            float sum = 0;
            for (int i = 0; i < x.Length; i++) {
                sum += x[i];
            }
            return Mathf.Log(sum / (1 - sum));
        }

        #region ReLU
        /// <summary>
        /// <para>Rectified Linear Unit (ReLU): Float
        /// </para><para>The rectified linear unit (ReLU) is a piecewise linear function that will output the input directly if it is positive, otherwise, it will output zero.
        /// </para>
        /// </summary>
        /// <param name="x">The float value to calculate the ReLU of.</param>
        /// <returns>The ReLU of the given value, as a float between 0 and +∞.</returns>
        public static float ReLU( float x ) {
            return Mathf.Max(0, x);
        }

        /// <summary>
        /// <para>Rectified Linear Unit (ReLU): Double
        /// </para><para>The rectified linear unit (ReLU) is a piecewise linear function that will output the input directly if it is positive, otherwise, it will output zero.
        /// </para>
        /// </summary>
        /// <param name="x">The double value to calculate the ReLU of.</param>
        /// <returns>The ReLU of the given value, as a double between 0 and +∞.</returns>
        public static double ReLU( double x ) {
            return Math.Max(0, x);
        }

        /// <summary>
        /// <para>Rectified Linear Unit (ReLU): Decimal
        /// </para><para>The rectified linear unit (ReLU) is a piecewise linear function that will output the input directly if it is positive, otherwise, it will output zero.
        /// </para>
        /// </summary>
        /// <param name="x">The decimal value to calculate the ReLU of.</param>
        /// <returns>The ReLU of the given value, as a decimal between 0 and decimal.MaxValue.</returns>
        public static decimal ReLU( decimal x ) {
            return Math.Max(0, x);
        }

        /// <summary>
        /// <para>Multivariate Rectified Linear Unit (ReLU): Float
        /// </para><para>The rectified linear unit (ReLU) is a piecewise linear function that will output the input directly if it is positive, otherwise, it will output zero.
        /// </para>
        /// </summary>
        /// <param name="x">The float array to sum and calculate the ReLU of.</param>
        /// <returns>The aggregate ReLU of the given values, as a float between 0 and +∞.</returns>
        public static float ReLUMultivariate( float[] x ) {
            float sum = 0;
            for (int i = 0; i < x.Length; i++) {
                sum += x[i];
            }
            return Mathf.Max(0, sum);
        }

        /// <summary>
        /// <para>Multivariate Rectified Linear Unit (ReLU): Double
        /// </para><para>The rectified linear unit (ReLU) is a piecewise linear function that will output the input directly if it is positive, otherwise, it will output zero.
        /// </para>
        /// </summary>
        /// <param name="x">The double array to sum and calculate the ReLU of.</param>
        /// <returns>The aggregate ReLU of the given values, as a double between 0 and +∞.</returns>
        public static double ReLUMultivariate( double[] x ) {
            double sum = 0;
            for (int i = 0; i < x.Length; i++) {
                sum += x[i];
            }
            return Math.Max(0, sum);
        }

        /// <summary>
        /// <para>Multivariate Rectified Linear Unit (ReLU): Decimal
        /// </para><para>The rectified linear unit (ReLU) is a piecewise linear function that will output the input directly if it is positive, otherwise, it will output zero.
        /// </para>
        /// </summary>
        /// <param name="x">The decimal array to sum and calculate the ReLU of.</param>
        /// <returns>The aggregate ReLU of the given values, as a decimal between 0 and decimal.MaxValue.</returns>
        public static decimal ReLUMultivariate( decimal[] x ) {
            decimal sum = 0;
            for (int i = 0; i < x.Length; i++) {
                sum += x[i];
            }
            return Math.Max(0, sum);
        }

        /// <summary>
        /// <para>Leaky Rectified Linear Unit (ReLU): Float
        /// </para><para>The leaky rectified linear unit (Leaky ReLU) is a piecewise linear function that will output the input directly if it is positive, otherwise, it will output a small constant value.
        /// </para><para>Leaky ReLU is an attempt to fix the "dying ReLU" problem, where ReLU neurons always output 0 because they have encountered a negative input.
        /// </para>
        /// </summary>
        /// <param name="x">The float value to calculate the Leaky ReLU of.</param>
        /// <returns>The Leaky ReLU of the given value, as a float greater than 0f.</returns>
        public static float LeakyReLU( float x ) {
            return Mathf.Max(0.01f * x, x);
        }

        /// <summary>
        /// <para>Leaky Rectified Linear Unit (ReLU): Double
        /// </para><para>The leaky rectified linear unit (Leaky ReLU) is a piecewise linear function that will output the input directly if it is positive, otherwise, it will output a small constant value.
        /// </para><para>Leaky ReLU is an attempt to fix the "dying ReLU" problem, where ReLU neurons always output 0 because they have encountered a negative input.
        /// </para>
        /// </summary>
        /// <param name="x">The double value to calculate the Leaky ReLU of.</param>
        /// <returns>The Leaky ReLU of the given value, as a double greater than 0d.</returns>
        public static double LeakyReLU( double x ) {
            return Math.Max(0.01d * x, x);
        }

        /// <summary>
        /// <para>Leaky Rectified Linear Unit (ReLU): Decimal
        /// </para><para>The leaky rectified linear unit (Leaky ReLU) is a piecewise linear function that will output the input directly if it is positive, otherwise, it will output a small constant value.
        /// </para><para>Leaky ReLU is an attempt to fix the "dying ReLU" problem, where ReLU neurons always output 0 because they have encountered a negative input.
        /// </para>
        /// </summary>
        /// <param name="x">The double value to calculate the Leaky ReLU of.</param>
        /// <returns>The Leaky ReLU of the given value, as a Decimal greater than 0.</returns>
        public static decimal LeakyReLU( decimal x ) {
            return Math.Max(0.01m * x, x);
        }

        /// <summary>
        /// <para>Leaky Rectified Linear Unit (ReLU) Multivariate: Float
        /// </para><para>The leaky rectified linear unit (Leaky ReLU) is a piecewise linear function that will output the input directly if it is positive, otherwise, it will output a small constant value.
        /// </summary><para>Leaky ReLU is an attempt to fix the "dying ReLU" problem, where ReLU neurons always output 0 because they have encountered a negative input.
        /// </para>
        /// <param name="x">The float array to sum and calculate the Leaky ReLU of.</param>
        /// <returns>The aggregate Leaky ReLU of the given values, as a float between 0 and +∞.</returns>
        public static float LeakyReLUMultivariate( float[] x ) {
            float sum = 0;
            for (int i = 0; i < x.Length; i++) {
                sum += x[i];
            }
            return Mathf.Max(0.01f * sum, sum);
        }

        /// <summary>
        /// <para>Leaky Rectified Linear Unit (ReLU) Multivariate: Double
        /// </para><para>The leaky rectified linear unit (Leaky ReLU) is a piecewise linear function that will output the input directly if it is positive, otherwise, it will output a small constant value.
        /// </summary><para>Leaky ReLU is an attempt to fix the "dying ReLU" problem, where ReLU neurons always output 0 because they have encountered a negative input.
        /// </para>
        /// <param name="x">The double array to sum and calculate the Leaky ReLU of.</param>
        /// <returns>The aggregate Leaky ReLU of the given values, as a double between 0 and +∞.</returns>
        public static double LeakyReLUMultivariate( double[] x ) {
            double sum = 0;
            for (int i = 0; i < x.Length; i++) {
                sum += x[i];
            }
            return Math.Max(0.01d * sum, sum);
        }

        /// <summary>
        /// <para>Leaky Rectified Linear Unit (ReLU) Multivariate: Decimal
        /// </para><para>The leaky rectified linear unit (Leaky ReLU) is a piecewise linear function that will output the input directly if it is positive, otherwise, it will output a small constant value.
        /// </summary><para>Leaky ReLU is an attempt to fix the "dying ReLU" problem, where ReLU neurons always output 0 because they have encountered a negative input.
        /// </para>
        /// <param name="x">The decimal array to sum and calculate the Leaky ReLU of.</param>
        /// <returns>The aggregate Leaky ReLU of the given values, as a decimal between 0 and decimal.MaxValue.</returns>
        public static decimal LeakyReLUMultivariate( decimal[] x ) {
            decimal sum = 0;
            for (int i = 0; i < x.Length; i++) {
                sum += x[i];
            }
            return Math.Max(0.01m * sum, sum);
        }
        #endregion

        /// <summary>
        /// <para>Tanh function
        /// </para><para>The hyperbolic tangent function, also called the tanh function, is often used in machine learning as an activation function for artificial neurons.
        /// </para><para>It accomplishes this by mapping the input values in the range (-∞, +∞) to values in the range (-1, +1), and then squashing those values to range (0, 1).
        /// </para><para>It is defined as: f(x) = (e^x - e^-x) / (e^x + e^-x)
        /// </para><para>This function is similar to the sigmoid function, but it is symmetric around the origin. It is used in the same way as the sigmoid function.
        /// </para>
        /// </summary>
        /// <param name="x">The value to calculate the Tanh of.</param>
        /// <returns>The Tanh of the given value, as a float between -1 and +1.</returns>
        public static float Tanh( float x ) {
            return (Mathf.Exp(x) - Mathf.Exp(-x)) / (Mathf.Exp(x) + Mathf.Exp(-x));
        }

        /// <summary>
        /// <para>Multivariate Tanh function
        /// </para><para>The hyperbolic tangent function, also called the tanh function, is often used in machine learning as an activation function for artificial neurons.
        /// </para><para>It accomplishes this by mapping the input values in the range (-∞, +∞) to values in the range (-1, +1), and then squashing those values to range (0, 1).
        /// </para><para>It is defined as: f(x) = (e^x - e^-x) / (e^x + e^-x)
        /// </para><para>This function is similar to the sigmoid function, but it is symmetric around the origin. It is used in the same way as the sigmoid function.
        /// </para>
        /// </summary>
        /// <param name="x">The values array to calculate the Tanh of.</param>
        /// <returns>The aggregate Tanh of the given values, as a float between -1 and +1.</returns>
        public static float TanhMultivariate( float[] x ) {
            float sum = 0;
            for (int i = 0; i < x.Length; i++) {
                sum += x[i];
            }
            return (Mathf.Exp(sum) - Mathf.Exp(-sum)) / (Mathf.Exp(sum) + Mathf.Exp(-sum));
        }

        /// <summary>
        /// <para>Float Softmax function
        /// </para><para>The softmax function is often used in the final layer of a neural network-based classifier.
        /// </para><para>Such networks are commonly trained under a log loss (or cross-entropy) regime, giving a non-linear variant of multinomial logistic regression.
        /// </para><para>In this context, the softmax function is often referred to as a softmax classifier.
        /// </para><para>The softmax function is also sometimes used in the output layer of a neural network-based regressor, where the idea is to restrict the output to lie between 0 and 1, and to sum to 1.
        /// </para><para>Like the sigmoid function, the softmax function is also a type of logistic function.
        /// </para>
        /// </summary>
        /// <param name="input">The array of float values to calculate the softmax of.</param>
        /// <returns>The softmax of the given values, as an array of floats between 0 and 1.</returns>
        public static float[] Softmax( float[] input ) {
            float max = float.MinValue;
            for (int i = 0; i < input.Length; i++) {
                if (input[i] > max) {
                    max = input[i];
                }
            }

            float[] expInput = new float[input.Length];
            float sumExp = 0.0f;

            for (int i = 0; i < input.Length; i++) {
                expInput[i] = Mathf.Exp(input[i] - max);
                sumExp += expInput[i];
            }

            float[] softmaxOutput = new float[input.Length];
            for (int i = 0; i < input.Length; i++) {
                softmaxOutput[i] = expInput[i] / sumExp;
            }

            return softmaxOutput;
        }

        /// <summary>
        /// <para>Double Softmax function
        /// </para><para>The softmax function is often used in the final layer of a neural network-based classifier.
        /// </para><para>Such networks are commonly trained under a log loss (or cross-entropy) regime, giving a non-linear variant of multinomial logistic regression.
        /// </para><para>In this context, the softmax function is often referred to as a softmax classifier.
        /// </para><para>The softmax function is also sometimes used in the output layer of a neural network-based regressor, where the idea is to restrict the output to lie between 0 and 1, and to sum to 1.
        /// </para><para>Like the sigmoid function, the softmax function is also a type of logistic function.
        /// </para>
        /// </summary>
        /// <param name="input">The array of double values to calculate the softmax of.</param>
        /// <returns>The softmax of the given values, as an array of doubles between 0 and 1.</returns>
        public static double[] Softmax( double[] input ) {
            double max = double.MinValue;
            for (int i = 0; i < input.Length; i++) {
                if (input[i] > max) {
                    max = input[i];
                }
            }

            double[] expInput = new double[input.Length];
            double sumExp = 0.0;

            for (int i = 0; i < input.Length; i++) {
                expInput[i] = Math.Exp(input[i] - max);
                sumExp += expInput[i];
            }

            double[] softmaxOutput = new double[input.Length];
            for (int i = 0; i < input.Length; i++) {
                softmaxOutput[i] = expInput[i] / sumExp;
            }

            return softmaxOutput;
        }

        /// <summary>
        /// <para>Decimal Softmax function
        /// </para><para>The softmax function is often used in the final layer of a neural network-based classifier.
        /// </para><para>Such networks are commonly trained under a log loss (or cross-entropy) regime, giving a non-linear variant of multinomial logistic regression.
        /// </para><para>In this context, the softmax function is often referred to as a softmax classifier.
        /// </para><para>The softmax function is also sometimes used in the output layer of a neural network-based regressor, where the idea is to restrict the output to lie between 0 and 1, and to sum to 1.
        /// </para><para>Like the sigmoid function, the softmax function is also a type of logistic function.
        /// </para>
        /// </summary>
        /// <param name="input">The array of decimal values to calculate the softmax of.</param>
        /// <returns>The softmax of the given values, as an array of decimals between 0 and 1.</returns>
        public static decimal Softmax( decimal[] input ) {
            decimal max = decimal.MinValue;
            for (int i = 0; i < input.Length; i++) {
                if (input[i] > max) {
                    max = input[i];
                }
            }

            decimal[] expInput = new decimal[input.Length];
            decimal sumExp = 0.0m;

            for (int i = 0; i < input.Length; i++) {
                expInput[i] = (decimal)Math.Exp((double)(input[i] - max));
                sumExp += expInput[i];
            }

            decimal softmaxOutput = 0.0m;
            for (int i = 0; i < input.Length; i++) {
                softmaxOutput = expInput[i] / sumExp;
            }

            return softmaxOutput;
        }

        #endregion

        #region Loss Functions
        //https://ml-cheatsheet.readthedocs.io/en/latest/loss_functions.html

        public static float MeanSquaredError( float[] actual, float[] expected ) {
            float sum = 0.0f;
            for (int i = 0; i < actual.Length; i++) {
                sum += Mathf.Pow(actual[i] - expected[i], 2);
            }
            return sum / actual.Length;
        }

        public static double MeanSquaredError( double[] actual, double[] expected ) {
            double sum = 0.0;
            for (int i = 0; i < actual.Length; i++) {
                sum += Math.Pow(actual[i] - expected[i], 2);
            }
            return sum / actual.Length;
        }

        public static decimal MeanSquaredError( decimal[] actual, decimal[] expected ) {
            decimal sum = 0.0m;
            for (int i = 0; i < actual.Length; i++) {
                sum += (decimal)Math.Pow((double)(actual[i] - expected[i]), 2);
            }
            return sum / actual.Length;
        }

        public static float MeanAbsoluteError( float[] actual, float[] expected ) {
            float sum = 0.0f;
            for (int i = 0; i < actual.Length; i++) {
                sum += Mathf.Abs(actual[i] - expected[i]);
            }
            return sum / actual.Length;
        }

        public static double MeanAbsoluteError( double[] actual, double[] expected ) {
            double sum = 0.0;
            for (int i = 0; i < actual.Length; i++) {
                sum += Math.Abs(actual[i] - expected[i]);
            }
            return sum / actual.Length;
        }

        public static decimal MeanAbsoluteError( decimal[] actual, decimal[] expected ) {
            decimal sum = 0.0m;
            for (int i = 0; i < actual.Length; i++) {
                sum += Math.Abs(actual[i] - expected[i]);
            }
            return sum / actual.Length;
        }

        public static float MeanBiasError( float[] actual, float[] expected ) {
            float sum = 0.0f;
            for (int i = 0; i < actual.Length; i++) {
                sum += actual[i] - expected[i];
            }
            return sum / actual.Length;
        }

        public static double MeanBiasError( double[] actual, double[] expected ) {
            double sum = 0.0;
            for (int i = 0; i < actual.Length; i++) {
                sum += actual[i] - expected[i];
            }
            return sum / actual.Length;
        }

        public static decimal MeanBiasError( decimal[] actual, decimal[] expected ) {
            decimal sum = 0.0m;
            for (int i = 0; i < actual.Length; i++) {
                sum += actual[i] - expected[i];
            }
            return sum / actual.Length;
        }
        
        public static float CrossEntropyError( float[] actual, float[] expected ) {
            float sum = 0.0f;
            for (int i = 0; i < actual.Length; i++) {
                sum += expected[i] * Mathf.Log(actual[i]);
            }
            return -sum;
        }

        public static double CrossEntropyError( double[] actual, double[] expected ) {
            double sum = 0.0;
            for (int i = 0; i < actual.Length; i++) {
                sum += expected[i] * Math.Log(actual[i]);
            }
            return -sum;
        }

        public static decimal CrossEntropyError( decimal[] actual, decimal[] expected ) {
            decimal sum = 0.0m;
            for (int i = 0; i < actual.Length; i++) {
                sum += expected[i] * (decimal)Math.Log((double)actual[i]);
            }
            return -sum;
        }

        public static float HingeLoss( float[] actual, float[] expected ) {
            float sum = 0.0f;
            for (int i = 0; i < actual.Length; i++) {
                sum += Mathf.Max(0.0f, 1.0f - actual[i] * expected[i]);
            }
            return sum;
        }

        public static double HingeLoss( double[] actual, double[] expected ) {
            double sum = 0.0;
            for (int i = 0; i < actual.Length; i++) {
                sum += Math.Max(0.0, 1.0 - actual[i] * expected[i]);
            }
            return sum;
        }

        public static decimal HingeLoss( decimal[] actual, decimal[] expected ) {
            decimal sum = 0.0m;
            for (int i = 0; i < actual.Length; i++) {
                sum += Math.Max(0.0m, 1.0m - actual[i] * expected[i]);
            }
            return sum;
        }

        public static float HuberLoss( float[] actual, float[] expected, float delta ) {
            float sum = 0.0f;
            for (int i = 0; i < actual.Length; i++) {
                float diff = actual[i] - expected[i];
                if (Mathf.Abs(diff) <= delta) {
                    sum += 0.5f * diff * diff;
                } else {
                    sum += delta * (Mathf.Abs(diff) - 0.5f * delta);
                }
            }
            return sum;
        }

        public static double HuberLoss( double[] actual, double[] expected, double delta ) {
            double sum = 0.0;
            for (int i = 0; i < actual.Length; i++) {
                double diff = actual[i] - expected[i];
                if (Math.Abs(diff) <= delta) {
                    sum += 0.5 * diff * diff;
                } else {
                    sum += delta * (Math.Abs(diff) - 0.5 * delta);
                }
            }
            return sum;
        }

        public static decimal HuberLoss( decimal[] actual, decimal[] expected, decimal delta ) {
            decimal sum = 0.0m;
            for (int i = 0; i < actual.Length; i++) {
                decimal diff = actual[i] - expected[i];
                if (Math.Abs(diff) <= delta) {
                    sum += 0.5m * diff * diff;
                } else {
                    sum += delta * (Math.Abs(diff) - 0.5m * delta);
                }
            }
            return sum;
        }

        public static float KullbackLeiblerDivergence( float[] actual, float[] expected ) {
            float sum = 0.0f;
            for (int i = 0; i < actual.Length; i++) {
                sum += expected[i] * Mathf.Log(expected[i] / actual[i]);
            }
            return sum;
        }

        public static double KullbackLeiblerDivergence( double[] actual, double[] expected ) {
            double sum = 0.0;
            for (int i = 0; i < actual.Length; i++) {
                sum += expected[i] * Math.Log(expected[i] / actual[i]);
            }
            return sum;
        }

        public static decimal KullbackLeiblerDivergence( decimal[] actual, decimal[] expected ) {
            decimal sum = 0.0m;
            for (int i = 0; i < actual.Length; i++) {
                sum += expected[i] * (decimal)Math.Log((double)(expected[i] / actual[i]));
            }
            return sum;
        }

        public static float LogCoshLoss( float[] actual, float[] expected ) {
            float sum = 0.0f;
            for (int i = 0; i < actual.Length; i++) {
                float diff = actual[i] - expected[i];
                sum += diff * diff;
            }
            return sum;
        }

        public static double LogCoshLoss( double[] actual, double[] expected ) {
            double sum = 0.0;
            for (int i = 0; i < actual.Length; i++) {
                double diff = actual[i] - expected[i];
                sum += diff * diff;
            }
            return sum;
        }

        public static decimal LogCoshLoss( decimal[] actual, decimal[] expected ) {
            decimal sum = 0.0m;
            for (int i = 0; i < actual.Length; i++) {
                decimal diff = actual[i] - expected[i];
                sum += diff * diff;
            }
            return sum;
        }

        public static float PoissonLoss( float[] actual, float[] expected ) {
            float sum = 0.0f;
            for (int i = 0; i < actual.Length; i++) {
                sum += actual[i] - expected[i] * Mathf.Log(actual[i]);
            }
            return sum;
        }

        public static double PoissonLoss( double[] actual, double[] expected ) {
            double sum = 0.0;
            for (int i = 0; i < actual.Length; i++) {
                sum += actual[i] - expected[i] * Math.Log(actual[i]);
            }
            return sum;
        }

        public static decimal PoissonLoss( decimal[] actual, decimal[] expected ) {
            decimal sum = 0.0m;
            for (int i = 0; i < actual.Length; i++) {
                sum += actual[i] - expected[i] * (decimal)Math.Log((double)actual[i]);
            }
            return sum;
        }

        public static float QuantileLoss( float[] actual, float[] expected, float quantile ) {
            float sum = 0.0f;
            for (int i = 0; i < actual.Length; i++) {
                float diff = actual[i] - expected[i];
                if (diff >= 0.0f) {
                    sum += quantile * diff;
                } else {
                    sum += (quantile - 1.0f) * diff;
                }
            }
            return sum;
        }

        public static double QuantileLoss( double[] actual, double[] expected, double quantile ) {
            double sum = 0.0;
            for (int i = 0; i < actual.Length; i++) {
                double diff = actual[i] - expected[i];
                if (diff >= 0.0) {
                    sum += quantile * diff;
                } else {
                    sum += (quantile - 1.0) * diff;
                }
            }
            return sum;
        }

        public static decimal QuantileLoss( decimal[] actual, decimal[] expected, decimal quantile ) {
            decimal sum = 0.0m;
            for (int i = 0; i < actual.Length; i++) {
                decimal diff = actual[i] - expected[i];
                if (diff >= 0.0m) {
                    sum += quantile * diff;
                } else {
                    sum += (quantile - 1.0m) * diff;
                }
            }
            return sum;
        }

        public static float RootMeanSquareError( float[] actual, float[] expected ) {
            float sum = 0.0f;
            for (int i = 0; i < actual.Length; i++) {
                float diff = actual[i] - expected[i];
                sum += diff * diff;
            }
            return Mathf.Sqrt(sum / actual.Length);
        }

        public static double RootMeanSquareError( double[] actual, double[] expected ) {
            double sum = 0.0;
            for (int i = 0; i < actual.Length; i++) {
                double diff = actual[i] - expected[i];
                sum += diff * diff;
            }
            return Math.Sqrt(sum / actual.Length);
        }

        public static decimal RootMeanSquareError( decimal[] actual, decimal[] expected ) {
            decimal sum = 0.0m;
            for (int i = 0; i < actual.Length; i++) {
                decimal diff = actual[i] - expected[i];
                sum += diff * diff;
            }
            return (decimal)Math.Sqrt((double)(sum / actual.Length));
        }

        public static float TripletLoss( float[] anchor, float[] positive, float[] negative, float margin ) {
            float sum = 0.0f;
            for (int i = 0; i < anchor.Length; i++) {
                float diff = anchor[i] - positive[i];
                sum += Mathf.Max(0.0f, diff + margin);
                diff = anchor[i] - negative[i];
                sum += Mathf.Max(0.0f, -diff + margin);
            }
            return sum;
        }

        public static double TripletLoss( double[] anchor, double[] positive, double[] negative, double margin ) {
            double sum = 0.0;
            for (int i = 0; i < anchor.Length; i++) {
                double diff = anchor[i] - positive[i];
                sum += Math.Max(0.0, diff + margin);
                diff = anchor[i] - negative[i];
                sum += Math.Max(0.0, -diff + margin);
            }
            return sum;
        }

        public static decimal TripletLoss( decimal[] anchor, decimal[] positive, decimal[] negative, decimal margin ) {
            decimal sum = 0.0m;
            for (int i = 0; i < anchor.Length; i++) {
                decimal diff = anchor[i] - positive[i];
                sum += Math.Max(0.0m, diff + margin);
                diff = anchor[i] - negative[i];
                sum += Math.Max(0.0m, -diff + margin);
            }
            return sum;
        }
        #endregion

        #region Optimization
        //Functions for optimizing the parameters of a model.
        //These functions all take a function to be optimized, a function to calculate the gradient of the function, and an initial set of parameters.
        //They all return the optimized parameters.
        //They include: GradientDescent, Momentum, NesterovMomentum, Adagrad, RMSProp, Adam, AdaMax, Nadam, AMSGrad, AMSBound, AMSBoundMax, BFGS, SGD, AdaDelta, RMSProp
        #endregion

        #region Lucas & Fibonacci
        /// <summary>
        /// <para>Lucas Numbers
        /// </para><para>The Lucas numbers or Lucas series, and their fascinating connections with the Fibonacci numbers and the golden section.
        /// </para><para>The Lucas numbers are an integer sequence named after the mathematician François Édouard Anatole Lucas (1842–1891), who studied both that sequence and the closely related Fibonacci numbers.
        /// </para><para>Lucas numbers and Fibonacci numbers form complementary instances of Lucas sequences.
        /// </para><para>The Lucas numbers are defined as: L(n) = φ^n + ψ^n, where φ and ψ are the roots of the equation: x^2 - x - 1 = 0
        /// </para>
        /// </summary>
        /// <param name="power">The power to raise Phi to.</param>        
        /// <returns>The Lucas number at the given power.
        /// </returns>
        public static int CalculateLucasNumber( int power ) {
            decimal lucasValue = Decimal.Multiply((decimal)Math.Pow((double)Maths._Phi, power), (decimal)(1 / Mathf.Sqrt(5)));
            return (int)lucasValue;
        }

        /// <summary>
        /// <para>Get the nth Fibonacci number
        /// </para><para>The Fibonacci numbers are the numbers in the following integer sequence, called the Fibonacci sequence, and characterized by the fact that every number after the first two is the sum of the two preceding ones.
        /// </para><para>Often, especially in modern usage, the sequence is extended by one more initial term: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 …
        /// </para><para>This function uses recursion to calculate the Fibonacci number at the given index by adding the previous two Fibonacci numbers together.
        /// </para>
        /// </summary>
        /// <param name="_n">The index of the Fibonacci number to calculate.</param>
        /// <returns>The Fibonacci number at the given index.</returns>
        public static ulong GetFibonacciNumber( ulong _n ) {
            if (_n <= 1) {
                return _n;
            }
            return GetFibonacciNumber(_n - 1) + GetFibonacciNumber(_n - 2);
        }
        #endregion
    }

}