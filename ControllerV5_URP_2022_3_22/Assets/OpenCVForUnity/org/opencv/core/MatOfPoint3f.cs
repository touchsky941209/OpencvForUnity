using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;

namespace OpenCVForUnity.CoreModule
{
    public class MatOfPoint3f : Mat
    {
        // 32FC3
        private const int _depth = CvType.CV_32F;
        private const int _channels = 3;

        public MatOfPoint3f()
            : base()
        {

        }

        protected MatOfPoint3f(IntPtr addr)
            : base(addr)
        {

            if (!empty() && checkVector(_channels, _depth) < 0)
                throw new CvException("Incompatible Mat");
            //FIXME: do we need release() here?
        }

        public static MatOfPoint3f fromNativeAddr(IntPtr addr)
        {
            return new MatOfPoint3f(addr);
        }

        public MatOfPoint3f(Mat m)
            : base(m, Range.all())
        {
            if (m != null)
                m.ThrowIfDisposed();


            if (!empty() && checkVector(_channels, _depth) < 0)
                throw new CvException("Incompatible Mat");
            //FIXME: do we need release() here?
        }

        public MatOfPoint3f(params Point3[] a)
            : base()
        {

            fromArray(a);
        }

        public void alloc(int elemNumber)
        {
            if (elemNumber > 0)
                base.create(elemNumber, 1, CvType.makeType(_depth, _channels));
        }

        public void fromArray(params Point3[] a)
        {
            if (a == null || a.Length == 0)
                return;
            int num = a.Length;
            alloc(num);

            Converters.Array_Point3_to_Mat(a, this, num, CvType.CV_32FC3);
        }

        public Point3[] toArray()
        {
            int num = (int)total();
            Point3[] ap = new Point3[num];
            if (num == 0)
                return ap;

            for (int i = 0; i < ap.Length; i++)
            {
                ap[i] = new Point3();
            }
            Converters.Mat_to_Array_Point3(this, ap, num, CvType.CV_32FC3);
            return ap;
        }

        public void fromList(List<Point3> lp)
        {
            if (lp == null || lp.Count == 0)
                return;
            int num = lp.Count;
            alloc(num);

            Converters.List_Point3_to_Mat(lp, this, num, CvType.CV_32FC3);
        }

        public List<Point3> toList()
        {
            int num = (int)total();
            List<Point3> ap = new List<Point3>(num);
            if (num == 0)
                return ap;

            for (int i = 0; i < num; i++)
            {
                ap.Add(new Point3());
            }
            Converters.Mat_to_List_Point3(this, ap, num, CvType.CV_32FC3);
            return ap;
        }
    }

}