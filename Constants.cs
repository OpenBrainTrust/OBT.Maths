using System;
using UnityEngine;

namespace OBT.Maths {
    public static class Maths {
        /// <summary>
        /// <para>ζ(3) (Zeta3): Apéry's constant
        /// </para><para>The Apéry's constant, denoted by ζ(3), is a mathematical constant that appears in number theory and mathematical analysis.
        /// </para><para>It is related to the Riemann zeta function evaluated at 3: ζ(3) = 1.20205690315959428539973816151144999…
        /// </para><para>It is the sum of the series 1/1^3 + 1/2^3 + 1/3^3 + 1/4^3 + ...
        /// </para><para>The value of ζ(3) is of great interest in number theory and has connections to various unsolved problems, including the irrationality of certain numbers.
        /// </para><para>Despite being a special value of the Riemann zeta function, Apéry's constant arises naturally in a number of physical problems, including in the second- and third-order terms of the electron's gyromagnetic ratio, computed using quantum electrodynamics.
        /// </para>
        /// </summary>
        public static class Apery {
            public static readonly decimal Zeta3_m = 1.20205690315959428539973816151144999m;
            public static readonly double Zeta3_d = 1.2020569031595942d;
            public static readonly float Zeta3_f = 1.2020569f;
        }

        /// <summary>
        /// <para>B: Backhouse's constant
        /// </para><para>Backhouse's constant, denoted by B, is defined by using the Power Series such that the coefficients of successive terms are the Prime Numbers.
        /// </para><para>It is approximately 1.45607494858268967139959535111654356...
        /// </para>
        /// </summary>
        public static class Backhouse {
            public static readonly decimal B_m = 1.45607494858268967139959535111654356m;
            public static readonly double B_d = 1.4560749485826897d;
            public static readonly float B_f = 1.4560749f;
        }

        /// <summary>
        /// <para>C: Cahen's constant
        /// </para><para>Cahen's constant is a mathematical constant that appears in the study of continued fractions and Diophantine approximation.
        /// </para><para>It is approximately 0.643410546288338025182254...
        /// </para><para>Cahen's constant is defined as the value of an infinite series of unit fractions.
        /// </para><para>It is named after Eugène Cahen, a French mathematician who studied continued fractions and Diophantine approximation.
        /// </para>
        /// </summary>
        public static class Cahen {
            public static readonly decimal Cahen_m = 0.643410546288338025182254m;
            public static readonly double Cahen_d = 0.6434105462883380d;
            public static readonly float Cahen_f = 0.6434105f;
        }

        /// <summary>
        /// <para>G: Catalan's constant
        /// </para><para>Catalan's constant G is a mathematical constant with significance in number theory and analysis.
        /// </para><para>It is approximately 0.915965594177219...
        /// </para><para>G appears in various mathematical problems, related to special functions, integrals, and series. 
        /// It's linked to unsolved questions and has applications in scientific fields.
        /// </para>
        /// </summary>
        public static class Catalan {
            public static readonly decimal G_m = 0.91596559417721901505460351493238411m;
            public static readonly double G_d = 0.915965594177219d;
            public static readonly float G_f = 0.91596559f;
        }

        /// <summary>
        /// <para>λ (Lambda): Conway's constant
        /// </para><para>Conway's constant, denoted by λ, is a mathematical constant that appears in the study of look-and-say sequences.
        /// </para><para>It is approximately 1.30357726903429639125709911215255189...
        /// </para><para>Conway's constant is the unique real root of the cubic polynomial x^3 − x^2 − 2x − 1 = 0.
        /// </para><para>It is named after John Horton Conway, who discovered the connection between the look-and-say sequence and this constant.
        /// </para><para>Conway's constant is also related to the plastic number, which is the unique real root of the cubic polynomial x^3 − x − 1 = 0.
        /// </para>
        /// </summary>
        public static class Conway {
            public static readonly decimal Lambda_m = 1.30357726903429639125709911215255189m;
            public static readonly double Lambda_d = 1.3035772690342964d;
            public static readonly float Lambda_f = 1.30357727f;
        }

        /// <summary>
        /// <para>E: Erdős–Borwein constant
        /// </para><para>The Erdős–Borwein constant, denoted by E, is the sum of the reciprocals of the Mersenne numbers. The Erdős–Borwein constant is named after mathematicians Paul Erdős and Peter Borwein, who proved that the constant is irrational. Despite its irrationality, the binary representation of the Erdős–Borwein constant may be calculated efficiently.
        /// </para><para>It is approximately 1.60669515241529176378330152319092458...
        /// </para><para>The Erdős–Borwein constant comes up in the average case analysis of the heapsort algorithm, where it controls the constant factor in the running time for converting an unsorted array of items into a heap.
        /// </para>
        /// </summary>
        public static class ErdosBorwein {
            public static readonly decimal E_m = 1.60669515241529176378330152319092458m;
            public static readonly double E_d = 1.6066951524152918d;
            public static readonly float E_f = 1.6066952f;
        }

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
        public static class EulerMascheroni {
            public static readonly decimal Gamma_m = 0.5772156649015328606065120900824m;
            public static readonly double Gamma_d = 0.577215664901532d;
            public static readonly float Gamma_f = 0.577216f;
        }

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
        public static class Feigenbaum {
            public static readonly decimal Alpha_m = 2.50290787509589282228390287321821m;
            public static readonly double Alpha_d = 2.5029078750958928d;
            public static readonly float Alpha_f = 2.50290787f;

            public static readonly decimal Delta_m = 4.66920160910299067185320382046620161m;
            public static readonly double Delta_d = 4.6692016091029907d;
            public static readonly float Delta_f = 4.66920161f;
        }

        /// <summary>
        /// <para>A: Glaisher-Kinkelin constant
        /// </para><para> The Glaisher–Kinkelin constant A is a mathematical constant occurring in the asymptotic expansion of the partition function, which counts the number of ways of writing a positive integer as a sum of positive integers. It is named after James Whitbread Lee Glaisher and Joseph Kinkelin.
        /// </para><para>The constant is approximately 1.28242712910062263687534256886979172...
        /// </para><para>The Glaisher–Kinkelin constant is related to the Dedekind eta function by the formula η(i) = eπ√(2/3) / (2π)^(1/4) / Γ(1/4) / Γ(3/4) / ζ(3/2) / A, where A is the Glaisher–Kinkelin constant.
        /// </para><para>The Glaisher–Kinkelin constant is also related to the Barnes G-function by the formula G(1) = 2π^(1/4) / Γ(1/4) / Γ(3/4) / A.
        /// </para>
        /// </summary>
        public static class GlaisherKinkelin {
            public static readonly decimal A_m = 1.28242712910062263687534256886979172m;
            public static readonly double A_d = 1.2824271291006226d;
            public static readonly float A_f = 1.28242712f;
        }

        /// <summary>
        /// <para>λ (Lambda): Golomb-Dickman constant
        /// </para><para>The Golomb-Dickman constant λ is a mathematical constant that arises in the study of combinatorics and number theory.
        /// </para><para>It is approximately 0.62432998854355087099293638310083724...
        /// </para><para>The Golomb-Dickman constant is related to the Dickman function ρ(x) and the Riemann zeta function ζ(s) by the formula ρ(x) = ζ(λ) / ζ(λ + 1).
        /// </para>
        /// </summary>
        public static class GolombDickman {
            public static readonly decimal Lambda_m = 0.62432998854355087099293638310083724m;
            public static readonly double Lambda_d = 0.6243299885435509d;
            public static readonly float Lambda_f = 0.62432998f;
        }

        /// <summary>
        /// <para>K0: Khinchin's constant
        /// </para><para>Khinchin's constant K is a mathematical constant that arises in the study of continued fractions and plays a role in the modern formulation of the law of large numbers.
        /// </para><para>Khinchin's constant is approximately 2.68545200106530644530971483548179569...
        /// </para><para>Khinchin proved that for almost all real numbers, the sequence of partial quotients of its continued fraction representation tends to K in the mean.
        /// </para>
        /// </summary>
        public static class Khinchin {
            public static readonly decimal K0_m = 2.68545200106530644530971483548179569m;
            public static readonly double K0_d = 2.6854520010653064d;
            public static readonly float K0_f = 2.68545200f;
        }

        /// <summary>
        /// <para>b: Landau-Ramanujan constant
        /// </para><para>The Landau–Ramanujan constant is a mathematical constant occurring in the asymptotic expansion of the partition function, which counts the number of ways of writing a positive integer as a sum of positive integers. It is named after Edmund Landau and Srinivasa Ramanujan.
        /// </para><para>The constant is approximately 0.76422365358922066299069873125009232...
        /// </para><para>The Landau–Ramanujan constant is related to the Dedekind eta function by the formula η(i) = eπ√(2/3) / (2π)^(1/4) / Γ(1/4) / Γ(3/4) / ζ(3/2) / Λ, where Λ is the Landau–Ramanujan constant.
        /// </para>
        /// </summary>
        public static class LandauRamanujan {
            public static readonly decimal b_m = 0.76422365358922066299069873125009232m;
            public static readonly double b_d = 0.7642236535892207d;
            public static readonly float b_f = 0.76422365f;
        }

        /// <summary>
        /// <para>Lieb's square ice constant
        /// </para><para>Lieb's square ice constant is a mathematical constant occurring in the study of the square ice model in statistical mechanics. It is named after Elliott Lieb.
        /// </para><para>The constant is approximately 1.539600717839002038691063...
        /// </para><para>It is used in the field of combinatorics to quantify the number of Eulerian orientations of grid graphs.
        /// </para>
        /// </summary>
        public static class LiebSquareIce {
            public static readonly decimal Lieb_m = 1.539600717839002038691063m;
            public static readonly double Lieb_d = 1.5396007178390020d;
            public static readonly float Lieb_f = 1.53960071f;
        }

        /// <summary>
        /// <para>M: Meissel-Mertens constant
        /// </para><para>The Meissel–Mertens constant M is a mathematical constant occurring in the asymptotic expansion of the prime-counting function, which counts the number of prime numbers less than a given number. It is named after Ernst Meissel and Franz Mertens.
        /// </para><para>The constant is approximately 0.26149721284764278375542683860869585...
        /// </para><para>It is defined as the limiting difference between the harmonic series summed only over the prime numbers and the natural logarithm of the natural logarithm function, or equivalently as the limiting difference between the sum of the reciprocals of the prime numbers and the natural logarithm of the natural logarithm function.
        /// </para>
        /// </summary>
        public static class MeisselMertens {
            public static readonly decimal M_m = 0.26149721284764278375542683860869585m;
            public static readonly double M_d = 0.2614972128476428d;
            public static readonly float M_f = 0.26149721f;
        }

        /// <summary>
        /// <para>A: Mills' constant
        /// </para><para>Mills' constant A is a mathematical constant occurring in a certain theorem about prime numbers that are generated by a deterministic finite-state machine. It is named after William H. Mills who proved in 1947 the existence of such a constant.
        /// </para><para>The constant is approximately 1.30637788386308069046861449260260571...
        /// </para><para>The theorem states that there is a positive real number A such that ⌊A^(3^n)⌋ is a prime number for all positive integers n. The smallest such A is given by Mills' constant.
        /// </para>
        /// </summary>
        public static class Mills {
            public static readonly decimal A_m = 1.30637788386308069046861449260260571m;
            public static readonly double A_d = 1.3063778838630807d;
            public static readonly float A_f = 1.30637788f;
        }

        /// <summary>
        /// <para>φ: Phi
        /// </para><para>The golden ratio Phi, often denoted by the Greek letter φ (phi), is a mathematical constant that appears in various fields of science, art, and nature.
        /// </para><para>It is defined as the positive solution to the quadratic equation x = 1 + 1/x, and its approximate value is φ ≈ 1.6180339887498948482045868343656...
        /// </para><para>The golden ratio is known for its aesthetic properties and has been used in art and architecture for centuries. It appears in the proportions of natural objects, such as the spirals in seashells and the arrangement of leaves on stems.
        /// Phi is also closely related to the Fibonacci sequence, where the ratio of consecutive Fibonacci numbers approaches Phi as the sequence progresses.
        /// Beyond its visual appeal, Phi has intriguing connections in mathematics, including its appearance in the solution to the quadratic equation, continued fractions, and various geometric shapes.
        /// </para>
        /// </summary>
        public static class Phi {
            public static readonly decimal Phi_m = 1.6180339887498948482045868343656m;
            public static readonly double Phi_d = 1.618033988749895d;
            public static readonly float Phi_f = 1.6180339f;

            public static int CalculateLucasNumber( int power ) {
                decimal lucasValue = Decimal.Multiply((decimal)Math.Pow(Phi_d, power), (decimal)(1 / Mathf.Sqrt(5)));
                return (int)lucasValue;
            }
        }

        /// <summary>
        /// <para>ρ (Rho): Plastic number
        /// </para><para>The plastic number ρ is a mathematical constant that is the unique real solution of the cubic equation x^3 = x + 1. A plastic number is also known as the plastic constant, the minimal Pisot number, the platin number, the silver number, the bronze number, or the octonacci constant.
        /// </para><para>The constant is approximately 1.32471795724474602596090885447809734...
        /// </para><para>The plastic number is also known as the minimal Pisot number, because it is the smallest Pisot number. It is also the smallest possible Pisot–Vijayaraghavan number, and the smallest possible Pisot–Erdős number.
        /// </para><para>It is used in the plastic number base, a non-standard positional numeral system, for its good irrationality properties.
        /// </para>
        /// </summary>
        public static class Plastic {
            public static readonly decimal P_m = 1.32471795724474602596090885447809734m;
            public static readonly double P_d = 1.324717957244746d;
            public static readonly float P_f = 1.32471795f;
        }

        /// <summary>
        /// <para>Porter's constant
        /// </para><para>Porter's constant is the constant appearing in formulas for the efficiency of the Euclidean algorithm.
        /// </para><para>It is approximately 1.467078079433975472897798...
        /// </para>
        /// </summary>
        public static class Porter {
            public static readonly decimal C_m = 1.467078079433975472897798m;
            public static readonly double C_d = 1.467078079433975d;
            public static readonly float C_f = 1.46707808f;
        }

        /// <summary>
        /// <para>Ω: Omega
        /// </para><para>Omega is the unique real number such that e^Ω = Ω + 1. It is also called the infinite thorn, since it is an infinitely large number that is also infinitely close to zero.
        /// </para><para>Omega is approximately 0.56714329040978387299996866221035555...
        /// </para><para>Omega is the limit of the sequence x_0 = 0, x_(n+1) = e^(-x_n), which converges to Omega for any starting value x_0 > -1.
        /// </para><para>Omega is also the unique fixed point of the Lambert W function, which is defined as the inverse of the function f(x) = xe^x.
        /// </para>
        /// </summary>
        public static class Omega {
            public static readonly decimal Omega_m = 0.56714329040978387299996866221035555m;
            public static readonly double Omega_d = 0.5671432904097839d;
            public static readonly float Omega_f = 0.56714329f;
        }

        /// <summary>
        /// <para>μ (Mu): Ramanujan-Soldner constant
        /// </para><para>The Ramanujan–Soldner constant μ is a mathematical constant that is defined as the unique positive zero of the logarithmic integral function. It is named after Srinivasa Ramanujan and Johann Georg von Soldner.
        /// </para><para>The constant is approximately 1.45136923488338105028396848589202744...
        /// </para><para>The Ramanujan-Soldner constant is used for solving Lambert's problem in orbital mechanics, which is the problem of determining the time of flight to move between two points in space, given the positions and velocities at those two points.
        /// </para>
        /// </summary>
        public static class RamanujanSoldner {
            public static readonly decimal R_m = 1.45136923488338105028396848589202744m;
            public static readonly double R_d = 1.451369234883381d;
            public static readonly float R_f = 1.45136923f;
        }

        /// <summary>
        /// <para>ψ (Psi): Reciprocal Fibonacci constant
        /// </para><para>The reciprocal Fibonacci constant ψ is a mathematical constant defined as the sum of the reciprocals of the Fibonacci numbers.
        /// </para><para>The constant is approximately 3.35988566624317755317201130291892718...
        /// </para><para>The ratio of the successive terms tends to the reciprocal of the Golden Ratio.
        /// </para>
        /// </summary>
        public static class ReciprocalFibonacci {
            public static readonly decimal Psi_m = 3.35988566624317755317201130291892718m;
            public static readonly double Psi_d = 3.359885666243177d;
            public static readonly float Psi_f = 3.35988566f;
        }

        /// <summary>
        /// <para>√2: The Square Root of 2
        /// </para><para>The Square Root of 2 is the length of the hypotenuse of a right triangle with unit base and altitude, denoted mathematically as √2 or 2^(1/2). It has been proved that √2 is irrational.
        /// </para><para>It is also known as Pythagoras' constant, named after the ancient Greek mathematician.
        /// </para><para>It is approximately 1.41421356237309504880168872420969808...
        /// </para><para>The fraction √2/2 is the probability that, when two integers are chosen at random, they have no common divisors (other than 1). The square root of 2 is also the central value in the Gaussian distribution.
        /// </para>
        /// </summary>
        public static class Root2 {
            public static readonly decimal root2_m = 1.41421356237309504880168872420969808m;
            public static readonly double root2_d = 1.4142135623730951d;
            public static readonly float root2_f = 1.41421356f;
        }

        /// <summary>
        /// <para>√3: The Square Root of 3
        /// </para><para>The Square Root of 3 is the length of the diagonal of a cube with unit sides, and is the highest number which is the hypotenuse of two right-angled triangles with unit sides.
        /// </para><para>It is approximately 1.73205080756887729352744634150587236...
        /// </para><para>It is also known as Theodorus' constant, named after Theodorus of Cyrene, a Greek philosopher and mathematician.
        /// </para><para>The square root of 3 is also the central value in the Cauchy distribution.
        /// </para><para>√3 is the probability that, when three integers are chosen at random, they have no common divisors (other than 1).
        /// </para>
        /// </summary>
        public static class Root3 {
            public static readonly decimal root3_m = 1.73205080756887729352744634150587236m;
            public static readonly double root3_d = 1.7320508075688772d;
            public static readonly float root3_f = 1.73205081f;
        }

        /// <summary>
        /// <para>√5: The Square Root of 5
        /// </para><para>The Square Root of 5 is the length of the hypotenuse of right-angled triangles with unit sides 1 and 2.
        /// </para><para>It is approximately 2.23606797749978969640917366873127623...
        /// </para><para>This number appears in the expression for the golden ratio, and is also equal to the reciprocal of the golden ratio minus 1.
        /// </para>
        /// </summary>
        public static class Root5 {
            public static readonly decimal root5_m = 2.23606797749978969640917366873127623m;
            public static readonly double root5_d = 2.23606797749979d;
            public static readonly float root5_f = 2.23606798f;
        }

        /// <summary>
        /// <para>P: Universal Parabolic Constant
        /// </para><para>The Universal Parabolic Constant is defined as the ratio, for any parabola, of the arc length of the parabolic segment formed by the latus rectum to the focal parameter.
        /// </para><para>It is approximately 2.29558714939263807403429804918949039...
        /// </para><para>The circle and parabola are unique among conic sections in that they have a universal constant. The analogous ratios for ellipses and hyperbolas depend on their eccentricities. This means that all circles are similar and all parabolas are similar, whereas ellipses and hyperbolas are not.
        /// </para>
        /// </summary>
        public static class UniversalParabolic {
            public static readonly decimal P_m = 2.29558714939263807403429804918949039m;
            public static readonly double P_d = 2.29558714939264d;
            public static readonly float P_f = 2.29558715f;
        }
    }
}
