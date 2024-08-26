using System;
using OpenCVForUnity.UnityUtils;

namespace OpenCVForUnity.CoreModule
{

    public partial class Range
    {

        //

        #region Operators

        // (here r stand for a range ( Range ), alpha for a real-valued scalar ( int ).)

        #region Unary

        // !r
        public static bool operator !(Range r)
        {
            return r.start == r.end;
        }

        #endregion

        #region Binary

        // r + alpha, alpha + r
        public static Range operator +(Range r1, int delta)
        {
            return new Range(r1.start + delta, r1.end + delta);
        }

        public static Range operator +(int delta, Range r1)
        {
            return new Range(r1.start + delta, r1.end + delta);
        }

        // r - alpha
        public static Range operator -(Range r1, int delta)
        {
            return r1 + (-delta);
        }

        // r & r
        public static Range operator &(Range r1, Range r2)
        {
            Range r = new Range(Math.Max(r1.start, r2.start), Math.Min(r1.end, r2.end));
            r.end = Math.Max(r.end, r.start);
            return r;
        }

        #endregion

        #region Comparison

        public bool Equals(Range a)
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
            return this.start == a.start && this.end == a.end;
        }

        // R == R
        public static bool operator ==(Range a, Range b)
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
            return a.start == b.start && a.end == b.end;
        }

        // R != R
        public static bool operator !=(Range a, Range b)
        {
            return !(a == b);
        }

        #endregion

        #endregion

        //
    }
}
