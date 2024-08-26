
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class RICInterpolator
    /**
     @brief Sparse match interpolation algorithm based on modified piecewise locally-weighted affine
      * estimator called Robust Interpolation method of Correspondences or RIC from @cite Hu2017 and Variational
      * and Fast Global Smoother as post-processing filter. The RICInterpolator is a extension of the EdgeAwareInterpolator.
      * Main concept of this extension is an piece-wise affine model based on over-segmentation via SLIC superpixel estimation.
      * The method contains an efficient propagation mechanism to estimate among the pieces-wise models.
     */

    public class RICInterpolator : SparseMatchInterpolator
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
                        ximgproc_RICInterpolator_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal RICInterpolator(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new RICInterpolator __fromPtr__(IntPtr addr) { return new RICInterpolator(addr); }

        //
        // C++:  void cv::ximgproc::RICInterpolator::setK(int k = 32)
        //

        /**
         @brief K is a number of nearest-neighbor matches considered, when fitting a locally affine
              *model for a superpixel segment. However, lower values would make the interpolation
              *noticeably faster. The original implementation of @cite Hu2017 uses 32.
         */
        public void setK(int k)
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setK_10(nativeObj, k);


        }

        /**
         @brief K is a number of nearest-neighbor matches considered, when fitting a locally affine
              *model for a superpixel segment. However, lower values would make the interpolation
              *noticeably faster. The original implementation of @cite Hu2017 uses 32.
         */
        public void setK()
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setK_11(nativeObj);


        }


        //
        // C++:  int cv::ximgproc::RICInterpolator::getK()
        //

        /**
         @copybrief setK
              *  @see setK
         */
        public int getK()
        {
            ThrowIfDisposed();

            return ximgproc_RICInterpolator_getK_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::RICInterpolator::setCostMap(Mat costMap)
        //

        /**
         @brief Interface to provide a more elaborated cost map, i.e. edge map, for the edge-aware term.
              *  This implementation is based on a rather simple gradient-based edge map estimation.
              *  To used more complex edge map estimator (e.g. StructuredEdgeDetection that has been
              *  used in the original publication) that may lead to improved accuracies, the internal
              *  edge map estimation can be bypassed here.
              *  @param costMap a type CV_32FC1 Mat is required.
              *  @see cv::ximgproc::createSuperpixelSLIC
         */
        public void setCostMap(Mat costMap)
        {
            ThrowIfDisposed();
            if (costMap != null) costMap.ThrowIfDisposed();

            ximgproc_RICInterpolator_setCostMap_10(nativeObj, costMap.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::RICInterpolator::setSuperpixelSize(int spSize = 15)
        //

        /**
         @brief Get the internal cost, i.e. edge map, used for estimating the edge-aware term.
              *  @see setCostMap
         */
        public void setSuperpixelSize(int spSize)
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setSuperpixelSize_10(nativeObj, spSize);


        }

        /**
         @brief Get the internal cost, i.e. edge map, used for estimating the edge-aware term.
              *  @see setCostMap
         */
        public void setSuperpixelSize()
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setSuperpixelSize_11(nativeObj);


        }


        //
        // C++:  int cv::ximgproc::RICInterpolator::getSuperpixelSize()
        //

        /**
         @copybrief setSuperpixelSize
              *  @see setSuperpixelSize
         */
        public int getSuperpixelSize()
        {
            ThrowIfDisposed();

            return ximgproc_RICInterpolator_getSuperpixelSize_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::RICInterpolator::setSuperpixelNNCnt(int spNN = 150)
        //

        /**
         @brief Parameter defines the number of nearest-neighbor matches for each superpixel considered, when fitting a locally affine
              *model.
         */
        public void setSuperpixelNNCnt(int spNN)
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setSuperpixelNNCnt_10(nativeObj, spNN);


        }

        /**
         @brief Parameter defines the number of nearest-neighbor matches for each superpixel considered, when fitting a locally affine
              *model.
         */
        public void setSuperpixelNNCnt()
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setSuperpixelNNCnt_11(nativeObj);


        }


        //
        // C++:  int cv::ximgproc::RICInterpolator::getSuperpixelNNCnt()
        //

        /**
         @copybrief setSuperpixelNNCnt
              *  @see setSuperpixelNNCnt
         */
        public int getSuperpixelNNCnt()
        {
            ThrowIfDisposed();

            return ximgproc_RICInterpolator_getSuperpixelNNCnt_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::RICInterpolator::setSuperpixelRuler(float ruler = 15.f)
        //

        /**
         @brief Parameter to tune enforcement of superpixel smoothness factor used for oversegmentation.
              *  @see cv::ximgproc::createSuperpixelSLIC
         */
        public void setSuperpixelRuler(float ruler)
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setSuperpixelRuler_10(nativeObj, ruler);


        }

        /**
         @brief Parameter to tune enforcement of superpixel smoothness factor used for oversegmentation.
              *  @see cv::ximgproc::createSuperpixelSLIC
         */
        public void setSuperpixelRuler()
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setSuperpixelRuler_11(nativeObj);


        }


        //
        // C++:  float cv::ximgproc::RICInterpolator::getSuperpixelRuler()
        //

        /**
         @copybrief setSuperpixelRuler
              *  @see setSuperpixelRuler
         */
        public float getSuperpixelRuler()
        {
            ThrowIfDisposed();

            return ximgproc_RICInterpolator_getSuperpixelRuler_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::RICInterpolator::setSuperpixelMode(int mode = 100)
        //

        /**
         @brief Parameter to choose superpixel algorithm variant to use:
              * - cv::ximgproc::SLICType SLIC segments image using a desired region_size (value: 100)
              * - cv::ximgproc::SLICType SLICO will optimize using adaptive compactness factor (value: 101)
              * - cv::ximgproc::SLICType MSLIC will optimize using manifold methods resulting in more content-sensitive superpixels (value: 102).
              *  @see cv::ximgproc::createSuperpixelSLIC
         */
        public void setSuperpixelMode(int mode)
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setSuperpixelMode_10(nativeObj, mode);


        }

        /**
         @brief Parameter to choose superpixel algorithm variant to use:
              * - cv::ximgproc::SLICType SLIC segments image using a desired region_size (value: 100)
              * - cv::ximgproc::SLICType SLICO will optimize using adaptive compactness factor (value: 101)
              * - cv::ximgproc::SLICType MSLIC will optimize using manifold methods resulting in more content-sensitive superpixels (value: 102).
              *  @see cv::ximgproc::createSuperpixelSLIC
         */
        public void setSuperpixelMode()
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setSuperpixelMode_11(nativeObj);


        }


        //
        // C++:  int cv::ximgproc::RICInterpolator::getSuperpixelMode()
        //

        /**
         @copybrief setSuperpixelMode
              *  @see setSuperpixelMode
         */
        public int getSuperpixelMode()
        {
            ThrowIfDisposed();

            return ximgproc_RICInterpolator_getSuperpixelMode_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::RICInterpolator::setAlpha(float alpha = 0.7f)
        //

        /**
         @brief Alpha is a parameter defining a global weight for transforming geodesic distance into weight.
         */
        public void setAlpha(float alpha)
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setAlpha_10(nativeObj, alpha);


        }

        /**
         @brief Alpha is a parameter defining a global weight for transforming geodesic distance into weight.
         */
        public void setAlpha()
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setAlpha_11(nativeObj);


        }


        //
        // C++:  float cv::ximgproc::RICInterpolator::getAlpha()
        //

        /**
         @copybrief setAlpha
              *  @see setAlpha
         */
        public float getAlpha()
        {
            ThrowIfDisposed();

            return ximgproc_RICInterpolator_getAlpha_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::RICInterpolator::setModelIter(int modelIter = 4)
        //

        /**
         @brief Parameter defining the number of iterations for piece-wise affine model estimation.
         */
        public void setModelIter(int modelIter)
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setModelIter_10(nativeObj, modelIter);


        }

        /**
         @brief Parameter defining the number of iterations for piece-wise affine model estimation.
         */
        public void setModelIter()
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setModelIter_11(nativeObj);


        }


        //
        // C++:  int cv::ximgproc::RICInterpolator::getModelIter()
        //

        /**
         @copybrief setModelIter
              *  @see setModelIter
         */
        public int getModelIter()
        {
            ThrowIfDisposed();

            return ximgproc_RICInterpolator_getModelIter_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::RICInterpolator::setRefineModels(bool refineModles = true)
        //

        /**
         @brief Parameter to choose wether additional refinement of the piece-wise affine models is employed.
         */
        public void setRefineModels(bool refineModles)
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setRefineModels_10(nativeObj, refineModles);


        }

        /**
         @brief Parameter to choose wether additional refinement of the piece-wise affine models is employed.
         */
        public void setRefineModels()
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setRefineModels_11(nativeObj);


        }


        //
        // C++:  bool cv::ximgproc::RICInterpolator::getRefineModels()
        //

        /**
         @copybrief setRefineModels
              *  @see setRefineModels
         */
        public bool getRefineModels()
        {
            ThrowIfDisposed();

            return ximgproc_RICInterpolator_getRefineModels_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::RICInterpolator::setMaxFlow(float maxFlow = 250.f)
        //

        /**
         @brief MaxFlow is a threshold to validate the predictions using a certain piece-wise affine model.
              * If the prediction exceeds the treshold the translational model will be applied instead.
         */
        public void setMaxFlow(float maxFlow)
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setMaxFlow_10(nativeObj, maxFlow);


        }

        /**
         @brief MaxFlow is a threshold to validate the predictions using a certain piece-wise affine model.
              * If the prediction exceeds the treshold the translational model will be applied instead.
         */
        public void setMaxFlow()
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setMaxFlow_11(nativeObj);


        }


        //
        // C++:  float cv::ximgproc::RICInterpolator::getMaxFlow()
        //

        /**
         @copybrief setMaxFlow
              *  @see setMaxFlow
         */
        public float getMaxFlow()
        {
            ThrowIfDisposed();

            return ximgproc_RICInterpolator_getMaxFlow_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::RICInterpolator::setUseVariationalRefinement(bool use_variational_refinement = false)
        //

        /**
         @brief Parameter to choose wether the VariationalRefinement post-processing  is employed.
         */
        public void setUseVariationalRefinement(bool use_variational_refinement)
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setUseVariationalRefinement_10(nativeObj, use_variational_refinement);


        }

        /**
         @brief Parameter to choose wether the VariationalRefinement post-processing  is employed.
         */
        public void setUseVariationalRefinement()
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setUseVariationalRefinement_11(nativeObj);


        }


        //
        // C++:  bool cv::ximgproc::RICInterpolator::getUseVariationalRefinement()
        //

        /**
         @copybrief setUseVariationalRefinement
              *  @see setUseVariationalRefinement
         */
        public bool getUseVariationalRefinement()
        {
            ThrowIfDisposed();

            return ximgproc_RICInterpolator_getUseVariationalRefinement_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::RICInterpolator::setUseGlobalSmootherFilter(bool use_FGS = true)
        //

        /**
         @brief Sets whether the fastGlobalSmootherFilter() post-processing is employed.
         */
        public void setUseGlobalSmootherFilter(bool use_FGS)
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setUseGlobalSmootherFilter_10(nativeObj, use_FGS);


        }

        /**
         @brief Sets whether the fastGlobalSmootherFilter() post-processing is employed.
         */
        public void setUseGlobalSmootherFilter()
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setUseGlobalSmootherFilter_11(nativeObj);


        }


        //
        // C++:  bool cv::ximgproc::RICInterpolator::getUseGlobalSmootherFilter()
        //

        /**
         @copybrief setUseGlobalSmootherFilter
              *  @see setUseGlobalSmootherFilter
         */
        public bool getUseGlobalSmootherFilter()
        {
            ThrowIfDisposed();

            return ximgproc_RICInterpolator_getUseGlobalSmootherFilter_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::RICInterpolator::setFGSLambda(float lambda = 500.f)
        //

        /**
         @brief Sets the respective fastGlobalSmootherFilter() parameter.
         */
        public void setFGSLambda(float lambda)
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setFGSLambda_10(nativeObj, lambda);


        }

        /**
         @brief Sets the respective fastGlobalSmootherFilter() parameter.
         */
        public void setFGSLambda()
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setFGSLambda_11(nativeObj);


        }


        //
        // C++:  float cv::ximgproc::RICInterpolator::getFGSLambda()
        //

        /**
         @copybrief setFGSLambda
              *  @see setFGSLambda
         */
        public float getFGSLambda()
        {
            ThrowIfDisposed();

            return ximgproc_RICInterpolator_getFGSLambda_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::RICInterpolator::setFGSSigma(float sigma = 1.5f)
        //

        /**
         @brief Sets the respective fastGlobalSmootherFilter() parameter.
         */
        public void setFGSSigma(float sigma)
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setFGSSigma_10(nativeObj, sigma);


        }

        /**
         @brief Sets the respective fastGlobalSmootherFilter() parameter.
         */
        public void setFGSSigma()
        {
            ThrowIfDisposed();

            ximgproc_RICInterpolator_setFGSSigma_11(nativeObj);


        }


        //
        // C++:  float cv::ximgproc::RICInterpolator::getFGSSigma()
        //

        /**
         @copybrief setFGSSigma
              *  @see setFGSSigma
         */
        public float getFGSSigma()
        {
            ThrowIfDisposed();

            return ximgproc_RICInterpolator_getFGSSigma_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::ximgproc::RICInterpolator::setK(int k = 32)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setK_10(IntPtr nativeObj, int k);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setK_11(IntPtr nativeObj);

        // C++:  int cv::ximgproc::RICInterpolator::getK()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_RICInterpolator_getK_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::RICInterpolator::setCostMap(Mat costMap)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setCostMap_10(IntPtr nativeObj, IntPtr costMap_nativeObj);

        // C++:  void cv::ximgproc::RICInterpolator::setSuperpixelSize(int spSize = 15)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setSuperpixelSize_10(IntPtr nativeObj, int spSize);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setSuperpixelSize_11(IntPtr nativeObj);

        // C++:  int cv::ximgproc::RICInterpolator::getSuperpixelSize()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_RICInterpolator_getSuperpixelSize_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::RICInterpolator::setSuperpixelNNCnt(int spNN = 150)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setSuperpixelNNCnt_10(IntPtr nativeObj, int spNN);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setSuperpixelNNCnt_11(IntPtr nativeObj);

        // C++:  int cv::ximgproc::RICInterpolator::getSuperpixelNNCnt()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_RICInterpolator_getSuperpixelNNCnt_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::RICInterpolator::setSuperpixelRuler(float ruler = 15.f)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setSuperpixelRuler_10(IntPtr nativeObj, float ruler);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setSuperpixelRuler_11(IntPtr nativeObj);

        // C++:  float cv::ximgproc::RICInterpolator::getSuperpixelRuler()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_RICInterpolator_getSuperpixelRuler_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::RICInterpolator::setSuperpixelMode(int mode = 100)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setSuperpixelMode_10(IntPtr nativeObj, int mode);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setSuperpixelMode_11(IntPtr nativeObj);

        // C++:  int cv::ximgproc::RICInterpolator::getSuperpixelMode()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_RICInterpolator_getSuperpixelMode_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::RICInterpolator::setAlpha(float alpha = 0.7f)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setAlpha_10(IntPtr nativeObj, float alpha);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setAlpha_11(IntPtr nativeObj);

        // C++:  float cv::ximgproc::RICInterpolator::getAlpha()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_RICInterpolator_getAlpha_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::RICInterpolator::setModelIter(int modelIter = 4)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setModelIter_10(IntPtr nativeObj, int modelIter);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setModelIter_11(IntPtr nativeObj);

        // C++:  int cv::ximgproc::RICInterpolator::getModelIter()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_RICInterpolator_getModelIter_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::RICInterpolator::setRefineModels(bool refineModles = true)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setRefineModels_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool refineModles);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setRefineModels_11(IntPtr nativeObj);

        // C++:  bool cv::ximgproc::RICInterpolator::getRefineModels()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ximgproc_RICInterpolator_getRefineModels_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::RICInterpolator::setMaxFlow(float maxFlow = 250.f)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setMaxFlow_10(IntPtr nativeObj, float maxFlow);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setMaxFlow_11(IntPtr nativeObj);

        // C++:  float cv::ximgproc::RICInterpolator::getMaxFlow()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_RICInterpolator_getMaxFlow_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::RICInterpolator::setUseVariationalRefinement(bool use_variational_refinement = false)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setUseVariationalRefinement_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool use_variational_refinement);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setUseVariationalRefinement_11(IntPtr nativeObj);

        // C++:  bool cv::ximgproc::RICInterpolator::getUseVariationalRefinement()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ximgproc_RICInterpolator_getUseVariationalRefinement_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::RICInterpolator::setUseGlobalSmootherFilter(bool use_FGS = true)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setUseGlobalSmootherFilter_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool use_FGS);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setUseGlobalSmootherFilter_11(IntPtr nativeObj);

        // C++:  bool cv::ximgproc::RICInterpolator::getUseGlobalSmootherFilter()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ximgproc_RICInterpolator_getUseGlobalSmootherFilter_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::RICInterpolator::setFGSLambda(float lambda = 500.f)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setFGSLambda_10(IntPtr nativeObj, float lambda);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setFGSLambda_11(IntPtr nativeObj);

        // C++:  float cv::ximgproc::RICInterpolator::getFGSLambda()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_RICInterpolator_getFGSLambda_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::RICInterpolator::setFGSSigma(float sigma = 1.5f)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setFGSSigma_10(IntPtr nativeObj, float sigma);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_setFGSSigma_11(IntPtr nativeObj);

        // C++:  float cv::ximgproc::RICInterpolator::getFGSSigma()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_RICInterpolator_getFGSSigma_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RICInterpolator_delete(IntPtr nativeObj);

    }
}
