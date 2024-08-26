using System;
using System.Linq;
using OpenCVForUnity.UnityUtils;

namespace OpenCVForUnity.CoreModule
{

    public partial class Scalar
    {

        //

        #region Operators

        // (here s stand for a scalar ( Scalar ), alpha for a real-valued scalar ( double ).)

        #region Unary

        // -s
        public static Scalar operator -(Scalar a)
        {
            return new Scalar(-a.val[0], -a.val[1], -a.val[2], -a.val[3]);
        }

        #endregion

        #region Binary

        // s + s
        public static Scalar operator +(Scalar a, Scalar b)
        {
            return new Scalar(a.val[0] + b.val[0], a.val[1] + b.val[1], a.val[2] + b.val[2], a.val[3] + b.val[3]);
        }

        // s - s
        public static Scalar operator -(Scalar a, Scalar b)
        {
            return new Scalar(a.val[0] - b.val[0], a.val[1] - b.val[1], a.val[2] - b.val[2], a.val[3] - b.val[3]);
        }

        // s * s, s * alpha, alpha * s
        public static Scalar operator *(Scalar a, Scalar b)
        {
            return new Scalar((a.val[0] * b.val[0] - a.val[1] * b.val[1] - a.val[2] * b.val[2] - a.val[3] * b.val[3]),
                (a.val[0] * b.val[1] + a.val[1] * b.val[0] + a.val[2] * b.val[3] - a.val[3] * b.val[2]),
                (a.val[0] * b.val[2] - a.val[1] * b.val[3] + a.val[2] * b.val[0] + a.val[3] * b.val[1]),
                (a.val[0] * b.val[3] + a.val[1] * b.val[2] - a.val[2] * b.val[1] + a.val[3] * b.val[0]));
        }

        public static Scalar operator *(Scalar a, double alpha)
        {
            return new Scalar(a.val[0] * alpha, a.val[1] * alpha, a.val[2] * alpha, a.val[3] * alpha);
        }

        public static Scalar operator *(double alpha, Scalar a)
        {
            return a * alpha;
        }

        // s / s, s / alpha, alpha / s
        public static Scalar operator /(Scalar a, Scalar b)
        {
            return a * (1 / b);
        }

        public static Scalar operator /(Scalar a, double alpha)
        {
            double s = 1 / alpha;
            return new Scalar(a.val[0] * s, a.val[1] * s, a.val[2] * s, a.val[3] * s);
        }

        public static Scalar operator /(double a, Scalar b)
        {
            double s = a / (b.val[0] * b.val[0] + b.val[1] * b.val[1] + b.val[2] * b.val[2] + b.val[3] * b.val[3]);
            return b.conj() * s;
        }

        #endregion

        #region Comparison

        public bool Equals(Scalar a)
        {
            // If both are same instance, return true.
            if (System.Object.ReferenceEquals(this, a))
            {
                return true;
            }

            // If object is null, return false.
            if ((object)a == null)
            {
                return false;
            }

            // Return true if the fields match:
            if (!this.val.SequenceEqual(a.val))
                return false;
            return true;
        }

        // s == s
        public static bool operator ==(Scalar a, Scalar b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            if (!a.val.SequenceEqual(b.val))
                return false;
            return true;
        }

        // s != s
        public static bool operator !=(Scalar a, Scalar b)
        {
            return !(a == b);
        }

        #endregion

        #endregion

        //
    }
}
