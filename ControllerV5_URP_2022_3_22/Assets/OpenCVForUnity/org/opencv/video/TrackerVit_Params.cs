

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{
    // C++: class Params


    public class TrackerVit_Params : DisposableOpenCVObject
    {

        protected override void Dispose(bool disposing)
        {

            try
            {
                if (disposing)
                {
                }
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        video_TrackerVit_1Params_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrackerVit_Params(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static TrackerVit_Params __fromPtr__(IntPtr addr) { return new TrackerVit_Params(addr); }

        //
        // C++:   cv::TrackerVit::Params::Params()
        //

        public TrackerVit_Params()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(video_TrackerVit_1Params_TrackerVit_1Params_10());


        }


        //
        // C++: string TrackerVit_Params::net
        //

        public string get_net()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(video_TrackerVit_1Params_get_1net_10(nativeObj)));

            return retVal;
        }


        //
        // C++: void TrackerVit_Params::net
        //

        public void set_net(string net)
        {
            ThrowIfDisposed();

            video_TrackerVit_1Params_set_1net_10(nativeObj, net);


        }


        //
        // C++: int TrackerVit_Params::backend
        //

        public int get_backend()
        {
            ThrowIfDisposed();

            return video_TrackerVit_1Params_get_1backend_10(nativeObj);


        }


        //
        // C++: void TrackerVit_Params::backend
        //

        public void set_backend(int backend)
        {
            ThrowIfDisposed();

            video_TrackerVit_1Params_set_1backend_10(nativeObj, backend);


        }


        //
        // C++: int TrackerVit_Params::target
        //

        public int get_target()
        {
            ThrowIfDisposed();

            return video_TrackerVit_1Params_get_1target_10(nativeObj);


        }


        //
        // C++: void TrackerVit_Params::target
        //

        public void set_target(int target)
        {
            ThrowIfDisposed();

            video_TrackerVit_1Params_set_1target_10(nativeObj, target);


        }


        //
        // C++: Scalar TrackerVit_Params::meanvalue
        //

        public Scalar get_meanvalue()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[4];
            video_TrackerVit_1Params_get_1meanvalue_10(nativeObj, tmpArray);
            Scalar retVal = new Scalar(tmpArray);

            return retVal;
        }


        //
        // C++: void TrackerVit_Params::meanvalue
        //

        public void set_meanvalue(Scalar meanvalue)
        {
            ThrowIfDisposed();

            video_TrackerVit_1Params_set_1meanvalue_10(nativeObj, meanvalue.val[0], meanvalue.val[1], meanvalue.val[2], meanvalue.val[3]);


        }


        //
        // C++: Scalar TrackerVit_Params::stdvalue
        //

        public Scalar get_stdvalue()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[4];
            video_TrackerVit_1Params_get_1stdvalue_10(nativeObj, tmpArray);
            Scalar retVal = new Scalar(tmpArray);

            return retVal;
        }


        //
        // C++: void TrackerVit_Params::stdvalue
        //

        public void set_stdvalue(Scalar stdvalue)
        {
            ThrowIfDisposed();

            video_TrackerVit_1Params_set_1stdvalue_10(nativeObj, stdvalue.val[0], stdvalue.val[1], stdvalue.val[2], stdvalue.val[3]);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::TrackerVit::Params::Params()
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerVit_1Params_TrackerVit_1Params_10();

        // C++: string TrackerVit_Params::net
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerVit_1Params_get_1net_10(IntPtr nativeObj);

        // C++: void TrackerVit_Params::net
        [DllImport(LIBNAME)]
        private static extern void video_TrackerVit_1Params_set_1net_10(IntPtr nativeObj, string net);

        // C++: int TrackerVit_Params::backend
        [DllImport(LIBNAME)]
        private static extern int video_TrackerVit_1Params_get_1backend_10(IntPtr nativeObj);

        // C++: void TrackerVit_Params::backend
        [DllImport(LIBNAME)]
        private static extern void video_TrackerVit_1Params_set_1backend_10(IntPtr nativeObj, int backend);

        // C++: int TrackerVit_Params::target
        [DllImport(LIBNAME)]
        private static extern int video_TrackerVit_1Params_get_1target_10(IntPtr nativeObj);

        // C++: void TrackerVit_Params::target
        [DllImport(LIBNAME)]
        private static extern void video_TrackerVit_1Params_set_1target_10(IntPtr nativeObj, int target);

        // C++: Scalar TrackerVit_Params::meanvalue
        [DllImport(LIBNAME)]
        private static extern void video_TrackerVit_1Params_get_1meanvalue_10(IntPtr nativeObj, double[] retVal);

        // C++: void TrackerVit_Params::meanvalue
        [DllImport(LIBNAME)]
        private static extern void video_TrackerVit_1Params_set_1meanvalue_10(IntPtr nativeObj, double meanvalue_val0, double meanvalue_val1, double meanvalue_val2, double meanvalue_val3);

        // C++: Scalar TrackerVit_Params::stdvalue
        [DllImport(LIBNAME)]
        private static extern void video_TrackerVit_1Params_get_1stdvalue_10(IntPtr nativeObj, double[] retVal);

        // C++: void TrackerVit_Params::stdvalue
        [DllImport(LIBNAME)]
        private static extern void video_TrackerVit_1Params_set_1stdvalue_10(IntPtr nativeObj, double stdvalue_val0, double stdvalue_val1, double stdvalue_val2, double stdvalue_val3);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_TrackerVit_1Params_delete(IntPtr nativeObj);

    }
}
