
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using OpenCVForUnity.VideoModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.BgsegmModule
{

    // C++: class BackgroundSubtractorCNT
    /**
     @brief Background subtraction based on counting.
     
       About as fast as MOG2 on a high end system.
       More than twice faster than MOG2 on cheap hardware (benchmarked on Raspberry Pi3).
     
       %Algorithm by Sagi Zeevi ( https://github.com/sagi-z/BackgroundSubtractorCNT )
     */

    public class BackgroundSubtractorCNT : BackgroundSubtractor
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
                        bgsegm_BackgroundSubtractorCNT_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BackgroundSubtractorCNT(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BackgroundSubtractorCNT __fromPtr__(IntPtr addr) { return new BackgroundSubtractorCNT(addr); }

        //
        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::apply(Mat image, Mat& fgmask, double learningRate = -1)
        //

        public override void apply(Mat image, Mat fgmask, double learningRate)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();

            bgsegm_BackgroundSubtractorCNT_apply_10(nativeObj, image.nativeObj, fgmask.nativeObj, learningRate);


        }

        public override void apply(Mat image, Mat fgmask)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();

            bgsegm_BackgroundSubtractorCNT_apply_11(nativeObj, image.nativeObj, fgmask.nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::getBackgroundImage(Mat& backgroundImage)
        //

        public override void getBackgroundImage(Mat backgroundImage)
        {
            ThrowIfDisposed();
            if (backgroundImage != null) backgroundImage.ThrowIfDisposed();

            bgsegm_BackgroundSubtractorCNT_getBackgroundImage_10(nativeObj, backgroundImage.nativeObj);


        }


        //
        // C++:  int cv::bgsegm::BackgroundSubtractorCNT::getMinPixelStability()
        //

        /**
         @brief Returns number of frames with same pixel color to consider stable.
         */
        public int getMinPixelStability()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorCNT_getMinPixelStability_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::setMinPixelStability(int value)
        //

        /**
         @brief Sets the number of frames with same pixel color to consider stable.
         */
        public void setMinPixelStability(int value)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorCNT_setMinPixelStability_10(nativeObj, value);


        }


        //
        // C++:  int cv::bgsegm::BackgroundSubtractorCNT::getMaxPixelStability()
        //

        /**
         @brief Returns maximum allowed credit for a pixel in history.
         */
        public int getMaxPixelStability()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorCNT_getMaxPixelStability_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::setMaxPixelStability(int value)
        //

        /**
         @brief Sets the maximum allowed credit for a pixel in history.
         */
        public void setMaxPixelStability(int value)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorCNT_setMaxPixelStability_10(nativeObj, value);


        }


        //
        // C++:  bool cv::bgsegm::BackgroundSubtractorCNT::getUseHistory()
        //

        /**
         @brief Returns if we're giving a pixel credit for being stable for a long time.
         */
        public bool getUseHistory()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorCNT_getUseHistory_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::setUseHistory(bool value)
        //

        /**
         @brief Sets if we're giving a pixel credit for being stable for a long time.
         */
        public void setUseHistory(bool value)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorCNT_setUseHistory_10(nativeObj, value);


        }


        //
        // C++:  bool cv::bgsegm::BackgroundSubtractorCNT::getIsParallel()
        //

        /**
         @brief Returns if we're parallelizing the algorithm.
         */
        public bool getIsParallel()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorCNT_getIsParallel_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::setIsParallel(bool value)
        //

        /**
         @brief Sets if we're parallelizing the algorithm.
         */
        public void setIsParallel(bool value)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorCNT_setIsParallel_10(nativeObj, value);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::apply(Mat image, Mat& fgmask, double learningRate = -1)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_apply_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj, double learningRate);
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_apply_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::getBackgroundImage(Mat& backgroundImage)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_getBackgroundImage_10(IntPtr nativeObj, IntPtr backgroundImage_nativeObj);

        // C++:  int cv::bgsegm::BackgroundSubtractorCNT::getMinPixelStability()
        [DllImport(LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorCNT_getMinPixelStability_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::setMinPixelStability(int value)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_setMinPixelStability_10(IntPtr nativeObj, int value);

        // C++:  int cv::bgsegm::BackgroundSubtractorCNT::getMaxPixelStability()
        [DllImport(LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorCNT_getMaxPixelStability_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::setMaxPixelStability(int value)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_setMaxPixelStability_10(IntPtr nativeObj, int value);

        // C++:  bool cv::bgsegm::BackgroundSubtractorCNT::getUseHistory()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool bgsegm_BackgroundSubtractorCNT_getUseHistory_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::setUseHistory(bool value)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_setUseHistory_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool value);

        // C++:  bool cv::bgsegm::BackgroundSubtractorCNT::getIsParallel()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool bgsegm_BackgroundSubtractorCNT_getIsParallel_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorCNT::setIsParallel(bool value)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_setIsParallel_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool value);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_delete(IntPtr nativeObj);

    }
}
