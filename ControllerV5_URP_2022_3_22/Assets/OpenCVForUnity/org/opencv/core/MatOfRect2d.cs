using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;

namespace OpenCVForUnity.CoreModule
{
    public class MatOfRect2d : Mat
    {

        // 32SC4
        private const int _depth = CvType.CV_64F;
        private const int _channels = 4;

        public MatOfRect2d()
            : base()
        {

        }

        protected MatOfRect2d(IntPtr addr)
            : base(addr)
        {

            if (!empty() && checkVector(_channels, _depth) < 0)
                throw new CvException("Incompatible Mat");
            //FIXME: do we need release() here?
        }

        public static MatOfRect2d fromNativeAddr(IntPtr addr)
        {
            return new MatOfRect2d(addr);
        }

        public MatOfRect2d(Mat m)
            : base(m, Range.all())
        {

            if (!empty() && checkVector(_channels, _depth) < 0)
                throw new CvException("Incompatible Mat");
            //FIXME: do we need release() here?
        }

        public MatOfRect2d(params Rect2d[] a)
            : base()
        {

            fromArray(a);
        }

        public void alloc(int elemNumber)
        {
            if (elemNumber > 0)
                base.create(elemNumber, 1, CvType.makeType(_depth, _channels));
        }

        public void fromArray(params Rect2d[] a)
        {
            if (a == null || a.Length == 0)
                return;
            int num = a.Length;
            alloc(num);

            Converters.Array_Rect2d_to_Mat(a, this, num);
        }

        public Rect2d[] toArray()
        {
            int num = (int)total();
            Rect2d[] a = new Rect2d[num];
            if (num == 0)
                return a;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Rect2d();
            }
            Converters.Mat_to_Array_Rect2d(this, a, num);
            return a;
        }

        public void fromList(List<Rect2d> lr)
        {
            if (lr == null || lr.Count == 0)
                return;
            int num = lr.Count;
            alloc(num);

            Converters.List_Rect2d_to_Mat(lr, this, num);
        }

        public List<Rect2d> toList()
        {
            int num = (int)total();
            List<Rect2d> a = new List<Rect2d>(num);
            if (num == 0)
                return a;

            for (int i = 0; i < num; i++)
            {
                a.Add(new Rect2d());
            }
            Converters.Mat_to_List_Rect2d(this, a, num);
            return a;
        }
    }
}
