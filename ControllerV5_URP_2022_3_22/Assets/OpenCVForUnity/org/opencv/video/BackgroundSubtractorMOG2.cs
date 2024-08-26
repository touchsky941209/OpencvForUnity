
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{

    // C++: class BackgroundSubtractorMOG2
    /**
     @brief Gaussian Mixture-based Background/Foreground Segmentation Algorithm.
     
     The class implements the Gaussian mixture model background subtraction described in @cite Zivkovic2004
     and @cite Zivkovic2006 .
     */

    public class BackgroundSubtractorMOG2 : BackgroundSubtractor
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
                        video_BackgroundSubtractorMOG2_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BackgroundSubtractorMOG2(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BackgroundSubtractorMOG2 __fromPtr__(IntPtr addr) { return new BackgroundSubtractorMOG2(addr); }

        //
        // C++:  int cv::BackgroundSubtractorMOG2::getHistory()
        //

        /**
         @brief Returns the number of last frames that affect the background model
         */
        public int getHistory()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorMOG2_getHistory_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setHistory(int history)
        //

        /**
         @brief Sets the number of last frames that affect the background model
         */
        public void setHistory(int history)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorMOG2_setHistory_10(nativeObj, history);


        }


        //
        // C++:  int cv::BackgroundSubtractorMOG2::getNMixtures()
        //

        /**
         @brief Returns the number of gaussian components in the background model
         */
        public int getNMixtures()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorMOG2_getNMixtures_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setNMixtures(int nmixtures)
        //

        /**
         @brief Sets the number of gaussian components in the background model.
         
             The model needs to be reinitalized to reserve memory.
         */
        public void setNMixtures(int nmixtures)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorMOG2_setNMixtures_10(nativeObj, nmixtures);


        }


        //
        // C++:  double cv::BackgroundSubtractorMOG2::getBackgroundRatio()
        //

        /**
         @brief Returns the "background ratio" parameter of the algorithm
         
             If a foreground pixel keeps semi-constant value for about backgroundRatio\*history frames, it's
             considered background and added to the model as a center of a new component. It corresponds to TB
             parameter in the paper.
         */
        public double getBackgroundRatio()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorMOG2_getBackgroundRatio_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setBackgroundRatio(double ratio)
        //

        /**
         @brief Sets the "background ratio" parameter of the algorithm
         */
        public void setBackgroundRatio(double ratio)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorMOG2_setBackgroundRatio_10(nativeObj, ratio);


        }


        //
        // C++:  double cv::BackgroundSubtractorMOG2::getVarThreshold()
        //

        /**
         @brief Returns the variance threshold for the pixel-model match
         
             The main threshold on the squared Mahalanobis distance to decide if the sample is well described by
             the background model or not. Related to Cthr from the paper.
         */
        public double getVarThreshold()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorMOG2_getVarThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setVarThreshold(double varThreshold)
        //

        /**
         @brief Sets the variance threshold for the pixel-model match
         */
        public void setVarThreshold(double varThreshold)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorMOG2_setVarThreshold_10(nativeObj, varThreshold);


        }


        //
        // C++:  double cv::BackgroundSubtractorMOG2::getVarThresholdGen()
        //

        /**
         @brief Returns the variance threshold for the pixel-model match used for new mixture component generation
         
             Threshold for the squared Mahalanobis distance that helps decide when a sample is close to the
             existing components (corresponds to Tg in the paper). If a pixel is not close to any component, it
             is considered foreground or added as a new component. 3 sigma =&gt; Tg=3\*3=9 is default. A smaller Tg
             value generates more components. A higher Tg value may result in a small number of components but
             they can grow too large.
         */
        public double getVarThresholdGen()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorMOG2_getVarThresholdGen_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setVarThresholdGen(double varThresholdGen)
        //

        /**
         @brief Sets the variance threshold for the pixel-model match used for new mixture component generation
         */
        public void setVarThresholdGen(double varThresholdGen)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorMOG2_setVarThresholdGen_10(nativeObj, varThresholdGen);


        }


        //
        // C++:  double cv::BackgroundSubtractorMOG2::getVarInit()
        //

        /**
         @brief Returns the initial variance of each gaussian component
         */
        public double getVarInit()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorMOG2_getVarInit_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setVarInit(double varInit)
        //

        /**
         @brief Sets the initial variance of each gaussian component
         */
        public void setVarInit(double varInit)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorMOG2_setVarInit_10(nativeObj, varInit);


        }


        //
        // C++:  double cv::BackgroundSubtractorMOG2::getVarMin()
        //

        public double getVarMin()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorMOG2_getVarMin_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setVarMin(double varMin)
        //

        public void setVarMin(double varMin)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorMOG2_setVarMin_10(nativeObj, varMin);


        }


        //
        // C++:  double cv::BackgroundSubtractorMOG2::getVarMax()
        //

        public double getVarMax()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorMOG2_getVarMax_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setVarMax(double varMax)
        //

        public void setVarMax(double varMax)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorMOG2_setVarMax_10(nativeObj, varMax);


        }


        //
        // C++:  double cv::BackgroundSubtractorMOG2::getComplexityReductionThreshold()
        //

        /**
         @brief Returns the complexity reduction threshold
         
             This parameter defines the number of samples needed to accept to prove the component exists. CT=0.05
             is a default value for all the samples. By setting CT=0 you get an algorithm very similar to the
             standard Stauffer&amp;Grimson algorithm.
         */
        public double getComplexityReductionThreshold()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorMOG2_getComplexityReductionThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setComplexityReductionThreshold(double ct)
        //

        /**
         @brief Sets the complexity reduction threshold
         */
        public void setComplexityReductionThreshold(double ct)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorMOG2_setComplexityReductionThreshold_10(nativeObj, ct);


        }


        //
        // C++:  bool cv::BackgroundSubtractorMOG2::getDetectShadows()
        //

        /**
         @brief Returns the shadow detection flag
         
             If true, the algorithm detects shadows and marks them. See createBackgroundSubtractorMOG2 for
             details.
         */
        public bool getDetectShadows()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorMOG2_getDetectShadows_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setDetectShadows(bool detectShadows)
        //

        /**
         @brief Enables or disables shadow detection
         */
        public void setDetectShadows(bool detectShadows)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorMOG2_setDetectShadows_10(nativeObj, detectShadows);


        }


        //
        // C++:  int cv::BackgroundSubtractorMOG2::getShadowValue()
        //

        /**
         @brief Returns the shadow value
         
             Shadow value is the value used to mark shadows in the foreground mask. Default value is 127. Value 0
             in the mask always means background, 255 means foreground.
         */
        public int getShadowValue()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorMOG2_getShadowValue_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setShadowValue(int value)
        //

        /**
         @brief Sets the shadow value
         */
        public void setShadowValue(int value)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorMOG2_setShadowValue_10(nativeObj, value);


        }


        //
        // C++:  double cv::BackgroundSubtractorMOG2::getShadowThreshold()
        //

        /**
         @brief Returns the shadow threshold
         
             A shadow is detected if pixel is a darker version of the background. The shadow threshold (Tau in
             the paper) is a threshold defining how much darker the shadow can be. Tau= 0.5 means that if a pixel
             is more than twice darker then it is not shadow. See Prati, Mikic, Trivedi and Cucchiara,
             *Detecting Moving Shadows...*, IEEE PAMI,2003.
         */
        public double getShadowThreshold()
        {
            ThrowIfDisposed();

            return video_BackgroundSubtractorMOG2_getShadowThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::setShadowThreshold(double threshold)
        //

        /**
         @brief Sets the shadow threshold
         */
        public void setShadowThreshold(double threshold)
        {
            ThrowIfDisposed();

            video_BackgroundSubtractorMOG2_setShadowThreshold_10(nativeObj, threshold);


        }


        //
        // C++:  void cv::BackgroundSubtractorMOG2::apply(Mat image, Mat& fgmask, double learningRate = -1)
        //

        /**
         @brief Computes a foreground mask.
         
             @param image Next video frame. Floating point frame will be used without scaling and should be in range \f$[0,255]\f$.
             @param fgmask The output foreground mask as an 8-bit binary image.
             @param learningRate The value between 0 and 1 that indicates how fast the background model is
             learnt. Negative parameter value makes the algorithm to use some automatically chosen learning
             rate. 0 means that the background model is not updated at all, 1 means that the background model
             is completely reinitialized from the last frame.
         */
        public override void apply(Mat image, Mat fgmask, double learningRate)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();

            video_BackgroundSubtractorMOG2_apply_10(nativeObj, image.nativeObj, fgmask.nativeObj, learningRate);


        }

        /**
         @brief Computes a foreground mask.
         
             @param image Next video frame. Floating point frame will be used without scaling and should be in range \f$[0,255]\f$.
             @param fgmask The output foreground mask as an 8-bit binary image.
             @param learningRate The value between 0 and 1 that indicates how fast the background model is
             learnt. Negative parameter value makes the algorithm to use some automatically chosen learning
             rate. 0 means that the background model is not updated at all, 1 means that the background model
             is completely reinitialized from the last frame.
         */
        public override void apply(Mat image, Mat fgmask)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();

            video_BackgroundSubtractorMOG2_apply_11(nativeObj, image.nativeObj, fgmask.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::BackgroundSubtractorMOG2::getHistory()
        [DllImport(LIBNAME)]
        private static extern int video_BackgroundSubtractorMOG2_getHistory_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorMOG2::setHistory(int history)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setHistory_10(IntPtr nativeObj, int history);

        // C++:  int cv::BackgroundSubtractorMOG2::getNMixtures()
        [DllImport(LIBNAME)]
        private static extern int video_BackgroundSubtractorMOG2_getNMixtures_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorMOG2::setNMixtures(int nmixtures)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setNMixtures_10(IntPtr nativeObj, int nmixtures);

        // C++:  double cv::BackgroundSubtractorMOG2::getBackgroundRatio()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getBackgroundRatio_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorMOG2::setBackgroundRatio(double ratio)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setBackgroundRatio_10(IntPtr nativeObj, double ratio);

        // C++:  double cv::BackgroundSubtractorMOG2::getVarThreshold()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getVarThreshold_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorMOG2::setVarThreshold(double varThreshold)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setVarThreshold_10(IntPtr nativeObj, double varThreshold);

        // C++:  double cv::BackgroundSubtractorMOG2::getVarThresholdGen()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getVarThresholdGen_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorMOG2::setVarThresholdGen(double varThresholdGen)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setVarThresholdGen_10(IntPtr nativeObj, double varThresholdGen);

        // C++:  double cv::BackgroundSubtractorMOG2::getVarInit()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getVarInit_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorMOG2::setVarInit(double varInit)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setVarInit_10(IntPtr nativeObj, double varInit);

        // C++:  double cv::BackgroundSubtractorMOG2::getVarMin()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getVarMin_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorMOG2::setVarMin(double varMin)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setVarMin_10(IntPtr nativeObj, double varMin);

        // C++:  double cv::BackgroundSubtractorMOG2::getVarMax()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getVarMax_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorMOG2::setVarMax(double varMax)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setVarMax_10(IntPtr nativeObj, double varMax);

        // C++:  double cv::BackgroundSubtractorMOG2::getComplexityReductionThreshold()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getComplexityReductionThreshold_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorMOG2::setComplexityReductionThreshold(double ct)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setComplexityReductionThreshold_10(IntPtr nativeObj, double ct);

        // C++:  bool cv::BackgroundSubtractorMOG2::getDetectShadows()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool video_BackgroundSubtractorMOG2_getDetectShadows_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorMOG2::setDetectShadows(bool detectShadows)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setDetectShadows_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool detectShadows);

        // C++:  int cv::BackgroundSubtractorMOG2::getShadowValue()
        [DllImport(LIBNAME)]
        private static extern int video_BackgroundSubtractorMOG2_getShadowValue_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorMOG2::setShadowValue(int value)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setShadowValue_10(IntPtr nativeObj, int value);

        // C++:  double cv::BackgroundSubtractorMOG2::getShadowThreshold()
        [DllImport(LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getShadowThreshold_10(IntPtr nativeObj);

        // C++:  void cv::BackgroundSubtractorMOG2::setShadowThreshold(double threshold)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setShadowThreshold_10(IntPtr nativeObj, double threshold);

        // C++:  void cv::BackgroundSubtractorMOG2::apply(Mat image, Mat& fgmask, double learningRate = -1)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_apply_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj, double learningRate);
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_apply_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_delete(IntPtr nativeObj);

    }
}
