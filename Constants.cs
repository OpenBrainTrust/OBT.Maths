using System;
using UnityEngine;

namespace OBT.Maths {
    /// <summary>
    /// <para>φ: Phi
    /// </para><para>
    /// The golden ratio Phi, often denoted by the Greek letter φ (phi), is a mathematical constant that appears in various fields of science, art, and nature.
    /// </para><para>
    /// It is defined as the positive solution to the quadratic equation x = 1 + 1/x, and its approximate value is φ ≈ 1.6180339887498948482045868343656...
    /// </para><para>
    /// The golden ratio is known for its aesthetic properties and has been used in art and architecture for centuries. It appears in the proportions of natural objects, such as the spirals in seashells and the arrangement of leaves on stems.
    /// Phi is also closely related to the Fibonacci sequence, where the ratio of consecutive Fibonacci numbers approaches Phi as the sequence progresses.
    /// Beyond its visual appeal, Phi has intriguing connections in mathematics, including its appearance in the solution to the quadratic equation, continued fractions, and various geometric shapes.
    /// </para>
    /// </summary>
    public static class Phi {
        public static readonly decimal Phi_m = 1.6180339887498948482045868343656m;
        public static readonly double Phi_d = 1.618033988749895d;
        public static readonly float Phi_f = 1.618034f;

        public static int CalculateLucasNumber( int power ) {
            decimal lucasValue = Decimal.Multiply((decimal)Math.Pow(Phi_d, power), (decimal)(1 / Mathf.Sqrt(5)));
            return (int)lucasValue;
        }
    }

    /// <summary>
    /// <para>γ: Gamma
    /// </para><para>
    /// The Euler-Mascheroni constant, also known as Euler's constant or simply "gamma," is a constant that appears in many problems in analytic number theory and calculus.
    /// </para><para>It is denoted by γ, and the first few digits of this constant are as follows: γ ≈ 0.57721566490153286060651209008240243…
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
    /// <para>ζ(3)
    /// </para><para>
    /// The Apéry's constant, denoted by ζ(3), is a mathematical constant that appears in number theory and mathematical analysis.
    /// </para><para>It is related to the Riemann zeta function evaluated at 3: ζ(3) = 1.20205690315959428539973816151144999…
    /// </para><para>
    /// The value of ζ(3) is of great interest in number theory and has connections to various unsolved problems, including the irrationality of certain numbers.
    /// </para>
    /// </summary>
    public static class Apery {
        public static readonly decimal Zeta3_m = 1.20205690315959428539973816151144999m;
        public static readonly double Zeta3_d = 1.2020569031595942d;
        public static readonly float Zeta3_f = 1.2020569f;
    }

    /// <summary>
    /// <para>α: Alpha
    /// </para><para>
    /// Feigenbaum's constant α is a mathematical constant that emerges in the study of chaos theory and bifurcation in dynamical systems.
    /// It is approximately 2.50290787509589282228390287321821.
    /// </para><para>
    /// The value of α appears as a universal scaling factor in the period-doubling route to chaos and is integral in understanding the transition to chaotic behavior in various nonlinear systems.
    /// Beyond its significance in the field of chaos theory, α connects various mathematical properties and has intriguing relations with other constants.
    /// </para><para>δ: Delta
    /// </para><para>
    /// Feigenbaum's constant δ is another mathematical constant closely related to the study of chaos and bifurcation in dynamical systems.
    /// It is approximately 4.66920160910299067185320382046620161.
    /// </para><para>
    /// The constant δ arises in the context of universality in the period-doubling route to chaos, similar to α. It represents the scaling factor for the horizontal displacement between successive bifurcation points.
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
    /// <para>G
    /// </para><para>Catalan's constant G is a mathematical constant with significance in number theory and analysis.
    /// </para><para>
    /// It is approximately 0.915965594177219.
    /// </para><para>
    /// G appears in various mathematical problems, related to special functions, integrals, and series. 
    /// It's linked to unsolved questions and has applications in scientific fields.
    /// </para>
    /// </summary>
    public static class Catalan {
        public static readonly decimal G_m = 0.91596559417721901505460351493238411m;
        public static readonly double G_d = 0.915965594177219d;
        public static readonly float G_f = 0.91596559f;
    }
}
