using System;
using OpenCVForUnity.UnityUtils;

namespace OpenCVForUnity.CoreModule
{
    public partial class Point3
    {

        //

        #region Operators

        // (here p stand for a point ( Point3 ), alpha for a real-valued scalar ( double ).)

        #region Unary

        // -p
        public static Point3 operator -(Point3 a)
        {
            return new Point3(-a.x, -a.y, -a.z);
        }

        #endregion

        #region Binary

        // p + p
        public static Point3 operator +(Point3 a, Point3 b)
        {
            return new Point3(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        // p - p
        public static Point3 operator -(Point3 a, Point3 b)
        {
            return new Point3(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        // p * alpha, alpha * p
        public static Point3 operator *(Point3 a, double b)
        {
            return new Point3(a.x * b, a.y * b, a.z * b);
        }

        public static Point3 operator *(double a, Point3 b)
        {
            return new Point3(b.x * a, b.y * a, b.z * a);
        }

        // p / alpha
        public static Point3 operator /(Point3 a, double b)
        {
            return new Point3(a.x / b, a.y / b, a.z / b);
        }

        #endregion

        #region Comparison

        public bool Equals(Point3 a)
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
            return this.x == a.x && this.y == a.y && this.z == a.z;
        }

        // p == p
        public static bool operator ==(Point3 a, Point3 b)
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
            return a.x == b.x && a.y == b.y && a.z == b.z;
        }

        // p != p
        public static bool operator !=(Point3 a, Point3 b)
        {
            return !(a == b);
        }

        #endregion

        #endregion

        //
    }
}
