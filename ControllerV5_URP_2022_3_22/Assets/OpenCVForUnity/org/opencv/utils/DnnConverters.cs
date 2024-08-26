#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using System.Collections.Generic;

namespace OpenCVForUnity.UtilsModule
{
    public partial class Converters
    {

        public static Mat vector_MatShape_to_Mat(List<MatOfInt> matshapes)
        {

            Mat res;
            int count = (matshapes != null) ? matshapes.Count : 0;
            if (count > 0)
            {
                res = new Mat(count, 1, CvType.CV_32SC2);
                Converters.List_Mat_to_Mat<MatOfInt>(matshapes, res, count);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static void Mat_to_vector_Target(Mat m, List<int> targets)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (targets == null)
                throw new CvException("targets == null");
            int count = m.rows();
            if (CvType.CV_32SC1 != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_32SC1 != m.type() ||  m.cols()!=1\n" + m);

            targets.Clear();
            for (int i = 0; i < count; i++)
            {
                targets.Add(0);
            }
            Converters.Mat_to_List_int(m, targets, count, CvType.CV_32SC1);
        }
    }
}
#endif