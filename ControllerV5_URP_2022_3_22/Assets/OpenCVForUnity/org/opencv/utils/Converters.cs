using System;
#if NET_STANDARD_2_1
using System.Buffers;
#endif
using System.Collections.Generic;
using OpenCVForUnity.CoreModule;


namespace OpenCVForUnity.UtilsModule
{
    public partial class Converters
    {

        public static Mat vector_Point_to_Mat(List<Point> pts)
        {
            return vector_Point_to_Mat(pts, CvType.CV_32SC2);
        }

        public static Mat vector_Point2f_to_Mat(List<Point> pts)
        {
            return vector_Point_to_Mat(pts, CvType.CV_32FC2);
        }

        public static Mat vector_Point2d_to_Mat(List<Point> pts)
        {
            return vector_Point_to_Mat(pts, CvType.CV_64FC2);
        }

        public static Mat vector_Point_to_Mat(List<Point> pts, int type)
        {
            Mat res;
            int count = (pts != null) ? pts.Count : 0;
            if (count > 0)
            {
                res = new Mat(count, 1, type);
                List_Point_to_Mat(pts, res, count, type);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static Mat vector_Point3_to_Mat(List<Point3> pts)
        {
            return vector_Point3_to_Mat(pts, CvType.CV_32SC3);
        }

        public static Mat vector_Point3i_to_Mat(List<Point3> pts)
        {
            return vector_Point3_to_Mat(pts, CvType.CV_32SC3);
        }

        public static Mat vector_Point3f_to_Mat(List<Point3> pts)
        {
            return vector_Point3_to_Mat(pts, CvType.CV_32FC3);
        }

        public static Mat vector_Point3d_to_Mat(List<Point3> pts)
        {
            return vector_Point3_to_Mat(pts, CvType.CV_64FC3);
        }

        public static Mat vector_Point3_to_Mat(List<Point3> pts, int type)
        {
            Mat res;
            int count = (pts != null) ? pts.Count : 0;
            if (count > 0)
            {
                res = new Mat(count, 1, type);
                List_Point3_to_Mat(pts, res, count, type);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static void Mat_to_vector_Point(Mat m, List<Point> pts)
        {
            if (m != null)
                m.ThrowIfDisposed();

            Mat_to_vector_Point(m, pts, m.type());
        }
        public static void Mat_to_vector_Point2f(Mat m, List<Point> pts)
        {
            if (m != null)
                m.ThrowIfDisposed();

            Mat_to_vector_Point(m, pts, m.type());
        }

        public static void Mat_to_vector_Point2d(Mat m, List<Point> pts)
        {
            if (m != null)
                m.ThrowIfDisposed();

            Mat_to_vector_Point(m, pts, m.type());
        }

        public static void Mat_to_vector_Point(Mat m, List<Point> pts, int type)
        {

            if (pts == null)
                throw new CvException("Output List can't be null");
            int count = m.rows();
            if (m.cols() != 1)
                throw new CvException("Input Mat should have one column\n" + m);

            pts.Clear();
            for (int i = 0; i < count; i++)
            {
                pts.Add(new Point());
            }
            Mat_to_List_Point(m, pts, count, type);
        }

        public static void Mat_to_vector_Point3(Mat m, List<Point3> pts)
        {
            if (m != null)
                m.ThrowIfDisposed();

            Mat_to_vector_Point3(m, pts, m.type());
        }
        public static void Mat_to_vector_Point3i(Mat m, List<Point3> pts)
        {
            if (m != null)
                m.ThrowIfDisposed();

            Mat_to_vector_Point3(m, pts, m.type());
        }

        public static void Mat_to_vector_Point3f(Mat m, List<Point3> pts)
        {
            if (m != null)
                m.ThrowIfDisposed();

            Mat_to_vector_Point3(m, pts, m.type());
        }

        public static void Mat_to_vector_Point3d(Mat m, List<Point3> pts)
        {
            if (m != null)
                m.ThrowIfDisposed();

            Mat_to_vector_Point3(m, pts, m.type());
        }

        public static void Mat_to_vector_Point3(Mat m, List<Point3> pts, int type)
        {

            if (pts == null)
                throw new CvException("Output List can't be null");
            int count = m.rows();
            if (m.cols() != 1)
                throw new CvException("Input Mat should have one column\n" + m);

            pts.Clear();
            for (int i = 0; i < count; i++)
            {
                pts.Add(new Point3());
            }
            Mat_to_List_Point3(m, pts, count, type);
        }

        public static Mat vector_Mat_to_Mat(List<Mat> mats)
        {
            Mat res;
            int count = (mats != null) ? mats.Count : 0;
            if (count > 0)
            {
                res = new Mat(count, 1, CvType.CV_32SC2);
                Converters.List_Mat_to_Mat<Mat>(mats, res, count);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static void Mat_to_vector_Mat(Mat m, List<Mat> mats)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (mats == null)
                throw new CvException("mats == null");
            int count = m.rows();
            if (CvType.CV_32SC2 != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_32SC2 != m.type() ||  m.cols()!=1\n" + m);

            mats.Clear();
            for (int i = 0; i < count; i++)
            {
                mats.Add(new Mat());
            }
            Converters.Mat_to_List_Mat<Mat>(m, mats, count);
        }

        public static Mat vector_float_to_Mat(List<float> fs)
        {
            Mat res;
            int count = (fs != null) ? fs.Count : 0;
            if (count > 0)
            {
                res = new Mat(count, 1, CvType.CV_32FC1);
                List_float_to_Mat(fs, res, count, CvType.CV_32FC1);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static void Mat_to_vector_float(Mat m, List<float> fs)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (fs == null)
                throw new CvException("fs == null");
            int count = m.rows();
            if (CvType.CV_32FC1 != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_32FC1 != m.type() ||  m.cols()!=1\n" + m);

            fs.Clear();
            for (int i = 0; i < count; i++)
            {
                fs.Add(0);
            }
            Converters.Mat_to_List_float(m, fs, count, CvType.CV_32FC1);
        }

        public static Mat vector_uchar_to_Mat(List<byte> bs)
        {
            Mat res;
            int count = (bs != null) ? bs.Count : 0;
            if (count > 0)
            {
                res = new Mat(count, 1, CvType.CV_8UC1);
                List_uchar_to_Mat(bs, res, count);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static void Mat_to_vector_uchar(Mat m, List<byte> us)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (us == null)
                throw new CvException("Output List can't be null");
            int count = m.rows();
            if (CvType.CV_8UC1 != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_8UC1 != m.type() ||  m.cols()!=1\n" + m);

            us.Clear();
            for (int i = 0; i < count; i++)
            {
                us.Add(0);
            }
            Converters.Mat_to_List_uchar(m, us, count);
        }

        public static Mat vector_char_to_Mat(List<sbyte> bs)
        {
            Mat res;
            int count = (bs != null) ? bs.Count : 0;
            if (count > 0)
            {
                res = new Mat(count, 1, CvType.CV_8SC1);
                List_char_to_Mat(bs, res, count);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static Mat vector_int_to_Mat(List<int> _is)
        {
            Mat res;
            int count = (_is != null) ? _is.Count : 0;
            if (count > 0)
            {
                res = new Mat(count, 1, CvType.CV_32SC1);
                List_int_to_Mat(_is, res, count, CvType.CV_32SC1);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static void Mat_to_vector_int(Mat m, List<int> _is)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (_is == null)
                throw new CvException("is == null");
            int count = m.rows();
            if (CvType.CV_32SC1 != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_32SC1 != m.type() ||  m.cols()!=1\n" + m);

            _is.Clear();
            for (int i = 0; i < count; i++)
            {
                _is.Add(0);
            }
            Converters.Mat_to_List_int(m, _is, count, CvType.CV_32SC1);
        }

        public static void Mat_to_vector_char(Mat m, List<sbyte> bs)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (bs == null)
                throw new CvException("Output List can't be null");
            int count = m.rows();
            if (CvType.CV_8SC1 != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_8SC1 != m.type() ||  m.cols()!=1\n" + m);

            bs.Clear();
            for (int i = 0; i < count; i++)
            {
                bs.Add(0);
            }
            Converters.Mat_to_List_char(m, bs, count);
        }

        public static Mat vector_Rect_to_Mat(List<Rect> rs)
        {
            Mat res;
            int count = (rs != null) ? rs.Count : 0;
            if (count > 0)
            {
                res = new Mat(count, 1, CvType.CV_32SC4);
                List_Rect_to_Mat(rs, res, count);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static void Mat_to_vector_Rect(Mat m, List<Rect> rs)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (rs == null)
                throw new CvException("rs == null");
            int count = m.rows();
            if (CvType.CV_32SC4 != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_32SC4 != m.type() ||  m.rows()!=1\n" + m);

            rs.Clear();
            for (int i = 0; i < count; i++)
            {
                rs.Add(new Rect());
            }
            Converters.Mat_to_List_Rect(m, rs, count);
        }

        public static Mat vector_KeyPoint_to_Mat(List<KeyPoint> kps)
        {
            Mat res;
            int count = (kps != null) ? kps.Count : 0;
            if (count > 0)
            {
                res = new Mat(count, 1, CvType.CV_64FC(7));
                List_KeyPoint_to_Mat(kps, res, count, CvType.CV_64FC(7));
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static void Mat_to_vector_KeyPoint(Mat m, List<KeyPoint> kps)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (kps == null)
                throw new CvException("Output List can't be null");
            int count = m.rows();
            if (CvType.CV_64FC(7) != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_64FC(7) != m.type() ||  m.cols()!=1\n" + m);

            kps.Clear();
            for (int i = 0; i < count; i++)
            {
                kps.Add(new KeyPoint());
            }
            Converters.Mat_to_List_KeyPoint(m, kps, count, CvType.CV_64FC(7));
        }

        public static Mat vector_vector_Point_to_Mat(List<MatOfPoint> pts, List<Mat> mats)
        {
            Mat res;
            int lCount = (pts != null) ? pts.Count : 0;
            if (lCount > 0)
            {
                res = new Mat(lCount, 1, CvType.CV_32SC2);
                List_Mat_to_Mat<MatOfPoint>(pts, res, lCount);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static void Mat_to_vector_vector_Point(Mat m, List<MatOfPoint> pts)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (pts == null)
                throw new CvException("Output List can't be null");

            if (m == null)
                throw new CvException("Input Mat can't be null");

            int count = m.rows();
            if (CvType.CV_32SC2 != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_32SC2 != m.type() ||  m.cols()!=1\n" + m);

            pts.Clear();
            for (int i = 0; i < count; i++)
            {
                pts.Add(new MatOfPoint());
            }
            Converters.Mat_to_List_Mat(m, pts, count);
        }

        // vector_vector_Point2f
        public static void Mat_to_vector_vector_Point2f(Mat m, List<MatOfPoint2f> pts)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (pts == null)
                throw new CvException("Output List can't be null");

            if (m == null)
                throw new CvException("Input Mat can't be null");

            int count = m.rows();
            if (CvType.CV_32SC2 != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_32SC2 != m.type() ||  m.cols()!=1\n" + m);

            pts.Clear();
            for (int i = 0; i < count; i++)
            {
                pts.Add(new MatOfPoint2f());
            }
            Converters.Mat_to_List_Mat(m, pts, count);
        }

        // vector_vector_Point2f
        public static Mat vector_vector_Point2f_to_Mat(List<MatOfPoint2f> pts, List<Mat> mats)
        {
            Mat res;
            int lCount = (pts != null) ? pts.Count : 0;
            if (lCount > 0)
            {
                res = new Mat(lCount, 1, CvType.CV_32SC2);
                List_Mat_to_Mat<MatOfPoint2f>(pts, res, lCount);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        // vector_vector_Point3f
        public static void Mat_to_vector_vector_Point3f(Mat m, List<MatOfPoint3f> pts)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (pts == null)
                throw new CvException("Output List can't be null");

            if (m == null)
                throw new CvException("Input Mat can't be null");

            int count = m.rows();
            if (CvType.CV_32SC2 != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_32SC2 != m.type() ||  m.cols()!=1\n" + m);

            pts.Clear();
            for (int i = 0; i < count; i++)
            {
                pts.Add(new MatOfPoint3f());
            }
            Converters.Mat_to_List_Mat(m, pts, count);
        }

        // vector_vector_Point3f
        public static Mat vector_vector_Point3f_to_Mat(List<MatOfPoint3f> pts, List<Mat> mats)
        {
            Mat res;
            int lCount = (pts != null) ? pts.Count : 0;
            if (lCount > 0)
            {
                res = new Mat(lCount, 1, CvType.CV_32SC2);
                List_Mat_to_Mat<MatOfPoint3f>(pts, res, lCount);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        // vector_vector_KeyPoint
        public static Mat vector_vector_KeyPoint_to_Mat(List<MatOfKeyPoint> kps, List<Mat> mats)
        {
            Mat res;
            int lCount = (kps != null) ? kps.Count : 0;
            if (lCount > 0)
            {
                res = new Mat(lCount, 1, CvType.CV_32SC2);
                List_Mat_to_Mat<MatOfKeyPoint>(kps, res, lCount);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static void Mat_to_vector_vector_KeyPoint(Mat m, List<MatOfKeyPoint> kps)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (kps == null)
                throw new CvException("Output List can't be null");

            if (m == null)
                throw new CvException("Input Mat can't be null");

            int count = m.rows();
            if (CvType.CV_32SC2 != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_32SC2 != m.type() ||  m.cols()!=1\n" + m);

            kps.Clear();
            for (int i = 0; i < count; i++)
            {
                kps.Add(new MatOfKeyPoint());
            }
            Converters.Mat_to_List_Mat(m, kps, count);
        }

        public static Mat vector_double_to_Mat(List<double> ds)
        {
            Mat res;
            int count = (ds != null) ? ds.Count : 0;
            if (count > 0)
            {
                res = new Mat(count, 1, CvType.CV_64FC1);
                List_double_to_Mat(ds, res, count);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static void Mat_to_vector_double(Mat m, List<double> ds)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (ds == null)
                throw new CvException("ds == null");
            int count = m.rows();
            if (CvType.CV_64FC1 != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_64FC1 != m.type() ||  m.cols()!=1\n" + m);

            ds.Clear();
            for (int i = 0; i < count; i++)
            {
                ds.Add(0);
            }
            Converters.Mat_to_List_double(m, ds, count);
        }

        public static Mat vector_DMatch_to_Mat(List<DMatch> matches)
        {
            Mat res;
            int count = (matches != null) ? matches.Count : 0;
            if (count > 0)
            {
                res = new Mat(count, 1, CvType.CV_64FC4);
                List_DMatch_to_Mat(matches, res, count, CvType.CV_64FC4);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static void Mat_to_vector_DMatch(Mat m, List<DMatch> matches)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (matches == null)
                throw new CvException("Output List can't be null");
            int count = m.rows();
            if (CvType.CV_64FC4 != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_64FC4 != m.type() ||  m.cols()!=1\n" + m);

            matches.Clear();
            for (int i = 0; i < count; i++)
            {
                matches.Add(new DMatch());
            }
            Converters.Mat_to_List_DMatch(m, matches, count, CvType.CV_64FC4);
        }

        // vector_vector_DMatch
        public static Mat vector_vector_DMatch_to_Mat(List<MatOfDMatch> lvdm, List<Mat> mats)
        {
            Mat res;
            int lCount = (lvdm != null) ? lvdm.Count : 0;
            if (lCount > 0)
            {
                res = new Mat(lCount, 1, CvType.CV_32SC2);
                List_Mat_to_Mat<MatOfDMatch>(lvdm, res, lCount);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static void Mat_to_vector_vector_DMatch(Mat m, List<MatOfDMatch> lvdm)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (lvdm == null)
                throw new CvException("Output List can't be null");

            if (m == null)
                throw new CvException("Input Mat can't be null");

            int count = m.rows();
            if (CvType.CV_32SC2 != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_32SC2 != m.type() ||  m.cols()!=1\n" + m);

            lvdm.Clear();
            for (int i = 0; i < count; i++)
            {
                lvdm.Add(new MatOfDMatch());
            }
            Converters.Mat_to_List_Mat(m, lvdm, count);
        }

        // vector_vector_char
        public static Mat vector_vector_char_to_Mat(List<MatOfByte> lvb, List<Mat> mats)
        {
            Mat res;
            int lCount = (lvb != null) ? lvb.Count : 0;
            if (lCount > 0)
            {
                res = new Mat(lCount, 1, CvType.CV_32SC2);
                List_Mat_to_Mat<MatOfByte>(lvb, res, lCount);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static void Mat_to_vector_vector_char(Mat m, List<List<byte>> llb)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (llb == null)
                throw new CvException("Output List can't be null");

            if (m == null)
                throw new CvException("Input Mat can't be null");

            List<Mat> mats = new List<Mat>(m.rows());
            Mat_to_vector_Mat(m, mats);
            foreach (Mat mi in mats)
            {
                List<byte> lb = new List<byte>();
                Mat_to_vector_uchar(mi, lb);
                llb.Add(lb);
                mi.release();
            }
            mats.Clear();
        }

        public static Mat vector_RotatedRect_to_Mat(List<RotatedRect> rs)
        {
            Mat res;
            int count = (rs != null) ? rs.Count : 0;
            if (count > 0)
            {
                res = new Mat(count, 1, CvType.CV_32FC(5));
                List_RotatedRect_to_Mat(rs, res, count);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static void Mat_to_vector_RotatedRect(Mat m, List<RotatedRect> rs)
        {
            if (rs == null)
                throw new CvException("rs == null");
            int count = m.rows();
            if (CvType.CV_32FC(5) != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_32FC5 != m.type() ||  m.rows()!=1\n" + m);

            rs.Clear();
            for (int i = 0; i < count; i++)
            {
                rs.Add(new RotatedRect());
            }
            Converters.Mat_to_List_RotatedRect(m, rs, count);
        }

        public static Mat vector_String_to_Mat(List<string> strings)
        {
            {
                Mat res;

                int count = (strings != null) ? strings.Count : 0;
                if (count > 0)
                {

#if NET_STANDARD_2_1
                int[] strLen = ArrayPool<int>.Shared.Rent(count);

                int concatStrLen = 0;
                for (int i = 0; i < count; i++)
                {
                    strLen[i] = strings[i].Length;
                    concatStrLen += strLen[i];
                }
                concatStrLen += count - 1;

                char[] concatStr = ArrayPool<char>.Shared.Rent(concatStrLen);

                int index = 0;
                for (int i = 0; i < count; i++)
                {
                    strings[i].CopyTo(0, concatStr, index, strLen[i]);
                    index += strLen[i];
                    concatStr[index] = ',';
                    index++;
                }

                byte[] buff = ArrayPool<byte>.Shared.Rent(concatStr.Length * 3);

                int length = System.Text.Encoding.UTF8.GetBytes(new ReadOnlySpan<char>(concatStr, 0, concatStrLen), buff);

                res = new Mat(1, length, CvType.CV_8SC1);
                res.put(0, 0, buff, length);

                ArrayPool<byte>.Shared.Return(buff);
                ArrayPool<char>.Shared.Return(concatStr);
                ArrayPool<int>.Shared.Return(strLen);
#else
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    for (int i = 0; i < count; i++)
                    {
                        if (i > 0)
                            sb.Append(",");
                        sb.Append(strings[i]);
                    }

                    byte[] buff = System.Text.Encoding.UTF8.GetBytes(sb.ToString());

                    res = new Mat(1, buff.Length, CvType.CV_8SC1);
                    res.put(0, 0, buff);
#endif

                }
                else
                {
                    res = new Mat();
                }

                return res;
            }
        }

        public static void Mat_to_vector_String(Mat m, List<string> strings)
        {
            {
                if (m != null)
                    m.ThrowIfDisposed();

                if (strings == null)
                    throw new CvException("strings == null");
                int count = m.cols();
                if (CvType.CV_8SC1 != m.type() || m.rows() != 1)
                    throw new CvException(
                        "CvType.CV_8SC1 != m.type() ||  m.rows()!=1\n" + m);

                strings.Clear();

                if (count > 0)
                {

#if NET_STANDARD_2_1
                char[] chars = ArrayPool<char>.Shared.Rent(count);
                int length = 0;

#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (m.isContinuous())
                {
                    unsafe
                    {
                        Span<byte> buff = new Span<byte>(new IntPtr(m.dataAddr()).ToPointer(), count);

                        length = System.Text.Encoding.UTF8.GetChars(buff, chars);
                    }
                }
                else
                {
                    byte[] buff = ArrayPool<byte>.Shared.Rent(count);

                    m.get(0, 0, buff, count);

                    length = System.Text.Encoding.UTF8.GetChars(new Span<byte>(buff,0,count), chars);

                    ArrayPool<byte>.Shared.Return(buff);
                }
#else

                byte[] buff = ArrayPool<byte>.Shared.Rent(count);

                m.get(0, 0, buff, count);

                length = System.Text.Encoding.UTF8.GetChars(new Span<byte>(buff, 0, count), chars);

                ArrayPool<byte>.Shared.Return(buff);

#endif
                Span<char> charsSpan = new Span<char>(chars, 0, length);

                while (true)
                {
                    int index = MemoryExtensions.IndexOf<char>(charsSpan, ',');
                    if (index < 0)
                    {
                        strings.Add(charsSpan.ToString());
                        break;
                    }
                    strings.Add(charsSpan.Slice(0, index).ToString());
                    charsSpan = charsSpan.Slice(index + 1);

                }

                ArrayPool<char>.Shared.Return(chars);

#else
                    byte[] buff = new byte[count];
                    m.get(0, 0, buff);
                    strings.AddRange(System.Text.Encoding.UTF8.GetString(buff).Split(','));
#endif
                }
            }
        }

        public static Mat vector_string_to_Mat(List<string> strings)
        {
            return vector_String_to_Mat(strings);
        }

        public static void Mat_to_vector_string(Mat m, List<string> strings)
        {
            Mat_to_vector_String(m, strings);
        }


        internal static void List_Point_to_Mat(List<Point> lp, Mat mat, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        if (type == CvType.CV_32SC2)
                        {
                            int* ptr = (int*)mat.dataAddr();
                            for (int i = 0; i < count; i++)
                            {
                                Point p = lp[i];
                                ptr[2 * i + 0] = (int)p.x;
                                ptr[2 * i + 1] = (int)p.y;
                            }
                        }
                        else if (type == CvType.CV_32FC2)
                        {
                            float* ptr = (float*)mat.dataAddr();
                            for (int i = 0; i < count; i++)
                            {
                                Point p = lp[i];
                                ptr[2 * i + 0] = (float)p.x;
                                ptr[2 * i + 1] = (float)p.y;
                            }
                        }
                        else if (type == CvType.CV_64FC2)
                        {
                            double* ptr = (double*)mat.dataAddr();
                            for (int i = 0; i < count; i++)
                            {
                                Point p = lp[i];
                                ptr[2 * i + 0] = p.x;
                                ptr[2 * i + 1] = p.y;
                            }
                        }
                        else
                        {
                            throw new CvException("'type' can be CV_32SC2, CV_32F or CV_64FC2");
                        }
                    }
                    return;
                }
#endif
                if (type == CvType.CV_32SC2)
                {

#if NET_STANDARD_2_1
                int[] buff = ArrayPool<int>.Shared.Rent(count * 2);
#else
                    int[] buff = new int[count * 2];
#endif
                    for (int i = 0; i < count; i++)
                    {
                        Point p = lp[i];
                        buff[2 * i + 0] = (int)p.x;
                        buff[2 * i + 1] = (int)p.y;
                    }
                    mat.put(0, 0, buff, count * 2); //TODO: check ret val!
#if NET_STANDARD_2_1
                ArrayPool<int>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_32FC2)
                {

#if NET_STANDARD_2_1
                float[] buff = ArrayPool<float>.Shared.Rent(count * 2);
#else
                    float[] buff = new float[count * 2];
#endif
                    for (int i = 0; i < count; i++)
                    {
                        Point p = lp[i];
                        buff[i * 2 + 0] = (float)p.x;
                        buff[i * 2 + 1] = (float)p.y;
                    }
                    mat.put(0, 0, buff, count * 2);
#if NET_STANDARD_2_1
                ArrayPool<float>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_64FC2)
                {

#if NET_STANDARD_2_1
                double[] buff = ArrayPool<double>.Shared.Rent(count * 2);
#else
                    double[] buff = new double[count * 2];
#endif
                    for (int i = 0; i < count; i++)
                    {
                        Point p = lp[i];
                        buff[i * 2 + 0] = p.x;
                        buff[i * 2 + 1] = p.y;
                    }
                    mat.put(0, 0, buff, count * 2);
#if NET_STANDARD_2_1
                ArrayPool<double>.Shared.Return(buff);
#endif
                }
                else
                {
                    throw new CvException("'type' can be CV_32SC2, CV_32FC2 or CV_64FC2");
                }
            }
        }

        internal static void Array_Point_to_Mat(Point[] ap, Mat mat, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        if (type == CvType.CV_32SC2)
                        {
                            int* ptr = (int*)mat.dataAddr();
                            for (int i = 0; i < ap.Length; i++)
                            {
                                Point p = ap[i];
                                ptr[2 * i + 0] = (int)p.x;
                                ptr[2 * i + 1] = (int)p.y;
                            }
                        }
                        else if (type == CvType.CV_32FC2)
                        {
                            float* ptr = (float*)mat.dataAddr();
                            for (int i = 0; i < ap.Length; i++)
                            {
                                Point p = ap[i];
                                ptr[2 * i + 0] = (float)p.x;
                                ptr[2 * i + 1] = (float)p.y;
                            }
                        }
                        else if (type == CvType.CV_64FC2)
                        {
                            double* ptr = (double*)mat.dataAddr();
                            for (int i = 0; i < ap.Length; i++)
                            {
                                Point p = ap[i];
                                ptr[2 * i + 0] = p.x;
                                ptr[2 * i + 1] = p.y;
                            }
                        }
                        else
                        {
                            throw new CvException("'type' can be CV_32SC2, CV_32F or CV_64FC2");
                        }
                    }
                    return;
                }
#endif
                if (type == CvType.CV_32SC2)
                {

#if NET_STANDARD_2_1
                int[] buff = ArrayPool<int>.Shared.Rent(count * 2);
#else
                    int[] buff = new int[count * 2];
#endif
                    for (int i = 0; i < ap.Length; i++)
                    {
                        Point p = ap[i];
                        buff[2 * i + 0] = (int)p.x;
                        buff[2 * i + 1] = (int)p.y;
                    }
                    mat.put(0, 0, buff, count * 2); //TODO: check ret val!
#if NET_STANDARD_2_1
                ArrayPool<int>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_32FC2)
                {

#if NET_STANDARD_2_1
                float[] buff = ArrayPool<float>.Shared.Rent(count * 2);
#else
                    float[] buff = new float[count * 2];
#endif
                    for (int i = 0; i < ap.Length; i++)
                    {
                        Point p = ap[i];
                        buff[i * 2 + 0] = (float)p.x;
                        buff[i * 2 + 1] = (float)p.y;
                    }
                    mat.put(0, 0, buff, count * 2);
#if NET_STANDARD_2_1
                ArrayPool<float>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_64FC2)
                {

#if NET_STANDARD_2_1
                double[] buff = ArrayPool<double>.Shared.Rent(count * 2);
#else
                    double[] buff = new double[count * 2];
#endif
                    for (int i = 0; i < ap.Length; i++)
                    {
                        Point p = ap[i];
                        buff[i * 2 + 0] = p.x;
                        buff[i * 2 + 1] = p.y;
                    }
                    mat.put(0, 0, buff, count * 2);
#if NET_STANDARD_2_1
                ArrayPool<double>.Shared.Return(buff);
#endif
                }
                else
                {
                    throw new CvException("'type' can be CV_32SC2, CV_32FC2 or CV_64FC2");
                }
            }
        }

        internal static void Mat_to_List_Point(Mat mat, List<Point> lp, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        if (type == CvType.CV_32SC2)
                        {
                            int* ptr = (int*)mat.dataAddr();

                            for (int i = 0; i < count; i++)
                            {
                                Point p = lp[i];
                                p.x = ptr[i * 2];
                                p.y = ptr[i * 2 + 1];
                            }

                        }
                        else if (type == CvType.CV_32FC2)
                        {
                            float* ptr = (float*)mat.dataAddr();

                            for (int i = 0; i < count; i++)
                            {
                                Point p = lp[i];
                                p.x = ptr[i * 2];
                                p.y = ptr[i * 2 + 1];
                            }
                        }
                        else if (type == CvType.CV_64FC2)
                        {
                            double* ptr = (double*)mat.dataAddr();

                            for (int i = 0; i < count; i++)
                            {
                                Point p = lp[i];
                                p.x = ptr[i * 2];
                                p.y = ptr[i * 2 + 1];
                            }
                        }
                        else
                        {
                            throw new CvException("Input Mat should be of CV_32SC2, CV_32FC2 or CV_64FC2 type\n" + mat);
                        }
                    }
                    return;
                }
#endif
                if (type == CvType.CV_32SC2)
                {
#if NET_STANDARD_2_1
                int[] buff = ArrayPool<int>.Shared.Rent(count * 2);
#else
                    int[] buff = new int[count * 2];
#endif
                    mat.get(0, 0, buff, count * 2); //TODO: check ret val!
                    for (int i = 0; i < count; i++)
                    {
                        Point p = lp[i];
                        p.x = buff[i * 2];
                        p.y = buff[i * 2 + 1];
                    }
#if NET_STANDARD_2_1
                ArrayPool<int>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_32FC2)
                {
#if NET_STANDARD_2_1
                float[] buff = ArrayPool<float>.Shared.Rent(count * 2);
#else
                    float[] buff = new float[count * 2];
#endif
                    mat.get(0, 0, buff, count * 2); //TODO: check ret val!
                    for (int i = 0; i < count; i++)
                    {
                        Point p = lp[i];
                        p.x = buff[i * 2];
                        p.y = buff[i * 2 + 1];
                    }
#if NET_STANDARD_2_1
                ArrayPool<float>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_64FC2)
                {
#if NET_STANDARD_2_1
                double[] buff = ArrayPool<double>.Shared.Rent(count * 2);
#else
                    double[] buff = new double[count * 2];
#endif
                    mat.get(0, 0, buff, count * 2); //TODO: check ret val!
                    for (int i = 0; i < count; i++)
                    {
                        Point p = lp[i];
                        p.x = buff[i * 2];
                        p.y = buff[i * 2 + 1];
                    }
#if NET_STANDARD_2_1
                ArrayPool<double>.Shared.Return(buff);
#endif
                }
                else
                {
                    throw new CvException("Input Mat should be of CV_32SC2, CV_32FC2 or CV_64FC2 type\n" + mat);
                }
            }
        }

        internal static void Mat_to_Array_Point(Mat mat, Point[] ap, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        if (type == CvType.CV_32SC2)
                        {
                            int* ptr = (int*)mat.dataAddr();

                            for (int i = 0; i < ap.Length; i++)
                            {
                                Point p = ap[i];
                                p.x = ptr[i * 2];
                                p.y = ptr[i * 2 + 1];
                            }

                        }
                        else if (type == CvType.CV_32FC2)
                        {
                            float* ptr = (float*)mat.dataAddr();

                            for (int i = 0; i < ap.Length; i++)
                            {
                                Point p = ap[i];
                                p.x = ptr[i * 2];
                                p.y = ptr[i * 2 + 1];
                            }
                        }
                        else if (type == CvType.CV_64FC2)
                        {
                            double* ptr = (double*)mat.dataAddr();

                            for (int i = 0; i < ap.Length; i++)
                            {
                                Point p = ap[i];
                                p.x = ptr[i * 2];
                                p.y = ptr[i * 2 + 1];
                            }
                        }
                        else
                        {
                            throw new CvException("Input Mat should be of CV_32SC2, CV_32FC2 or CV_64FC2 type\n" + mat);
                        }
                    }
                    return;
                }
#endif
                if (type == CvType.CV_32SC2)
                {
#if NET_STANDARD_2_1
                int[] buff = ArrayPool<int>.Shared.Rent(count * 2);
#else
                    int[] buff = new int[count * 2];
#endif
                    mat.get(0, 0, buff, count * 2); //TODO: check ret val!
                    for (int i = 0; i < ap.Length; i++)
                    {
                        Point p = ap[i];
                        p.x = buff[i * 2];
                        p.y = buff[i * 2 + 1];
                    }
#if NET_STANDARD_2_1
                ArrayPool<int>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_32FC2)
                {
#if NET_STANDARD_2_1
                float[] buff = ArrayPool<float>.Shared.Rent(count * 2);
#else
                    float[] buff = new float[count * 2];
#endif
                    mat.get(0, 0, buff, count * 2); //TODO: check ret val!
                    for (int i = 0; i < ap.Length; i++)
                    {
                        Point p = ap[i];
                        p.x = buff[i * 2];
                        p.y = buff[i * 2 + 1];
                    }
#if NET_STANDARD_2_1
                ArrayPool<float>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_64FC2)
                {
#if NET_STANDARD_2_1
                double[] buff = ArrayPool<double>.Shared.Rent(count * 2);
#else
                    double[] buff = new double[count * 2];
#endif
                    mat.get(0, 0, buff, count * 2); //TODO: check ret val!
                    for (int i = 0; i < ap.Length; i++)
                    {
                        Point p = ap[i];
                        p.x = buff[i * 2];
                        p.y = buff[i * 2 + 1];
                    }
#if NET_STANDARD_2_1
                ArrayPool<double>.Shared.Return(buff);
#endif
                }
                else
                {
                    throw new CvException("Input Mat should be of CV_32SC2, CV_32FC2 or CV_64FC2 type\n" + mat);
                }
            }
        }

        internal static void List_Point3_to_Mat(List<Point3> lp3, Mat mat, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        if (type == CvType.CV_32SC3)
                        {
                            int* ptr = (int*)mat.dataAddr();
                            for (int i = 0; i < count; i++)
                            {
                                Point3 p = lp3[i];
                                ptr[i * 3] = (int)p.x;
                                ptr[i * 3 + 1] = (int)p.y;
                                ptr[i * 3 + 2] = (int)p.z;
                            }
                        }
                        else if (type == CvType.CV_32FC3)
                        {
                            float* ptr = (float*)mat.dataAddr();
                            for (int i = 0; i < count; i++)
                            {
                                Point3 p = lp3[i];
                                ptr[i * 3] = (float)p.x;
                                ptr[i * 3 + 1] = (float)p.y;
                                ptr[i * 3 + 2] = (float)p.z;
                            }
                        }
                        else if (type == CvType.CV_64FC3)
                        {
                            double* ptr = (double*)mat.dataAddr();
                            for (int i = 0; i < count; i++)
                            {
                                Point3 p = lp3[i];
                                ptr[i * 3] = p.x;
                                ptr[i * 3 + 1] = p.y;
                                ptr[i * 3 + 2] = p.z;
                            }
                        }
                        else
                        {
                            throw new CvException("'type' can be CV_32SC3, CV_32FC3 or CV_64FC3");
                        }

                    }
                    return;
                }
#endif
                if (type == CvType.CV_32SC3)
                {

#if NET_STANDARD_2_1
                int[] buff = ArrayPool<int>.Shared.Rent(count * 3);
#else
                    int[] buff = new int[count * 3];
#endif
                    for (int i = 0; i < count; i++)
                    {
                        Point3 p = lp3[i];
                        buff[i * 3] = (int)p.x;
                        buff[i * 3 + 1] = (int)p.y;
                        buff[i * 3 + 2] = (int)p.z;
                    }
                    mat.put(0, 0, buff, count * 3); //TODO: check ret val!
#if NET_STANDARD_2_1
                ArrayPool<int>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_32FC3)
                {

#if NET_STANDARD_2_1
                float[] buff = ArrayPool<float>.Shared.Rent(count * 3);
#else
                    float[] buff = new float[count * 3];
#endif
                    for (int i = 0; i < count; i++)
                    {
                        Point3 p = lp3[i];
                        buff[i * 3] = (float)p.x;
                        buff[i * 3 + 1] = (float)p.y;
                        buff[i * 3 + 2] = (float)p.z;
                    }
                    mat.put(0, 0, buff, count * 3);
#if NET_STANDARD_2_1
                ArrayPool<float>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_64FC3)
                {

#if NET_STANDARD_2_1
                double[] buff = ArrayPool<double>.Shared.Rent(count * 3);
#else
                    double[] buff = new double[count * 3];
#endif
                    for (int i = 0; i < count; i++)
                    {
                        Point3 p = lp3[i];
                        buff[i * 3] = p.x;
                        buff[i * 3 + 1] = p.y;
                        buff[i * 3 + 2] = p.z;
                    }
                    mat.put(0, 0, buff, count * 3);
#if NET_STANDARD_2_1
                ArrayPool<double>.Shared.Return(buff);
#endif
                }
                else
                {
                    throw new CvException("'type' can be CV_32SC3, CV_32FC3 or CV_64FC3");
                }
            }
        }

        internal static void Array_Point3_to_Mat(Point3[] ap3, Mat mat, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        if (type == CvType.CV_32SC3)
                        {
                            int* ptr = (int*)mat.dataAddr();
                            for (int i = 0; i < ap3.Length; i++)
                            {
                                Point3 p = ap3[i];
                                ptr[i * 3] = (int)p.x;
                                ptr[i * 3 + 1] = (int)p.y;
                                ptr[i * 3 + 2] = (int)p.z;
                            }
                        }
                        else if (type == CvType.CV_32FC3)
                        {
                            float* ptr = (float*)mat.dataAddr();
                            for (int i = 0; i < ap3.Length; i++)
                            {
                                Point3 p = ap3[i];
                                ptr[i * 3] = (float)p.x;
                                ptr[i * 3 + 1] = (float)p.y;
                                ptr[i * 3 + 2] = (float)p.z;
                            }
                        }
                        else if (type == CvType.CV_64FC3)
                        {
                            double* ptr = (double*)mat.dataAddr();
                            for (int i = 0; i < ap3.Length; i++)
                            {
                                Point3 p = ap3[i];
                                ptr[i * 3] = p.x;
                                ptr[i * 3 + 1] = p.y;
                                ptr[i * 3 + 2] = p.z;
                            }
                        }
                        else
                        {
                            throw new CvException("'type' can be CV_32SC3, CV_32FC3 or CV_64FC3");
                        }

                    }
                    return;
                }
#endif
                if (type == CvType.CV_32SC3)
                {

#if NET_STANDARD_2_1
                int[] buff = ArrayPool<int>.Shared.Rent(count * 3);
#else
                    int[] buff = new int[count * 3];
#endif
                    for (int i = 0; i < ap3.Length; i++)
                    {
                        Point3 p = ap3[i];
                        buff[i * 3] = (int)p.x;
                        buff[i * 3 + 1] = (int)p.y;
                        buff[i * 3 + 2] = (int)p.z;
                    }
                    mat.put(0, 0, buff, count * 3); //TODO: check ret val!
#if NET_STANDARD_2_1
                ArrayPool<int>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_32FC3)
                {

#if NET_STANDARD_2_1
                float[] buff = ArrayPool<float>.Shared.Rent(count * 3);
#else
                    float[] buff = new float[count * 3];
#endif
                    for (int i = 0; i < ap3.Length; i++)
                    {
                        Point3 p = ap3[i];
                        buff[i * 3] = (float)p.x;
                        buff[i * 3 + 1] = (float)p.y;
                        buff[i * 3 + 2] = (float)p.z;
                    }
                    mat.put(0, 0, buff, count * 3);
#if NET_STANDARD_2_1
                ArrayPool<float>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_64FC3)
                {

#if NET_STANDARD_2_1
                double[] buff = ArrayPool<double>.Shared.Rent(count * 3);
#else
                    double[] buff = new double[count * 3];
#endif
                    for (int i = 0; i < ap3.Length; i++)
                    {
                        Point3 p = ap3[i];
                        buff[i * 3] = p.x;
                        buff[i * 3 + 1] = p.y;
                        buff[i * 3 + 2] = p.z;
                    }
                    mat.put(0, 0, buff, count * 3);
#if NET_STANDARD_2_1
                ArrayPool<double>.Shared.Return(buff);
#endif
                }
                else
                {
                    throw new CvException("'type' can be CV_32SC3, CV_32FC3 or CV_64FC3");
                }
            }
        }

        internal static void Mat_to_List_Point3(Mat mat, List<Point3> lp3, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        if (type == CvType.CV_32SC3)
                        {
                            int* ptr = (int*)mat.dataAddr();

                            for (int i = 0; i < count; i++)
                            {
                                Point3 p = lp3[i];
                                p.x = ptr[i * 3];
                                p.y = ptr[i * 3 + 1];
                                p.z = ptr[i * 3 + 2];
                            }

                        }
                        else if (type == CvType.CV_32FC3)
                        {
                            float* ptr = (float*)mat.dataAddr();

                            for (int i = 0; i < count; i++)
                            {
                                Point3 p = lp3[i];
                                p.x = ptr[i * 3];
                                p.y = ptr[i * 3 + 1];
                                p.z = ptr[i * 3 + 2];
                            }
                        }
                        else if (type == CvType.CV_64FC3)
                        {
                            double* ptr = (double*)mat.dataAddr();

                            for (int i = 0; i < count; i++)
                            {
                                Point3 p = lp3[i];
                                p.x = ptr[i * 3];
                                p.y = ptr[i * 3 + 1];
                                p.z = ptr[i * 3 + 2];
                            }
                        }
                        else
                        {
                            throw new CvException("Input Mat should be of CV_32SC3, CV_32FC3 or CV_64FC3 type\n" + mat);
                        }
                    }
                    return;
                }
#endif
                if (type == CvType.CV_32SC3)
                {
#if NET_STANDARD_2_1
                int[] buff = ArrayPool<int>.Shared.Rent(count * 3);
#else
                    int[] buff = new int[count * 3];
#endif
                    mat.get(0, 0, buff, count * 3); //TODO: check ret val!
                    for (int i = 0; i < count; i++)
                    {
                        Point3 p = lp3[i];
                        p.x = buff[i * 3];
                        p.y = buff[i * 3 + 1];
                        p.z = buff[i * 3 + 2];
                    }
#if NET_STANDARD_2_1
                ArrayPool<int>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_32FC3)
                {
#if NET_STANDARD_2_1
                float[] buff = ArrayPool<float>.Shared.Rent(count * 3);
#else
                    float[] buff = new float[count * 3];
#endif
                    mat.get(0, 0, buff, count * 3); //TODO: check ret val!
                    for (int i = 0; i < count; i++)
                    {
                        Point3 p = lp3[i];
                        p.x = buff[i * 3];
                        p.y = buff[i * 3 + 1];
                        p.z = buff[i * 3 + 2];
                    }
#if NET_STANDARD_2_1
                ArrayPool<float>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_64FC3)
                {
#if NET_STANDARD_2_1
                double[] buff = ArrayPool<double>.Shared.Rent(count * 3);
#else
                    double[] buff = new double[count * 3];
#endif
                    mat.get(0, 0, buff, count * 3); //TODO: check ret val!
                    for (int i = 0; i < count; i++)
                    {
                        Point3 p = lp3[i];
                        p.x = buff[i * 3];
                        p.y = buff[i * 3 + 1];
                        p.z = buff[i * 3 + 2];
                    }
#if NET_STANDARD_2_1
                ArrayPool<double>.Shared.Return(buff);
#endif
                }
                else
                {
                    throw new CvException("Input Mat should be of CV_32SC3, CV_32FC3 or CV_64FC3 type\n" + mat);
                }
            }
        }

        internal static void Mat_to_Array_Point3(Mat mat, Point3[] ap3, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        if (type == CvType.CV_32SC3)
                        {
                            int* ptr = (int*)mat.dataAddr();

                            for (int i = 0; i < ap3.Length; i++)
                            {
                                Point3 p = ap3[i];
                                p.x = ptr[i * 3];
                                p.y = ptr[i * 3 + 1];
                                p.z = ptr[i * 3 + 2];
                            }

                        }
                        else if (type == CvType.CV_32FC3)
                        {
                            float* ptr = (float*)mat.dataAddr();

                            for (int i = 0; i < ap3.Length; i++)
                            {
                                Point3 p = ap3[i];
                                p.x = ptr[i * 3];
                                p.y = ptr[i * 3 + 1];
                                p.z = ptr[i * 3 + 2];
                            }
                        }
                        else if (type == CvType.CV_64FC3)
                        {
                            double* ptr = (double*)mat.dataAddr();

                            for (int i = 0; i < ap3.Length; i++)
                            {
                                Point3 p = ap3[i];
                                p.x = ptr[i * 3];
                                p.y = ptr[i * 3 + 1];
                                p.z = ptr[i * 3 + 2];
                            }
                        }
                        else
                        {
                            throw new CvException("Input Mat should be of CV_32SC3, CV_32FC3 or CV_64FC3 type\n" + mat);
                        }
                    }
                    return;
                }
#endif
                if (type == CvType.CV_32SC3)
                {
#if NET_STANDARD_2_1
                int[] buff = ArrayPool<int>.Shared.Rent(count * 3);
#else
                    int[] buff = new int[count * 3];
#endif
                    mat.get(0, 0, buff, count * 3); //TODO: check ret val!
                    for (int i = 0; i < ap3.Length; i++)
                    {
                        Point3 p = ap3[i];
                        p.x = buff[i * 3];
                        p.y = buff[i * 3 + 1];
                        p.z = buff[i * 3 + 2];
                    }
#if NET_STANDARD_2_1
                ArrayPool<int>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_32FC3)
                {
#if NET_STANDARD_2_1
                float[] buff = ArrayPool<float>.Shared.Rent(count * 3);
#else
                    float[] buff = new float[count * 3];
#endif
                    mat.get(0, 0, buff, count * 3); //TODO: check ret val!
                    for (int i = 0; i < ap3.Length; i++)
                    {
                        Point3 p = ap3[i];
                        p.x = buff[i * 3];
                        p.y = buff[i * 3 + 1];
                        p.z = buff[i * 3 + 2];
                    }
#if NET_STANDARD_2_1
                ArrayPool<float>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_64FC3)
                {
#if NET_STANDARD_2_1
                double[] buff = ArrayPool<double>.Shared.Rent(count * 3);
#else
                    double[] buff = new double[count * 3];
#endif
                    mat.get(0, 0, buff, count * 3); //TODO: check ret val!
                    for (int i = 0; i < ap3.Length; i++)
                    {
                        Point3 p = ap3[i];
                        p.x = buff[i * 3];
                        p.y = buff[i * 3 + 1];
                        p.z = buff[i * 3 + 2];
                    }
#if NET_STANDARD_2_1
                ArrayPool<double>.Shared.Return(buff);
#endif
                }
                else
                {
                    throw new CvException("Input Mat should be of CV_32SC3, CV_32FC3 or CV_64FC3 type\n" + mat);
                }
            }
        }

        internal static void List_DMatch_to_Mat(List<DMatch> ldm, Mat mat, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        if (type == CvType.CV_32FC4)
                        {
                            float* ptr = (float*)mat.dataAddr();

                            for (int i = 0; i < count; i++)
                            {
                                DMatch m = ldm[i];
                                ptr[4 * i] = m.queryIdx;
                                ptr[4 * i + 1] = m.trainIdx;
                                ptr[4 * i + 2] = m.imgIdx;
                                ptr[4 * i + 3] = m.distance;
                            }

                        }
                        else if (type == CvType.CV_64FC4)
                        {
                            double* ptr = (double*)mat.dataAddr();

                            for (int i = 0; i < count; i++)
                            {
                                DMatch m = ldm[i];
                                ptr[4 * i] = m.queryIdx;
                                ptr[4 * i + 1] = m.trainIdx;
                                ptr[4 * i + 2] = m.imgIdx;
                                ptr[4 * i + 3] = m.distance;
                            }
                        }
                        else
                        {
                            throw new CvException("'type' can be CV_32SC4 or CV_64FC4");
                        }
                    }
                    return;
                }
#endif
                if (type == CvType.CV_32FC4)
                {
#if NET_STANDARD_2_1
                float[] buff = ArrayPool<float>.Shared.Rent(count * 4);
#else
                    float[] buff = new float[count * 4];
#endif
                    for (int i = 0; i < count; i++)
                    {
                        DMatch m = ldm[i];
                        buff[4 * i] = m.queryIdx;
                        buff[4 * i + 1] = m.trainIdx;
                        buff[4 * i + 2] = m.imgIdx;
                        buff[4 * i + 3] = m.distance;
                    }
                    mat.put(0, 0, buff, count * 4);
#if NET_STANDARD_2_1
                ArrayPool<float>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_64FC4)
                {
#if NET_STANDARD_2_1
                double[] buff = ArrayPool<double>.Shared.Rent(count * 4);
#else
                    double[] buff = new double[count * 4];
#endif
                    for (int i = 0; i < count; i++)
                    {
                        DMatch m = ldm[i];
                        buff[4 * i] = m.queryIdx;
                        buff[4 * i + 1] = m.trainIdx;
                        buff[4 * i + 2] = m.imgIdx;
                        buff[4 * i + 3] = m.distance;
                    }
                    mat.put(0, 0, buff, count * 4);
#if NET_STANDARD_2_1
                ArrayPool<double>.Shared.Return(buff);
#endif
                }
                else
                {
                    throw new CvException("'type' can be CV_32SC4 or CV_64FC4");
                }
            }
        }

        internal static void Array_DMatch_to_Mat(DMatch[] adm, Mat mat, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        if (type == CvType.CV_32FC4)
                        {
                            float* ptr = (float*)mat.dataAddr();

                            for (int i = 0; i < adm.Length; i++)
                            {
                                DMatch m = adm[i];
                                ptr[4 * i] = m.queryIdx;
                                ptr[4 * i + 1] = m.trainIdx;
                                ptr[4 * i + 2] = m.imgIdx;
                                ptr[4 * i + 3] = m.distance;
                            }

                        }
                        else if (type == CvType.CV_64FC4)
                        {
                            double* ptr = (double*)mat.dataAddr();

                            for (int i = 0; i < adm.Length; i++)
                            {
                                DMatch m = adm[i];
                                ptr[4 * i] = m.queryIdx;
                                ptr[4 * i + 1] = m.trainIdx;
                                ptr[4 * i + 2] = m.imgIdx;
                                ptr[4 * i + 3] = m.distance;
                            }
                        }
                        else
                        {
                            throw new CvException("'type' can be CV_32SC4 or CV_64FC4");
                        }
                    }
                    return;
                }
#endif
                if (type == CvType.CV_32FC4)
                {
#if NET_STANDARD_2_1
                float[] buff = ArrayPool<float>.Shared.Rent(count * 4);
#else
                    float[] buff = new float[count * 4];
#endif
                    for (int i = 0; i < adm.Length; i++)
                    {
                        DMatch m = adm[i];
                        buff[4 * i] = m.queryIdx;
                        buff[4 * i + 1] = m.trainIdx;
                        buff[4 * i + 2] = m.imgIdx;
                        buff[4 * i + 3] = m.distance;
                    }
                    mat.put(0, 0, buff, count * 4);
#if NET_STANDARD_2_1
                ArrayPool<float>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_64FC4)
                {
#if NET_STANDARD_2_1
                double[] buff = ArrayPool<double>.Shared.Rent(count * 4);
#else
                    double[] buff = new double[count * 4];
#endif
                    for (int i = 0; i < adm.Length; i++)
                    {
                        DMatch m = adm[i];
                        buff[4 * i] = m.queryIdx;
                        buff[4 * i + 1] = m.trainIdx;
                        buff[4 * i + 2] = m.imgIdx;
                        buff[4 * i + 3] = m.distance;
                    }
                    mat.put(0, 0, buff, count * 4);
#if NET_STANDARD_2_1
                ArrayPool<double>.Shared.Return(buff);
#endif
                }
                else
                {
                    throw new CvException("'type' can be CV_32SC4 or CV_64FC4");
                }
            }
        }

        internal static void Mat_to_List_DMatch(Mat mat, List<DMatch> ldm, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        if (type == CvType.CV_32FC4)
                        {
                            float* ptr = (float*)mat.dataAddr();

                            for (int i = 0; i < count; i++)
                            {
                                DMatch m = ldm[i];
                                m.queryIdx = (int)ptr[4 * i];
                                m.trainIdx = (int)ptr[4 * i + 1];
                                m.imgIdx = (int)ptr[4 * i + 2];
                                m.distance = (float)ptr[4 * i + 3];
                            }

                        }
                        else if (type == CvType.CV_64FC4)
                        {
                            double* ptr = (double*)mat.dataAddr();

                            for (int i = 0; i < count; i++)
                            {
                                DMatch m = ldm[i];
                                m.queryIdx = (int)ptr[4 * i];
                                m.trainIdx = (int)ptr[4 * i + 1];
                                m.imgIdx = (int)ptr[4 * i + 2];
                                m.distance = (float)ptr[4 * i + 3];
                            }
                        }
                        else
                        {
                            throw new CvException("Input Mat should be of CV_32FC4 or CV_64FC4 type\n" + mat);
                        }
                    }
                    return;
                }
#endif
                if (type == CvType.CV_32FC4)
                {
#if NET_STANDARD_2_1
                float[] buff = ArrayPool<float>.Shared.Rent(count * 4);
#else
                    float[] buff = new float[4 * count];
#endif
                    mat.get(0, 0, buff, count * 4);
                    for (int i = 0; i < count; i++)
                    {
                        DMatch m = ldm[i];
                        m.queryIdx = (int)buff[4 * i];
                        m.trainIdx = (int)buff[4 * i + 1];
                        m.imgIdx = (int)buff[4 * i + 2];
                        m.distance = (float)buff[4 * i + 3];
                    }
#if NET_STANDARD_2_1
                ArrayPool<float>.Shared.Return(buff);
#endif

                }
                else if (type == CvType.CV_64FC4)
                {
#if NET_STANDARD_2_1
                double[] buff = ArrayPool<double>.Shared.Rent(count * 4);
#else
                    double[] buff = new double[4 * count];
#endif
                    mat.get(0, 0, buff, count * 4);
                    for (int i = 0; i < count; i++)
                    {
                        DMatch m = ldm[i];
                        m.queryIdx = (int)buff[4 * i];
                        m.trainIdx = (int)buff[4 * i + 1];
                        m.imgIdx = (int)buff[4 * i + 2];
                        m.distance = (float)buff[4 * i + 3];
                    }
#if NET_STANDARD_2_1
                ArrayPool<double>.Shared.Return(buff);
#endif
                }
                else
                {
                    throw new CvException("Input Mat should be of CV_32FC4 or CV_64FC4 type\n" + mat);
                }
            }
        }

        internal static void Mat_to_Array_DMatch(Mat mat, DMatch[] adm, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        if (type == CvType.CV_32FC4)
                        {
                            float* ptr = (float*)mat.dataAddr();

                            for (int i = 0; i < adm.Length; i++)
                            {
                                DMatch m = adm[i];
                                m.queryIdx = (int)ptr[4 * i];
                                m.trainIdx = (int)ptr[4 * i + 1];
                                m.imgIdx = (int)ptr[4 * i + 2];
                                m.distance = (float)ptr[4 * i + 3];
                            }

                        }
                        else if (type == CvType.CV_64FC4)
                        {
                            double* ptr = (double*)mat.dataAddr();

                            for (int i = 0; i < adm.Length; i++)
                            {
                                DMatch m = adm[i];
                                m.queryIdx = (int)ptr[4 * i];
                                m.trainIdx = (int)ptr[4 * i + 1];
                                m.imgIdx = (int)ptr[4 * i + 2];
                                m.distance = (float)ptr[4 * i + 3];
                            }
                        }
                        else
                        {
                            throw new CvException("Input Mat should be of CV_32FC4 or CV_64FC4 type\n" + mat);
                        }
                    }
                    return;
                }
#endif
                if (type == CvType.CV_32FC4)
                {
#if NET_STANDARD_2_1
                float[] buff = ArrayPool<float>.Shared.Rent(count * 4);
#else
                    float[] buff = new float[4 * count];
#endif
                    mat.get(0, 0, buff, count * 4);
                    for (int i = 0; i < adm.Length; i++)
                    {
                        DMatch m = adm[i];
                        m.queryIdx = (int)buff[4 * i];
                        m.trainIdx = (int)buff[4 * i + 1];
                        m.imgIdx = (int)buff[4 * i + 2];
                        m.distance = (float)buff[4 * i + 3];
                    }
#if NET_STANDARD_2_1
                ArrayPool<float>.Shared.Return(buff);
#endif

                }
                else if (type == CvType.CV_64FC4)
                {
#if NET_STANDARD_2_1
                double[] buff = ArrayPool<double>.Shared.Rent(count * 4);
#else
                    double[] buff = new double[4 * count];
#endif
                    mat.get(0, 0, buff, count * 4);
                    for (int i = 0; i < adm.Length; i++)
                    {
                        DMatch m = adm[i];
                        m.queryIdx = (int)buff[4 * i];
                        m.trainIdx = (int)buff[4 * i + 1];
                        m.imgIdx = (int)buff[4 * i + 2];
                        m.distance = (float)buff[4 * i + 3];
                    }
#if NET_STANDARD_2_1
                ArrayPool<double>.Shared.Return(buff);
#endif
                }
                else
                {
                    throw new CvException("Input Mat should be of CV_32FC4 or CV_64FC4 type\n" + mat);
                }
            }
        }

        internal static void List_KeyPoint_to_Mat(List<KeyPoint> lkp, Mat mat, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        if (type == CvType.CV_32FC(7))
                        {
                            float* ptr = (float*)mat.dataAddr();

                            for (int i = 0; i < count; i++)
                            {
                                KeyPoint kp = lkp[i];
                                ptr[7 * i] = (float)kp.pt.x;
                                ptr[7 * i + 1] = (float)kp.pt.y;
                                ptr[7 * i + 2] = kp.size;
                                ptr[7 * i + 3] = kp.angle;
                                ptr[7 * i + 4] = kp.response;
                                ptr[7 * i + 5] = kp.octave;
                                ptr[7 * i + 6] = kp.class_id;
                            }

                        }
                        else if (type == CvType.CV_64FC(7))
                        {
                            double* ptr = (double*)mat.dataAddr();

                            for (int i = 0; i < count; i++)
                            {
                                KeyPoint kp = lkp[i];
                                ptr[7 * i] = kp.pt.x;
                                ptr[7 * i + 1] = kp.pt.y;
                                ptr[7 * i + 2] = kp.size;
                                ptr[7 * i + 3] = kp.angle;
                                ptr[7 * i + 4] = kp.response;
                                ptr[7 * i + 5] = kp.octave;
                                ptr[7 * i + 6] = kp.class_id;
                            }
                        }
                        else
                        {
                            throw new CvException("'type' can be CV_32FC7 or CV_64FC7");
                        }
                    }
                    return;
                }
#endif
                if (type == CvType.CV_32FC(7))
                {
#if NET_STANDARD_2_1
                float[] buff = ArrayPool<float>.Shared.Rent(count * 7);
#else
                    float[] buff = new float[count * 7];
#endif
                    for (int i = 0; i < count; i++)
                    {
                        KeyPoint kp = lkp[i];
                        buff[7 * i] = (float)kp.pt.x;
                        buff[7 * i + 1] = (float)kp.pt.y;
                        buff[7 * i + 2] = kp.size;
                        buff[7 * i + 3] = kp.angle;
                        buff[7 * i + 4] = kp.response;
                        buff[7 * i + 5] = kp.octave;
                        buff[7 * i + 6] = kp.class_id;
                    }
                    mat.put(0, 0, buff, count * 7);
#if NET_STANDARD_2_1
                ArrayPool<float>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_64FC(7))
                {
#if NET_STANDARD_2_1
                double[] buff = ArrayPool<double>.Shared.Rent(count * 7);
#else
                    double[] buff = new double[count * 7];
#endif
                    for (int i = 0; i < count; i++)
                    {
                        KeyPoint kp = lkp[i];
                        buff[7 * i] = kp.pt.x;
                        buff[7 * i + 1] = kp.pt.y;
                        buff[7 * i + 2] = kp.size;
                        buff[7 * i + 3] = kp.angle;
                        buff[7 * i + 4] = kp.response;
                        buff[7 * i + 5] = kp.octave;
                        buff[7 * i + 6] = kp.class_id;
                    }
                    mat.put(0, 0, buff, count * 7);
#if NET_STANDARD_2_1
                ArrayPool<double>.Shared.Return(buff);
#endif
                }
                else
                {
                    throw new CvException("'type' can be CV_32FC7 or CV_64FC7");
                }
            }
        }

        internal static void Array_KeyPoint_to_Mat(KeyPoint[] akp, Mat mat, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        if (type == CvType.CV_32FC(7))
                        {
                            float* ptr = (float*)mat.dataAddr();

                            for (int i = 0; i < akp.Length; i++)
                            {
                                KeyPoint kp = akp[i];
                                ptr[7 * i] = (float)kp.pt.x;
                                ptr[7 * i + 1] = (float)kp.pt.y;
                                ptr[7 * i + 2] = kp.size;
                                ptr[7 * i + 3] = kp.angle;
                                ptr[7 * i + 4] = kp.response;
                                ptr[7 * i + 5] = kp.octave;
                                ptr[7 * i + 6] = kp.class_id;
                            }

                        }
                        else if (type == CvType.CV_64FC(7))
                        {
                            double* ptr = (double*)mat.dataAddr();

                            for (int i = 0; i < akp.Length; i++)
                            {
                                KeyPoint kp = akp[i];
                                ptr[7 * i] = kp.pt.x;
                                ptr[7 * i + 1] = kp.pt.y;
                                ptr[7 * i + 2] = kp.size;
                                ptr[7 * i + 3] = kp.angle;
                                ptr[7 * i + 4] = kp.response;
                                ptr[7 * i + 5] = kp.octave;
                                ptr[7 * i + 6] = kp.class_id;
                            }
                        }
                        else
                        {
                            throw new CvException("'type' can be CV_32FC7 or CV_64FC7");
                        }
                    }
                    return;
                }
#endif
                if (type == CvType.CV_32FC(7))
                {
#if NET_STANDARD_2_1
                float[] buff = ArrayPool<float>.Shared.Rent(count * 7);
#else
                    float[] buff = new float[count * 7];
#endif
                    for (int i = 0; i < akp.Length; i++)
                    {
                        KeyPoint kp = akp[i];
                        buff[7 * i] = (float)kp.pt.x;
                        buff[7 * i + 1] = (float)kp.pt.y;
                        buff[7 * i + 2] = kp.size;
                        buff[7 * i + 3] = kp.angle;
                        buff[7 * i + 4] = kp.response;
                        buff[7 * i + 5] = kp.octave;
                        buff[7 * i + 6] = kp.class_id;
                    }
                    mat.put(0, 0, buff, count * 7);
#if NET_STANDARD_2_1
                ArrayPool<float>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_64FC(7))
                {
#if NET_STANDARD_2_1
                double[] buff = ArrayPool<double>.Shared.Rent(count * 7);
#else
                    double[] buff = new double[count * 7];
#endif
                    for (int i = 0; i < akp.Length; i++)
                    {
                        KeyPoint kp = akp[i];
                        buff[7 * i] = kp.pt.x;
                        buff[7 * i + 1] = kp.pt.y;
                        buff[7 * i + 2] = kp.size;
                        buff[7 * i + 3] = kp.angle;
                        buff[7 * i + 4] = kp.response;
                        buff[7 * i + 5] = kp.octave;
                        buff[7 * i + 6] = kp.class_id;
                    }
                    mat.put(0, 0, buff, count * 7);
#if NET_STANDARD_2_1
                ArrayPool<double>.Shared.Return(buff);
#endif
                }
                else
                {
                    throw new CvException("'type' can be CV_32FC7 or CV_64FC7");
                }
            }
        }

        internal static void Mat_to_List_KeyPoint(Mat mat, List<KeyPoint> lkp, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        if (type == CvType.CV_32FC(7))
                        {
                            float* ptr = (float*)mat.dataAddr();

                            for (int i = 0; i < count; i++)
                            {
                                KeyPoint kp = lkp[i];
                                kp.pt.x = ptr[7 * i];
                                kp.pt.y = ptr[7 * i + 1];
                                kp.size = ptr[7 * i + 2];
                                kp.angle = ptr[7 * i + 3];
                                kp.response = ptr[7 * i + 4];
                                kp.octave = (int)ptr[7 * i + 5];
                                kp.class_id = (int)ptr[7 * i + 6];
                            }
                        }
                        else if (type == CvType.CV_64FC(7))
                        {
                            double* ptr = (double*)mat.dataAddr();

                            for (int i = 0; i < count; i++)
                            {
                                KeyPoint kp = lkp[i];
                                kp.pt.x = (float)ptr[7 * i];
                                kp.pt.y = (float)ptr[7 * i + 1];
                                kp.size = (float)ptr[7 * i + 2];
                                kp.angle = (float)ptr[7 * i + 3];
                                kp.response = (float)ptr[7 * i + 4];
                                kp.octave = (int)ptr[7 * i + 5];
                                kp.class_id = (int)ptr[7 * i + 6];
                            }
                        }
                        else
                        {
                            throw new CvException("Input Mat should be of CV_32FC7 or CV_64FC7 type\n" + mat);
                        }
                    }
                    return;
                }
#endif
                if (type == CvType.CV_32FC(7))
                {
#if NET_STANDARD_2_1
                float[] buff = ArrayPool<float>.Shared.Rent(7 * count);
#else
                    float[] buff = new float[7 * count];
#endif
                    mat.get(0, 0, buff, 7 * count);
                    for (int i = 0; i < count; i++)
                    {
                        KeyPoint kp = lkp[i];
                        kp.pt.x = buff[7 * i];
                        kp.pt.y = buff[7 * i + 1];
                        kp.size = buff[7 * i + 2];
                        kp.angle = buff[7 * i + 3];
                        kp.response = buff[7 * i + 4];
                        kp.octave = (int)buff[7 * i + 5];
                        kp.class_id = (int)buff[7 * i + 6];
                    }
#if NET_STANDARD_2_1
                ArrayPool<float>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_64FC(7))
                {
#if NET_STANDARD_2_1
                double[] buff = ArrayPool<double>.Shared.Rent(7 * count);
#else
                    double[] buff = new double[7 * count];
#endif
                    mat.get(0, 0, buff, 7 * count);
                    for (int i = 0; i < count; i++)
                    {
                        KeyPoint kp = lkp[i];
                        kp.pt.x = (float)buff[7 * i];
                        kp.pt.y = (float)buff[7 * i + 1];
                        kp.size = (float)buff[7 * i + 2];
                        kp.angle = (float)buff[7 * i + 3];
                        kp.response = (float)buff[7 * i + 4];
                        kp.octave = (int)buff[7 * i + 5];
                        kp.class_id = (int)buff[7 * i + 6];
                    }
#if NET_STANDARD_2_1
                ArrayPool<double>.Shared.Return(buff);
#endif
                }
                else
                {
                    throw new CvException("Input Mat should be of CV_32FC7 or CV_64FC7 type\n" + mat);
                }
            }
        }

        internal static void Mat_to_Array_KeyPoint(Mat mat, KeyPoint[] akp, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        if (type == CvType.CV_32FC(7))
                        {
                            float* ptr = (float*)mat.dataAddr();

                            for (int i = 0; i < akp.Length; i++)
                            {
                                KeyPoint kp = akp[i];
                                kp.pt.x = ptr[7 * i];
                                kp.pt.y = ptr[7 * i + 1];
                                kp.size = ptr[7 * i + 2];
                                kp.angle = ptr[7 * i + 3];
                                kp.response = ptr[7 * i + 4];
                                kp.octave = (int)ptr[7 * i + 5];
                                kp.class_id = (int)ptr[7 * i + 6];
                            }
                        }
                        else if (type == CvType.CV_64FC(7))
                        {
                            double* ptr = (double*)mat.dataAddr();

                            for (int i = 0; i < akp.Length; i++)
                            {
                                KeyPoint kp = akp[i];
                                kp.pt.x = (float)ptr[7 * i];
                                kp.pt.y = (float)ptr[7 * i + 1];
                                kp.size = (float)ptr[7 * i + 2];
                                kp.angle = (float)ptr[7 * i + 3];
                                kp.response = (float)ptr[7 * i + 4];
                                kp.octave = (int)ptr[7 * i + 5];
                                kp.class_id = (int)ptr[7 * i + 6];
                            }
                        }
                        else
                        {
                            throw new CvException("Input Mat should be of CV_32FC7 or CV_64FC7 type\n" + mat);
                        }
                    }
                    return;
                }
#endif
                if (type == CvType.CV_32FC(7))
                {
#if NET_STANDARD_2_1
                float[] buff = ArrayPool<float>.Shared.Rent(7 * count);
#else
                    float[] buff = new float[7 * count];
#endif
                    mat.get(0, 0, buff, 7 * count);
                    for (int i = 0; i < akp.Length; i++)
                    {
                        KeyPoint kp = akp[i];
                        kp.pt.x = buff[7 * i];
                        kp.pt.y = buff[7 * i + 1];
                        kp.size = buff[7 * i + 2];
                        kp.angle = buff[7 * i + 3];
                        kp.response = buff[7 * i + 4];
                        kp.octave = (int)buff[7 * i + 5];
                        kp.class_id = (int)buff[7 * i + 6];
                    }
#if NET_STANDARD_2_1
                ArrayPool<float>.Shared.Return(buff);
#endif
                }
                else if (type == CvType.CV_64FC(7))
                {
#if NET_STANDARD_2_1
                double[] buff = ArrayPool<double>.Shared.Rent(7 * count);
#else
                    double[] buff = new double[7 * count];
#endif
                    mat.get(0, 0, buff, 7 * count);
                    for (int i = 0; i < akp.Length; i++)
                    {
                        KeyPoint kp = akp[i];
                        kp.pt.x = (float)buff[7 * i];
                        kp.pt.y = (float)buff[7 * i + 1];
                        kp.size = (float)buff[7 * i + 2];
                        kp.angle = (float)buff[7 * i + 3];
                        kp.response = (float)buff[7 * i + 4];
                        kp.octave = (int)buff[7 * i + 5];
                        kp.class_id = (int)buff[7 * i + 6];
                    }
#if NET_STANDARD_2_1
                ArrayPool<double>.Shared.Return(buff);
#endif
                }
                else
                {
                    throw new CvException("Input Mat should be of CV_32FC7 or CV_64FC7 type\n" + mat);
                }
            }
        }

        internal static void List_Rect_to_Mat(List<Rect> lr, Mat mat, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        int* ptr = (int*)mat.dataAddr();

                        for (int i = 0; i < count; i++)
                        {
                            Rect r = lr[i];
                            ptr[4 * i] = (int)r.x;
                            ptr[4 * i + 1] = (int)r.y;
                            ptr[4 * i + 2] = (int)r.width;
                            ptr[4 * i + 3] = (int)r.height;
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            int[] buff = ArrayPool<int>.Shared.Rent(4 * count);
#else
                int[] buff = new int[4 * count];
#endif
                for (int i = 0; i < count; i++)
                {
                    Rect r = lr[i];
                    buff[4 * i] = (int)r.x;
                    buff[4 * i + 1] = (int)r.y;
                    buff[4 * i + 2] = (int)r.width;
                    buff[4 * i + 3] = (int)r.height;
                }
                mat.put(0, 0, buff, 4 * count);
#if NET_STANDARD_2_1
            ArrayPool<int>.Shared.Return(buff);
#endif
            }
        }

        internal static void Array_Rect_to_Mat(Rect[] ar, Mat mat, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        int* ptr = (int*)mat.dataAddr();

                        for (int i = 0; i < ar.Length; i++)
                        {
                            Rect r = ar[i];
                            ptr[4 * i] = (int)r.x;
                            ptr[4 * i + 1] = (int)r.y;
                            ptr[4 * i + 2] = (int)r.width;
                            ptr[4 * i + 3] = (int)r.height;
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            int[] buff = ArrayPool<int>.Shared.Rent(4 * count);
#else
                int[] buff = new int[4 * count];
#endif
                for (int i = 0; i < ar.Length; i++)
                {
                    Rect r = ar[i];
                    buff[4 * i] = (int)r.x;
                    buff[4 * i + 1] = (int)r.y;
                    buff[4 * i + 2] = (int)r.width;
                    buff[4 * i + 3] = (int)r.height;
                }
                mat.put(0, 0, buff, 4 * count);
#if NET_STANDARD_2_1
            ArrayPool<int>.Shared.Return(buff);
#endif
            }
        }

        internal static void Mat_to_List_Rect(Mat mat, List<Rect> lr, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        int* ptr = (int*)mat.dataAddr();

                        for (int i = 0; i < count; i++)
                        {
                            Rect r = lr[i];
                            r.x = ptr[4 * i];
                            r.y = ptr[4 * i + 1];
                            r.width = ptr[4 * i + 2];
                            r.height = ptr[4 * i + 3];
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            int[] buff = ArrayPool<int>.Shared.Rent(4 * count);
#else
                int[] buff = new int[4 * count];
#endif
                mat.get(0, 0, buff, 4 * count);
                for (int i = 0; i < count; i++)
                {
                    Rect r = lr[i];
                    r.x = buff[4 * i];
                    r.y = buff[4 * i + 1];
                    r.width = buff[4 * i + 2];
                    r.height = buff[4 * i + 3];
                }
#if NET_STANDARD_2_1
            ArrayPool<int>.Shared.Return(buff);
#endif
            }
        }

        internal static void Mat_to_Array_Rect(Mat mat, Rect[] ar, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        int* ptr = (int*)mat.dataAddr();

                        for (int i = 0; i < ar.Length; i++)
                        {
                            Rect r = ar[i];
                            r.x = ptr[4 * i];
                            r.y = ptr[4 * i + 1];
                            r.width = ptr[4 * i + 2];
                            r.height = ptr[4 * i + 3];
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            int[] buff = ArrayPool<int>.Shared.Rent(4 * count);
#else
                int[] buff = new int[4 * count];
#endif
                mat.get(0, 0, buff, 4 * count);
                for (int i = 0; i < ar.Length; i++)
                {
                    Rect r = ar[i];
                    r.x = buff[4 * i];
                    r.y = buff[4 * i + 1];
                    r.width = buff[4 * i + 2];
                    r.height = buff[4 * i + 3];
                }
#if NET_STANDARD_2_1
            ArrayPool<int>.Shared.Return(buff);
#endif
            }
        }

        internal static void List_Rect2d_to_Mat(List<Rect2d> lr2d, Mat mat, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        double* ptr = (double*)mat.dataAddr();
                        for (int i = 0; i < count; i++)
                        {
                            Rect2d r = lr2d[i];
                            ptr[4 * i + 0] = (double)r.x;
                            ptr[4 * i + 1] = (double)r.y;
                            ptr[4 * i + 2] = (double)r.width;
                            ptr[4 * i + 3] = (double)r.height;
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            double[] buff = ArrayPool<double>.Shared.Rent(count * 4);
#else
                double[] buff = new double[count * 4];
#endif
                for (int i = 0; i < count; i++)
                {
                    Rect2d r = lr2d[i];
                    buff[4 * i + 0] = (double)r.x;
                    buff[4 * i + 1] = (double)r.y;
                    buff[4 * i + 2] = (double)r.width;
                    buff[4 * i + 3] = (double)r.height;
                }
                mat.put(0, 0, buff, count * 4); //TODO: check ret val!
#if NET_STANDARD_2_1
            ArrayPool<double>.Shared.Return(buff);
#endif
            }
        }

        internal static void Array_Rect2d_to_Mat(Rect2d[] ar2d, Mat mat, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        double* ptr = (double*)mat.dataAddr();
                        for (int i = 0; i < ar2d.Length; i++)
                        {
                            Rect2d r = ar2d[i];
                            ptr[4 * i + 0] = (double)r.x;
                            ptr[4 * i + 1] = (double)r.y;
                            ptr[4 * i + 2] = (double)r.width;
                            ptr[4 * i + 3] = (double)r.height;
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            double[] buff = ArrayPool<double>.Shared.Rent(count * 4);
#else
                double[] buff = new double[count * 4];
#endif
                for (int i = 0; i < ar2d.Length; i++)
                {
                    Rect2d r = ar2d[i];
                    buff[4 * i + 0] = (double)r.x;
                    buff[4 * i + 1] = (double)r.y;
                    buff[4 * i + 2] = (double)r.width;
                    buff[4 * i + 3] = (double)r.height;
                }
                mat.put(0, 0, buff, count * 4); //TODO: check ret val!
#if NET_STANDARD_2_1
            ArrayPool<double>.Shared.Return(buff);
#endif
            }
        }

        internal static void Mat_to_List_Rect2d(Mat mat, List<Rect2d> lr2d, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        double* ptr = (double*)mat.dataAddr();

                        for (int i = 0; i < count; i++)
                        {
                            Rect2d r = lr2d[i];
                            r.x = ptr[4 * i + 0];
                            r.y = ptr[4 * i + 1];
                            r.width = ptr[4 * i + 2];
                            r.height = ptr[4 * i + 3];
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            double[] buff = ArrayPool<double>.Shared.Rent(count * 4);
#else
                double[] buff = new double[count * 4];
#endif
                mat.get(0, 0, buff, count * 4); //TODO: check ret val!
                for (int i = 0; i < count; i++)
                {
                    Rect2d r = lr2d[i];
                    r.x = buff[4 * i + 0];
                    r.y = buff[4 * i + 1];
                    r.width = buff[4 * i + 2];
                    r.height = buff[4 * i + 3];
                }
#if NET_STANDARD_2_1
            ArrayPool<double>.Shared.Return(buff);
#endif
            }
        }

        internal static void Mat_to_Array_Rect2d(Mat mat, Rect2d[] ar2d, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        double* ptr = (double*)mat.dataAddr();

                        for (int i = 0; i < ar2d.Length; i++)
                        {
                            Rect2d r = ar2d[i];
                            r.x = ptr[4 * i + 0];
                            r.y = ptr[4 * i + 1];
                            r.width = ptr[4 * i + 2];
                            r.height = ptr[4 * i + 3];
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            double[] buff = ArrayPool<double>.Shared.Rent(count * 4);
#else
                double[] buff = new double[count * 4];
#endif
                mat.get(0, 0, buff, count * 4); //TODO: check ret val!
                for (int i = 0; i < ar2d.Length; i++)
                {
                    Rect2d r = ar2d[i];
                    r.x = buff[4 * i + 0];
                    r.y = buff[4 * i + 1];
                    r.width = buff[4 * i + 2];
                    r.height = buff[4 * i + 3];
                }
#if NET_STANDARD_2_1
            ArrayPool<double>.Shared.Return(buff);
#endif
            }
        }

        internal static void List_RotatedRect_to_Mat(List<RotatedRect> lrr, Mat mat, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        float* ptr = (float*)mat.dataAddr();

                        for (int i = 0; i < count; i++)
                        {
                            RotatedRect r = lrr[i];
                            ptr[5 * i] = (float)r.center.x;
                            ptr[5 * i + 1] = (float)r.center.y;
                            ptr[5 * i + 2] = (float)r.size.width;
                            ptr[5 * i + 3] = (float)r.size.height;
                            ptr[5 * i + 4] = (float)r.angle;
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            float[] buff = ArrayPool<float>.Shared.Rent(5 * count);
#else
                float[] buff = new float[5 * count];
#endif
                for (int i = 0; i < count; i++)
                {
                    RotatedRect r = lrr[i];
                    buff[5 * i] = (float)r.center.x;
                    buff[5 * i + 1] = (float)r.center.y;
                    buff[5 * i + 2] = (float)r.size.width;
                    buff[5 * i + 3] = (float)r.size.height;
                    buff[5 * i + 4] = (float)r.angle;
                }
                mat.put(0, 0, buff, 5 * count);
#if NET_STANDARD_2_1
            ArrayPool<float>.Shared.Return(buff);
#endif
            }
        }

        internal static void Array_RotatedRect_to_Mat(RotatedRect[] lrr, Mat mat, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        float* ptr = (float*)mat.dataAddr();

                        for (int i = 0; i < lrr.Length; i++)
                        {
                            RotatedRect r = lrr[i];
                            ptr[5 * i] = (float)r.center.x;
                            ptr[5 * i + 1] = (float)r.center.y;
                            ptr[5 * i + 2] = (float)r.size.width;
                            ptr[5 * i + 3] = (float)r.size.height;
                            ptr[5 * i + 4] = (float)r.angle;
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            float[] buff = ArrayPool<float>.Shared.Rent(5 * count);
#else
                float[] buff = new float[5 * count];
#endif
                for (int i = 0; i < lrr.Length; i++)
                {
                    RotatedRect r = lrr[i];
                    buff[5 * i] = (float)r.center.x;
                    buff[5 * i + 1] = (float)r.center.y;
                    buff[5 * i + 2] = (float)r.size.width;
                    buff[5 * i + 3] = (float)r.size.height;
                    buff[5 * i + 4] = (float)r.angle;
                }
                mat.put(0, 0, buff, 5 * count);
#if NET_STANDARD_2_1
            ArrayPool<float>.Shared.Return(buff);
#endif
            }
        }

        internal static void Mat_to_List_RotatedRect(Mat mat, List<RotatedRect> lrr, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        float* ptr = (float*)mat.dataAddr();

                        for (int i = 0; i < count; i++)
                        {
                            RotatedRect r = lrr[i];
                            r.center.x = ptr[5 * i];
                            r.center.y = ptr[5 * i + 1];
                            r.size.width = ptr[5 * i + 2];
                            r.size.height = ptr[5 * i + 3];
                            r.angle = ptr[5 * i + 4];
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            float[] buff = ArrayPool<float>.Shared.Rent(5 * count);
#else
                float[] buff = new float[5 * count];
#endif
                mat.get(0, 0, buff, 5 * count);
                for (int i = 0; i < count; i++)
                {
                    RotatedRect r = lrr[i];
                    r.center.x = buff[5 * i];
                    r.center.y = buff[5 * i + 1];
                    r.size.width = buff[5 * i + 2];
                    r.size.height = buff[5 * i + 3];
                    r.angle = buff[5 * i + 4];
                }
#if NET_STANDARD_2_1
            ArrayPool<float>.Shared.Return(buff);
#endif
            }
        }

        internal static void Mat_to_Array_RotatedRect(Mat mat, RotatedRect[] arr, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        float* ptr = (float*)mat.dataAddr();

                        for (int i = 0; i < arr.Length; i++)
                        {
                            RotatedRect r = arr[i];
                            r.center.x = ptr[5 * i];
                            r.center.y = ptr[5 * i + 1];
                            r.size.width = ptr[5 * i + 2];
                            r.size.height = ptr[5 * i + 3];
                            r.angle = ptr[5 * i + 4];
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            float[] buff = ArrayPool<float>.Shared.Rent(5 * count);
#else
                float[] buff = new float[5 * count];
#endif
                mat.get(0, 0, buff, 5 * count);
                for (int i = 0; i < arr.Length; i++)
                {
                    RotatedRect r = arr[i];
                    r.center.x = buff[5 * i];
                    r.center.y = buff[5 * i + 1];
                    r.size.width = buff[5 * i + 2];
                    r.size.height = buff[5 * i + 3];
                    r.angle = buff[5 * i + 4];
                }
#if NET_STANDARD_2_1
            ArrayPool<float>.Shared.Return(buff);
#endif
            }
        }

        internal static void List_Mat_to_Mat<T>(List<T> lm, Mat mat, int count) where T : Mat
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        int* ptr = (int*)mat.dataAddr();

                        for (int i = 0; i < count; i++)
                        {
                            long addr = lm[i].nativeObj.ToInt64();//TODO:@check
                            ptr[i * 2] = (int)(addr >> 32);
                            ptr[i * 2 + 1] = (int)(addr & 0xffffffff);
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            int[] buff = ArrayPool<int>.Shared.Rent(count * 2);
#else
                int[] buff = new int[count * 2];
#endif
                for (int i = 0; i < count; i++)
                {
                    long addr = lm[i].nativeObj.ToInt64();//TODO:@check
                    buff[i * 2] = (int)(addr >> 32);
                    buff[i * 2 + 1] = (int)(addr & 0xffffffff);
                }
                mat.put(0, 0, buff, count * 2);
#if NET_STANDARD_2_1
            ArrayPool<int>.Shared.Return(buff);
#endif
            }
        }

        internal static void Mat_to_List_Mat<T>(Mat mat, List<T> lm, int count) where T : Mat
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        int* ptr = (int*)mat.dataAddr();

                        for (int i = 0; i < count; i++)
                        {
                            long addr = (((long)ptr[i * 2]) << 32) | (((long)ptr[i * 2 + 1]) & 0xffffffffL);
                            //          mats.add(new Mat(addr));
                            //ilm.Add(new Mat(new IntPtr(addr)));//TODO:@check
                            lm[i].nativeObj = new IntPtr(addr);

                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            int[] buff = ArrayPool<int>.Shared.Rent(count * 2);
#else
                int[] buff = new int[count * 2];
#endif
                mat.get(0, 0, buff, count * 2);
                for (int i = 0; i < count; i++)
                {
                    long addr = (((long)buff[i * 2]) << 32) | (((long)buff[i * 2 + 1]) & 0xffffffffL);
                    //          mats.add(new Mat(addr));
                    //ilm.Add(new Mat(new IntPtr(addr)));//TODO:@check
                    lm[i].nativeObj = new IntPtr(addr);

                }
#if NET_STANDARD_2_1
            ArrayPool<int>.Shared.Return(buff);
#endif
            }
        }

        internal static void List_uchar_to_Mat(List<byte> lb, Mat mat, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        byte* ptr = (byte*)mat.dataAddr();

                        for (int i = 0; i < count; i++)
                        {
                            ptr[i] = lb[i];
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            byte[] buff = ArrayPool<byte>.Shared.Rent(count);
#else
                byte[] buff = new byte[count];
#endif
                for (int i = 0; i < count; i++)
                {
                    buff[i] = lb[i];
                }
                mat.put(0, 0, buff, count);
#if NET_STANDARD_2_1
            ArrayPool<byte>.Shared.Return(buff);
#endif
            }
        }

        internal static void Mat_to_List_uchar(Mat mat, List<byte> lb, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        byte* ptr = (byte*)mat.dataAddr();

                        for (int i = 0; i < count; i++)
                        {
                            lb[i] = ptr[i];
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            byte[] buff = ArrayPool<byte>.Shared.Rent(count);
#else
                byte[] buff = new byte[count];
#endif
                mat.get(0, 0, buff, count);
                for (int i = 0; i < count; i++)
                {
                    lb[i] = buff[i];
                }
#if NET_STANDARD_2_1
            ArrayPool<byte>.Shared.Return(buff);
#endif
            }
        }

        internal static void List_char_to_Mat(List<sbyte> lb, Mat mat, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        sbyte* ptr = (sbyte*)mat.dataAddr();

                        for (int i = 0; i < count; i++)
                        {
                            ptr[i] = lb[i];
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            sbyte[] buff = ArrayPool<sbyte>.Shared.Rent(count);
#else
                sbyte[] buff = new sbyte[count];
#endif
                for (int i = 0; i < count; i++)
                {
                    buff[i] = lb[i];
                }
                mat.put(0, 0, buff, count);
#if NET_STANDARD_2_1
            ArrayPool<sbyte>.Shared.Return(buff);
#endif
            }
        }

        internal static void Mat_to_List_char(Mat mat, List<sbyte> lb, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        sbyte* ptr = (sbyte*)mat.dataAddr();

                        for (int i = 0; i < count; i++)
                        {
                            lb[i] = ptr[i];
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            sbyte[] buff = ArrayPool<sbyte>.Shared.Rent(count);
#else
                sbyte[] buff = new sbyte[count];
#endif
                mat.get(0, 0, buff, count);
                for (int i = 0; i < count; i++)
                {
                    lb[i] = buff[i];
                }
#if NET_STANDARD_2_1
            ArrayPool<sbyte>.Shared.Return(buff);
#endif
            }
        }

        internal static void List_int_to_Mat(List<int> li, Mat mat, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        int* ptr = (int*)mat.dataAddr();

                        if (type == CvType.CV_32SC1)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                ptr[i] = li[i];
                            }
                        }
                        else if (type == CvType.CV_32SC4)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                ptr[i + 0] = li[i + 0];
                                ptr[i + 1] = li[i + 1];
                                ptr[i + 2] = li[i + 2];
                                ptr[i + 3] = li[i + 3];
                            }
                        }
                        else
                        {
                            throw new CvException("'type' can be CV_32SC1 or CV_32SC4");
                        }
                        return;
                    }
                }
#endif

#if NET_STANDARD_2_1
            int[] buff = ArrayPool<int>.Shared.Rent(count);
#else
                int[] buff = new int[count];
#endif
                if (type == CvType.CV_32SC1)
                {
                    for (int i = 0; i < count; i++)
                    {
                        buff[i] = li[i];
                    }
                }
                else if (type == CvType.CV_32SC4)
                {
                    for (int i = 0; i < count; i++)
                    {
                        buff[i + 0] = li[i + 0];
                        buff[i + 1] = li[i + 1];
                        buff[i + 2] = li[i + 2];
                        buff[i + 3] = li[i + 3];
                    }
                }
                else
                {
                    throw new CvException("'type' can be CV_32SC1 or CV_32SC4");
                }
                mat.put(0, 0, buff, count);
#if NET_STANDARD_2_1
            ArrayPool<int>.Shared.Return(buff);
#endif
            }
        }

        internal static void Mat_to_List_int(Mat mat, List<int> li, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        int* ptr = (int*)mat.dataAddr();

                        if (type == CvType.CV_32SC1)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                li[i] = ptr[i];
                            }
                        }
                        else if (type == CvType.CV_32SC4)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                li[i + 0] = ptr[i + 0];
                                li[i + 1] = ptr[i + 1];
                                li[i + 2] = ptr[i + 2];
                                li[i + 3] = ptr[i + 3];
                            }
                        }
                        else
                        {
                            throw new CvException("Input Mat should be of CV_32SC1 or CV_32SC4 type\n" + mat);
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            int[] buff = ArrayPool<int>.Shared.Rent(count);
#else
                int[] buff = new int[count];
#endif
                mat.get(0, 0, buff, count);
                if (type == CvType.CV_32SC1)
                {
                    for (int i = 0; i < count; i++)
                    {
                        li[i] = buff[i];
                    }
                }
                else if (type == CvType.CV_32SC4)
                {
                    for (int i = 0; i < count; i++)
                    {
                        li[i + 0] = buff[i + 0];
                        li[i + 1] = buff[i + 1];
                        li[i + 2] = buff[i + 2];
                        li[i + 3] = buff[i + 3];
                    }
                }
                else
                {
                    throw new CvException("Input Mat should be of CV_32SC1 or CV_32SC4 type\n" + mat);
                }
#if NET_STANDARD_2_1
            ArrayPool<int>.Shared.Return(buff);
#endif
            }
        }

        internal static void List_float_to_Mat(List<float> lf, Mat mat, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        float* ptr = (float*)mat.dataAddr();

                        if (type == CvType.CV_32FC1)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                ptr[i] = lf[i];
                            }
                        }
                        else if (type == CvType.CV_32FC4)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                ptr[i + 0] = lf[i + 0];
                                ptr[i + 1] = lf[i + 1];
                                ptr[i + 2] = lf[i + 2];
                                ptr[i + 3] = lf[i + 3];
                            }
                        }
                        else if (type == CvType.CV_32FC(6))
                        {
                            for (int i = 0; i < count; i++)
                            {
                                ptr[i + 0] = lf[i + 0];
                                ptr[i + 1] = lf[i + 1];
                                ptr[i + 2] = lf[i + 2];
                                ptr[i + 3] = lf[i + 3];
                                ptr[i + 4] = lf[i + 4];
                                ptr[i + 5] = lf[i + 5];
                            }
                        }
                        else
                        {
                            throw new CvException("'type' can be CV_32FC1, CV_32FC4 or CV_32FC6");
                        }
                        return;
                    }
                }
#endif

#if NET_STANDARD_2_1
            float[] buff = ArrayPool<float>.Shared.Rent(count);
#else
                float[] buff = new float[count];
#endif
                if (type == CvType.CV_32FC1)
                {
                    for (int i = 0; i < count; i++)
                    {
                        buff[i] = lf[i];
                    }
                }
                else if (type == CvType.CV_32FC4)
                {
                    for (int i = 0; i < count; i++)
                    {
                        buff[i + 0] = lf[i + 0];
                        buff[i + 1] = lf[i + 1];
                        buff[i + 2] = lf[i + 2];
                        buff[i + 3] = lf[i + 3];
                    }
                }
                else if (type == CvType.CV_32FC(6))
                {
                    for (int i = 0; i < count; i++)
                    {
                        buff[i + 0] = lf[i + 0];
                        buff[i + 1] = lf[i + 1];
                        buff[i + 2] = lf[i + 2];
                        buff[i + 3] = lf[i + 3];
                        buff[i + 4] = lf[i + 4];
                        buff[i + 5] = lf[i + 5];
                    }
                }
                else
                {
                    throw new CvException("'type' can be CV_32FC1, CV_32FC4 or CV_32FC6");
                }
                mat.put(0, 0, buff, count);
#if NET_STANDARD_2_1
            ArrayPool<float>.Shared.Return(buff);
#endif
            }
        }

        internal static void Mat_to_List_float(Mat mat, List<float> lf, int count, int type)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        float* ptr = (float*)mat.dataAddr();

                        if (type == CvType.CV_32FC1)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                lf[i] = ptr[i];
                            }
                        }
                        else if (type == CvType.CV_32FC4)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                lf[i + 0] = ptr[i + 0];
                                lf[i + 1] = ptr[i + 1];
                                lf[i + 2] = ptr[i + 2];
                                lf[i + 3] = ptr[i + 3];
                            }
                        }
                        else if (type == CvType.CV_32FC(6))
                        {
                            for (int i = 0; i < count; i++)
                            {
                                lf[i + 0] = ptr[i + 0];
                                lf[i + 1] = ptr[i + 1];
                                lf[i + 2] = ptr[i + 2];
                                lf[i + 3] = ptr[i + 3];
                                lf[i + 4] = ptr[i + 4];
                                lf[i + 5] = ptr[i + 5];
                            }
                        }
                        else
                        {
                            throw new CvException("Input Mat should be of CV_32FC1, CV_32FC4 or CV_32FC6 type\n" + mat);
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            float[] buff = ArrayPool<float>.Shared.Rent(count);
#else
                float[] buff = new float[count];
#endif
                mat.get(0, 0, buff, count);
                if (type == CvType.CV_32FC1)
                {
                    for (int i = 0; i < count; i++)
                    {
                        lf[i] = buff[i];
                    }
                }
                else if (type == CvType.CV_32FC4)
                {
                    for (int i = 0; i < count; i++)
                    {
                        lf[i + 0] = buff[i + 0];
                        lf[i + 1] = buff[i + 1];
                        lf[i + 2] = buff[i + 2];
                        lf[i + 3] = buff[i + 3];
                    }
                }
                else if (type == CvType.CV_32FC(6))
                {
                    for (int i = 0; i < count; i++)
                    {
                        lf[i + 0] = buff[i + 0];
                        lf[i + 1] = buff[i + 1];
                        lf[i + 2] = buff[i + 2];
                        lf[i + 3] = buff[i + 3];
                        lf[i + 4] = buff[i + 4];
                        lf[i + 5] = buff[i + 5];
                    }
                }
                else
                {
                    throw new CvException("Input Mat should be of CV_32FC1, CV_32FC4 or CV_32FC6 type\n" + mat);
                }
#if NET_STANDARD_2_1
            ArrayPool<float>.Shared.Return(buff);
#endif
            }
        }

        internal static void List_double_to_Mat(List<double> ld, Mat mat, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        double* ptr = (double*)mat.dataAddr();

                        for (int i = 0; i < count; i++)
                        {
                            ptr[i] = ld[i];
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            double[] buff = ArrayPool<double>.Shared.Rent(count);
#else
                double[] buff = new double[count];
#endif
                for (int i = 0; i < count; i++)
                {
                    buff[i] = ld[i];
                }
                mat.put(0, 0, buff, count);
#if NET_STANDARD_2_1
            ArrayPool<double>.Shared.Return(buff);
#endif
            }
        }

        internal static void Mat_to_List_double(Mat mat, List<double> ld, int count)
        {
            {
#if !OPENCV_DONT_USE_UNSAFE_CODE
                if (mat.isContinuous())
                {
                    unsafe
                    {
                        double* ptr = (double*)mat.dataAddr();

                        for (int i = 0; i < count; i++)
                        {
                            ld[i] = ptr[i];
                        }
                    }
                    return;
                }
#endif

#if NET_STANDARD_2_1
            double[] buff = ArrayPool<double>.Shared.Rent(count);
#else
                double[] buff = new double[count];
#endif
                mat.get(0, 0, buff, count);
                for (int i = 0; i < count; i++)
                {
                    ld[i] = buff[i];
                }
#if NET_STANDARD_2_1
            ArrayPool<double>.Shared.Return(buff);
#endif
            }
        }
    }
}
