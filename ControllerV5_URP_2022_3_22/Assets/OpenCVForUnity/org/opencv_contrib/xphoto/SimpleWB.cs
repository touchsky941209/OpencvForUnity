
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XphotoModule
{

    // C++: class SimpleWB
    /**
     @brief A simple white balance algorithm that works by independently stretching
         each of the input image channels to the specified range. For increased robustness
         it ignores the top and bottom \f$$p\%\f$$ of pixel values.
     */

    public class SimpleWB : WhiteBalancer
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
                        xphoto_SimpleWB_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SimpleWB(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SimpleWB __fromPtr__(IntPtr addr) { return new SimpleWB(addr); }

        //
        // C++:  float cv::xphoto::SimpleWB::getInputMin()
        //

        /**
         @brief Input image range minimum value
         @see setInputMin
         */
        public float getInputMin()
        {
            ThrowIfDisposed();

            return xphoto_SimpleWB_getInputMin_10(nativeObj);


        }


        //
        // C++:  void cv::xphoto::SimpleWB::setInputMin(float val)
        //

        /**
         @copybrief getInputMin @see getInputMin
         */
        public void setInputMin(float val)
        {
            ThrowIfDisposed();

            xphoto_SimpleWB_setInputMin_10(nativeObj, val);


        }


        //
        // C++:  float cv::xphoto::SimpleWB::getInputMax()
        //

        /**
         @brief Input image range maximum value
         @see setInputMax
         */
        public float getInputMax()
        {
            ThrowIfDisposed();

            return xphoto_SimpleWB_getInputMax_10(nativeObj);


        }


        //
        // C++:  void cv::xphoto::SimpleWB::setInputMax(float val)
        //

        /**
         @copybrief getInputMax @see getInputMax
         */
        public void setInputMax(float val)
        {
            ThrowIfDisposed();

            xphoto_SimpleWB_setInputMax_10(nativeObj, val);


        }


        //
        // C++:  float cv::xphoto::SimpleWB::getOutputMin()
        //

        /**
         @brief Output image range minimum value
         @see setOutputMin
         */
        public float getOutputMin()
        {
            ThrowIfDisposed();

            return xphoto_SimpleWB_getOutputMin_10(nativeObj);


        }


        //
        // C++:  void cv::xphoto::SimpleWB::setOutputMin(float val)
        //

        /**
         @copybrief getOutputMin @see getOutputMin
         */
        public void setOutputMin(float val)
        {
            ThrowIfDisposed();

            xphoto_SimpleWB_setOutputMin_10(nativeObj, val);


        }


        //
        // C++:  float cv::xphoto::SimpleWB::getOutputMax()
        //

        /**
         @brief Output image range maximum value
         @see setOutputMax
         */
        public float getOutputMax()
        {
            ThrowIfDisposed();

            return xphoto_SimpleWB_getOutputMax_10(nativeObj);


        }


        //
        // C++:  void cv::xphoto::SimpleWB::setOutputMax(float val)
        //

        /**
         @copybrief getOutputMax @see getOutputMax
         */
        public void setOutputMax(float val)
        {
            ThrowIfDisposed();

            xphoto_SimpleWB_setOutputMax_10(nativeObj, val);


        }


        //
        // C++:  float cv::xphoto::SimpleWB::getP()
        //

        /**
         @brief Percent of top/bottom values to ignore
         @see setP
         */
        public float getP()
        {
            ThrowIfDisposed();

            return xphoto_SimpleWB_getP_10(nativeObj);


        }


        //
        // C++:  void cv::xphoto::SimpleWB::setP(float val)
        //

        /**
         @copybrief getP @see getP
         */
        public void setP(float val)
        {
            ThrowIfDisposed();

            xphoto_SimpleWB_setP_10(nativeObj, val);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  float cv::xphoto::SimpleWB::getInputMin()
        [DllImport(LIBNAME)]
        private static extern float xphoto_SimpleWB_getInputMin_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::SimpleWB::setInputMin(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_setInputMin_10(IntPtr nativeObj, float val);

        // C++:  float cv::xphoto::SimpleWB::getInputMax()
        [DllImport(LIBNAME)]
        private static extern float xphoto_SimpleWB_getInputMax_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::SimpleWB::setInputMax(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_setInputMax_10(IntPtr nativeObj, float val);

        // C++:  float cv::xphoto::SimpleWB::getOutputMin()
        [DllImport(LIBNAME)]
        private static extern float xphoto_SimpleWB_getOutputMin_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::SimpleWB::setOutputMin(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_setOutputMin_10(IntPtr nativeObj, float val);

        // C++:  float cv::xphoto::SimpleWB::getOutputMax()
        [DllImport(LIBNAME)]
        private static extern float xphoto_SimpleWB_getOutputMax_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::SimpleWB::setOutputMax(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_setOutputMax_10(IntPtr nativeObj, float val);

        // C++:  float cv::xphoto::SimpleWB::getP()
        [DllImport(LIBNAME)]
        private static extern float xphoto_SimpleWB_getP_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::SimpleWB::setP(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_setP_10(IntPtr nativeObj, float val);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xphoto_SimpleWB_delete(IntPtr nativeObj);

    }
}
