
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{

    // C++: class TrackerVit
    /**
     @brief the VIT tracker is a super lightweight dnn-based general object tracking.
      *
      *  VIT tracker is much faster and extremely lightweight due to special model structure, the model file is about 767KB.
      *  Model download link: https://github.com/opencv/opencv_zoo/tree/main/models/object_tracking_vittrack
      *  Author: PengyuLiu, 1872918507@qq.com
     */

    public class TrackerVit : Tracker
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
                        video_TrackerVit_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrackerVit(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TrackerVit __fromPtr__(IntPtr addr) { return new TrackerVit(addr); }

        //
        // C++: static Ptr_TrackerVit cv::TrackerVit::create(TrackerVit_Params parameters = TrackerVit::Params())
        //

        /**
         @brief Constructor
             @param parameters vit tracker parameters TrackerVit::Params
         */
        public static TrackerVit create(TrackerVit_Params parameters)
        {
            if (parameters != null) parameters.ThrowIfDisposed();

            return TrackerVit.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_TrackerVit_create_10(parameters.nativeObj)));


        }

        /**
         @brief Constructor
             @param parameters vit tracker parameters TrackerVit::Params
         */
        public static TrackerVit create()
        {


            return TrackerVit.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_TrackerVit_create_11()));


        }


        //
        // C++:  float cv::TrackerVit::getTrackingScore()
        //

        /**
         @brief Return tracking score
         */
        public float getTrackingScore()
        {
            ThrowIfDisposed();

            return video_TrackerVit_getTrackingScore_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_TrackerVit cv::TrackerVit::create(TrackerVit_Params parameters = TrackerVit::Params())
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerVit_create_10(IntPtr parameters_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerVit_create_11();

        // C++:  float cv::TrackerVit::getTrackingScore()
        [DllImport(LIBNAME)]
        private static extern float video_TrackerVit_getTrackingScore_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_TrackerVit_delete(IntPtr nativeObj);

    }
}
