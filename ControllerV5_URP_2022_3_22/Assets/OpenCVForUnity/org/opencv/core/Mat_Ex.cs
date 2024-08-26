using UnityEngine;

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.CoreModule
{

    public partial class Mat
    {
        public int put(int row, int col, double[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            return core_Mat_nPutD(nativeObj, row, col, length, data);

        }

        // javadoc:Mat::put(idx,data)
        public int put(int[] idx, double[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            return core_Mat_nPutDIdx(nativeObj, idx, idx.Length, length, data);

        }

        public int put(int row, int col, float[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_32F)
            {
                return core_Mat_nPutF(nativeObj, row, col, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::put(idx,data)
        public int put(int[] idx, float[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_32F)
            {
                return core_Mat_nPutFIdx(nativeObj, idx, idx.Length, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        public int put(int row, int col, int[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_32S)
            {
                return core_Mat_nPutI(nativeObj, row, col, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::put(idx,data)
        public int put(int[] idx, int[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_32S)
            {
                return core_Mat_nPutIIdx(nativeObj, idx, idx.Length, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        public int put(int row, int col, short[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_16U || CvType.depth(t) == CvType.CV_16S)
            {
                return core_Mat_nPutS(nativeObj, row, col, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::put(idx,data)
        public int put(int[] idx, short[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_16U || CvType.depth(t) == CvType.CV_16S)
            {
                return core_Mat_nPutSIdx(nativeObj, idx, idx.Length, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        public int put(int row, int col, ushort[] data)
        {
            ThrowIfDisposed();

            int t = type();
            if (data == null || data.Length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : data.Length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_16U || CvType.depth(t) == CvType.CV_16S)
            {
                return core_Mat_nPutS(nativeObj, row, col, data.Length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        public int put(int row, int col, ushort[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_16U || CvType.depth(t) == CvType.CV_16S)
            {
                return core_Mat_nPutS(nativeObj, row, col, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::put(idx,data)
        public int put(int[] idx, ushort[] data)
        {
            ThrowIfDisposed();

            int t = type();
            if (data == null || data.Length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : data.Length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_16U || CvType.depth(t) == CvType.CV_16S)
            {
                return core_Mat_nPutSIdx(nativeObj, idx, idx.Length, data.Length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::put(idx,data)
        public int put(int[] idx, ushort[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_16U || CvType.depth(t) == CvType.CV_16S)
            {
                return core_Mat_nPutSIdx(nativeObj, idx, idx.Length, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        public int put(int row, int col, sbyte[] data)
        {
            ThrowIfDisposed();

            int t = type();
            if (data == null || data.Length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : data.Length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_8U || CvType.depth(t) == CvType.CV_8S)
            {
                return core_Mat_nPutB(nativeObj, row, col, data.Length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        public int put(int row, int col, sbyte[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_8U || CvType.depth(t) == CvType.CV_8S)
            {
                return core_Mat_nPutB(nativeObj, row, col, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::put(idx,data)
        public int put(int[] idx, sbyte[] data)
        {
            ThrowIfDisposed();

            int t = type();
            if (data == null || data.Length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : data.Length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_8U || CvType.depth(t) == CvType.CV_8S)
            {
                return core_Mat_nPutBIdx(nativeObj, idx, idx.Length, data.Length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::put(idx,data)
        public int put(int[] idx, sbyte[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_8U || CvType.depth(t) == CvType.CV_8S)
            {
                return core_Mat_nPutBIdx(nativeObj, idx, idx.Length, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        public int put(int row, int col, sbyte[] data, int offset, int length)
        {
            ThrowIfDisposed();

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_8U || CvType.depth(t) == CvType.CV_8S)
            {
                return core_Mat_nPutBwOffset(nativeObj, row, col, length, offset, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::put(idx,data,offset,length)
        public int put(int[] idx, sbyte[] data, int offset, int length)
        {
            ThrowIfDisposed();

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_8U || CvType.depth(t) == CvType.CV_8S)
            {
                return core_Mat_nPutBwIdxOffset(nativeObj, idx, idx.Length, length, offset, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }
        public int put(int row, int col, byte[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_8U || CvType.depth(t) == CvType.CV_8S)
            {
                return core_Mat_nPutB(nativeObj, row, col, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::put(idx,data)
        public int put(int[] idx, byte[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_8U || CvType.depth(t) == CvType.CV_8S)
            {
                return core_Mat_nPutBIdx(nativeObj, idx, idx.Length, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        public int get(int row, int col, sbyte[] data)
        {
            ThrowIfDisposed();

            int t = type();
            if (data == null || data.Length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : data.Length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_8U || CvType.depth(t) == CvType.CV_8S)
            {
                return core_Mat_nGetB(nativeObj, row, col, data.Length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        public int get(int row, int col, sbyte[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_8U || CvType.depth(t) == CvType.CV_8S)
            {
                return core_Mat_nGetB(nativeObj, row, col, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::get(idx,data)
        public int get(int[] idx, sbyte[] data)
        {
            ThrowIfDisposed();

            int t = type();
            if (data == null || data.Length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : data.Length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_8U || CvType.depth(t) == CvType.CV_8S)
            {
                return core_Mat_nGetBIdx(nativeObj, idx, idx.Length, data.Length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::get(idx,data)
        public int get(int[] idx, sbyte[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_8U || CvType.depth(t) == CvType.CV_8S)
            {
                return core_Mat_nGetBIdx(nativeObj, idx, idx.Length, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        public int get(int row, int col, byte[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_8U || CvType.depth(t) == CvType.CV_8S)
            {
                return core_Mat_nGetB(nativeObj, row, col, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::get(idx,data)
        public int get(int[] idx, byte[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_8U || CvType.depth(t) == CvType.CV_8S)
            {
                return core_Mat_nGetBIdx(nativeObj, idx, idx.Length, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        public int get(int row, int col, short[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_16U || CvType.depth(t) == CvType.CV_16S)
            {
                return core_Mat_nGetS(nativeObj, row, col, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::get(idx,data)
        public int get(int[] idx, short[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_16U || CvType.depth(t) == CvType.CV_16S)
            {
                return core_Mat_nGetSIdx(nativeObj, idx, idx.Length, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        public int get(int row, int col, ushort[] data)
        {
            ThrowIfDisposed();

            int t = type();
            if (data == null || data.Length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : data.Length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_16U || CvType.depth(t) == CvType.CV_16S)
            {
                return core_Mat_nGetS(nativeObj, row, col, data.Length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        public int get(int row, int col, ushort[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_16U || CvType.depth(t) == CvType.CV_16S)
            {
                return core_Mat_nGetS(nativeObj, row, col, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::get(idx,data)
        public int get(int[] idx, ushort[] data)
        {
            ThrowIfDisposed();

            int t = type();
            if (data == null || data.Length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : data.Length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_16U || CvType.depth(t) == CvType.CV_16S)
            {
                return core_Mat_nGetSIdx(nativeObj, idx, idx.Length, data.Length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::get(idx,data)
        public int get(int[] idx, ushort[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_16U || CvType.depth(t) == CvType.CV_16S)
            {
                return core_Mat_nGetSIdx(nativeObj, idx, idx.Length, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        public int get(int row, int col, int[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_32S)
            {
                return core_Mat_nGetI(nativeObj, row, col, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::get(idx,data)
        public int get(int[] idx, int[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_32S)
            {
                return core_Mat_nGetIIdx(nativeObj, idx, idx.Length, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        public int get(int row, int col, float[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_32F)
            {
                return core_Mat_nGetF(nativeObj, row, col, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::get(idx,data)
        public int get(int[] idx, float[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_32F)
            {
                return core_Mat_nGetFIdx(nativeObj, idx, idx.Length, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        public int get(int row, int col, double[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                    "Provided data element number (" +
                    (data == null ? 0 : length) +
                    ") should be multiple of the Mat channels count (" +
                    CvType.channels(t) + ")");
            if (CvType.depth(t) == CvType.CV_64F)
            {
                return core_Mat_nGetD(nativeObj, row, col, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }

        // javadoc:Mat::get(idx,data)
        public int get(int[] idx, double[] data, int length)
        {
            ThrowIfDisposed();

            if (length < 0)
                length = data?.Length ?? 0;

            int t = type();
            if (data == null || length % CvType.channels(t) != 0)
                throw new CvException(
                        "Provided data element number (" +
                                (data == null ? 0 : length) +
                                ") should be multiple of the Mat channels count (" +
                                CvType.channels(t) + ")");
            if (idx.Length != dims())
                throw new CvException("Incorrect number of indices");
            if (CvType.depth(t) == CvType.CV_64F)
            {
                return core_Mat_nGetDIdx(nativeObj, idx, idx.Length, length, data);
            }
            throw new CvException("Mat data type is not compatible: " + t);

        }


        [DllImport(LIBNAME)]
        private static extern int core_Mat_nPutS(IntPtr self, int row, int col, int count, [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] data);

        [DllImport(LIBNAME)]
        private static extern int core_Mat_nPutSIdx(IntPtr self, int[] idx, int length, int count, [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] data);

        [DllImport(LIBNAME)]
        private static extern int core_Mat_nPutB(IntPtr self, int row, int col, int count, [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] sbyte[] data);

        [DllImport(LIBNAME)]
        private static extern int core_Mat_nPutBIdx(IntPtr self, int[] idx, int lenght, int count, [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] sbyte[] data);

        [DllImport(LIBNAME)]
        private static extern int core_Mat_nPutBwOffset(IntPtr self, int row, int col, int count, int offset, [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] sbyte[] data);

        [DllImport(LIBNAME)]
        private static extern int core_Mat_nPutBwIdxOffset(IntPtr self, int[] idx, int length, int count, int offset, [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] sbyte[] data);

        [DllImport(LIBNAME)]
        private static extern int core_Mat_nGetB(IntPtr self, int row, int col, int count, [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] sbyte[] vals);

        [DllImport(LIBNAME)]
        private static extern int core_Mat_nGetBIdx(IntPtr self, int[] idx, int length, int count, [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] sbyte[] vals);

        [DllImport(LIBNAME)]
        private static extern int core_Mat_nGetS(IntPtr self, int row, int col, int count, [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] vals);

        [DllImport(LIBNAME)]
        private static extern int core_Mat_nGetSIdx(IntPtr self, int[] idx, int length, int count, [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] vals);

        //
        #region Operators

        // (here A, B stand for matrices ( Mat ), s for a scalar ( Scalar ), alpha for a real-valued scalar ( double ).)

        #region Unary

        #region -
        // Negation.
        // -A
        public static Mat operator -(Mat a)
        {
            Mat m = new Mat();
            Core.multiply(a, Scalar.all(-1), m);
            return m;
        }
        #endregion

        #region ~

        // Bitwise not.
        // ~A
        public static Mat operator ~(Mat a)
        {
            Mat m = new Mat();
            Core.bitwise_not(a, m);
            return m;
        }

        #endregion

        #endregion


        #region Binary

        #region +
        // Addition.
        // A + B, A + s, s + A
        // A += A, A += s
        public static Mat operator +(Mat a, Mat b)
        {
            Mat m = new Mat();
            Core.add(a, b, m);
            return m;
        }

        public static Mat operator +(Mat a, Scalar s)
        {
            Mat m = new Mat();
            Core.add(a, s, m);
            return m;
        }

        public static Mat operator +(Scalar s, Mat a)
        {
            Mat m = new Mat();
            Core.add(a, s, m);
            return m;
        }
        #endregion

        #region -
        // Subtraction.
        // A - B, A - s, s - A
        // A -= A, A -= s
        public static Mat operator -(Mat a, Mat b)
        {
            Mat m = new Mat();
            Core.subtract(a, b, m);
            return m;
        }

        public static Mat operator -(Mat a, Scalar s)
        {
            Mat m = new Mat();
            Core.subtract(a, s, m);
            return m;
        }

        public static Mat operator -(Scalar s, Mat a)
        {
            Mat m = new Mat();
            using (Mat b = new Mat(a.size(), a.type(), s))
            {
                Core.subtract(b, a, m);
            }
            return m;
        }
        #endregion

        #region *
        // Matrix multiplication.
        // A * A
        public static Mat operator *(Mat a, Mat b)
        {
            Mat m = new Mat();
            Core.gemm(a, b, 1, new Mat(), 0, m);
            return m;
        }

        // Scaling.
        // A * alpha, alpha * A
        public static Mat operator *(Mat a, double s)
        {
            Mat m = new Mat();
            Core.multiply(a, Scalar.all(s), m);
            return m;
        }

        public static Mat operator *(double s, Mat a)
        {
            Mat m = new Mat();
            Core.multiply(a, Scalar.all(s), m);
            return m;
        }
        #endregion

        #region /
        // Per-element multiplication and division.
        // A / A, alpha / A
        public static Mat operator /(Mat a, Mat b)
        {
            Mat m = new Mat();
            Core.divide(a, b, m);
            return m;
        }

        public static Mat operator /(double s, Mat a)
        {
            Mat m = new Mat();
            using (Mat b = new Mat(a.size(), a.type(), Scalar.all(s)))
            {
                Core.divide(b, a, m);
            }
            return m;
        }

        // Scaling.
        // A / alpha
        public static Mat operator /(Mat a, double s)
        {
            Mat m = new Mat();
            Core.divide(a, Scalar.all(s), m);
            return m;
        }
        #endregion

        #region &
        // Bitwise and.
        // A & A, A & s, s & A
        public static Mat operator &(Mat a, Mat b)
        {
            Mat m = new Mat();
            Core.bitwise_and(a, b, m);
            return m;
        }

        public static Mat operator &(Mat a, Scalar s)
        {
            Mat m = new Mat();
            using (Mat b = new Mat(a.size(), a.type(), s))
            {
                Core.bitwise_and(a, b, m);
            }
            return m;
        }

        public static Mat operator &(Scalar s, Mat a)
        {
            Mat m = new Mat();
            using (Mat b = new Mat(a.size(), a.type(), s))
            {
                Core.bitwise_and(b, a, m);
            }
            return m;
        }
        #endregion

        #region |
        // Bitwise or.
        // A | A, A | s, s | A
        public static Mat operator |(Mat a, Mat b)
        {
            Mat m = new Mat();
            Core.bitwise_or(a, b, m);
            return m;
        }

        public static Mat operator |(Mat a, Scalar s)
        {
            Mat m = new Mat();
            using (Mat b = new Mat(a.size(), a.type(), s))
            {
                Core.bitwise_or(a, b, m);
            }
            return m;
        }

        public static Mat operator |(Scalar s, Mat a)
        {
            Mat m = new Mat();
            using (Mat b = new Mat(a.size(), a.type(), s))
            {
                Core.bitwise_or(b, a, m);
            }
            return m;
        }
        #endregion

        #region ^
        // Bitwise xor.
        // A ^ A, A ^ s, s ^ A
        public static Mat operator ^(Mat a, Mat b)
        {
            Mat m = new Mat();
            Core.bitwise_xor(a, b, m);
            return m;
        }

        public static Mat operator ^(Mat a, Scalar s)
        {
            Mat m = new Mat();
            using (Mat b = new Mat(a.size(), a.type(), s))
            {
                Core.bitwise_xor(a, b, m);
            }
            return m;
        }

        public static Mat operator ^(Scalar s, Mat a)
        {
            Mat m = new Mat();
            using (Mat b = new Mat(a.size(), a.type(), s))
            {
                Core.bitwise_xor(b, a, m);
            }
            return m;
        }
        #endregion

        #endregion

        #endregion
        //

    }
}
