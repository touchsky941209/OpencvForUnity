using OpenCVForUnity.UnityUtils;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;

namespace OpenCVForUnity.CoreModule
{
    public class MatOfFloat4 : Mat
    {
        // 32FC4
        private const int _depth = CvType.CV_32F;
        private const int _channels = 4;

        public MatOfFloat4()
            : base()
        {

        }

        protected MatOfFloat4(IntPtr addr)
            : base(addr)
        {

            if (!empty() && checkVector(_channels, _depth) < 0)
                throw new CvException("Incompatible Mat");
            //FIXME: do we need release() here?
        }

        public static MatOfFloat4 fromNativeAddr(IntPtr addr)
        {
            return new MatOfFloat4(addr);
        }

        public MatOfFloat4(Mat m)
            : base(m, Range.all())
        {
            if (m != null)
                m.ThrowIfDisposed();


            if (!empty() && checkVector(_channels, _depth) < 0)
                throw new CvException("Incompatible Mat");
            //FIXME: do we need release() here?
        }

        public MatOfFloat4(params float[] a)
            : base()
        {

            fromArray(a);
        }

        public void alloc(int elemNumber)
        {
            if (elemNumber > 0)
                base.create(elemNumber, 1, CvType.makeType(_depth, _channels));
        }

        public void fromArray(params float[] a)
        {
            if (a == null || a.Length == 0)
                return;
            int num = a.Length / _channels;
            alloc(num);

            if (isContinuous())
            {
                MatUtils.copyToMat<float>(a, this);
            }
            else
            {
                if (dims() <= 2)
                {
                    MatUtils.copyToMat<float>(a, this);
                }
                else
                {
                    put(0, 0, a); //TODO: check ret val!
                }
            }
        }

        public float[] toArray()
        {
            int num = checkVector(_channels, _depth);
            if (num < 0)
                throw new CvException("Native Mat has unexpected type or size: " + ToString());
            float[] a = new float[num * _channels];
            if (num == 0)
                return a;

            if (isContinuous())
            {
                MatUtils.copyFromMat<float>(this, a);
            }
            else
            {
                if (dims() <= 2)
                {
                    MatUtils.copyFromMat<float>(this, a);
                }
                else
                {
                    get(0, 0, a); //TODO: check ret val!
                }
            }
            return a;
        }

        public void fromList(List<float> lb)
        {
            if (lb == null || lb.Count == 0)
                return;

            int num = lb.Count / _channels;
            alloc(num);

            Converters.List_float_to_Mat(lb, this, num, CvType.CV_32FC4);
        }

        public List<float> toList()
        {
            int num = checkVector(_channels, _depth);
            if (num < 0)
                throw new CvException("Native Mat has unexpected type or size: " + ToString());

            List<float> a = new List<float>(num);
            for (int i = 0; i < num; i++)
            {
                a.Add(0);
            }
            Converters.Mat_to_List_float(this, a, num, CvType.CV_32FC4);
            return a;
        }
    }
}
