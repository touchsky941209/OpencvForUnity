using System;
using OpenCVForUnity.UnityUtils;

namespace OpenCVForUnity.CoreModule
{

    public partial class Size
    {

        //

        #region Operators

        // (here S stand for a size ( Size ), alpha for a real-valued scalar ( double ).)

        #region Binary

        // S + S
        public static Size operator +(Size a, Size b)
        {
            return new Size(a.width + b.width, a.height + b.height);
        }

        // S - S
        public static Size operator -(Size a, Size b)
        {
            return new Size(a.width - b.width, a.height - b.height);
        }

        // S * alpha
        public static Size operator *(Size a, double b)
        {
            return new Size(a.width * b, a.height * b);
        }

        // S / alpha
        public static Size operator /(Size a, double b)
        {
            return new Size(a.width / b, a.height / b);
        }

        #endregion

        #region Comparison

        public bool Equals(Size a)
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
            return this.width == a.width && this.height == a.height;
        }

        // S == S
        public static bool operator ==(Size a, Size b)
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
            return a.width == b.width && a.height == b.height;
        }

        // S != S
        public static bool operator !=(Size a, Size b)
        {
            return !(a == b);
        }

        #endregion

        #endregion

        //
    }
}

