using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;

namespace OpenCVForUnity.CoreModule
{
    public class MatOfDMatch : Mat
    {
        // 32FC4
        private const int _depth = CvType.CV_32F;
        private const int _channels = 4;

        public MatOfDMatch()
            : base()
        {

        }

        protected MatOfDMatch(IntPtr addr)
            : base(addr)
        {

            if (!empty() && checkVector(_channels, _depth) < 0)
                throw new CvException("Incompatible Mat: " + ToString());
            //FIXME: do we need release() here?
        }

        public static MatOfDMatch fromNativeAddr(IntPtr addr)
        {
            return new MatOfDMatch(addr);
        }

        public MatOfDMatch(Mat m)
            : base(m, Range.all())
        {
            if (m != null)
                m.ThrowIfDisposed();


            if (!empty() && checkVector(_channels, _depth) < 0)
                throw new CvException("Incompatible Mat: " + ToString());
            //FIXME: do we need release() here?
        }

        public MatOfDMatch(params DMatch[] ap)
            : base()
        {

            fromArray(ap);
        }

        public void alloc(int elemNumber)
        {
            if (elemNumber > 0)
                base.create(elemNumber, 1, CvType.makeType(_depth, _channels));
        }

        public void fromArray(params DMatch[] a)
        {
            if (a == null || a.Length == 0)
                return;
            int num = a.Length;
            alloc(num);

            Converters.Array_DMatch_to_Mat(a, this, num, CvType.CV_32FC4);
        }

        public DMatch[] toArray()
        {
            int num = (int)total();
            DMatch[] a = new DMatch[num];
            if (num == 0)
                return a;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new DMatch();
            }
            Converters.Mat_to_Array_DMatch(this, a, num, CvType.CV_32FC4);
            return a;
        }

        public void fromList(List<DMatch> ldm)
        {
            if (ldm == null || ldm.Count == 0)
                return;
            int num = ldm.Count;
            alloc(num);

            Converters.List_DMatch_to_Mat(ldm, this, num, CvType.CV_32FC4);
        }

        public List<DMatch> toList()
        {
            int num = (int)total();
            List<DMatch> a = new List<DMatch>(num);
            if (num == 0)
                return a;

            for (int i = 0; i < num; i++)
            {
                a.Add(new DMatch());
            }
            Converters.Mat_to_List_DMatch(this, a, num, CvType.CV_32FC4);
            return a;
        }
    }
}
