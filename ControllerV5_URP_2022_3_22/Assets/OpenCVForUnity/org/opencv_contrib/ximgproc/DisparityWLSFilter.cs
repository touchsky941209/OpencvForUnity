
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class DisparityWLSFilter
    /**
     @brief Disparity map filter based on Weighted Least Squares filter (in form of Fast Global Smoother that
     is a lot faster than traditional Weighted Least Squares filter implementations) and optional use of
     left-right-consistency-based confidence to refine the results in half-occlusions and uniform areas.
     */

    public class DisparityWLSFilter : DisparityFilter
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
                        ximgproc_DisparityWLSFilter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DisparityWLSFilter(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new DisparityWLSFilter __fromPtr__(IntPtr addr) { return new DisparityWLSFilter(addr); }

        //
        // C++:  double cv::ximgproc::DisparityWLSFilter::getLambda()
        //

        /**
         @brief Lambda is a parameter defining the amount of regularization during filtering. Larger values force
             filtered disparity map edges to adhere more to source image edges. Typical value is 8000.
         */
        public double getLambda()
        {
            ThrowIfDisposed();

            return ximgproc_DisparityWLSFilter_getLambda_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::DisparityWLSFilter::setLambda(double _lambda)
        //

        /**
         @see getLambda
         */
        public void setLambda(double _lambda)
        {
            ThrowIfDisposed();

            ximgproc_DisparityWLSFilter_setLambda_10(nativeObj, _lambda);


        }


        //
        // C++:  double cv::ximgproc::DisparityWLSFilter::getSigmaColor()
        //

        /**
         @brief SigmaColor is a parameter defining how sensitive the filtering process is to source image edges.
             Large values can lead to disparity leakage through low-contrast edges. Small values can make the filter too
             sensitive to noise and textures in the source image. Typical values range from 0.8 to 2.0.
         */
        public double getSigmaColor()
        {
            ThrowIfDisposed();

            return ximgproc_DisparityWLSFilter_getSigmaColor_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::DisparityWLSFilter::setSigmaColor(double _sigma_color)
        //

        /**
         @see getSigmaColor
         */
        public void setSigmaColor(double _sigma_color)
        {
            ThrowIfDisposed();

            ximgproc_DisparityWLSFilter_setSigmaColor_10(nativeObj, _sigma_color);


        }


        //
        // C++:  int cv::ximgproc::DisparityWLSFilter::getLRCthresh()
        //

        /**
         @brief LRCthresh is a threshold of disparity difference used in left-right-consistency check during
             confidence map computation. The default value of 24 (1.5 pixels) is virtually always good enough.
         */
        public int getLRCthresh()
        {
            ThrowIfDisposed();

            return ximgproc_DisparityWLSFilter_getLRCthresh_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::DisparityWLSFilter::setLRCthresh(int _LRC_thresh)
        //

        /**
         @see getLRCthresh
         */
        public void setLRCthresh(int _LRC_thresh)
        {
            ThrowIfDisposed();

            ximgproc_DisparityWLSFilter_setLRCthresh_10(nativeObj, _LRC_thresh);


        }


        //
        // C++:  int cv::ximgproc::DisparityWLSFilter::getDepthDiscontinuityRadius()
        //

        /**
         @brief DepthDiscontinuityRadius is a parameter used in confidence computation. It defines the size of
             low-confidence regions around depth discontinuities.
         */
        public int getDepthDiscontinuityRadius()
        {
            ThrowIfDisposed();

            return ximgproc_DisparityWLSFilter_getDepthDiscontinuityRadius_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::DisparityWLSFilter::setDepthDiscontinuityRadius(int _disc_radius)
        //

        /**
         @see getDepthDiscontinuityRadius
         */
        public void setDepthDiscontinuityRadius(int _disc_radius)
        {
            ThrowIfDisposed();

            ximgproc_DisparityWLSFilter_setDepthDiscontinuityRadius_10(nativeObj, _disc_radius);


        }


        //
        // C++:  Mat cv::ximgproc::DisparityWLSFilter::getConfidenceMap()
        //

        /**
         @brief Get the confidence map that was used in the last filter call. It is a CV_32F one-channel image
             with values ranging from 0.0 (totally untrusted regions of the raw disparity map) to 255.0 (regions containing
             correct disparity values with a high degree of confidence).
         */
        public Mat getConfidenceMap()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(ximgproc_DisparityWLSFilter_getConfidenceMap_10(nativeObj)));


        }


        //
        // C++:  Rect cv::ximgproc::DisparityWLSFilter::getROI()
        //

        /**
         @brief Get the ROI used in the last filter call
         */
        public Rect getROI()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[4];
            ximgproc_DisparityWLSFilter_getROI_10(nativeObj, tmpArray);
            Rect retVal = new Rect(tmpArray);

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  double cv::ximgproc::DisparityWLSFilter::getLambda()
        [DllImport(LIBNAME)]
        private static extern double ximgproc_DisparityWLSFilter_getLambda_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::DisparityWLSFilter::setLambda(double _lambda)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_setLambda_10(IntPtr nativeObj, double _lambda);

        // C++:  double cv::ximgproc::DisparityWLSFilter::getSigmaColor()
        [DllImport(LIBNAME)]
        private static extern double ximgproc_DisparityWLSFilter_getSigmaColor_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::DisparityWLSFilter::setSigmaColor(double _sigma_color)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_setSigmaColor_10(IntPtr nativeObj, double _sigma_color);

        // C++:  int cv::ximgproc::DisparityWLSFilter::getLRCthresh()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_DisparityWLSFilter_getLRCthresh_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::DisparityWLSFilter::setLRCthresh(int _LRC_thresh)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_setLRCthresh_10(IntPtr nativeObj, int _LRC_thresh);

        // C++:  int cv::ximgproc::DisparityWLSFilter::getDepthDiscontinuityRadius()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_DisparityWLSFilter_getDepthDiscontinuityRadius_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::DisparityWLSFilter::setDepthDiscontinuityRadius(int _disc_radius)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_setDepthDiscontinuityRadius_10(IntPtr nativeObj, int _disc_radius);

        // C++:  Mat cv::ximgproc::DisparityWLSFilter::getConfidenceMap()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_DisparityWLSFilter_getConfidenceMap_10(IntPtr nativeObj);

        // C++:  Rect cv::ximgproc::DisparityWLSFilter::getROI()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_getROI_10(IntPtr nativeObj, double[] retVal);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_delete(IntPtr nativeObj);

    }
}
