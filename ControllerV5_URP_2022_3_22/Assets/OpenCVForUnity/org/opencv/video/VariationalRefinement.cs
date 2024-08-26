
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{

    // C++: class VariationalRefinement
    /**
     @brief Variational optical flow refinement
     
     This class implements variational refinement of the input flow field, i.e.
     it uses input flow to initialize the minimization of the following functional:
     \f$$E(U) = \int_{\Omega} \delta \Psi(E_I) + \gamma \Psi(E_G) + \alpha \Psi(E_S) \f$$,
     where \f$$E_I,E_G,E_S\f$$ are color constancy, gradient constancy and smoothness terms
     respectively. \f$$\Psi(s^2)=\sqrt{s^2+\epsilon^2}\f$$ is a robust penalizer to limit the
     influence of outliers. A complete formulation and a description of the minimization
     procedure can be found in @cite Brox2004
     */

    public class VariationalRefinement : DenseOpticalFlow
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
                        video_VariationalRefinement_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal VariationalRefinement(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new VariationalRefinement __fromPtr__(IntPtr addr) { return new VariationalRefinement(addr); }

        //
        // C++:  void cv::VariationalRefinement::calcUV(Mat I0, Mat I1, Mat& flow_u, Mat& flow_v)
        //

        /**
         @brief @ref calc function overload to handle separate horizontal (u) and vertical (v) flow components
         (to avoid extra splits/merges)
         */
        public void calcUV(Mat I0, Mat I1, Mat flow_u, Mat flow_v)
        {
            ThrowIfDisposed();
            if (I0 != null) I0.ThrowIfDisposed();
            if (I1 != null) I1.ThrowIfDisposed();
            if (flow_u != null) flow_u.ThrowIfDisposed();
            if (flow_v != null) flow_v.ThrowIfDisposed();

            video_VariationalRefinement_calcUV_10(nativeObj, I0.nativeObj, I1.nativeObj, flow_u.nativeObj, flow_v.nativeObj);


        }


        //
        // C++:  int cv::VariationalRefinement::getFixedPointIterations()
        //

        /**
         @brief Number of outer (fixed-point) iterations in the minimization procedure.
         @see setFixedPointIterations
         */
        public int getFixedPointIterations()
        {
            ThrowIfDisposed();

            return video_VariationalRefinement_getFixedPointIterations_10(nativeObj);


        }


        //
        // C++:  void cv::VariationalRefinement::setFixedPointIterations(int val)
        //

        /**
         @copybrief getFixedPointIterations @see getFixedPointIterations
         */
        public void setFixedPointIterations(int val)
        {
            ThrowIfDisposed();

            video_VariationalRefinement_setFixedPointIterations_10(nativeObj, val);


        }


        //
        // C++:  int cv::VariationalRefinement::getSorIterations()
        //

        /**
         @brief Number of inner successive over-relaxation (SOR) iterations
                 in the minimization procedure to solve the respective linear system.
         @see setSorIterations
         */
        public int getSorIterations()
        {
            ThrowIfDisposed();

            return video_VariationalRefinement_getSorIterations_10(nativeObj);


        }


        //
        // C++:  void cv::VariationalRefinement::setSorIterations(int val)
        //

        /**
         @copybrief getSorIterations @see getSorIterations
         */
        public void setSorIterations(int val)
        {
            ThrowIfDisposed();

            video_VariationalRefinement_setSorIterations_10(nativeObj, val);


        }


        //
        // C++:  float cv::VariationalRefinement::getOmega()
        //

        /**
         @brief Relaxation factor in SOR
         @see setOmega
         */
        public float getOmega()
        {
            ThrowIfDisposed();

            return video_VariationalRefinement_getOmega_10(nativeObj);


        }


        //
        // C++:  void cv::VariationalRefinement::setOmega(float val)
        //

        /**
         @copybrief getOmega @see getOmega
         */
        public void setOmega(float val)
        {
            ThrowIfDisposed();

            video_VariationalRefinement_setOmega_10(nativeObj, val);


        }


        //
        // C++:  float cv::VariationalRefinement::getAlpha()
        //

        /**
         @brief Weight of the smoothness term
         @see setAlpha
         */
        public float getAlpha()
        {
            ThrowIfDisposed();

            return video_VariationalRefinement_getAlpha_10(nativeObj);


        }


        //
        // C++:  void cv::VariationalRefinement::setAlpha(float val)
        //

        /**
         @copybrief getAlpha @see getAlpha
         */
        public void setAlpha(float val)
        {
            ThrowIfDisposed();

            video_VariationalRefinement_setAlpha_10(nativeObj, val);


        }


        //
        // C++:  float cv::VariationalRefinement::getDelta()
        //

        /**
         @brief Weight of the color constancy term
         @see setDelta
         */
        public float getDelta()
        {
            ThrowIfDisposed();

            return video_VariationalRefinement_getDelta_10(nativeObj);


        }


        //
        // C++:  void cv::VariationalRefinement::setDelta(float val)
        //

        /**
         @copybrief getDelta @see getDelta
         */
        public void setDelta(float val)
        {
            ThrowIfDisposed();

            video_VariationalRefinement_setDelta_10(nativeObj, val);


        }


        //
        // C++:  float cv::VariationalRefinement::getGamma()
        //

        /**
         @brief Weight of the gradient constancy term
         @see setGamma
         */
        public float getGamma()
        {
            ThrowIfDisposed();

            return video_VariationalRefinement_getGamma_10(nativeObj);


        }


        //
        // C++:  void cv::VariationalRefinement::setGamma(float val)
        //

        /**
         @copybrief getGamma @see getGamma
         */
        public void setGamma(float val)
        {
            ThrowIfDisposed();

            video_VariationalRefinement_setGamma_10(nativeObj, val);


        }


        //
        // C++: static Ptr_VariationalRefinement cv::VariationalRefinement::create()
        //

        /**
         @brief Creates an instance of VariationalRefinement
         */
        public static VariationalRefinement create()
        {


            return VariationalRefinement.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_VariationalRefinement_create_10()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::VariationalRefinement::calcUV(Mat I0, Mat I1, Mat& flow_u, Mat& flow_v)
        [DllImport(LIBNAME)]
        private static extern void video_VariationalRefinement_calcUV_10(IntPtr nativeObj, IntPtr I0_nativeObj, IntPtr I1_nativeObj, IntPtr flow_u_nativeObj, IntPtr flow_v_nativeObj);

        // C++:  int cv::VariationalRefinement::getFixedPointIterations()
        [DllImport(LIBNAME)]
        private static extern int video_VariationalRefinement_getFixedPointIterations_10(IntPtr nativeObj);

        // C++:  void cv::VariationalRefinement::setFixedPointIterations(int val)
        [DllImport(LIBNAME)]
        private static extern void video_VariationalRefinement_setFixedPointIterations_10(IntPtr nativeObj, int val);

        // C++:  int cv::VariationalRefinement::getSorIterations()
        [DllImport(LIBNAME)]
        private static extern int video_VariationalRefinement_getSorIterations_10(IntPtr nativeObj);

        // C++:  void cv::VariationalRefinement::setSorIterations(int val)
        [DllImport(LIBNAME)]
        private static extern void video_VariationalRefinement_setSorIterations_10(IntPtr nativeObj, int val);

        // C++:  float cv::VariationalRefinement::getOmega()
        [DllImport(LIBNAME)]
        private static extern float video_VariationalRefinement_getOmega_10(IntPtr nativeObj);

        // C++:  void cv::VariationalRefinement::setOmega(float val)
        [DllImport(LIBNAME)]
        private static extern void video_VariationalRefinement_setOmega_10(IntPtr nativeObj, float val);

        // C++:  float cv::VariationalRefinement::getAlpha()
        [DllImport(LIBNAME)]
        private static extern float video_VariationalRefinement_getAlpha_10(IntPtr nativeObj);

        // C++:  void cv::VariationalRefinement::setAlpha(float val)
        [DllImport(LIBNAME)]
        private static extern void video_VariationalRefinement_setAlpha_10(IntPtr nativeObj, float val);

        // C++:  float cv::VariationalRefinement::getDelta()
        [DllImport(LIBNAME)]
        private static extern float video_VariationalRefinement_getDelta_10(IntPtr nativeObj);

        // C++:  void cv::VariationalRefinement::setDelta(float val)
        [DllImport(LIBNAME)]
        private static extern void video_VariationalRefinement_setDelta_10(IntPtr nativeObj, float val);

        // C++:  float cv::VariationalRefinement::getGamma()
        [DllImport(LIBNAME)]
        private static extern float video_VariationalRefinement_getGamma_10(IntPtr nativeObj);

        // C++:  void cv::VariationalRefinement::setGamma(float val)
        [DllImport(LIBNAME)]
        private static extern void video_VariationalRefinement_setGamma_10(IntPtr nativeObj, float val);

        // C++: static Ptr_VariationalRefinement cv::VariationalRefinement::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr video_VariationalRefinement_create_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_VariationalRefinement_delete(IntPtr nativeObj);

    }
}
