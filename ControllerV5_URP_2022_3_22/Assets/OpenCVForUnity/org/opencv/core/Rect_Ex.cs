using System;
using OpenCVForUnity.UnityUtils;

namespace OpenCVForUnity.CoreModule
{

    public partial class Rect
    {

        //

        #region Operators

        // (here R stand for a rect ( Rect ), p for a point ( Point ), S for a size ( Size ).)

        #region Binary

        // R + p, R + S
        public static Rect operator +(Rect a, Point b)
        {
            return new Rect(a.x + (int)b.x, a.y + (int)b.y, a.width, a.height);
        }

        public static Rect operator +(Rect a, Size b)
        {
            return new Rect(a.x, a.y, a.width + (int)b.width, a.height + (int)b.height);
        }

        // R - p, R - S
        public static Rect operator -(Rect a, Point b)
        {
            return new Rect(a.x - (int)b.x, a.y - (int)b.y, a.width, a.height);
        }

        public static Rect operator -(Rect a, Size b)
        {
            return new Rect(a.x, a.y, a.width - (int)b.width, a.height - (int)b.height);
        }

        // R & R
        public static Rect operator &(Rect a, Rect b)
        {
            return intersect(a, b);
        }

        // R | R
        public static Rect operator |(Rect a, Rect b)
        {
            return union(a, b);
        }

        #endregion

        #region Comparison

        public bool Equals(Rect a)
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
            return this.x == a.x && this.y == a.y && this.width == a.width && this.height == a.height;
        }

        // R == R
        public static bool operator ==(Rect a, Rect b)
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
            return a.x == b.x && a.y == b.y && a.width == b.width && a.height == b.height;
        }

        // R != R
        public static bool operator !=(Rect a, Rect b)
        {
            return !(a == b);
        }

        #endregion

        #endregion

        public bool contains(int x, int y)
        {
            return this.x <= x && x < this.x + this.width && this.y <= y && y < this.y + this.height;
        }

        public bool contains(Rect rect)
        {
            return x <= rect.x &&
            (rect.x + rect.width) <= (x + width) &&
            y <= rect.y &&
            (rect.y + rect.height) <= (y + height);
        }

        public void inflate(int width, int height)
        {
            this.x -= width;
            this.y -= height;
            this.width += (2 * width);
            this.height += (2 * height);
        }

        public void inflate(Size size)
        {
            inflate((int)size.width, (int)size.height);
        }

        public static Rect inflate(Rect rect, int x, int y)
        {
            rect.inflate(x, y);
            return rect;
        }

        public static Rect intersect(Rect a, Rect b)
        {
            int x1 = Math.Max(a.x, b.x);
            int x2 = Math.Min(a.x + a.width, b.x + b.width);
            int y1 = Math.Max(a.y, b.y);
            int y2 = Math.Min(a.y + a.height, b.y + b.height);

            if (x2 >= x1 && y2 >= y1)
                return new Rect(x1, y1, x2 - x1, y2 - y1);
            return new Rect();
        }

        public Rect intersect(Rect rect)
        {
            return intersect(this, rect);
        }

        public bool intersectsWith(Rect rect)
        {
            return (
                (x < rect.x + rect.width) &&
                (x + width > rect.x) &&
                (y < rect.y + rect.height) &&
                (y + height > rect.y)
            );
        }

        public Rect union(Rect rect)
        {
            return union(this, rect);
        }

        public static Rect union(Rect a, Rect b)
        {
            int x1 = Math.Min(a.x, b.x);
            int x2 = Math.Max(a.x + a.width, b.x + b.width);
            int y1 = Math.Min(a.y, b.y);
            int y2 = Math.Max(a.y + a.height, b.y + b.height);

            return new Rect(x1, y1, x2 - x1, y2 - y1);
        }
        //
    }
}