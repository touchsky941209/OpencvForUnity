
using OpenCVForUnity.Calib3dModule;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{
    // C++: class Ximgproc


    public class Ximgproc
    {

        // C++: enum cv.ximgproc.AngleRangeOption
        public const int ARO_0_45 = 0;
        public const int ARO_45_90 = 1;
        public const int ARO_90_135 = 2;
        public const int ARO_315_0 = 3;
        public const int ARO_315_45 = 4;
        public const int ARO_45_135 = 5;
        public const int ARO_315_135 = 6;
        public const int ARO_CTR_HOR = 7;
        public const int ARO_CTR_VER = 8;
        // C++: enum cv.ximgproc.EdgeAwareFiltersList
        public const int DTF_NC = 0;
        public const int DTF_IC = 1;
        public const int DTF_RF = 2;
        public const int GUIDED_FILTER = 3;
        public const int AM_FILTER = 4;
        // C++: enum cv.ximgproc.HoughDeskewOption
        public const int HDO_RAW = 0;
        public const int HDO_DESKEW = 1;
        // C++: enum cv.ximgproc.HoughOp
        public const int FHT_MIN = 0;
        public const int FHT_MAX = 1;
        public const int FHT_ADD = 2;
        public const int FHT_AVE = 3;
        // C++: enum cv.ximgproc.LocalBinarizationMethods
        public const int BINARIZATION_NIBLACK = 0;
        public const int BINARIZATION_SAUVOLA = 1;
        public const int BINARIZATION_WOLF = 2;
        public const int BINARIZATION_NICK = 3;
        // C++: enum cv.ximgproc.SLICType
        public const int SLIC = 100;
        public const int SLICO = 101;
        public const int MSLIC = 102;
        // C++: enum cv.ximgproc.ThinningTypes
        public const int THINNING_ZHANGSUEN = 0;
        public const int THINNING_GUOHALL = 1;
        // C++: enum cv.ximgproc.WMFWeightType
        public const int WMF_EXP = 1;
        public const int WMF_IV1 = 1 << 1;
        public const int WMF_IV2 = 1 << 2;
        public const int WMF_COS = 1 << 3;
        public const int WMF_JAC = 1 << 4;
        public const int WMF_OFF = 1 << 5;
        //
        // C++:  void cv::ximgproc::niBlackThreshold(Mat _src, Mat& _dst, double maxValue, int type, int blockSize, double k, int binarizationMethod = BINARIZATION_NIBLACK, double r = 128)
        //

        /**
         @brief Performs thresholding on input images using Niblack's technique or some of the
         popular variations it inspired.
         
         The function transforms a grayscale image to a binary image according to the formulae:
         -   **THRESH_BINARY**
             \f[dst(x,y) =  \fork{\texttt{maxValue}}{if \(src(x,y) &gt; T(x,y)\)}{0}{otherwise}\f]
         -   **THRESH_BINARY_INV**
             \f[dst(x,y) =  \fork{0}{if \(src(x,y) &gt; T(x,y)\)}{\texttt{maxValue}}{otherwise}\f]
         where \f$T(x,y)\f$ is a threshold calculated individually for each pixel.
         
         The threshold value \f$T(x, y)\f$ is determined based on the binarization method chosen. For
         classic Niblack, it is the mean minus \f$ k \f$ times standard deviation of
         \f$\texttt{blockSize} \times\texttt{blockSize}\f$ neighborhood of \f$(x, y)\f$.
         
         The function can't process the image in-place.
         
         @param _src Source 8-bit single-channel image.
         @param _dst Destination image of the same size and the same type as src.
         @param maxValue Non-zero value assigned to the pixels for which the condition is satisfied,
         used with the THRESH_BINARY and THRESH_BINARY_INV thresholding types.
         @param type Thresholding type, see cv::ThresholdTypes.
         @param blockSize Size of a pixel neighborhood that is used to calculate a threshold value
         for the pixel: 3, 5, 7, and so on.
         @param k The user-adjustable parameter used by Niblack and inspired techniques. For Niblack, this is
         normally a value between 0 and 1 that is multiplied with the standard deviation and subtracted from
         the mean.
         @param binarizationMethod Binarization method to use. By default, Niblack's technique is used.
         Other techniques can be specified, see cv::ximgproc::LocalBinarizationMethods.
         @param r The user-adjustable parameter used by Sauvola's technique. This is the dynamic range
         of standard deviation.
         @sa  threshold, adaptiveThreshold
         */
        public static void niBlackThreshold(Mat _src, Mat _dst, double maxValue, int type, int blockSize, double k, int binarizationMethod, double r)
        {
            if (_src != null) _src.ThrowIfDisposed();
            if (_dst != null) _dst.ThrowIfDisposed();

            ximgproc_Ximgproc_niBlackThreshold_10(_src.nativeObj, _dst.nativeObj, maxValue, type, blockSize, k, binarizationMethod, r);


        }

        /**
         @brief Performs thresholding on input images using Niblack's technique or some of the
         popular variations it inspired.
         
         The function transforms a grayscale image to a binary image according to the formulae:
         -   **THRESH_BINARY**
             \f[dst(x,y) =  \fork{\texttt{maxValue}}{if \(src(x,y) &gt; T(x,y)\)}{0}{otherwise}\f]
         -   **THRESH_BINARY_INV**
             \f[dst(x,y) =  \fork{0}{if \(src(x,y) &gt; T(x,y)\)}{\texttt{maxValue}}{otherwise}\f]
         where \f$T(x,y)\f$ is a threshold calculated individually for each pixel.
         
         The threshold value \f$T(x, y)\f$ is determined based on the binarization method chosen. For
         classic Niblack, it is the mean minus \f$ k \f$ times standard deviation of
         \f$\texttt{blockSize} \times\texttt{blockSize}\f$ neighborhood of \f$(x, y)\f$.
         
         The function can't process the image in-place.
         
         @param _src Source 8-bit single-channel image.
         @param _dst Destination image of the same size and the same type as src.
         @param maxValue Non-zero value assigned to the pixels for which the condition is satisfied,
         used with the THRESH_BINARY and THRESH_BINARY_INV thresholding types.
         @param type Thresholding type, see cv::ThresholdTypes.
         @param blockSize Size of a pixel neighborhood that is used to calculate a threshold value
         for the pixel: 3, 5, 7, and so on.
         @param k The user-adjustable parameter used by Niblack and inspired techniques. For Niblack, this is
         normally a value between 0 and 1 that is multiplied with the standard deviation and subtracted from
         the mean.
         @param binarizationMethod Binarization method to use. By default, Niblack's technique is used.
         Other techniques can be specified, see cv::ximgproc::LocalBinarizationMethods.
         @param r The user-adjustable parameter used by Sauvola's technique. This is the dynamic range
         of standard deviation.
         @sa  threshold, adaptiveThreshold
         */
        public static void niBlackThreshold(Mat _src, Mat _dst, double maxValue, int type, int blockSize, double k, int binarizationMethod)
        {
            if (_src != null) _src.ThrowIfDisposed();
            if (_dst != null) _dst.ThrowIfDisposed();

            ximgproc_Ximgproc_niBlackThreshold_11(_src.nativeObj, _dst.nativeObj, maxValue, type, blockSize, k, binarizationMethod);


        }

        /**
         @brief Performs thresholding on input images using Niblack's technique or some of the
         popular variations it inspired.
         
         The function transforms a grayscale image to a binary image according to the formulae:
         -   **THRESH_BINARY**
             \f[dst(x,y) =  \fork{\texttt{maxValue}}{if \(src(x,y) &gt; T(x,y)\)}{0}{otherwise}\f]
         -   **THRESH_BINARY_INV**
             \f[dst(x,y) =  \fork{0}{if \(src(x,y) &gt; T(x,y)\)}{\texttt{maxValue}}{otherwise}\f]
         where \f$T(x,y)\f$ is a threshold calculated individually for each pixel.
         
         The threshold value \f$T(x, y)\f$ is determined based on the binarization method chosen. For
         classic Niblack, it is the mean minus \f$ k \f$ times standard deviation of
         \f$\texttt{blockSize} \times\texttt{blockSize}\f$ neighborhood of \f$(x, y)\f$.
         
         The function can't process the image in-place.
         
         @param _src Source 8-bit single-channel image.
         @param _dst Destination image of the same size and the same type as src.
         @param maxValue Non-zero value assigned to the pixels for which the condition is satisfied,
         used with the THRESH_BINARY and THRESH_BINARY_INV thresholding types.
         @param type Thresholding type, see cv::ThresholdTypes.
         @param blockSize Size of a pixel neighborhood that is used to calculate a threshold value
         for the pixel: 3, 5, 7, and so on.
         @param k The user-adjustable parameter used by Niblack and inspired techniques. For Niblack, this is
         normally a value between 0 and 1 that is multiplied with the standard deviation and subtracted from
         the mean.
         @param binarizationMethod Binarization method to use. By default, Niblack's technique is used.
         Other techniques can be specified, see cv::ximgproc::LocalBinarizationMethods.
         @param r The user-adjustable parameter used by Sauvola's technique. This is the dynamic range
         of standard deviation.
         @sa  threshold, adaptiveThreshold
         */
        public static void niBlackThreshold(Mat _src, Mat _dst, double maxValue, int type, int blockSize, double k)
        {
            if (_src != null) _src.ThrowIfDisposed();
            if (_dst != null) _dst.ThrowIfDisposed();

            ximgproc_Ximgproc_niBlackThreshold_12(_src.nativeObj, _dst.nativeObj, maxValue, type, blockSize, k);


        }


        //
        // C++:  void cv::ximgproc::thinning(Mat src, Mat& dst, int thinningType = THINNING_ZHANGSUEN)
        //

        /**
         @brief Applies a binary blob thinning operation, to achieve a skeletization of the input image.
         
         The function transforms a binary blob image into a skeletized form using the technique of Zhang-Suen.
         
         @param src Source 8-bit single-channel image, containing binary blobs, with blobs having 255 pixel values.
         @param dst Destination image of the same size and the same type as src. The function can work in-place.
         @param thinningType Value that defines which thinning algorithm should be used. See cv::ximgproc::ThinningTypes
         */
        public static void thinning(Mat src, Mat dst, int thinningType)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_thinning_10(src.nativeObj, dst.nativeObj, thinningType);


        }

        /**
         @brief Applies a binary blob thinning operation, to achieve a skeletization of the input image.
         
         The function transforms a binary blob image into a skeletized form using the technique of Zhang-Suen.
         
         @param src Source 8-bit single-channel image, containing binary blobs, with blobs having 255 pixel values.
         @param dst Destination image of the same size and the same type as src. The function can work in-place.
         @param thinningType Value that defines which thinning algorithm should be used. See cv::ximgproc::ThinningTypes
         */
        public static void thinning(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_thinning_11(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::anisotropicDiffusion(Mat src, Mat& dst, float alpha, float K, int niters)
        //

        /**
         @brief Performs anisotropic diffusion on an image.
         
          The function applies Perona-Malik anisotropic diffusion to an image. This is the solution to the partial differential equation:
         
          \f[{\frac  {\partial I}{\partial t}}={\mathrm  {div}}\left(c(x,y,t)\nabla I\right)=\nabla c\cdot \nabla I+c(x,y,t)\Delta I\f]
         
          Suggested functions for c(x,y,t) are:
         
          \f[c\left(\|\nabla I\|\right)=e^{{-\left(\|\nabla I\|/K\right)^{2}}}\f]
         
          or
         
          \f[ c\left(\|\nabla I\|\right)={\frac {1}{1+\left({\frac  {\|\nabla I\|}{K}}\right)^{2}}} \f]
         
          @param src Source image with 3 channels.
          @param dst Destination image of the same size and the same number of channels as src .
          @param alpha The amount of time to step forward by on each iteration (normally, it's between 0 and 1).
          @param K sensitivity to the edges
          @param niters The number of iterations
         */
        public static void anisotropicDiffusion(Mat src, Mat dst, float alpha, float K, int niters)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_anisotropicDiffusion_10(src.nativeObj, dst.nativeObj, alpha, K, niters);


        }


        //
        // C++:  void cv::ximgproc::createQuaternionImage(Mat img, Mat& qimg)
        //

        /**
         * @brief   creates a quaternion image.
         *
         * @param   img         Source 8-bit, 32-bit or 64-bit image, with 3-channel image.
         * @param   qimg        result CV_64FC4 a quaternion image( 4 chanels zero channel and B,G,R).
         */
        public static void createQuaternionImage(Mat img, Mat qimg)
        {
            if (img != null) img.ThrowIfDisposed();
            if (qimg != null) qimg.ThrowIfDisposed();

            ximgproc_Ximgproc_createQuaternionImage_10(img.nativeObj, qimg.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::qconj(Mat qimg, Mat& qcimg)
        //

        /**
         * @brief   calculates conjugate of a quaternion image.
         *
         * @param   qimg         quaternion image.
         * @param   qcimg        conjugate of qimg
         */
        public static void qconj(Mat qimg, Mat qcimg)
        {
            if (qimg != null) qimg.ThrowIfDisposed();
            if (qcimg != null) qcimg.ThrowIfDisposed();

            ximgproc_Ximgproc_qconj_10(qimg.nativeObj, qcimg.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::qunitary(Mat qimg, Mat& qnimg)
        //

        /**
         * @brief   divides each element by its modulus.
         *
         * @param   qimg         quaternion image.
         * @param   qnimg        conjugate of qimg
         */
        public static void qunitary(Mat qimg, Mat qnimg)
        {
            if (qimg != null) qimg.ThrowIfDisposed();
            if (qnimg != null) qnimg.ThrowIfDisposed();

            ximgproc_Ximgproc_qunitary_10(qimg.nativeObj, qnimg.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::qmultiply(Mat src1, Mat src2, Mat& dst)
        //

        /**
         * @brief   Calculates the per-element quaternion product of two arrays
         *
         * @param   src1         quaternion image.
         * @param   src2         quaternion image.
         * @param   dst        product dst(I)=src1(I) . src2(I)
         */
        public static void qmultiply(Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_qmultiply_10(src1.nativeObj, src2.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::qdft(Mat img, Mat& qimg, int flags, bool sideLeft)
        //

        /**
         * @brief    Performs a forward or inverse Discrete quaternion Fourier transform of a 2D quaternion array.
         *
         * @param   img        quaternion image.
         * @param   qimg       quaternion image in dual space.
         * @param   flags      quaternion image in dual space. only DFT_INVERSE flags is supported
         * @param   sideLeft   true the hypercomplex exponential is to be multiplied on the left (false on the right ).
         */
        public static void qdft(Mat img, Mat qimg, int flags, bool sideLeft)
        {
            if (img != null) img.ThrowIfDisposed();
            if (qimg != null) qimg.ThrowIfDisposed();

            ximgproc_Ximgproc_qdft_10(img.nativeObj, qimg.nativeObj, flags, sideLeft);


        }


        //
        // C++:  void cv::ximgproc::colorMatchTemplate(Mat img, Mat templ, Mat& result)
        //

        /**
         * @brief    Compares a color template against overlapped color image regions.
         *
         * @param   img        Image where the search is running. It must be 3 channels image
         * @param   templ       Searched template. It must be not greater than the source image and have 3 channels
         * @param   result     Map of comparison results. It must be single-channel 64-bit floating-point
         */
        public static void colorMatchTemplate(Mat img, Mat templ, Mat result)
        {
            if (img != null) img.ThrowIfDisposed();
            if (templ != null) templ.ThrowIfDisposed();
            if (result != null) result.ThrowIfDisposed();

            ximgproc_Ximgproc_colorMatchTemplate_10(img.nativeObj, templ.nativeObj, result.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::GradientDericheY(Mat op, Mat& dst, double alpha, double omega)
        //

        /**
         * @brief   Applies Y Deriche filter to an image.
         *
         * For more details about this implementation, please see http://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.476.5736&amp;rep=rep1&amp;type=pdf
         *
         * @param   op         Source 8-bit or 16bit image, 1-channel or 3-channel image.
         * @param   dst        result CV_32FC image with same number of channel than _op.
         * @param   alpha double see paper
         * @param   omega   double see paper
         *
         */
        public static void GradientDericheY(Mat op, Mat dst, double alpha, double omega)
        {
            if (op != null) op.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_GradientDericheY_10(op.nativeObj, dst.nativeObj, alpha, omega);


        }


        //
        // C++:  void cv::ximgproc::GradientDericheX(Mat op, Mat& dst, double alpha, double omega)
        //

        /**
         * @brief   Applies X Deriche filter to an image.
         *
         * For more details about this implementation, please see http://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.476.5736&amp;rep=rep1&amp;type=pdf
         *
         * @param   op         Source 8-bit or 16bit image, 1-channel or 3-channel image.
         * @param   dst        result CV_32FC image with same number of channel than _op.
         * @param   alpha double see paper
         * @param   omega   double see paper
         *
         */
        public static void GradientDericheX(Mat op, Mat dst, double alpha, double omega)
        {
            if (op != null) op.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_GradientDericheX_10(op.nativeObj, dst.nativeObj, alpha, omega);


        }


        //
        // C++:  Ptr_DisparityWLSFilter cv::ximgproc::createDisparityWLSFilter(Ptr_StereoMatcher matcher_left)
        //

        /**
         @brief Convenience factory method that creates an instance of DisparityWLSFilter and sets up all the relevant
         filter parameters automatically based on the matcher instance. Currently supports only StereoBM and StereoSGBM.
         
         @param matcher_left stereo matcher instance that will be used with the filter
         */
        public static DisparityWLSFilter createDisparityWLSFilter(StereoMatcher matcher_left)
        {
            if (matcher_left != null) matcher_left.ThrowIfDisposed();

            return DisparityWLSFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createDisparityWLSFilter_10(matcher_left.getNativeObjAddr())));


        }


        //
        // C++:  Ptr_StereoMatcher cv::ximgproc::createRightMatcher(Ptr_StereoMatcher matcher_left)
        //

        /**
         @brief Convenience method to set up the matcher for computing the right-view disparity map
         that is required in case of filtering with confidence.
         
         @param matcher_left main stereo matcher instance that will be used with the filter
         */
        public static StereoMatcher createRightMatcher(StereoMatcher matcher_left)
        {
            if (matcher_left != null) matcher_left.ThrowIfDisposed();

            return StereoMatcher.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createRightMatcher_10(matcher_left.getNativeObjAddr())));


        }


        //
        // C++:  Ptr_DisparityWLSFilter cv::ximgproc::createDisparityWLSFilterGeneric(bool use_confidence)
        //

        /**
         @brief More generic factory method, create instance of DisparityWLSFilter and execute basic
         initialization routines. When using this method you will need to set-up the ROI, matchers and
         other parameters by yourself.
         
         @param use_confidence filtering with confidence requires two disparity maps (for the left and right views) and is
         approximately two times slower. However, quality is typically significantly better.
         */
        public static DisparityWLSFilter createDisparityWLSFilterGeneric(bool use_confidence)
        {


            return DisparityWLSFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createDisparityWLSFilterGeneric_10(use_confidence)));


        }


        //
        // C++:  int cv::ximgproc::readGT(String src_path, Mat& dst)
        //

        /**
         @brief Function for reading ground truth disparity maps. Supports basic Middlebury
         and MPI-Sintel formats. Note that the resulting disparity map is scaled by 16.
         
         @param src_path path to the image, containing ground-truth disparity map
         
         @param dst output disparity map, CV_16S depth
         
         @result returns zero if successfully read the ground truth
         */
        public static int readGT(string src_path, Mat dst)
        {
            if (dst != null) dst.ThrowIfDisposed();

            return ximgproc_Ximgproc_readGT_10(src_path, dst.nativeObj);


        }


        //
        // C++:  double cv::ximgproc::computeMSE(Mat GT, Mat src, Rect ROI)
        //

        /**
         @brief Function for computing mean square error for disparity maps
         
         @param GT ground truth disparity map
         
         @param src disparity map to evaluate
         
         @param ROI region of interest
         
         @result returns mean square error between GT and src
         */
        public static double computeMSE(Mat GT, Mat src, Rect ROI)
        {
            if (GT != null) GT.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();

            return ximgproc_Ximgproc_computeMSE_10(GT.nativeObj, src.nativeObj, ROI.x, ROI.y, ROI.width, ROI.height);


        }


        //
        // C++:  double cv::ximgproc::computeBadPixelPercent(Mat GT, Mat src, Rect ROI, int thresh = 24)
        //

        /**
         @brief Function for computing the percent of "bad" pixels in the disparity map
         (pixels where error is higher than a specified threshold)
         
         @param GT ground truth disparity map
         
         @param src disparity map to evaluate
         
         @param ROI region of interest
         
         @param thresh threshold used to determine "bad" pixels
         
         @result returns mean square error between GT and src
         */
        public static double computeBadPixelPercent(Mat GT, Mat src, Rect ROI, int thresh)
        {
            if (GT != null) GT.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();

            return ximgproc_Ximgproc_computeBadPixelPercent_10(GT.nativeObj, src.nativeObj, ROI.x, ROI.y, ROI.width, ROI.height, thresh);


        }

        /**
         @brief Function for computing the percent of "bad" pixels in the disparity map
         (pixels where error is higher than a specified threshold)
         
         @param GT ground truth disparity map
         
         @param src disparity map to evaluate
         
         @param ROI region of interest
         
         @param thresh threshold used to determine "bad" pixels
         
         @result returns mean square error between GT and src
         */
        public static double computeBadPixelPercent(Mat GT, Mat src, Rect ROI)
        {
            if (GT != null) GT.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();

            return ximgproc_Ximgproc_computeBadPixelPercent_11(GT.nativeObj, src.nativeObj, ROI.x, ROI.y, ROI.width, ROI.height);


        }


        //
        // C++:  void cv::ximgproc::getDisparityVis(Mat src, Mat& dst, double scale = 1.0)
        //

        /**
         @brief Function for creating a disparity map visualization (clamped CV_8U image)
         
         @param src input disparity map (CV_16S depth)
         
         @param dst output visualization
         
         @param scale disparity map will be multiplied by this value for visualization
         */
        public static void getDisparityVis(Mat src, Mat dst, double scale)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_getDisparityVis_10(src.nativeObj, dst.nativeObj, scale);


        }

        /**
         @brief Function for creating a disparity map visualization (clamped CV_8U image)
         
         @param src input disparity map (CV_16S depth)
         
         @param dst output visualization
         
         @param scale disparity map will be multiplied by this value for visualization
         */
        public static void getDisparityVis(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_getDisparityVis_11(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  Ptr_EdgeBoxes cv::ximgproc::createEdgeBoxes(float alpha = 0.65f, float beta = 0.75f, float eta = 1, float minScore = 0.01f, int maxBoxes = 10000, float edgeMinMag = 0.1f, float edgeMergeThr = 0.5f, float clusterMinMag = 0.5f, float maxAspectRatio = 3, float minBoxArea = 1000, float gamma = 2, float kappa = 1.5f)
        //

        /**
         @brief Creates a Edgeboxes
         
         @param alpha step size of sliding window search.
         @param beta nms threshold for object proposals.
         @param eta adaptation rate for nms threshold.
         @param minScore min score of boxes to detect.
         @param maxBoxes max number of boxes to detect.
         @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
         @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
         @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
         @param maxAspectRatio max aspect ratio of boxes.
         @param minBoxArea minimum area of boxes.
         @param gamma affinity sensitivity.
         @param kappa scale sensitivity.
         */
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio, float minBoxArea, float gamma, float kappa)
        {


            return EdgeBoxes.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createEdgeBoxes_10(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr, clusterMinMag, maxAspectRatio, minBoxArea, gamma, kappa)));


        }

        /**
         @brief Creates a Edgeboxes
         
         @param alpha step size of sliding window search.
         @param beta nms threshold for object proposals.
         @param eta adaptation rate for nms threshold.
         @param minScore min score of boxes to detect.
         @param maxBoxes max number of boxes to detect.
         @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
         @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
         @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
         @param maxAspectRatio max aspect ratio of boxes.
         @param minBoxArea minimum area of boxes.
         @param gamma affinity sensitivity.
         @param kappa scale sensitivity.
         */
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio, float minBoxArea, float gamma)
        {


            return EdgeBoxes.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createEdgeBoxes_11(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr, clusterMinMag, maxAspectRatio, minBoxArea, gamma)));


        }

        /**
         @brief Creates a Edgeboxes
         
         @param alpha step size of sliding window search.
         @param beta nms threshold for object proposals.
         @param eta adaptation rate for nms threshold.
         @param minScore min score of boxes to detect.
         @param maxBoxes max number of boxes to detect.
         @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
         @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
         @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
         @param maxAspectRatio max aspect ratio of boxes.
         @param minBoxArea minimum area of boxes.
         @param gamma affinity sensitivity.
         @param kappa scale sensitivity.
         */
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio, float minBoxArea)
        {


            return EdgeBoxes.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createEdgeBoxes_12(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr, clusterMinMag, maxAspectRatio, minBoxArea)));


        }

        /**
         @brief Creates a Edgeboxes
         
         @param alpha step size of sliding window search.
         @param beta nms threshold for object proposals.
         @param eta adaptation rate for nms threshold.
         @param minScore min score of boxes to detect.
         @param maxBoxes max number of boxes to detect.
         @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
         @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
         @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
         @param maxAspectRatio max aspect ratio of boxes.
         @param minBoxArea minimum area of boxes.
         @param gamma affinity sensitivity.
         @param kappa scale sensitivity.
         */
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio)
        {


            return EdgeBoxes.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createEdgeBoxes_13(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr, clusterMinMag, maxAspectRatio)));


        }

        /**
         @brief Creates a Edgeboxes
         
         @param alpha step size of sliding window search.
         @param beta nms threshold for object proposals.
         @param eta adaptation rate for nms threshold.
         @param minScore min score of boxes to detect.
         @param maxBoxes max number of boxes to detect.
         @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
         @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
         @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
         @param maxAspectRatio max aspect ratio of boxes.
         @param minBoxArea minimum area of boxes.
         @param gamma affinity sensitivity.
         @param kappa scale sensitivity.
         */
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag)
        {


            return EdgeBoxes.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createEdgeBoxes_14(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr, clusterMinMag)));


        }

        /**
         @brief Creates a Edgeboxes
         
         @param alpha step size of sliding window search.
         @param beta nms threshold for object proposals.
         @param eta adaptation rate for nms threshold.
         @param minScore min score of boxes to detect.
         @param maxBoxes max number of boxes to detect.
         @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
         @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
         @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
         @param maxAspectRatio max aspect ratio of boxes.
         @param minBoxArea minimum area of boxes.
         @param gamma affinity sensitivity.
         @param kappa scale sensitivity.
         */
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr)
        {


            return EdgeBoxes.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createEdgeBoxes_15(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr)));


        }

        /**
         @brief Creates a Edgeboxes
         
         @param alpha step size of sliding window search.
         @param beta nms threshold for object proposals.
         @param eta adaptation rate for nms threshold.
         @param minScore min score of boxes to detect.
         @param maxBoxes max number of boxes to detect.
         @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
         @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
         @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
         @param maxAspectRatio max aspect ratio of boxes.
         @param minBoxArea minimum area of boxes.
         @param gamma affinity sensitivity.
         @param kappa scale sensitivity.
         */
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag)
        {


            return EdgeBoxes.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createEdgeBoxes_16(alpha, beta, eta, minScore, maxBoxes, edgeMinMag)));


        }

        /**
         @brief Creates a Edgeboxes
         
         @param alpha step size of sliding window search.
         @param beta nms threshold for object proposals.
         @param eta adaptation rate for nms threshold.
         @param minScore min score of boxes to detect.
         @param maxBoxes max number of boxes to detect.
         @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
         @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
         @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
         @param maxAspectRatio max aspect ratio of boxes.
         @param minBoxArea minimum area of boxes.
         @param gamma affinity sensitivity.
         @param kappa scale sensitivity.
         */
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore, int maxBoxes)
        {


            return EdgeBoxes.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createEdgeBoxes_17(alpha, beta, eta, minScore, maxBoxes)));


        }

        /**
         @brief Creates a Edgeboxes
         
         @param alpha step size of sliding window search.
         @param beta nms threshold for object proposals.
         @param eta adaptation rate for nms threshold.
         @param minScore min score of boxes to detect.
         @param maxBoxes max number of boxes to detect.
         @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
         @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
         @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
         @param maxAspectRatio max aspect ratio of boxes.
         @param minBoxArea minimum area of boxes.
         @param gamma affinity sensitivity.
         @param kappa scale sensitivity.
         */
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta, float minScore)
        {


            return EdgeBoxes.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createEdgeBoxes_18(alpha, beta, eta, minScore)));


        }

        /**
         @brief Creates a Edgeboxes
         
         @param alpha step size of sliding window search.
         @param beta nms threshold for object proposals.
         @param eta adaptation rate for nms threshold.
         @param minScore min score of boxes to detect.
         @param maxBoxes max number of boxes to detect.
         @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
         @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
         @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
         @param maxAspectRatio max aspect ratio of boxes.
         @param minBoxArea minimum area of boxes.
         @param gamma affinity sensitivity.
         @param kappa scale sensitivity.
         */
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta, float eta)
        {


            return EdgeBoxes.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createEdgeBoxes_19(alpha, beta, eta)));


        }

        /**
         @brief Creates a Edgeboxes
         
         @param alpha step size of sliding window search.
         @param beta nms threshold for object proposals.
         @param eta adaptation rate for nms threshold.
         @param minScore min score of boxes to detect.
         @param maxBoxes max number of boxes to detect.
         @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
         @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
         @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
         @param maxAspectRatio max aspect ratio of boxes.
         @param minBoxArea minimum area of boxes.
         @param gamma affinity sensitivity.
         @param kappa scale sensitivity.
         */
        public static EdgeBoxes createEdgeBoxes(float alpha, float beta)
        {


            return EdgeBoxes.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createEdgeBoxes_110(alpha, beta)));


        }

        /**
         @brief Creates a Edgeboxes
         
         @param alpha step size of sliding window search.
         @param beta nms threshold for object proposals.
         @param eta adaptation rate for nms threshold.
         @param minScore min score of boxes to detect.
         @param maxBoxes max number of boxes to detect.
         @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
         @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
         @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
         @param maxAspectRatio max aspect ratio of boxes.
         @param minBoxArea minimum area of boxes.
         @param gamma affinity sensitivity.
         @param kappa scale sensitivity.
         */
        public static EdgeBoxes createEdgeBoxes(float alpha)
        {


            return EdgeBoxes.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createEdgeBoxes_111(alpha)));


        }

        /**
         @brief Creates a Edgeboxes
         
         @param alpha step size of sliding window search.
         @param beta nms threshold for object proposals.
         @param eta adaptation rate for nms threshold.
         @param minScore min score of boxes to detect.
         @param maxBoxes max number of boxes to detect.
         @param edgeMinMag edge min magnitude. Increase to trade off accuracy for speed.
         @param edgeMergeThr edge merge threshold. Increase to trade off accuracy for speed.
         @param clusterMinMag cluster min magnitude. Increase to trade off accuracy for speed.
         @param maxAspectRatio max aspect ratio of boxes.
         @param minBoxArea minimum area of boxes.
         @param gamma affinity sensitivity.
         @param kappa scale sensitivity.
         */
        public static EdgeBoxes createEdgeBoxes()
        {


            return EdgeBoxes.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createEdgeBoxes_112()));


        }


        //
        // C++:  void cv::ximgproc::edgePreservingFilter(Mat src, Mat& dst, int d, double threshold)
        //

        /**
         * @brief Smoothes an image using the Edge-Preserving filter.
             *
             * The function smoothes Gaussian noise as well as salt &amp; pepper noise.
             * For more details about this implementation, please see
             * [ReiWoe18]  Reich, S. and Wörgötter, F. and Dellen, B. (2018). A Real-Time Edge-Preserving Denoising Filter. Proceedings of the 13th International Joint Conference on Computer Vision, Imaging and Computer Graphics Theory and Applications (VISIGRAPP): Visapp, 85-94, 4. DOI: 10.5220/0006509000850094.
             *
             * @param src Source 8-bit 3-channel image.
             * @param dst Destination image of the same size and type as src.
             * @param d Diameter of each pixel neighborhood that is used during filtering. Must be greater or equal 3.
             * @param threshold Threshold, which distinguishes between noise, outliers, and data.
         */
        public static void edgePreservingFilter(Mat src, Mat dst, int d, double threshold)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_edgePreservingFilter_10(src.nativeObj, dst.nativeObj, d, threshold);


        }


        //
        // C++:  Ptr_EdgeDrawing cv::ximgproc::createEdgeDrawing()
        //

        /**
         @brief Creates a smart pointer to a EdgeDrawing object and initializes it
         */
        public static EdgeDrawing createEdgeDrawing()
        {


            return EdgeDrawing.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createEdgeDrawing_10()));


        }


        //
        // C++:  Ptr_DTFilter cv::ximgproc::createDTFilter(Mat guide, double sigmaSpatial, double sigmaColor, int mode = DTF_NC, int numIters = 3)
        //

        /**
         @brief Factory method, create instance of DTFilter and produce initialization routines.
         
         @param guide guided image (used to build transformed distance, which describes edge structure of
         guided image).
         
         @param sigmaSpatial \f${\sigma}_H\f$ parameter in the original article, it's similar to the sigma in the
         coordinate space into bilateralFilter.
         
         @param sigmaColor \f${\sigma}_r\f$ parameter in the original article, it's similar to the sigma in the
         color space into bilateralFilter.
         
         @param mode one form three modes DTF_NC, DTF_RF and DTF_IC which corresponds to three modes for
         filtering 2D signals in the article.
         
         @param numIters optional number of iterations used for filtering, 3 is quite enough.
         
         For more details about Domain Transform filter parameters, see the original article @cite Gastal11 and
         [Domain Transform filter homepage](http://www.inf.ufrgs.br/~eslgastal/DomainTransform/).
         */
        public static DTFilter createDTFilter(Mat guide, double sigmaSpatial, double sigmaColor, int mode, int numIters)
        {
            if (guide != null) guide.ThrowIfDisposed();

            return DTFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createDTFilter_10(guide.nativeObj, sigmaSpatial, sigmaColor, mode, numIters)));


        }

        /**
         @brief Factory method, create instance of DTFilter and produce initialization routines.
         
         @param guide guided image (used to build transformed distance, which describes edge structure of
         guided image).
         
         @param sigmaSpatial \f${\sigma}_H\f$ parameter in the original article, it's similar to the sigma in the
         coordinate space into bilateralFilter.
         
         @param sigmaColor \f${\sigma}_r\f$ parameter in the original article, it's similar to the sigma in the
         color space into bilateralFilter.
         
         @param mode one form three modes DTF_NC, DTF_RF and DTF_IC which corresponds to three modes for
         filtering 2D signals in the article.
         
         @param numIters optional number of iterations used for filtering, 3 is quite enough.
         
         For more details about Domain Transform filter parameters, see the original article @cite Gastal11 and
         [Domain Transform filter homepage](http://www.inf.ufrgs.br/~eslgastal/DomainTransform/).
         */
        public static DTFilter createDTFilter(Mat guide, double sigmaSpatial, double sigmaColor, int mode)
        {
            if (guide != null) guide.ThrowIfDisposed();

            return DTFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createDTFilter_11(guide.nativeObj, sigmaSpatial, sigmaColor, mode)));


        }

        /**
         @brief Factory method, create instance of DTFilter and produce initialization routines.
         
         @param guide guided image (used to build transformed distance, which describes edge structure of
         guided image).
         
         @param sigmaSpatial \f${\sigma}_H\f$ parameter in the original article, it's similar to the sigma in the
         coordinate space into bilateralFilter.
         
         @param sigmaColor \f${\sigma}_r\f$ parameter in the original article, it's similar to the sigma in the
         color space into bilateralFilter.
         
         @param mode one form three modes DTF_NC, DTF_RF and DTF_IC which corresponds to three modes for
         filtering 2D signals in the article.
         
         @param numIters optional number of iterations used for filtering, 3 is quite enough.
         
         For more details about Domain Transform filter parameters, see the original article @cite Gastal11 and
         [Domain Transform filter homepage](http://www.inf.ufrgs.br/~eslgastal/DomainTransform/).
         */
        public static DTFilter createDTFilter(Mat guide, double sigmaSpatial, double sigmaColor)
        {
            if (guide != null) guide.ThrowIfDisposed();

            return DTFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createDTFilter_12(guide.nativeObj, sigmaSpatial, sigmaColor)));


        }


        //
        // C++:  void cv::ximgproc::dtFilter(Mat guide, Mat src, Mat& dst, double sigmaSpatial, double sigmaColor, int mode = DTF_NC, int numIters = 3)
        //

        /**
         @brief Simple one-line Domain Transform filter call. If you have multiple images to filter with the same
         guided image then use DTFilter interface to avoid extra computations on initialization stage.
         
         @param guide guided image (also called as joint image) with unsigned 8-bit or floating-point 32-bit
         depth and up to 4 channels.
         @param src filtering image with unsigned 8-bit or floating-point 32-bit depth and up to 4 channels.
         @param dst destination image
         @param sigmaSpatial \f${\sigma}_H\f$ parameter in the original article, it's similar to the sigma in the
         coordinate space into bilateralFilter.
         @param sigmaColor \f${\sigma}_r\f$ parameter in the original article, it's similar to the sigma in the
         color space into bilateralFilter.
         @param mode one form three modes DTF_NC, DTF_RF and DTF_IC which corresponds to three modes for
         filtering 2D signals in the article.
         @param numIters optional number of iterations used for filtering, 3 is quite enough.
         @sa bilateralFilter, guidedFilter, amFilter
         */
        public static void dtFilter(Mat guide, Mat src, Mat dst, double sigmaSpatial, double sigmaColor, int mode, int numIters)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_dtFilter_10(guide.nativeObj, src.nativeObj, dst.nativeObj, sigmaSpatial, sigmaColor, mode, numIters);


        }

        /**
         @brief Simple one-line Domain Transform filter call. If you have multiple images to filter with the same
         guided image then use DTFilter interface to avoid extra computations on initialization stage.
         
         @param guide guided image (also called as joint image) with unsigned 8-bit or floating-point 32-bit
         depth and up to 4 channels.
         @param src filtering image with unsigned 8-bit or floating-point 32-bit depth and up to 4 channels.
         @param dst destination image
         @param sigmaSpatial \f${\sigma}_H\f$ parameter in the original article, it's similar to the sigma in the
         coordinate space into bilateralFilter.
         @param sigmaColor \f${\sigma}_r\f$ parameter in the original article, it's similar to the sigma in the
         color space into bilateralFilter.
         @param mode one form three modes DTF_NC, DTF_RF and DTF_IC which corresponds to three modes for
         filtering 2D signals in the article.
         @param numIters optional number of iterations used for filtering, 3 is quite enough.
         @sa bilateralFilter, guidedFilter, amFilter
         */
        public static void dtFilter(Mat guide, Mat src, Mat dst, double sigmaSpatial, double sigmaColor, int mode)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_dtFilter_11(guide.nativeObj, src.nativeObj, dst.nativeObj, sigmaSpatial, sigmaColor, mode);


        }

        /**
         @brief Simple one-line Domain Transform filter call. If you have multiple images to filter with the same
         guided image then use DTFilter interface to avoid extra computations on initialization stage.
         
         @param guide guided image (also called as joint image) with unsigned 8-bit or floating-point 32-bit
         depth and up to 4 channels.
         @param src filtering image with unsigned 8-bit or floating-point 32-bit depth and up to 4 channels.
         @param dst destination image
         @param sigmaSpatial \f${\sigma}_H\f$ parameter in the original article, it's similar to the sigma in the
         coordinate space into bilateralFilter.
         @param sigmaColor \f${\sigma}_r\f$ parameter in the original article, it's similar to the sigma in the
         color space into bilateralFilter.
         @param mode one form three modes DTF_NC, DTF_RF and DTF_IC which corresponds to three modes for
         filtering 2D signals in the article.
         @param numIters optional number of iterations used for filtering, 3 is quite enough.
         @sa bilateralFilter, guidedFilter, amFilter
         */
        public static void dtFilter(Mat guide, Mat src, Mat dst, double sigmaSpatial, double sigmaColor)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_dtFilter_12(guide.nativeObj, src.nativeObj, dst.nativeObj, sigmaSpatial, sigmaColor);


        }


        //
        // C++:  Ptr_GuidedFilter cv::ximgproc::createGuidedFilter(Mat guide, int radius, double eps)
        //

        /**
         @brief Factory method, create instance of GuidedFilter and produce initialization routines.
         
         @param guide guided image (or array of images) with up to 3 channels, if it have more then 3
         channels then only first 3 channels will be used.
         
         @param radius radius of Guided Filter.
         
         @param eps regularization term of Guided Filter. \f${eps}^2\f$ is similar to the sigma in the color
         space into bilateralFilter.
         
         For more details about Guided Filter parameters, see the original article @cite Kaiming10 .
         */
        public static GuidedFilter createGuidedFilter(Mat guide, int radius, double eps)
        {
            if (guide != null) guide.ThrowIfDisposed();

            return GuidedFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createGuidedFilter_10(guide.nativeObj, radius, eps)));


        }


        //
        // C++:  void cv::ximgproc::guidedFilter(Mat guide, Mat src, Mat& dst, int radius, double eps, int dDepth = -1)
        //

        /**
         @brief Simple one-line Guided Filter call.
         
         If you have multiple images to filter with the same guided image then use GuidedFilter interface to
         avoid extra computations on initialization stage.
         
         @param guide guided image (or array of images) with up to 3 channels, if it have more then 3
         channels then only first 3 channels will be used.
         
         @param src filtering image with any numbers of channels.
         
         @param dst output image.
         
         @param radius radius of Guided Filter.
         
         @param eps regularization term of Guided Filter. \f${eps}^2\f$ is similar to the sigma in the color
         space into bilateralFilter.
         
         @param dDepth optional depth of the output image.
         
         @sa bilateralFilter, dtFilter, amFilter
         */
        public static void guidedFilter(Mat guide, Mat src, Mat dst, int radius, double eps, int dDepth)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_guidedFilter_10(guide.nativeObj, src.nativeObj, dst.nativeObj, radius, eps, dDepth);


        }

        /**
         @brief Simple one-line Guided Filter call.
         
         If you have multiple images to filter with the same guided image then use GuidedFilter interface to
         avoid extra computations on initialization stage.
         
         @param guide guided image (or array of images) with up to 3 channels, if it have more then 3
         channels then only first 3 channels will be used.
         
         @param src filtering image with any numbers of channels.
         
         @param dst output image.
         
         @param radius radius of Guided Filter.
         
         @param eps regularization term of Guided Filter. \f${eps}^2\f$ is similar to the sigma in the color
         space into bilateralFilter.
         
         @param dDepth optional depth of the output image.
         
         @sa bilateralFilter, dtFilter, amFilter
         */
        public static void guidedFilter(Mat guide, Mat src, Mat dst, int radius, double eps)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_guidedFilter_11(guide.nativeObj, src.nativeObj, dst.nativeObj, radius, eps);


        }


        //
        // C++:  Ptr_AdaptiveManifoldFilter cv::ximgproc::createAMFilter(double sigma_s, double sigma_r, bool adjust_outliers = false)
        //

        /**
         @brief Factory method, create instance of AdaptiveManifoldFilter and produce some initialization routines.
         
         @param sigma_s spatial standard deviation.
         
         @param sigma_r color space standard deviation, it is similar to the sigma in the color space into
         bilateralFilter.
         
         @param adjust_outliers optional, specify perform outliers adjust operation or not, (Eq. 9) in the
         original paper.
         
         For more details about Adaptive Manifold Filter parameters, see the original article @cite Gastal12 .
         
         @note Joint images with CV_8U and CV_16U depth converted to images with CV_32F depth and [0; 1]
         color range before processing. Hence color space sigma sigma_r must be in [0; 1] range, unlike same
         sigmas in bilateralFilter and dtFilter functions.
         */
        public static AdaptiveManifoldFilter createAMFilter(double sigma_s, double sigma_r, bool adjust_outliers)
        {


            return AdaptiveManifoldFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createAMFilter_10(sigma_s, sigma_r, adjust_outliers)));


        }

        /**
         @brief Factory method, create instance of AdaptiveManifoldFilter and produce some initialization routines.
         
         @param sigma_s spatial standard deviation.
         
         @param sigma_r color space standard deviation, it is similar to the sigma in the color space into
         bilateralFilter.
         
         @param adjust_outliers optional, specify perform outliers adjust operation or not, (Eq. 9) in the
         original paper.
         
         For more details about Adaptive Manifold Filter parameters, see the original article @cite Gastal12 .
         
         @note Joint images with CV_8U and CV_16U depth converted to images with CV_32F depth and [0; 1]
         color range before processing. Hence color space sigma sigma_r must be in [0; 1] range, unlike same
         sigmas in bilateralFilter and dtFilter functions.
         */
        public static AdaptiveManifoldFilter createAMFilter(double sigma_s, double sigma_r)
        {


            return AdaptiveManifoldFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createAMFilter_11(sigma_s, sigma_r)));


        }


        //
        // C++:  void cv::ximgproc::amFilter(Mat joint, Mat src, Mat& dst, double sigma_s, double sigma_r, bool adjust_outliers = false)
        //

        /**
         @brief Simple one-line Adaptive Manifold Filter call.
         
         @param joint joint (also called as guided) image or array of images with any numbers of channels.
         
         @param src filtering image with any numbers of channels.
         
         @param dst output image.
         
         @param sigma_s spatial standard deviation.
         
         @param sigma_r color space standard deviation, it is similar to the sigma in the color space into
         bilateralFilter.
         
         @param adjust_outliers optional, specify perform outliers adjust operation or not, (Eq. 9) in the
         original paper.
         
         @note Joint images with CV_8U and CV_16U depth converted to images with CV_32F depth and [0; 1]
         color range before processing. Hence color space sigma sigma_r must be in [0; 1] range, unlike same
         sigmas in bilateralFilter and dtFilter functions. @sa bilateralFilter, dtFilter, guidedFilter
         */
        public static void amFilter(Mat joint, Mat src, Mat dst, double sigma_s, double sigma_r, bool adjust_outliers)
        {
            if (joint != null) joint.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_amFilter_10(joint.nativeObj, src.nativeObj, dst.nativeObj, sigma_s, sigma_r, adjust_outliers);


        }

        /**
         @brief Simple one-line Adaptive Manifold Filter call.
         
         @param joint joint (also called as guided) image or array of images with any numbers of channels.
         
         @param src filtering image with any numbers of channels.
         
         @param dst output image.
         
         @param sigma_s spatial standard deviation.
         
         @param sigma_r color space standard deviation, it is similar to the sigma in the color space into
         bilateralFilter.
         
         @param adjust_outliers optional, specify perform outliers adjust operation or not, (Eq. 9) in the
         original paper.
         
         @note Joint images with CV_8U and CV_16U depth converted to images with CV_32F depth and [0; 1]
         color range before processing. Hence color space sigma sigma_r must be in [0; 1] range, unlike same
         sigmas in bilateralFilter and dtFilter functions. @sa bilateralFilter, dtFilter, guidedFilter
         */
        public static void amFilter(Mat joint, Mat src, Mat dst, double sigma_s, double sigma_r)
        {
            if (joint != null) joint.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_amFilter_11(joint.nativeObj, src.nativeObj, dst.nativeObj, sigma_s, sigma_r);


        }


        //
        // C++:  void cv::ximgproc::jointBilateralFilter(Mat joint, Mat src, Mat& dst, int d, double sigmaColor, double sigmaSpace, int borderType = BORDER_DEFAULT)
        //

        /**
         @brief Applies the joint bilateral filter to an image.
         
         @param joint Joint 8-bit or floating-point, 1-channel or 3-channel image.
         
         @param src Source 8-bit or floating-point, 1-channel or 3-channel image with the same depth as joint
         image.
         
         @param dst Destination image of the same size and type as src .
         
         @param d Diameter of each pixel neighborhood that is used during filtering. If it is non-positive,
         it is computed from sigmaSpace .
         
         @param sigmaColor Filter sigma in the color space. A larger value of the parameter means that
         farther colors within the pixel neighborhood (see sigmaSpace ) will be mixed together, resulting in
         larger areas of semi-equal color.
         
         @param sigmaSpace Filter sigma in the coordinate space. A larger value of the parameter means that
         farther pixels will influence each other as long as their colors are close enough (see sigmaColor ).
         When d&gt;0 , it specifies the neighborhood size regardless of sigmaSpace . Otherwise, d is
         proportional to sigmaSpace .
         
         @param borderType
         
         @note bilateralFilter and jointBilateralFilter use L1 norm to compute difference between colors.
         
         @sa bilateralFilter, amFilter
         */
        public static void jointBilateralFilter(Mat joint, Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace, int borderType)
        {
            if (joint != null) joint.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_jointBilateralFilter_10(joint.nativeObj, src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace, borderType);


        }

        /**
         @brief Applies the joint bilateral filter to an image.
         
         @param joint Joint 8-bit or floating-point, 1-channel or 3-channel image.
         
         @param src Source 8-bit or floating-point, 1-channel or 3-channel image with the same depth as joint
         image.
         
         @param dst Destination image of the same size and type as src .
         
         @param d Diameter of each pixel neighborhood that is used during filtering. If it is non-positive,
         it is computed from sigmaSpace .
         
         @param sigmaColor Filter sigma in the color space. A larger value of the parameter means that
         farther colors within the pixel neighborhood (see sigmaSpace ) will be mixed together, resulting in
         larger areas of semi-equal color.
         
         @param sigmaSpace Filter sigma in the coordinate space. A larger value of the parameter means that
         farther pixels will influence each other as long as their colors are close enough (see sigmaColor ).
         When d&gt;0 , it specifies the neighborhood size regardless of sigmaSpace . Otherwise, d is
         proportional to sigmaSpace .
         
         @param borderType
         
         @note bilateralFilter and jointBilateralFilter use L1 norm to compute difference between colors.
         
         @sa bilateralFilter, amFilter
         */
        public static void jointBilateralFilter(Mat joint, Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace)
        {
            if (joint != null) joint.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_jointBilateralFilter_11(joint.nativeObj, src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace);


        }


        //
        // C++:  void cv::ximgproc::bilateralTextureFilter(Mat src, Mat& dst, int fr = 3, int numIter = 1, double sigmaAlpha = -1., double sigmaAvg = -1.)
        //

        /**
         @brief Applies the bilateral texture filter to an image. It performs structure-preserving texture filter.
         For more details about this filter see @cite Cho2014.
         
         @param src Source image whose depth is 8-bit UINT or 32-bit FLOAT
         
         @param dst Destination image of the same size and type as src.
         
         @param fr Radius of kernel to be used for filtering. It should be positive integer
         
         @param numIter Number of iterations of algorithm, It should be positive integer
         
         @param sigmaAlpha Controls the sharpness of the weight transition from edges to smooth/texture regions, where
         a bigger value means sharper transition. When the value is negative, it is automatically calculated.
         
         @param sigmaAvg Range blur parameter for texture blurring. Larger value makes result to be more blurred. When the
         value is negative, it is automatically calculated as described in the paper.
         
         @sa rollingGuidanceFilter, bilateralFilter
         */
        public static void bilateralTextureFilter(Mat src, Mat dst, int fr, int numIter, double sigmaAlpha, double sigmaAvg)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_bilateralTextureFilter_10(src.nativeObj, dst.nativeObj, fr, numIter, sigmaAlpha, sigmaAvg);


        }

        /**
         @brief Applies the bilateral texture filter to an image. It performs structure-preserving texture filter.
         For more details about this filter see @cite Cho2014.
         
         @param src Source image whose depth is 8-bit UINT or 32-bit FLOAT
         
         @param dst Destination image of the same size and type as src.
         
         @param fr Radius of kernel to be used for filtering. It should be positive integer
         
         @param numIter Number of iterations of algorithm, It should be positive integer
         
         @param sigmaAlpha Controls the sharpness of the weight transition from edges to smooth/texture regions, where
         a bigger value means sharper transition. When the value is negative, it is automatically calculated.
         
         @param sigmaAvg Range blur parameter for texture blurring. Larger value makes result to be more blurred. When the
         value is negative, it is automatically calculated as described in the paper.
         
         @sa rollingGuidanceFilter, bilateralFilter
         */
        public static void bilateralTextureFilter(Mat src, Mat dst, int fr, int numIter, double sigmaAlpha)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_bilateralTextureFilter_11(src.nativeObj, dst.nativeObj, fr, numIter, sigmaAlpha);


        }

        /**
         @brief Applies the bilateral texture filter to an image. It performs structure-preserving texture filter.
         For more details about this filter see @cite Cho2014.
         
         @param src Source image whose depth is 8-bit UINT or 32-bit FLOAT
         
         @param dst Destination image of the same size and type as src.
         
         @param fr Radius of kernel to be used for filtering. It should be positive integer
         
         @param numIter Number of iterations of algorithm, It should be positive integer
         
         @param sigmaAlpha Controls the sharpness of the weight transition from edges to smooth/texture regions, where
         a bigger value means sharper transition. When the value is negative, it is automatically calculated.
         
         @param sigmaAvg Range blur parameter for texture blurring. Larger value makes result to be more blurred. When the
         value is negative, it is automatically calculated as described in the paper.
         
         @sa rollingGuidanceFilter, bilateralFilter
         */
        public static void bilateralTextureFilter(Mat src, Mat dst, int fr, int numIter)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_bilateralTextureFilter_12(src.nativeObj, dst.nativeObj, fr, numIter);


        }

        /**
         @brief Applies the bilateral texture filter to an image. It performs structure-preserving texture filter.
         For more details about this filter see @cite Cho2014.
         
         @param src Source image whose depth is 8-bit UINT or 32-bit FLOAT
         
         @param dst Destination image of the same size and type as src.
         
         @param fr Radius of kernel to be used for filtering. It should be positive integer
         
         @param numIter Number of iterations of algorithm, It should be positive integer
         
         @param sigmaAlpha Controls the sharpness of the weight transition from edges to smooth/texture regions, where
         a bigger value means sharper transition. When the value is negative, it is automatically calculated.
         
         @param sigmaAvg Range blur parameter for texture blurring. Larger value makes result to be more blurred. When the
         value is negative, it is automatically calculated as described in the paper.
         
         @sa rollingGuidanceFilter, bilateralFilter
         */
        public static void bilateralTextureFilter(Mat src, Mat dst, int fr)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_bilateralTextureFilter_13(src.nativeObj, dst.nativeObj, fr);


        }

        /**
         @brief Applies the bilateral texture filter to an image. It performs structure-preserving texture filter.
         For more details about this filter see @cite Cho2014.
         
         @param src Source image whose depth is 8-bit UINT or 32-bit FLOAT
         
         @param dst Destination image of the same size and type as src.
         
         @param fr Radius of kernel to be used for filtering. It should be positive integer
         
         @param numIter Number of iterations of algorithm, It should be positive integer
         
         @param sigmaAlpha Controls the sharpness of the weight transition from edges to smooth/texture regions, where
         a bigger value means sharper transition. When the value is negative, it is automatically calculated.
         
         @param sigmaAvg Range blur parameter for texture blurring. Larger value makes result to be more blurred. When the
         value is negative, it is automatically calculated as described in the paper.
         
         @sa rollingGuidanceFilter, bilateralFilter
         */
        public static void bilateralTextureFilter(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_bilateralTextureFilter_14(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::rollingGuidanceFilter(Mat src, Mat& dst, int d = -1, double sigmaColor = 25, double sigmaSpace = 3, int numOfIter = 4, int borderType = BORDER_DEFAULT)
        //

        /**
         @brief Applies the rolling guidance filter to an image.
         
         For more details, please see @cite zhang2014rolling
         
         @param src Source 8-bit or floating-point, 1-channel or 3-channel image.
         
         @param dst Destination image of the same size and type as src.
         
         @param d Diameter of each pixel neighborhood that is used during filtering. If it is non-positive,
         it is computed from sigmaSpace .
         
         @param sigmaColor Filter sigma in the color space. A larger value of the parameter means that
         farther colors within the pixel neighborhood (see sigmaSpace ) will be mixed together, resulting in
         larger areas of semi-equal color.
         
         @param sigmaSpace Filter sigma in the coordinate space. A larger value of the parameter means that
         farther pixels will influence each other as long as their colors are close enough (see sigmaColor ).
         When d&gt;0 , it specifies the neighborhood size regardless of sigmaSpace . Otherwise, d is
         proportional to sigmaSpace .
         
         @param numOfIter Number of iterations of joint edge-preserving filtering applied on the source image.
         
         @param borderType
         
         @note  rollingGuidanceFilter uses jointBilateralFilter as the edge-preserving filter.
         
         @sa jointBilateralFilter, bilateralFilter, amFilter
         */
        public static void rollingGuidanceFilter(Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace, int numOfIter, int borderType)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_rollingGuidanceFilter_10(src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace, numOfIter, borderType);


        }

        /**
         @brief Applies the rolling guidance filter to an image.
         
         For more details, please see @cite zhang2014rolling
         
         @param src Source 8-bit or floating-point, 1-channel or 3-channel image.
         
         @param dst Destination image of the same size and type as src.
         
         @param d Diameter of each pixel neighborhood that is used during filtering. If it is non-positive,
         it is computed from sigmaSpace .
         
         @param sigmaColor Filter sigma in the color space. A larger value of the parameter means that
         farther colors within the pixel neighborhood (see sigmaSpace ) will be mixed together, resulting in
         larger areas of semi-equal color.
         
         @param sigmaSpace Filter sigma in the coordinate space. A larger value of the parameter means that
         farther pixels will influence each other as long as their colors are close enough (see sigmaColor ).
         When d&gt;0 , it specifies the neighborhood size regardless of sigmaSpace . Otherwise, d is
         proportional to sigmaSpace .
         
         @param numOfIter Number of iterations of joint edge-preserving filtering applied on the source image.
         
         @param borderType
         
         @note  rollingGuidanceFilter uses jointBilateralFilter as the edge-preserving filter.
         
         @sa jointBilateralFilter, bilateralFilter, amFilter
         */
        public static void rollingGuidanceFilter(Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace, int numOfIter)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_rollingGuidanceFilter_11(src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace, numOfIter);


        }

        /**
         @brief Applies the rolling guidance filter to an image.
         
         For more details, please see @cite zhang2014rolling
         
         @param src Source 8-bit or floating-point, 1-channel or 3-channel image.
         
         @param dst Destination image of the same size and type as src.
         
         @param d Diameter of each pixel neighborhood that is used during filtering. If it is non-positive,
         it is computed from sigmaSpace .
         
         @param sigmaColor Filter sigma in the color space. A larger value of the parameter means that
         farther colors within the pixel neighborhood (see sigmaSpace ) will be mixed together, resulting in
         larger areas of semi-equal color.
         
         @param sigmaSpace Filter sigma in the coordinate space. A larger value of the parameter means that
         farther pixels will influence each other as long as their colors are close enough (see sigmaColor ).
         When d&gt;0 , it specifies the neighborhood size regardless of sigmaSpace . Otherwise, d is
         proportional to sigmaSpace .
         
         @param numOfIter Number of iterations of joint edge-preserving filtering applied on the source image.
         
         @param borderType
         
         @note  rollingGuidanceFilter uses jointBilateralFilter as the edge-preserving filter.
         
         @sa jointBilateralFilter, bilateralFilter, amFilter
         */
        public static void rollingGuidanceFilter(Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_rollingGuidanceFilter_12(src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace);


        }

        /**
         @brief Applies the rolling guidance filter to an image.
         
         For more details, please see @cite zhang2014rolling
         
         @param src Source 8-bit or floating-point, 1-channel or 3-channel image.
         
         @param dst Destination image of the same size and type as src.
         
         @param d Diameter of each pixel neighborhood that is used during filtering. If it is non-positive,
         it is computed from sigmaSpace .
         
         @param sigmaColor Filter sigma in the color space. A larger value of the parameter means that
         farther colors within the pixel neighborhood (see sigmaSpace ) will be mixed together, resulting in
         larger areas of semi-equal color.
         
         @param sigmaSpace Filter sigma in the coordinate space. A larger value of the parameter means that
         farther pixels will influence each other as long as their colors are close enough (see sigmaColor ).
         When d&gt;0 , it specifies the neighborhood size regardless of sigmaSpace . Otherwise, d is
         proportional to sigmaSpace .
         
         @param numOfIter Number of iterations of joint edge-preserving filtering applied on the source image.
         
         @param borderType
         
         @note  rollingGuidanceFilter uses jointBilateralFilter as the edge-preserving filter.
         
         @sa jointBilateralFilter, bilateralFilter, amFilter
         */
        public static void rollingGuidanceFilter(Mat src, Mat dst, int d, double sigmaColor)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_rollingGuidanceFilter_13(src.nativeObj, dst.nativeObj, d, sigmaColor);


        }

        /**
         @brief Applies the rolling guidance filter to an image.
         
         For more details, please see @cite zhang2014rolling
         
         @param src Source 8-bit or floating-point, 1-channel or 3-channel image.
         
         @param dst Destination image of the same size and type as src.
         
         @param d Diameter of each pixel neighborhood that is used during filtering. If it is non-positive,
         it is computed from sigmaSpace .
         
         @param sigmaColor Filter sigma in the color space. A larger value of the parameter means that
         farther colors within the pixel neighborhood (see sigmaSpace ) will be mixed together, resulting in
         larger areas of semi-equal color.
         
         @param sigmaSpace Filter sigma in the coordinate space. A larger value of the parameter means that
         farther pixels will influence each other as long as their colors are close enough (see sigmaColor ).
         When d&gt;0 , it specifies the neighborhood size regardless of sigmaSpace . Otherwise, d is
         proportional to sigmaSpace .
         
         @param numOfIter Number of iterations of joint edge-preserving filtering applied on the source image.
         
         @param borderType
         
         @note  rollingGuidanceFilter uses jointBilateralFilter as the edge-preserving filter.
         
         @sa jointBilateralFilter, bilateralFilter, amFilter
         */
        public static void rollingGuidanceFilter(Mat src, Mat dst, int d)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_rollingGuidanceFilter_14(src.nativeObj, dst.nativeObj, d);


        }

        /**
         @brief Applies the rolling guidance filter to an image.
         
         For more details, please see @cite zhang2014rolling
         
         @param src Source 8-bit or floating-point, 1-channel or 3-channel image.
         
         @param dst Destination image of the same size and type as src.
         
         @param d Diameter of each pixel neighborhood that is used during filtering. If it is non-positive,
         it is computed from sigmaSpace .
         
         @param sigmaColor Filter sigma in the color space. A larger value of the parameter means that
         farther colors within the pixel neighborhood (see sigmaSpace ) will be mixed together, resulting in
         larger areas of semi-equal color.
         
         @param sigmaSpace Filter sigma in the coordinate space. A larger value of the parameter means that
         farther pixels will influence each other as long as their colors are close enough (see sigmaColor ).
         When d&gt;0 , it specifies the neighborhood size regardless of sigmaSpace . Otherwise, d is
         proportional to sigmaSpace .
         
         @param numOfIter Number of iterations of joint edge-preserving filtering applied on the source image.
         
         @param borderType
         
         @note  rollingGuidanceFilter uses jointBilateralFilter as the edge-preserving filter.
         
         @sa jointBilateralFilter, bilateralFilter, amFilter
         */
        public static void rollingGuidanceFilter(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_rollingGuidanceFilter_15(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  Ptr_FastBilateralSolverFilter cv::ximgproc::createFastBilateralSolverFilter(Mat guide, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda = 128.0, int num_iter = 25, double max_tol = 1e-5)
        //

        /**
         @brief Factory method, create instance of FastBilateralSolverFilter and execute the initialization routines.
         
         @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
         
         @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
         
         @param lambda smoothness strength parameter for solver.
         
         @param num_iter number of iterations used for solver, 25 is usually enough.
         
         @param max_tol convergence tolerance used for solver.
         
         For more details about the Fast Bilateral Solver parameters, see the original paper @cite BarronPoole2016.
         */
        public static FastBilateralSolverFilter createFastBilateralSolverFilter(Mat guide, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda, int num_iter, double max_tol)
        {
            if (guide != null) guide.ThrowIfDisposed();

            return FastBilateralSolverFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createFastBilateralSolverFilter_10(guide.nativeObj, sigma_spatial, sigma_luma, sigma_chroma, lambda, num_iter, max_tol)));


        }

        /**
         @brief Factory method, create instance of FastBilateralSolverFilter and execute the initialization routines.
         
         @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
         
         @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
         
         @param lambda smoothness strength parameter for solver.
         
         @param num_iter number of iterations used for solver, 25 is usually enough.
         
         @param max_tol convergence tolerance used for solver.
         
         For more details about the Fast Bilateral Solver parameters, see the original paper @cite BarronPoole2016.
         */
        public static FastBilateralSolverFilter createFastBilateralSolverFilter(Mat guide, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda, int num_iter)
        {
            if (guide != null) guide.ThrowIfDisposed();

            return FastBilateralSolverFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createFastBilateralSolverFilter_11(guide.nativeObj, sigma_spatial, sigma_luma, sigma_chroma, lambda, num_iter)));


        }

        /**
         @brief Factory method, create instance of FastBilateralSolverFilter and execute the initialization routines.
         
         @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
         
         @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
         
         @param lambda smoothness strength parameter for solver.
         
         @param num_iter number of iterations used for solver, 25 is usually enough.
         
         @param max_tol convergence tolerance used for solver.
         
         For more details about the Fast Bilateral Solver parameters, see the original paper @cite BarronPoole2016.
         */
        public static FastBilateralSolverFilter createFastBilateralSolverFilter(Mat guide, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda)
        {
            if (guide != null) guide.ThrowIfDisposed();

            return FastBilateralSolverFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createFastBilateralSolverFilter_12(guide.nativeObj, sigma_spatial, sigma_luma, sigma_chroma, lambda)));


        }

        /**
         @brief Factory method, create instance of FastBilateralSolverFilter and execute the initialization routines.
         
         @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
         
         @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
         
         @param lambda smoothness strength parameter for solver.
         
         @param num_iter number of iterations used for solver, 25 is usually enough.
         
         @param max_tol convergence tolerance used for solver.
         
         For more details about the Fast Bilateral Solver parameters, see the original paper @cite BarronPoole2016.
         */
        public static FastBilateralSolverFilter createFastBilateralSolverFilter(Mat guide, double sigma_spatial, double sigma_luma, double sigma_chroma)
        {
            if (guide != null) guide.ThrowIfDisposed();

            return FastBilateralSolverFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createFastBilateralSolverFilter_13(guide.nativeObj, sigma_spatial, sigma_luma, sigma_chroma)));


        }


        //
        // C++:  void cv::ximgproc::fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat& dst, double sigma_spatial = 8, double sigma_luma = 8, double sigma_chroma = 8, double lambda = 128.0, int num_iter = 25, double max_tol = 1e-5)
        //

        /**
         @brief Simple one-line Fast Bilateral Solver filter call. If you have multiple images to filter with the same
         guide then use FastBilateralSolverFilter interface to avoid extra computations.
         
         @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
         
         @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
         
         @param confidence confidence image with unsigned 8-bit or floating-point 32-bit confidence and 1 channel.
         
         @param dst destination image.
         
         @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
         
         @param lambda smoothness strength parameter for solver.
         
         @param num_iter number of iterations used for solver, 25 is usually enough.
         
         @param max_tol convergence tolerance used for solver.
         
         For more details about the Fast Bilateral Solver parameters, see the original paper @cite BarronPoole2016.
         
         @note Confidence images with CV_8U depth are expected to in [0, 255] and CV_32F in [0, 1] range.
         */
        public static void fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat dst, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda, int num_iter, double max_tol)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_fastBilateralSolverFilter_10(guide.nativeObj, src.nativeObj, confidence.nativeObj, dst.nativeObj, sigma_spatial, sigma_luma, sigma_chroma, lambda, num_iter, max_tol);


        }

        /**
         @brief Simple one-line Fast Bilateral Solver filter call. If you have multiple images to filter with the same
         guide then use FastBilateralSolverFilter interface to avoid extra computations.
         
         @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
         
         @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
         
         @param confidence confidence image with unsigned 8-bit or floating-point 32-bit confidence and 1 channel.
         
         @param dst destination image.
         
         @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
         
         @param lambda smoothness strength parameter for solver.
         
         @param num_iter number of iterations used for solver, 25 is usually enough.
         
         @param max_tol convergence tolerance used for solver.
         
         For more details about the Fast Bilateral Solver parameters, see the original paper @cite BarronPoole2016.
         
         @note Confidence images with CV_8U depth are expected to in [0, 255] and CV_32F in [0, 1] range.
         */
        public static void fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat dst, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda, int num_iter)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_fastBilateralSolverFilter_11(guide.nativeObj, src.nativeObj, confidence.nativeObj, dst.nativeObj, sigma_spatial, sigma_luma, sigma_chroma, lambda, num_iter);


        }

        /**
         @brief Simple one-line Fast Bilateral Solver filter call. If you have multiple images to filter with the same
         guide then use FastBilateralSolverFilter interface to avoid extra computations.
         
         @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
         
         @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
         
         @param confidence confidence image with unsigned 8-bit or floating-point 32-bit confidence and 1 channel.
         
         @param dst destination image.
         
         @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
         
         @param lambda smoothness strength parameter for solver.
         
         @param num_iter number of iterations used for solver, 25 is usually enough.
         
         @param max_tol convergence tolerance used for solver.
         
         For more details about the Fast Bilateral Solver parameters, see the original paper @cite BarronPoole2016.
         
         @note Confidence images with CV_8U depth are expected to in [0, 255] and CV_32F in [0, 1] range.
         */
        public static void fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat dst, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_fastBilateralSolverFilter_12(guide.nativeObj, src.nativeObj, confidence.nativeObj, dst.nativeObj, sigma_spatial, sigma_luma, sigma_chroma, lambda);


        }

        /**
         @brief Simple one-line Fast Bilateral Solver filter call. If you have multiple images to filter with the same
         guide then use FastBilateralSolverFilter interface to avoid extra computations.
         
         @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
         
         @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
         
         @param confidence confidence image with unsigned 8-bit or floating-point 32-bit confidence and 1 channel.
         
         @param dst destination image.
         
         @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
         
         @param lambda smoothness strength parameter for solver.
         
         @param num_iter number of iterations used for solver, 25 is usually enough.
         
         @param max_tol convergence tolerance used for solver.
         
         For more details about the Fast Bilateral Solver parameters, see the original paper @cite BarronPoole2016.
         
         @note Confidence images with CV_8U depth are expected to in [0, 255] and CV_32F in [0, 1] range.
         */
        public static void fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat dst, double sigma_spatial, double sigma_luma, double sigma_chroma)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_fastBilateralSolverFilter_13(guide.nativeObj, src.nativeObj, confidence.nativeObj, dst.nativeObj, sigma_spatial, sigma_luma, sigma_chroma);


        }

        /**
         @brief Simple one-line Fast Bilateral Solver filter call. If you have multiple images to filter with the same
         guide then use FastBilateralSolverFilter interface to avoid extra computations.
         
         @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
         
         @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
         
         @param confidence confidence image with unsigned 8-bit or floating-point 32-bit confidence and 1 channel.
         
         @param dst destination image.
         
         @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
         
         @param lambda smoothness strength parameter for solver.
         
         @param num_iter number of iterations used for solver, 25 is usually enough.
         
         @param max_tol convergence tolerance used for solver.
         
         For more details about the Fast Bilateral Solver parameters, see the original paper @cite BarronPoole2016.
         
         @note Confidence images with CV_8U depth are expected to in [0, 255] and CV_32F in [0, 1] range.
         */
        public static void fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat dst, double sigma_spatial, double sigma_luma)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_fastBilateralSolverFilter_14(guide.nativeObj, src.nativeObj, confidence.nativeObj, dst.nativeObj, sigma_spatial, sigma_luma);


        }

        /**
         @brief Simple one-line Fast Bilateral Solver filter call. If you have multiple images to filter with the same
         guide then use FastBilateralSolverFilter interface to avoid extra computations.
         
         @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
         
         @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
         
         @param confidence confidence image with unsigned 8-bit or floating-point 32-bit confidence and 1 channel.
         
         @param dst destination image.
         
         @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
         
         @param lambda smoothness strength parameter for solver.
         
         @param num_iter number of iterations used for solver, 25 is usually enough.
         
         @param max_tol convergence tolerance used for solver.
         
         For more details about the Fast Bilateral Solver parameters, see the original paper @cite BarronPoole2016.
         
         @note Confidence images with CV_8U depth are expected to in [0, 255] and CV_32F in [0, 1] range.
         */
        public static void fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat dst, double sigma_spatial)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_fastBilateralSolverFilter_15(guide.nativeObj, src.nativeObj, confidence.nativeObj, dst.nativeObj, sigma_spatial);


        }

        /**
         @brief Simple one-line Fast Bilateral Solver filter call. If you have multiple images to filter with the same
         guide then use FastBilateralSolverFilter interface to avoid extra computations.
         
         @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
         
         @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
         
         @param confidence confidence image with unsigned 8-bit or floating-point 32-bit confidence and 1 channel.
         
         @param dst destination image.
         
         @param sigma_spatial parameter, that is similar to spatial space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_luma parameter, that is similar to luma space sigma (bandwidth) in bilateralFilter.
         
         @param sigma_chroma parameter, that is similar to chroma space sigma (bandwidth) in bilateralFilter.
         
         @param lambda smoothness strength parameter for solver.
         
         @param num_iter number of iterations used for solver, 25 is usually enough.
         
         @param max_tol convergence tolerance used for solver.
         
         For more details about the Fast Bilateral Solver parameters, see the original paper @cite BarronPoole2016.
         
         @note Confidence images with CV_8U depth are expected to in [0, 255] and CV_32F in [0, 1] range.
         */
        public static void fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat dst)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_fastBilateralSolverFilter_16(guide.nativeObj, src.nativeObj, confidence.nativeObj, dst.nativeObj);


        }


        //
        // C++:  Ptr_FastGlobalSmootherFilter cv::ximgproc::createFastGlobalSmootherFilter(Mat guide, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
        //

        /**
         @brief Factory method, create instance of FastGlobalSmootherFilter and execute the initialization routines.
         
         @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
         
         @param lambda parameter defining the amount of regularization
         
         @param sigma_color parameter, that is similar to color space sigma in bilateralFilter.
         
         @param lambda_attenuation internal parameter, defining how much lambda decreases after each iteration. Normally,
         it should be 0.25. Setting it to 1.0 may lead to streaking artifacts.
         
         @param num_iter number of iterations used for filtering, 3 is usually enough.
         
         For more details about Fast Global Smoother parameters, see the original paper @cite Min2014. However, please note that
         there are several differences. Lambda attenuation described in the paper is implemented a bit differently so do not
         expect the results to be identical to those from the paper; sigma_color values from the paper should be multiplied by 255.0 to
         achieve the same effect. Also, in case of image filtering where source and guide image are the same, authors
         propose to dynamically update the guide image after each iteration. To maximize the performance this feature
         was not implemented here.
         */
        public static FastGlobalSmootherFilter createFastGlobalSmootherFilter(Mat guide, double lambda, double sigma_color, double lambda_attenuation, int num_iter)
        {
            if (guide != null) guide.ThrowIfDisposed();

            return FastGlobalSmootherFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createFastGlobalSmootherFilter_10(guide.nativeObj, lambda, sigma_color, lambda_attenuation, num_iter)));


        }

        /**
         @brief Factory method, create instance of FastGlobalSmootherFilter and execute the initialization routines.
         
         @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
         
         @param lambda parameter defining the amount of regularization
         
         @param sigma_color parameter, that is similar to color space sigma in bilateralFilter.
         
         @param lambda_attenuation internal parameter, defining how much lambda decreases after each iteration. Normally,
         it should be 0.25. Setting it to 1.0 may lead to streaking artifacts.
         
         @param num_iter number of iterations used for filtering, 3 is usually enough.
         
         For more details about Fast Global Smoother parameters, see the original paper @cite Min2014. However, please note that
         there are several differences. Lambda attenuation described in the paper is implemented a bit differently so do not
         expect the results to be identical to those from the paper; sigma_color values from the paper should be multiplied by 255.0 to
         achieve the same effect. Also, in case of image filtering where source and guide image are the same, authors
         propose to dynamically update the guide image after each iteration. To maximize the performance this feature
         was not implemented here.
         */
        public static FastGlobalSmootherFilter createFastGlobalSmootherFilter(Mat guide, double lambda, double sigma_color, double lambda_attenuation)
        {
            if (guide != null) guide.ThrowIfDisposed();

            return FastGlobalSmootherFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createFastGlobalSmootherFilter_11(guide.nativeObj, lambda, sigma_color, lambda_attenuation)));


        }

        /**
         @brief Factory method, create instance of FastGlobalSmootherFilter and execute the initialization routines.
         
         @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
         
         @param lambda parameter defining the amount of regularization
         
         @param sigma_color parameter, that is similar to color space sigma in bilateralFilter.
         
         @param lambda_attenuation internal parameter, defining how much lambda decreases after each iteration. Normally,
         it should be 0.25. Setting it to 1.0 may lead to streaking artifacts.
         
         @param num_iter number of iterations used for filtering, 3 is usually enough.
         
         For more details about Fast Global Smoother parameters, see the original paper @cite Min2014. However, please note that
         there are several differences. Lambda attenuation described in the paper is implemented a bit differently so do not
         expect the results to be identical to those from the paper; sigma_color values from the paper should be multiplied by 255.0 to
         achieve the same effect. Also, in case of image filtering where source and guide image are the same, authors
         propose to dynamically update the guide image after each iteration. To maximize the performance this feature
         was not implemented here.
         */
        public static FastGlobalSmootherFilter createFastGlobalSmootherFilter(Mat guide, double lambda, double sigma_color)
        {
            if (guide != null) guide.ThrowIfDisposed();

            return FastGlobalSmootherFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createFastGlobalSmootherFilter_12(guide.nativeObj, lambda, sigma_color)));


        }


        //
        // C++:  void cv::ximgproc::fastGlobalSmootherFilter(Mat guide, Mat src, Mat& dst, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
        //

        /**
         @brief Simple one-line Fast Global Smoother filter call. If you have multiple images to filter with the same
         guide then use FastGlobalSmootherFilter interface to avoid extra computations.
         
         @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
         
         @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
         
         @param dst destination image.
         
         @param lambda parameter defining the amount of regularization
         
         @param sigma_color parameter, that is similar to color space sigma in bilateralFilter.
         
         @param lambda_attenuation internal parameter, defining how much lambda decreases after each iteration. Normally,
         it should be 0.25. Setting it to 1.0 may lead to streaking artifacts.
         
         @param num_iter number of iterations used for filtering, 3 is usually enough.
         */
        public static void fastGlobalSmootherFilter(Mat guide, Mat src, Mat dst, double lambda, double sigma_color, double lambda_attenuation, int num_iter)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_fastGlobalSmootherFilter_10(guide.nativeObj, src.nativeObj, dst.nativeObj, lambda, sigma_color, lambda_attenuation, num_iter);


        }

        /**
         @brief Simple one-line Fast Global Smoother filter call. If you have multiple images to filter with the same
         guide then use FastGlobalSmootherFilter interface to avoid extra computations.
         
         @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
         
         @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
         
         @param dst destination image.
         
         @param lambda parameter defining the amount of regularization
         
         @param sigma_color parameter, that is similar to color space sigma in bilateralFilter.
         
         @param lambda_attenuation internal parameter, defining how much lambda decreases after each iteration. Normally,
         it should be 0.25. Setting it to 1.0 may lead to streaking artifacts.
         
         @param num_iter number of iterations used for filtering, 3 is usually enough.
         */
        public static void fastGlobalSmootherFilter(Mat guide, Mat src, Mat dst, double lambda, double sigma_color, double lambda_attenuation)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_fastGlobalSmootherFilter_11(guide.nativeObj, src.nativeObj, dst.nativeObj, lambda, sigma_color, lambda_attenuation);


        }

        /**
         @brief Simple one-line Fast Global Smoother filter call. If you have multiple images to filter with the same
         guide then use FastGlobalSmootherFilter interface to avoid extra computations.
         
         @param guide image serving as guide for filtering. It should have 8-bit depth and either 1 or 3 channels.
         
         @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
         
         @param dst destination image.
         
         @param lambda parameter defining the amount of regularization
         
         @param sigma_color parameter, that is similar to color space sigma in bilateralFilter.
         
         @param lambda_attenuation internal parameter, defining how much lambda decreases after each iteration. Normally,
         it should be 0.25. Setting it to 1.0 may lead to streaking artifacts.
         
         @param num_iter number of iterations used for filtering, 3 is usually enough.
         */
        public static void fastGlobalSmootherFilter(Mat guide, Mat src, Mat dst, double lambda, double sigma_color)
        {
            if (guide != null) guide.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_fastGlobalSmootherFilter_12(guide.nativeObj, src.nativeObj, dst.nativeObj, lambda, sigma_color);


        }


        //
        // C++:  void cv::ximgproc::l0Smooth(Mat src, Mat& dst, double lambda = 0.02, double kappa = 2.0)
        //

        /**
         @brief Global image smoothing via L0 gradient minimization.
         
         @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point depth.
         
         @param dst destination image.
         
         @param lambda parameter defining the smooth term weight.
         
         @param kappa parameter defining the increasing factor of the weight of the gradient data term.
         
         For more details about L0 Smoother, see the original paper @cite xu2011image.
         */
        public static void l0Smooth(Mat src, Mat dst, double lambda, double kappa)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_l0Smooth_10(src.nativeObj, dst.nativeObj, lambda, kappa);


        }

        /**
         @brief Global image smoothing via L0 gradient minimization.
         
         @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point depth.
         
         @param dst destination image.
         
         @param lambda parameter defining the smooth term weight.
         
         @param kappa parameter defining the increasing factor of the weight of the gradient data term.
         
         For more details about L0 Smoother, see the original paper @cite xu2011image.
         */
        public static void l0Smooth(Mat src, Mat dst, double lambda)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_l0Smooth_11(src.nativeObj, dst.nativeObj, lambda);


        }

        /**
         @brief Global image smoothing via L0 gradient minimization.
         
         @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point depth.
         
         @param dst destination image.
         
         @param lambda parameter defining the smooth term weight.
         
         @param kappa parameter defining the increasing factor of the weight of the gradient data term.
         
         For more details about L0 Smoother, see the original paper @cite xu2011image.
         */
        public static void l0Smooth(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_l0Smooth_12(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::covarianceEstimation(Mat src, Mat& dst, int windowRows, int windowCols)
        //

        /**
         @brief Computes the estimated covariance matrix of an image using the sliding
         window forumlation.
         
         @param src The source image. Input image must be of a complex type.
         @param dst The destination estimated covariance matrix. Output matrix will be size (windowRows*windowCols, windowRows*windowCols).
         @param windowRows The number of rows in the window.
         @param windowCols The number of cols in the window.
         The window size parameters control the accuracy of the estimation.
         The sliding window moves over the entire image from the top-left corner
         to the bottom right corner. Each location of the window represents a sample.
         If the window is the size of the image, then this gives the exact covariance matrix.
         For all other cases, the sizes of the window will impact the number of samples
         and the number of elements in the estimated covariance matrix.
         */
        public static void covarianceEstimation(Mat src, Mat dst, int windowRows, int windowCols)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_covarianceEstimation_10(src.nativeObj, dst.nativeObj, windowRows, windowCols);


        }


        //
        // C++:  void cv::ximgproc::FastHoughTransform(Mat src, Mat& dst, int dstMatDepth, int angleRange = ARO_315_135, int op = FHT_ADD, int makeSkew = HDO_DESKEW)
        //

        /**
         * @brief   Calculates 2D Fast Hough transform of an image.
         * @param   dst         The destination image, result of transformation.
         * @param   src         The source (input) image.
         * @param   dstMatDepth The depth of destination image
         * @param   op          The operation to be applied, see cv::HoughOp
         * @param   angleRange  The part of Hough space to calculate, see cv::AngleRangeOption
         * @param   makeSkew    Specifies to do or not to do image skewing, see cv::HoughDeskewOption
         *
         * The function calculates the fast Hough transform for full, half or quarter
         * range of angles.
         */
        public static void FastHoughTransform(Mat src, Mat dst, int dstMatDepth, int angleRange, int op, int makeSkew)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_FastHoughTransform_10(src.nativeObj, dst.nativeObj, dstMatDepth, angleRange, op, makeSkew);


        }

        /**
         * @brief   Calculates 2D Fast Hough transform of an image.
         * @param   dst         The destination image, result of transformation.
         * @param   src         The source (input) image.
         * @param   dstMatDepth The depth of destination image
         * @param   op          The operation to be applied, see cv::HoughOp
         * @param   angleRange  The part of Hough space to calculate, see cv::AngleRangeOption
         * @param   makeSkew    Specifies to do or not to do image skewing, see cv::HoughDeskewOption
         *
         * The function calculates the fast Hough transform for full, half or quarter
         * range of angles.
         */
        public static void FastHoughTransform(Mat src, Mat dst, int dstMatDepth, int angleRange, int op)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_FastHoughTransform_11(src.nativeObj, dst.nativeObj, dstMatDepth, angleRange, op);


        }

        /**
         * @brief   Calculates 2D Fast Hough transform of an image.
         * @param   dst         The destination image, result of transformation.
         * @param   src         The source (input) image.
         * @param   dstMatDepth The depth of destination image
         * @param   op          The operation to be applied, see cv::HoughOp
         * @param   angleRange  The part of Hough space to calculate, see cv::AngleRangeOption
         * @param   makeSkew    Specifies to do or not to do image skewing, see cv::HoughDeskewOption
         *
         * The function calculates the fast Hough transform for full, half or quarter
         * range of angles.
         */
        public static void FastHoughTransform(Mat src, Mat dst, int dstMatDepth, int angleRange)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_FastHoughTransform_12(src.nativeObj, dst.nativeObj, dstMatDepth, angleRange);


        }

        /**
         * @brief   Calculates 2D Fast Hough transform of an image.
         * @param   dst         The destination image, result of transformation.
         * @param   src         The source (input) image.
         * @param   dstMatDepth The depth of destination image
         * @param   op          The operation to be applied, see cv::HoughOp
         * @param   angleRange  The part of Hough space to calculate, see cv::AngleRangeOption
         * @param   makeSkew    Specifies to do or not to do image skewing, see cv::HoughDeskewOption
         *
         * The function calculates the fast Hough transform for full, half or quarter
         * range of angles.
         */
        public static void FastHoughTransform(Mat src, Mat dst, int dstMatDepth)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_FastHoughTransform_13(src.nativeObj, dst.nativeObj, dstMatDepth);


        }


        //
        // C++:  Vec4i cv::ximgproc::HoughPoint2Line(Point houghPoint, Mat srcImgInfo, int angleRange = ARO_315_135, int makeSkew = HDO_DESKEW, int rules = RO_IGNORE_BORDERS)
        //

        // Return type 'Vec4i' is not supported, skipping the function


        //
        // C++:  Ptr_FastLineDetector cv::ximgproc::createFastLineDetector(int length_threshold = 10, float distance_threshold = 1.414213562f, double canny_th1 = 50.0, double canny_th2 = 50.0, int canny_aperture_size = 3, bool do_merge = false)
        //

        /**
         @brief Creates a smart pointer to a FastLineDetector object and initializes it
         
         @param length_threshold    Segment shorter than this will be discarded
         @param distance_threshold  A point placed from a hypothesis line
                                    segment farther than this will be regarded as an outlier
         @param canny_th1           First threshold for hysteresis procedure in Canny()
         @param canny_th2           Second threshold for hysteresis procedure in Canny()
         @param canny_aperture_size Aperturesize for the sobel operator in Canny().
                                    If zero, Canny() is not applied and the input image is taken as an edge image.
         @param do_merge            If true, incremental merging of segments will be performed
         */
        public static FastLineDetector createFastLineDetector(int length_threshold, float distance_threshold, double canny_th1, double canny_th2, int canny_aperture_size, bool do_merge)
        {


            return FastLineDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createFastLineDetector_10(length_threshold, distance_threshold, canny_th1, canny_th2, canny_aperture_size, do_merge)));


        }

        /**
         @brief Creates a smart pointer to a FastLineDetector object and initializes it
         
         @param length_threshold    Segment shorter than this will be discarded
         @param distance_threshold  A point placed from a hypothesis line
                                    segment farther than this will be regarded as an outlier
         @param canny_th1           First threshold for hysteresis procedure in Canny()
         @param canny_th2           Second threshold for hysteresis procedure in Canny()
         @param canny_aperture_size Aperturesize for the sobel operator in Canny().
                                    If zero, Canny() is not applied and the input image is taken as an edge image.
         @param do_merge            If true, incremental merging of segments will be performed
         */
        public static FastLineDetector createFastLineDetector(int length_threshold, float distance_threshold, double canny_th1, double canny_th2, int canny_aperture_size)
        {


            return FastLineDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createFastLineDetector_11(length_threshold, distance_threshold, canny_th1, canny_th2, canny_aperture_size)));


        }

        /**
         @brief Creates a smart pointer to a FastLineDetector object and initializes it
         
         @param length_threshold    Segment shorter than this will be discarded
         @param distance_threshold  A point placed from a hypothesis line
                                    segment farther than this will be regarded as an outlier
         @param canny_th1           First threshold for hysteresis procedure in Canny()
         @param canny_th2           Second threshold for hysteresis procedure in Canny()
         @param canny_aperture_size Aperturesize for the sobel operator in Canny().
                                    If zero, Canny() is not applied and the input image is taken as an edge image.
         @param do_merge            If true, incremental merging of segments will be performed
         */
        public static FastLineDetector createFastLineDetector(int length_threshold, float distance_threshold, double canny_th1, double canny_th2)
        {


            return FastLineDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createFastLineDetector_12(length_threshold, distance_threshold, canny_th1, canny_th2)));


        }

        /**
         @brief Creates a smart pointer to a FastLineDetector object and initializes it
         
         @param length_threshold    Segment shorter than this will be discarded
         @param distance_threshold  A point placed from a hypothesis line
                                    segment farther than this will be regarded as an outlier
         @param canny_th1           First threshold for hysteresis procedure in Canny()
         @param canny_th2           Second threshold for hysteresis procedure in Canny()
         @param canny_aperture_size Aperturesize for the sobel operator in Canny().
                                    If zero, Canny() is not applied and the input image is taken as an edge image.
         @param do_merge            If true, incremental merging of segments will be performed
         */
        public static FastLineDetector createFastLineDetector(int length_threshold, float distance_threshold, double canny_th1)
        {


            return FastLineDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createFastLineDetector_13(length_threshold, distance_threshold, canny_th1)));


        }

        /**
         @brief Creates a smart pointer to a FastLineDetector object and initializes it
         
         @param length_threshold    Segment shorter than this will be discarded
         @param distance_threshold  A point placed from a hypothesis line
                                    segment farther than this will be regarded as an outlier
         @param canny_th1           First threshold for hysteresis procedure in Canny()
         @param canny_th2           Second threshold for hysteresis procedure in Canny()
         @param canny_aperture_size Aperturesize for the sobel operator in Canny().
                                    If zero, Canny() is not applied and the input image is taken as an edge image.
         @param do_merge            If true, incremental merging of segments will be performed
         */
        public static FastLineDetector createFastLineDetector(int length_threshold, float distance_threshold)
        {


            return FastLineDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createFastLineDetector_14(length_threshold, distance_threshold)));


        }

        /**
         @brief Creates a smart pointer to a FastLineDetector object and initializes it
         
         @param length_threshold    Segment shorter than this will be discarded
         @param distance_threshold  A point placed from a hypothesis line
                                    segment farther than this will be regarded as an outlier
         @param canny_th1           First threshold for hysteresis procedure in Canny()
         @param canny_th2           Second threshold for hysteresis procedure in Canny()
         @param canny_aperture_size Aperturesize for the sobel operator in Canny().
                                    If zero, Canny() is not applied and the input image is taken as an edge image.
         @param do_merge            If true, incremental merging of segments will be performed
         */
        public static FastLineDetector createFastLineDetector(int length_threshold)
        {


            return FastLineDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createFastLineDetector_15(length_threshold)));


        }

        /**
         @brief Creates a smart pointer to a FastLineDetector object and initializes it
         
         @param length_threshold    Segment shorter than this will be discarded
         @param distance_threshold  A point placed from a hypothesis line
                                    segment farther than this will be regarded as an outlier
         @param canny_th1           First threshold for hysteresis procedure in Canny()
         @param canny_th2           Second threshold for hysteresis procedure in Canny()
         @param canny_aperture_size Aperturesize for the sobel operator in Canny().
                                    If zero, Canny() is not applied and the input image is taken as an edge image.
         @param do_merge            If true, incremental merging of segments will be performed
         */
        public static FastLineDetector createFastLineDetector()
        {


            return FastLineDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createFastLineDetector_16()));


        }


        //
        // C++:  void cv::ximgproc::findEllipses(Mat image, Mat& ellipses, float scoreThreshold = 0.7f, float reliabilityThreshold = 0.5f, float centerDistanceThreshold = 0.05f)
        //

        /**
         @brief Finds ellipses fastly in an image using projective invariant pruning.
         *
         * The function detects ellipses in images using projective invariant pruning.
         * For more details about this implementation, please see @cite jia2017fast
         * Jia, Qi et al, (2017).
         * A Fast Ellipse Detector using Projective Invariant Pruning. IEEE Transactions on Image Processing.
         *
         @param image input image, could be gray or color.
         @param ellipses output vector of found ellipses. each vector is encoded as five float $x, y, a, b, radius, score$.
         @param scoreThreshold float, the threshold of ellipse score.
         @param reliabilityThreshold float, the threshold of reliability.
         @param centerDistanceThreshold float, the threshold of center distance.
         */
        public static void findEllipses(Mat image, Mat ellipses, float scoreThreshold, float reliabilityThreshold, float centerDistanceThreshold)
        {
            if (image != null) image.ThrowIfDisposed();
            if (ellipses != null) ellipses.ThrowIfDisposed();

            ximgproc_Ximgproc_findEllipses_10(image.nativeObj, ellipses.nativeObj, scoreThreshold, reliabilityThreshold, centerDistanceThreshold);


        }

        /**
         @brief Finds ellipses fastly in an image using projective invariant pruning.
         *
         * The function detects ellipses in images using projective invariant pruning.
         * For more details about this implementation, please see @cite jia2017fast
         * Jia, Qi et al, (2017).
         * A Fast Ellipse Detector using Projective Invariant Pruning. IEEE Transactions on Image Processing.
         *
         @param image input image, could be gray or color.
         @param ellipses output vector of found ellipses. each vector is encoded as five float $x, y, a, b, radius, score$.
         @param scoreThreshold float, the threshold of ellipse score.
         @param reliabilityThreshold float, the threshold of reliability.
         @param centerDistanceThreshold float, the threshold of center distance.
         */
        public static void findEllipses(Mat image, Mat ellipses, float scoreThreshold, float reliabilityThreshold)
        {
            if (image != null) image.ThrowIfDisposed();
            if (ellipses != null) ellipses.ThrowIfDisposed();

            ximgproc_Ximgproc_findEllipses_11(image.nativeObj, ellipses.nativeObj, scoreThreshold, reliabilityThreshold);


        }

        /**
         @brief Finds ellipses fastly in an image using projective invariant pruning.
         *
         * The function detects ellipses in images using projective invariant pruning.
         * For more details about this implementation, please see @cite jia2017fast
         * Jia, Qi et al, (2017).
         * A Fast Ellipse Detector using Projective Invariant Pruning. IEEE Transactions on Image Processing.
         *
         @param image input image, could be gray or color.
         @param ellipses output vector of found ellipses. each vector is encoded as five float $x, y, a, b, radius, score$.
         @param scoreThreshold float, the threshold of ellipse score.
         @param reliabilityThreshold float, the threshold of reliability.
         @param centerDistanceThreshold float, the threshold of center distance.
         */
        public static void findEllipses(Mat image, Mat ellipses, float scoreThreshold)
        {
            if (image != null) image.ThrowIfDisposed();
            if (ellipses != null) ellipses.ThrowIfDisposed();

            ximgproc_Ximgproc_findEllipses_12(image.nativeObj, ellipses.nativeObj, scoreThreshold);


        }

        /**
         @brief Finds ellipses fastly in an image using projective invariant pruning.
         *
         * The function detects ellipses in images using projective invariant pruning.
         * For more details about this implementation, please see @cite jia2017fast
         * Jia, Qi et al, (2017).
         * A Fast Ellipse Detector using Projective Invariant Pruning. IEEE Transactions on Image Processing.
         *
         @param image input image, could be gray or color.
         @param ellipses output vector of found ellipses. each vector is encoded as five float $x, y, a, b, radius, score$.
         @param scoreThreshold float, the threshold of ellipse score.
         @param reliabilityThreshold float, the threshold of reliability.
         @param centerDistanceThreshold float, the threshold of center distance.
         */
        public static void findEllipses(Mat image, Mat ellipses)
        {
            if (image != null) image.ThrowIfDisposed();
            if (ellipses != null) ellipses.ThrowIfDisposed();

            ximgproc_Ximgproc_findEllipses_13(image.nativeObj, ellipses.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::fourierDescriptor(Mat src, Mat& dst, int nbElt = -1, int nbFD = -1)
        //

        /**
         * @brief   Fourier descriptors for planed closed curves
             *
             * For more details about this implementation, please see @cite PersoonFu1977
             *
             * @param   src   contour type vector&lt;Point&gt; , vector&lt;Point2f&gt;  or vector&lt;Point2d&gt;
             * @param   dst   Mat of type CV_64FC2 and nbElt rows A VERIFIER
             * @param   nbElt number of rows in dst or getOptimalDFTSize rows if nbElt=-1
             * @param   nbFD number of FD return in dst dst = [FD(1...nbFD/2) FD(nbFD/2-nbElt+1...:nbElt)]
             *
         */
        public static void fourierDescriptor(Mat src, Mat dst, int nbElt, int nbFD)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_fourierDescriptor_10(src.nativeObj, dst.nativeObj, nbElt, nbFD);


        }

        /**
         * @brief   Fourier descriptors for planed closed curves
             *
             * For more details about this implementation, please see @cite PersoonFu1977
             *
             * @param   src   contour type vector&lt;Point&gt; , vector&lt;Point2f&gt;  or vector&lt;Point2d&gt;
             * @param   dst   Mat of type CV_64FC2 and nbElt rows A VERIFIER
             * @param   nbElt number of rows in dst or getOptimalDFTSize rows if nbElt=-1
             * @param   nbFD number of FD return in dst dst = [FD(1...nbFD/2) FD(nbFD/2-nbElt+1...:nbElt)]
             *
         */
        public static void fourierDescriptor(Mat src, Mat dst, int nbElt)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_fourierDescriptor_11(src.nativeObj, dst.nativeObj, nbElt);


        }

        /**
         * @brief   Fourier descriptors for planed closed curves
             *
             * For more details about this implementation, please see @cite PersoonFu1977
             *
             * @param   src   contour type vector&lt;Point&gt; , vector&lt;Point2f&gt;  or vector&lt;Point2d&gt;
             * @param   dst   Mat of type CV_64FC2 and nbElt rows A VERIFIER
             * @param   nbElt number of rows in dst or getOptimalDFTSize rows if nbElt=-1
             * @param   nbFD number of FD return in dst dst = [FD(1...nbFD/2) FD(nbFD/2-nbElt+1...:nbElt)]
             *
         */
        public static void fourierDescriptor(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_fourierDescriptor_12(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::transformFD(Mat src, Mat t, Mat& dst, bool fdContour = true)
        //

        /**
         * @brief   transform a contour
             *
             * @param   src   contour or Fourier Descriptors if fd is true
             * @param   t   transform Mat given by estimateTransformation
             * @param   dst   Mat of type CV_64FC2 and nbElt rows
             * @param   fdContour true src are Fourier Descriptors. fdContour false src is a contour
             *
         */
        public static void transformFD(Mat src, Mat t, Mat dst, bool fdContour)
        {
            if (src != null) src.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_transformFD_10(src.nativeObj, t.nativeObj, dst.nativeObj, fdContour);


        }

        /**
         * @brief   transform a contour
             *
             * @param   src   contour or Fourier Descriptors if fd is true
             * @param   t   transform Mat given by estimateTransformation
             * @param   dst   Mat of type CV_64FC2 and nbElt rows
             * @param   fdContour true src are Fourier Descriptors. fdContour false src is a contour
             *
         */
        public static void transformFD(Mat src, Mat t, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_transformFD_11(src.nativeObj, t.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::contourSampling(Mat src, Mat& _out, int nbElt)
        //

        /**
         * @brief   Contour sampling .
             *
             * @param   src   contour type vector&lt;Point&gt; , vector&lt;Point2f&gt;  or vector&lt;Point2d&gt;
             * @param   out   Mat of type CV_64FC2 and nbElt rows
             * @param   nbElt number of points in out contour
             *
         */
        public static void contourSampling(Mat src, Mat _out, int nbElt)
        {
            if (src != null) src.ThrowIfDisposed();
            if (_out != null) _out.ThrowIfDisposed();

            ximgproc_Ximgproc_contourSampling_10(src.nativeObj, _out.nativeObj, nbElt);


        }


        //
        // C++:  Ptr_ContourFitting cv::ximgproc::createContourFitting(int ctr = 1024, int fd = 16)
        //

        /**
         * @brief create ContourFitting algorithm object
             *
             * @param ctr number of Fourier descriptors equal to number of contour points after resampling.
             * @param fd Contour defining second shape (Target).
         */
        public static ContourFitting createContourFitting(int ctr, int fd)
        {


            return ContourFitting.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createContourFitting_10(ctr, fd)));


        }

        /**
         * @brief create ContourFitting algorithm object
             *
             * @param ctr number of Fourier descriptors equal to number of contour points after resampling.
             * @param fd Contour defining second shape (Target).
         */
        public static ContourFitting createContourFitting(int ctr)
        {


            return ContourFitting.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createContourFitting_11(ctr)));


        }

        /**
         * @brief create ContourFitting algorithm object
             *
             * @param ctr number of Fourier descriptors equal to number of contour points after resampling.
             * @param fd Contour defining second shape (Target).
         */
        public static ContourFitting createContourFitting()
        {


            return ContourFitting.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createContourFitting_12()));


        }


        //
        // C++:  Ptr_SuperpixelLSC cv::ximgproc::createSuperpixelLSC(Mat image, int region_size = 10, float ratio = 0.075f)
        //

        /**
         @brief Class implementing the LSC (Linear Spectral Clustering) superpixels
         
         @param image Image to segment
         @param region_size Chooses an average superpixel size measured in pixels
         @param ratio Chooses the enforcement of superpixel compactness factor of superpixel
         
         The function initializes a SuperpixelLSC object for the input image. It sets the parameters of
         superpixel algorithm, which are: region_size and ruler. It preallocate some buffers for future
         computing iterations over the given image. An example of LSC is ilustrated in the following picture.
         For enanched results it is recommended for color images to preprocess image with little gaussian blur
         with a small 3 x 3 kernel and additional conversion into CieLAB color space.
         
         ![image](pics/superpixels_lsc.png)
         */
        public static SuperpixelLSC createSuperpixelLSC(Mat image, int region_size, float ratio)
        {
            if (image != null) image.ThrowIfDisposed();

            return SuperpixelLSC.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSuperpixelLSC_10(image.nativeObj, region_size, ratio)));


        }

        /**
         @brief Class implementing the LSC (Linear Spectral Clustering) superpixels
         
         @param image Image to segment
         @param region_size Chooses an average superpixel size measured in pixels
         @param ratio Chooses the enforcement of superpixel compactness factor of superpixel
         
         The function initializes a SuperpixelLSC object for the input image. It sets the parameters of
         superpixel algorithm, which are: region_size and ruler. It preallocate some buffers for future
         computing iterations over the given image. An example of LSC is ilustrated in the following picture.
         For enanched results it is recommended for color images to preprocess image with little gaussian blur
         with a small 3 x 3 kernel and additional conversion into CieLAB color space.
         
         ![image](pics/superpixels_lsc.png)
         */
        public static SuperpixelLSC createSuperpixelLSC(Mat image, int region_size)
        {
            if (image != null) image.ThrowIfDisposed();

            return SuperpixelLSC.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSuperpixelLSC_11(image.nativeObj, region_size)));


        }

        /**
         @brief Class implementing the LSC (Linear Spectral Clustering) superpixels
         
         @param image Image to segment
         @param region_size Chooses an average superpixel size measured in pixels
         @param ratio Chooses the enforcement of superpixel compactness factor of superpixel
         
         The function initializes a SuperpixelLSC object for the input image. It sets the parameters of
         superpixel algorithm, which are: region_size and ruler. It preallocate some buffers for future
         computing iterations over the given image. An example of LSC is ilustrated in the following picture.
         For enanched results it is recommended for color images to preprocess image with little gaussian blur
         with a small 3 x 3 kernel and additional conversion into CieLAB color space.
         
         ![image](pics/superpixels_lsc.png)
         */
        public static SuperpixelLSC createSuperpixelLSC(Mat image)
        {
            if (image != null) image.ThrowIfDisposed();

            return SuperpixelLSC.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSuperpixelLSC_12(image.nativeObj)));


        }


        //
        // C++:  void cv::ximgproc::PeiLinNormalization(Mat I, Mat& T)
        //

        /**
         @overload
         */
        public static void PeiLinNormalization(Mat I, Mat T)
        {
            if (I != null) I.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();

            ximgproc_Ximgproc_PeiLinNormalization_10(I.nativeObj, T.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::RadonTransform(Mat src, Mat& dst, double theta = 1, double start_angle = 0, double end_angle = 180, bool crop = false, bool norm = false)
        //

        /**
         * @brief   Calculate Radon Transform of an image.
         * @param   src         The source (input) image.
         * @param   dst         The destination image, result of transformation.
         * @param   theta       Angle resolution of the transform in degrees.
         * @param   start_angle Start angle of the transform in degrees.
         * @param   end_angle   End angle of the transform in degrees.
         * @param   crop        Crop the source image into a circle.
         * @param   norm        Normalize the output Mat to grayscale and convert type to CV_8U
         *
         * This function calculates the Radon Transform of a given image in any range.
         * See https://engineering.purdue.edu/~malcolm/pct/CTI_Ch03.pdf for detail.
         * If the input type is CV_8U, the output will be CV_32S.
         * If the input type is CV_32F or CV_64F, the output will be CV_64F
         * The output size will be num_of_integral x src_diagonal_length.
         * If crop is selected, the input image will be crop into square then circle,
         * and output size will be num_of_integral x min_edge.
         *
         */
        public static void RadonTransform(Mat src, Mat dst, double theta, double start_angle, double end_angle, bool crop, bool norm)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_RadonTransform_10(src.nativeObj, dst.nativeObj, theta, start_angle, end_angle, crop, norm);


        }

        /**
         * @brief   Calculate Radon Transform of an image.
         * @param   src         The source (input) image.
         * @param   dst         The destination image, result of transformation.
         * @param   theta       Angle resolution of the transform in degrees.
         * @param   start_angle Start angle of the transform in degrees.
         * @param   end_angle   End angle of the transform in degrees.
         * @param   crop        Crop the source image into a circle.
         * @param   norm        Normalize the output Mat to grayscale and convert type to CV_8U
         *
         * This function calculates the Radon Transform of a given image in any range.
         * See https://engineering.purdue.edu/~malcolm/pct/CTI_Ch03.pdf for detail.
         * If the input type is CV_8U, the output will be CV_32S.
         * If the input type is CV_32F or CV_64F, the output will be CV_64F
         * The output size will be num_of_integral x src_diagonal_length.
         * If crop is selected, the input image will be crop into square then circle,
         * and output size will be num_of_integral x min_edge.
         *
         */
        public static void RadonTransform(Mat src, Mat dst, double theta, double start_angle, double end_angle, bool crop)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_RadonTransform_11(src.nativeObj, dst.nativeObj, theta, start_angle, end_angle, crop);


        }

        /**
         * @brief   Calculate Radon Transform of an image.
         * @param   src         The source (input) image.
         * @param   dst         The destination image, result of transformation.
         * @param   theta       Angle resolution of the transform in degrees.
         * @param   start_angle Start angle of the transform in degrees.
         * @param   end_angle   End angle of the transform in degrees.
         * @param   crop        Crop the source image into a circle.
         * @param   norm        Normalize the output Mat to grayscale and convert type to CV_8U
         *
         * This function calculates the Radon Transform of a given image in any range.
         * See https://engineering.purdue.edu/~malcolm/pct/CTI_Ch03.pdf for detail.
         * If the input type is CV_8U, the output will be CV_32S.
         * If the input type is CV_32F or CV_64F, the output will be CV_64F
         * The output size will be num_of_integral x src_diagonal_length.
         * If crop is selected, the input image will be crop into square then circle,
         * and output size will be num_of_integral x min_edge.
         *
         */
        public static void RadonTransform(Mat src, Mat dst, double theta, double start_angle, double end_angle)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_RadonTransform_12(src.nativeObj, dst.nativeObj, theta, start_angle, end_angle);


        }

        /**
         * @brief   Calculate Radon Transform of an image.
         * @param   src         The source (input) image.
         * @param   dst         The destination image, result of transformation.
         * @param   theta       Angle resolution of the transform in degrees.
         * @param   start_angle Start angle of the transform in degrees.
         * @param   end_angle   End angle of the transform in degrees.
         * @param   crop        Crop the source image into a circle.
         * @param   norm        Normalize the output Mat to grayscale and convert type to CV_8U
         *
         * This function calculates the Radon Transform of a given image in any range.
         * See https://engineering.purdue.edu/~malcolm/pct/CTI_Ch03.pdf for detail.
         * If the input type is CV_8U, the output will be CV_32S.
         * If the input type is CV_32F or CV_64F, the output will be CV_64F
         * The output size will be num_of_integral x src_diagonal_length.
         * If crop is selected, the input image will be crop into square then circle,
         * and output size will be num_of_integral x min_edge.
         *
         */
        public static void RadonTransform(Mat src, Mat dst, double theta, double start_angle)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_RadonTransform_13(src.nativeObj, dst.nativeObj, theta, start_angle);


        }

        /**
         * @brief   Calculate Radon Transform of an image.
         * @param   src         The source (input) image.
         * @param   dst         The destination image, result of transformation.
         * @param   theta       Angle resolution of the transform in degrees.
         * @param   start_angle Start angle of the transform in degrees.
         * @param   end_angle   End angle of the transform in degrees.
         * @param   crop        Crop the source image into a circle.
         * @param   norm        Normalize the output Mat to grayscale and convert type to CV_8U
         *
         * This function calculates the Radon Transform of a given image in any range.
         * See https://engineering.purdue.edu/~malcolm/pct/CTI_Ch03.pdf for detail.
         * If the input type is CV_8U, the output will be CV_32S.
         * If the input type is CV_32F or CV_64F, the output will be CV_64F
         * The output size will be num_of_integral x src_diagonal_length.
         * If crop is selected, the input image will be crop into square then circle,
         * and output size will be num_of_integral x min_edge.
         *
         */
        public static void RadonTransform(Mat src, Mat dst, double theta)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_RadonTransform_14(src.nativeObj, dst.nativeObj, theta);


        }

        /**
         * @brief   Calculate Radon Transform of an image.
         * @param   src         The source (input) image.
         * @param   dst         The destination image, result of transformation.
         * @param   theta       Angle resolution of the transform in degrees.
         * @param   start_angle Start angle of the transform in degrees.
         * @param   end_angle   End angle of the transform in degrees.
         * @param   crop        Crop the source image into a circle.
         * @param   norm        Normalize the output Mat to grayscale and convert type to CV_8U
         *
         * This function calculates the Radon Transform of a given image in any range.
         * See https://engineering.purdue.edu/~malcolm/pct/CTI_Ch03.pdf for detail.
         * If the input type is CV_8U, the output will be CV_32S.
         * If the input type is CV_32F or CV_64F, the output will be CV_64F
         * The output size will be num_of_integral x src_diagonal_length.
         * If crop is selected, the input image will be crop into square then circle,
         * and output size will be num_of_integral x min_edge.
         *
         */
        public static void RadonTransform(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_RadonTransform_15(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  Ptr_ScanSegment cv::ximgproc::createScanSegment(int image_width, int image_height, int num_superpixels, int slices = 8, bool merge_small = true)
        //

        /**
         @brief Initializes a ScanSegment object.
         
         The function initializes a ScanSegment object for the input image. It stores the parameters of
         the image: image_width and image_height. It also sets the parameters of the F-DBSCAN superpixel
         algorithm, which are: num_superpixels, threads, and merge_small.
         
         @param image_width Image width.
         @param image_height Image height.
         @param num_superpixels Desired number of superpixels. Note that the actual number may be smaller
         due to restrictions (depending on the image size). Use getNumberOfSuperpixels() to
         get the actual number.
         @param slices Number of processing threads for parallelisation. Setting -1 uses the maximum number
         of threads. In practice, four threads is enough for smaller images and eight threads for larger ones.
         @param merge_small merge small segments to give the desired number of superpixels. Processing is
         much faster without merging, but many small segments will be left in the image.
         */
        public static ScanSegment createScanSegment(int image_width, int image_height, int num_superpixels, int slices, bool merge_small)
        {


            return ScanSegment.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createScanSegment_10(image_width, image_height, num_superpixels, slices, merge_small)));


        }

        /**
         @brief Initializes a ScanSegment object.
         
         The function initializes a ScanSegment object for the input image. It stores the parameters of
         the image: image_width and image_height. It also sets the parameters of the F-DBSCAN superpixel
         algorithm, which are: num_superpixels, threads, and merge_small.
         
         @param image_width Image width.
         @param image_height Image height.
         @param num_superpixels Desired number of superpixels. Note that the actual number may be smaller
         due to restrictions (depending on the image size). Use getNumberOfSuperpixels() to
         get the actual number.
         @param slices Number of processing threads for parallelisation. Setting -1 uses the maximum number
         of threads. In practice, four threads is enough for smaller images and eight threads for larger ones.
         @param merge_small merge small segments to give the desired number of superpixels. Processing is
         much faster without merging, but many small segments will be left in the image.
         */
        public static ScanSegment createScanSegment(int image_width, int image_height, int num_superpixels, int slices)
        {


            return ScanSegment.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createScanSegment_11(image_width, image_height, num_superpixels, slices)));


        }

        /**
         @brief Initializes a ScanSegment object.
         
         The function initializes a ScanSegment object for the input image. It stores the parameters of
         the image: image_width and image_height. It also sets the parameters of the F-DBSCAN superpixel
         algorithm, which are: num_superpixels, threads, and merge_small.
         
         @param image_width Image width.
         @param image_height Image height.
         @param num_superpixels Desired number of superpixels. Note that the actual number may be smaller
         due to restrictions (depending on the image size). Use getNumberOfSuperpixels() to
         get the actual number.
         @param slices Number of processing threads for parallelisation. Setting -1 uses the maximum number
         of threads. In practice, four threads is enough for smaller images and eight threads for larger ones.
         @param merge_small merge small segments to give the desired number of superpixels. Processing is
         much faster without merging, but many small segments will be left in the image.
         */
        public static ScanSegment createScanSegment(int image_width, int image_height, int num_superpixels)
        {


            return ScanSegment.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createScanSegment_12(image_width, image_height, num_superpixels)));


        }


        //
        // C++:  Ptr_SuperpixelSEEDS cv::ximgproc::createSuperpixelSEEDS(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior = 2, int histogram_bins = 5, bool double_step = false)
        //

        /**
         @brief Initializes a SuperpixelSEEDS object.
         
         @param image_width Image width.
         @param image_height Image height.
         @param image_channels Number of channels of the image.
         @param num_superpixels Desired number of superpixels. Note that the actual number may be smaller
         due to restrictions (depending on the image size and num_levels). Use getNumberOfSuperpixels() to
         get the actual number.
         @param num_levels Number of block levels. The more levels, the more accurate is the segmentation,
         but needs more memory and CPU time.
         @param prior enable 3x3 shape smoothing term if &gt;0. A larger value leads to smoother shapes. prior
         must be in the range [0, 5].
         @param histogram_bins Number of histogram bins.
         @param double_step If true, iterate each block level twice for higher accuracy.
         
         The function initializes a SuperpixelSEEDS object for the input image. It stores the parameters of
         the image: image_width, image_height and image_channels. It also sets the parameters of the SEEDS
         superpixel algorithm, which are: num_superpixels, num_levels, use_prior, histogram_bins and
         double_step.
         
         The number of levels in num_levels defines the amount of block levels that the algorithm use in the
         optimization. The initialization is a grid, in which the superpixels are equally distributed through
         the width and the height of the image. The larger blocks correspond to the superpixel size, and the
         levels with smaller blocks are formed by dividing the larger blocks into 2 x 2 blocks of pixels,
         recursively until the smaller block level. An example of initialization of 4 block levels is
         illustrated in the following figure.
         
         ![image](pics/superpixels_blocks.png)
         */
        public static SuperpixelSEEDS createSuperpixelSEEDS(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior, int histogram_bins, bool double_step)
        {


            return SuperpixelSEEDS.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSuperpixelSEEDS_10(image_width, image_height, image_channels, num_superpixels, num_levels, prior, histogram_bins, double_step)));


        }

        /**
         @brief Initializes a SuperpixelSEEDS object.
         
         @param image_width Image width.
         @param image_height Image height.
         @param image_channels Number of channels of the image.
         @param num_superpixels Desired number of superpixels. Note that the actual number may be smaller
         due to restrictions (depending on the image size and num_levels). Use getNumberOfSuperpixels() to
         get the actual number.
         @param num_levels Number of block levels. The more levels, the more accurate is the segmentation,
         but needs more memory and CPU time.
         @param prior enable 3x3 shape smoothing term if &gt;0. A larger value leads to smoother shapes. prior
         must be in the range [0, 5].
         @param histogram_bins Number of histogram bins.
         @param double_step If true, iterate each block level twice for higher accuracy.
         
         The function initializes a SuperpixelSEEDS object for the input image. It stores the parameters of
         the image: image_width, image_height and image_channels. It also sets the parameters of the SEEDS
         superpixel algorithm, which are: num_superpixels, num_levels, use_prior, histogram_bins and
         double_step.
         
         The number of levels in num_levels defines the amount of block levels that the algorithm use in the
         optimization. The initialization is a grid, in which the superpixels are equally distributed through
         the width and the height of the image. The larger blocks correspond to the superpixel size, and the
         levels with smaller blocks are formed by dividing the larger blocks into 2 x 2 blocks of pixels,
         recursively until the smaller block level. An example of initialization of 4 block levels is
         illustrated in the following figure.
         
         ![image](pics/superpixels_blocks.png)
         */
        public static SuperpixelSEEDS createSuperpixelSEEDS(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior, int histogram_bins)
        {


            return SuperpixelSEEDS.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSuperpixelSEEDS_11(image_width, image_height, image_channels, num_superpixels, num_levels, prior, histogram_bins)));


        }

        /**
         @brief Initializes a SuperpixelSEEDS object.
         
         @param image_width Image width.
         @param image_height Image height.
         @param image_channels Number of channels of the image.
         @param num_superpixels Desired number of superpixels. Note that the actual number may be smaller
         due to restrictions (depending on the image size and num_levels). Use getNumberOfSuperpixels() to
         get the actual number.
         @param num_levels Number of block levels. The more levels, the more accurate is the segmentation,
         but needs more memory and CPU time.
         @param prior enable 3x3 shape smoothing term if &gt;0. A larger value leads to smoother shapes. prior
         must be in the range [0, 5].
         @param histogram_bins Number of histogram bins.
         @param double_step If true, iterate each block level twice for higher accuracy.
         
         The function initializes a SuperpixelSEEDS object for the input image. It stores the parameters of
         the image: image_width, image_height and image_channels. It also sets the parameters of the SEEDS
         superpixel algorithm, which are: num_superpixels, num_levels, use_prior, histogram_bins and
         double_step.
         
         The number of levels in num_levels defines the amount of block levels that the algorithm use in the
         optimization. The initialization is a grid, in which the superpixels are equally distributed through
         the width and the height of the image. The larger blocks correspond to the superpixel size, and the
         levels with smaller blocks are formed by dividing the larger blocks into 2 x 2 blocks of pixels,
         recursively until the smaller block level. An example of initialization of 4 block levels is
         illustrated in the following figure.
         
         ![image](pics/superpixels_blocks.png)
         */
        public static SuperpixelSEEDS createSuperpixelSEEDS(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior)
        {


            return SuperpixelSEEDS.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSuperpixelSEEDS_12(image_width, image_height, image_channels, num_superpixels, num_levels, prior)));


        }

        /**
         @brief Initializes a SuperpixelSEEDS object.
         
         @param image_width Image width.
         @param image_height Image height.
         @param image_channels Number of channels of the image.
         @param num_superpixels Desired number of superpixels. Note that the actual number may be smaller
         due to restrictions (depending on the image size and num_levels). Use getNumberOfSuperpixels() to
         get the actual number.
         @param num_levels Number of block levels. The more levels, the more accurate is the segmentation,
         but needs more memory and CPU time.
         @param prior enable 3x3 shape smoothing term if &gt;0. A larger value leads to smoother shapes. prior
         must be in the range [0, 5].
         @param histogram_bins Number of histogram bins.
         @param double_step If true, iterate each block level twice for higher accuracy.
         
         The function initializes a SuperpixelSEEDS object for the input image. It stores the parameters of
         the image: image_width, image_height and image_channels. It also sets the parameters of the SEEDS
         superpixel algorithm, which are: num_superpixels, num_levels, use_prior, histogram_bins and
         double_step.
         
         The number of levels in num_levels defines the amount of block levels that the algorithm use in the
         optimization. The initialization is a grid, in which the superpixels are equally distributed through
         the width and the height of the image. The larger blocks correspond to the superpixel size, and the
         levels with smaller blocks are formed by dividing the larger blocks into 2 x 2 blocks of pixels,
         recursively until the smaller block level. An example of initialization of 4 block levels is
         illustrated in the following figure.
         
         ![image](pics/superpixels_blocks.png)
         */
        public static SuperpixelSEEDS createSuperpixelSEEDS(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels)
        {


            return SuperpixelSEEDS.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSuperpixelSEEDS_13(image_width, image_height, image_channels, num_superpixels, num_levels)));


        }


        //
        // C++:  Ptr_GraphSegmentation cv::ximgproc::segmentation::createGraphSegmentation(double sigma = 0.5, float k = 300, int min_size = 100)
        //

        /**
         @brief Creates a graph based segmentor
                                 @param sigma The sigma parameter, used to smooth image
                                 @param k The k parameter of the algorythm
                                 @param min_size The minimum size of segments
         */
        public static GraphSegmentation createGraphSegmentation(double sigma, float k, int min_size)
        {


            return GraphSegmentation.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createGraphSegmentation_10(sigma, k, min_size)));


        }

        /**
         @brief Creates a graph based segmentor
                                 @param sigma The sigma parameter, used to smooth image
                                 @param k The k parameter of the algorythm
                                 @param min_size The minimum size of segments
         */
        public static GraphSegmentation createGraphSegmentation(double sigma, float k)
        {


            return GraphSegmentation.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createGraphSegmentation_11(sigma, k)));


        }

        /**
         @brief Creates a graph based segmentor
                                 @param sigma The sigma parameter, used to smooth image
                                 @param k The k parameter of the algorythm
                                 @param min_size The minimum size of segments
         */
        public static GraphSegmentation createGraphSegmentation(double sigma)
        {


            return GraphSegmentation.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createGraphSegmentation_12(sigma)));


        }

        /**
         @brief Creates a graph based segmentor
                                 @param sigma The sigma parameter, used to smooth image
                                 @param k The k parameter of the algorythm
                                 @param min_size The minimum size of segments
         */
        public static GraphSegmentation createGraphSegmentation()
        {


            return GraphSegmentation.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createGraphSegmentation_13()));


        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyColor cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyColor()
        //

        /**
         @brief Create a new color-based strategy
         */
        public static SelectiveSearchSegmentationStrategyColor createSelectiveSearchSegmentationStrategyColor()
        {


            return SelectiveSearchSegmentationStrategyColor.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyColor_10()));


        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategySize cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategySize()
        //

        /**
         @brief Create a new size-based strategy
         */
        public static SelectiveSearchSegmentationStrategySize createSelectiveSearchSegmentationStrategySize()
        {


            return SelectiveSearchSegmentationStrategySize.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategySize_10()));


        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyTexture cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyTexture()
        //

        /**
         @brief Create a new size-based strategy
         */
        public static SelectiveSearchSegmentationStrategyTexture createSelectiveSearchSegmentationStrategyTexture()
        {


            return SelectiveSearchSegmentationStrategyTexture.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyTexture_10()));


        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyFill cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyFill()
        //

        /**
         @brief Create a new fill-based strategy
         */
        public static SelectiveSearchSegmentationStrategyFill createSelectiveSearchSegmentationStrategyFill()
        {


            return SelectiveSearchSegmentationStrategyFill.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyFill_10()));


        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple()
        //

        /**
         @brief Create a new multiple strategy
         */
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple()
        {


            return SelectiveSearchSegmentationStrategyMultiple.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_10()));


        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1)
        //

        /**
         @brief Create a new multiple strategy and set one subtrategy
                                 @param s1 The first strategy
         */
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(SelectiveSearchSegmentationStrategy s1)
        {
            if (s1 != null) s1.ThrowIfDisposed();

            return SelectiveSearchSegmentationStrategyMultiple.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_11(s1.getNativeObjAddr())));


        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2)
        //

        /**
         @brief Create a new multiple strategy and set two subtrategies, with equal weights
                                 @param s1 The first strategy
                                 @param s2 The second strategy
         */
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(SelectiveSearchSegmentationStrategy s1, SelectiveSearchSegmentationStrategy s2)
        {
            if (s1 != null) s1.ThrowIfDisposed();
            if (s2 != null) s2.ThrowIfDisposed();

            return SelectiveSearchSegmentationStrategyMultiple.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_12(s1.getNativeObjAddr(), s2.getNativeObjAddr())));


        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3)
        //

        /**
         @brief Create a new multiple strategy and set three subtrategies, with equal weights
                                 @param s1 The first strategy
                                 @param s2 The second strategy
                                 @param s3 The third strategy
         */
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(SelectiveSearchSegmentationStrategy s1, SelectiveSearchSegmentationStrategy s2, SelectiveSearchSegmentationStrategy s3)
        {
            if (s1 != null) s1.ThrowIfDisposed();
            if (s2 != null) s2.ThrowIfDisposed();
            if (s3 != null) s3.ThrowIfDisposed();

            return SelectiveSearchSegmentationStrategyMultiple.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_13(s1.getNativeObjAddr(), s2.getNativeObjAddr(), s3.getNativeObjAddr())));


        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3, Ptr_SelectiveSearchSegmentationStrategy s4)
        //

        /**
         @brief Create a new multiple strategy and set four subtrategies, with equal weights
                                 @param s1 The first strategy
                                 @param s2 The second strategy
                                 @param s3 The third strategy
                                 @param s4 The forth strategy
         */
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(SelectiveSearchSegmentationStrategy s1, SelectiveSearchSegmentationStrategy s2, SelectiveSearchSegmentationStrategy s3, SelectiveSearchSegmentationStrategy s4)
        {
            if (s1 != null) s1.ThrowIfDisposed();
            if (s2 != null) s2.ThrowIfDisposed();
            if (s3 != null) s3.ThrowIfDisposed();
            if (s4 != null) s4.ThrowIfDisposed();

            return SelectiveSearchSegmentationStrategyMultiple.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_14(s1.getNativeObjAddr(), s2.getNativeObjAddr(), s3.getNativeObjAddr(), s4.getNativeObjAddr())));


        }


        //
        // C++:  Ptr_SelectiveSearchSegmentation cv::ximgproc::segmentation::createSelectiveSearchSegmentation()
        //

        /**
         @brief Create a new SelectiveSearchSegmentation class.
         */
        public static SelectiveSearchSegmentation createSelectiveSearchSegmentation()
        {


            return SelectiveSearchSegmentation.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSelectiveSearchSegmentation_10()));


        }


        //
        // C++:  Ptr_SuperpixelSLIC cv::ximgproc::createSuperpixelSLIC(Mat image, int algorithm = SLICO, int region_size = 10, float ruler = 10.0f)
        //

        /**
         @brief Initialize a SuperpixelSLIC object
         
         @param image Image to segment
         @param algorithm Chooses the algorithm variant to use:
         SLIC segments image using a desired region_size, and in addition SLICO will optimize using adaptive compactness factor,
         while MSLIC will optimize using manifold methods resulting in more content-sensitive superpixels.
         @param region_size Chooses an average superpixel size measured in pixels
         @param ruler Chooses the enforcement of superpixel smoothness factor of superpixel
         
         The function initializes a SuperpixelSLIC object for the input image. It sets the parameters of choosed
         superpixel algorithm, which are: region_size and ruler. It preallocate some buffers for future
         computing iterations over the given image. For enanched results it is recommended for color images to
         preprocess image with little gaussian blur using a small 3 x 3 kernel and additional conversion into
         CieLAB color space. An example of SLIC versus SLICO and MSLIC is ilustrated in the following picture.
         
         ![image](pics/superpixels_slic.png)
         */
        public static SuperpixelSLIC createSuperpixelSLIC(Mat image, int algorithm, int region_size, float ruler)
        {
            if (image != null) image.ThrowIfDisposed();

            return SuperpixelSLIC.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSuperpixelSLIC_10(image.nativeObj, algorithm, region_size, ruler)));


        }

        /**
         @brief Initialize a SuperpixelSLIC object
         
         @param image Image to segment
         @param algorithm Chooses the algorithm variant to use:
         SLIC segments image using a desired region_size, and in addition SLICO will optimize using adaptive compactness factor,
         while MSLIC will optimize using manifold methods resulting in more content-sensitive superpixels.
         @param region_size Chooses an average superpixel size measured in pixels
         @param ruler Chooses the enforcement of superpixel smoothness factor of superpixel
         
         The function initializes a SuperpixelSLIC object for the input image. It sets the parameters of choosed
         superpixel algorithm, which are: region_size and ruler. It preallocate some buffers for future
         computing iterations over the given image. For enanched results it is recommended for color images to
         preprocess image with little gaussian blur using a small 3 x 3 kernel and additional conversion into
         CieLAB color space. An example of SLIC versus SLICO and MSLIC is ilustrated in the following picture.
         
         ![image](pics/superpixels_slic.png)
         */
        public static SuperpixelSLIC createSuperpixelSLIC(Mat image, int algorithm, int region_size)
        {
            if (image != null) image.ThrowIfDisposed();

            return SuperpixelSLIC.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSuperpixelSLIC_11(image.nativeObj, algorithm, region_size)));


        }

        /**
         @brief Initialize a SuperpixelSLIC object
         
         @param image Image to segment
         @param algorithm Chooses the algorithm variant to use:
         SLIC segments image using a desired region_size, and in addition SLICO will optimize using adaptive compactness factor,
         while MSLIC will optimize using manifold methods resulting in more content-sensitive superpixels.
         @param region_size Chooses an average superpixel size measured in pixels
         @param ruler Chooses the enforcement of superpixel smoothness factor of superpixel
         
         The function initializes a SuperpixelSLIC object for the input image. It sets the parameters of choosed
         superpixel algorithm, which are: region_size and ruler. It preallocate some buffers for future
         computing iterations over the given image. For enanched results it is recommended for color images to
         preprocess image with little gaussian blur using a small 3 x 3 kernel and additional conversion into
         CieLAB color space. An example of SLIC versus SLICO and MSLIC is ilustrated in the following picture.
         
         ![image](pics/superpixels_slic.png)
         */
        public static SuperpixelSLIC createSuperpixelSLIC(Mat image, int algorithm)
        {
            if (image != null) image.ThrowIfDisposed();

            return SuperpixelSLIC.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSuperpixelSLIC_12(image.nativeObj, algorithm)));


        }

        /**
         @brief Initialize a SuperpixelSLIC object
         
         @param image Image to segment
         @param algorithm Chooses the algorithm variant to use:
         SLIC segments image using a desired region_size, and in addition SLICO will optimize using adaptive compactness factor,
         while MSLIC will optimize using manifold methods resulting in more content-sensitive superpixels.
         @param region_size Chooses an average superpixel size measured in pixels
         @param ruler Chooses the enforcement of superpixel smoothness factor of superpixel
         
         The function initializes a SuperpixelSLIC object for the input image. It sets the parameters of choosed
         superpixel algorithm, which are: region_size and ruler. It preallocate some buffers for future
         computing iterations over the given image. For enanched results it is recommended for color images to
         preprocess image with little gaussian blur using a small 3 x 3 kernel and additional conversion into
         CieLAB color space. An example of SLIC versus SLICO and MSLIC is ilustrated in the following picture.
         
         ![image](pics/superpixels_slic.png)
         */
        public static SuperpixelSLIC createSuperpixelSLIC(Mat image)
        {
            if (image != null) image.ThrowIfDisposed();

            return SuperpixelSLIC.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createSuperpixelSLIC_13(image.nativeObj)));


        }


        //
        // C++:  Ptr_EdgeAwareInterpolator cv::ximgproc::createEdgeAwareInterpolator()
        //

        /**
         @brief Factory method that creates an instance of the
         EdgeAwareInterpolator.
         */
        public static EdgeAwareInterpolator createEdgeAwareInterpolator()
        {


            return EdgeAwareInterpolator.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createEdgeAwareInterpolator_10()));


        }


        //
        // C++:  Ptr_RICInterpolator cv::ximgproc::createRICInterpolator()
        //

        /**
         @brief Factory method that creates an instance of the
         RICInterpolator.
         */
        public static RICInterpolator createRICInterpolator()
        {


            return RICInterpolator.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createRICInterpolator_10()));


        }


        //
        // C++:  Ptr_RFFeatureGetter cv::ximgproc::createRFFeatureGetter()
        //

        public static RFFeatureGetter createRFFeatureGetter()
        {


            return RFFeatureGetter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createRFFeatureGetter_10()));


        }


        //
        // C++:  Ptr_StructuredEdgeDetection cv::ximgproc::createStructuredEdgeDetection(String model, Ptr_RFFeatureGetter howToGetFeatures = Ptr<RFFeatureGetter>())
        //

        public static StructuredEdgeDetection createStructuredEdgeDetection(string model, RFFeatureGetter howToGetFeatures)
        {
            if (howToGetFeatures != null) howToGetFeatures.ThrowIfDisposed();

            return StructuredEdgeDetection.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createStructuredEdgeDetection_10(model, howToGetFeatures.getNativeObjAddr())));


        }

        public static StructuredEdgeDetection createStructuredEdgeDetection(string model)
        {


            return StructuredEdgeDetection.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_Ximgproc_createStructuredEdgeDetection_11(model)));


        }


        //
        // C++:  void cv::ximgproc::weightedMedianFilter(Mat joint, Mat src, Mat& dst, int r, double sigma = 25.5, int weightType = WMF_EXP, Mat mask = Mat())
        //

        /**
         * @brief   Applies weighted median filter to an image.
         *
         * For more details about this implementation, please see @cite zhang2014100+
         *
         * @param   joint       Joint 8-bit, 1-channel or 3-channel image.
         * @param   src         Source 8-bit or floating-point, 1-channel or 3-channel image.
         * @param   dst         Destination image.
         * @param   r           Radius of filtering kernel, should be a positive integer.
         * @param   sigma       Filter range standard deviation for the joint image.
         * @param   weightType  weightType The type of weight definition, see WMFWeightType
         * @param   mask        A 0-1 mask that has the same size with I. This mask is used to ignore the effect of some pixels. If the pixel value on mask is 0,
         *                           the pixel will be ignored when maintaining the joint-histogram. This is useful for applications like optical flow occlusion handling.
         *
         * @sa medianBlur, jointBilateralFilter
         */
        public static void weightedMedianFilter(Mat joint, Mat src, Mat dst, int r, double sigma, int weightType, Mat mask)
        {
            if (joint != null) joint.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            ximgproc_Ximgproc_weightedMedianFilter_10(joint.nativeObj, src.nativeObj, dst.nativeObj, r, sigma, weightType, mask.nativeObj);


        }

        /**
         * @brief   Applies weighted median filter to an image.
         *
         * For more details about this implementation, please see @cite zhang2014100+
         *
         * @param   joint       Joint 8-bit, 1-channel or 3-channel image.
         * @param   src         Source 8-bit or floating-point, 1-channel or 3-channel image.
         * @param   dst         Destination image.
         * @param   r           Radius of filtering kernel, should be a positive integer.
         * @param   sigma       Filter range standard deviation for the joint image.
         * @param   weightType  weightType The type of weight definition, see WMFWeightType
         * @param   mask        A 0-1 mask that has the same size with I. This mask is used to ignore the effect of some pixels. If the pixel value on mask is 0,
         *                           the pixel will be ignored when maintaining the joint-histogram. This is useful for applications like optical flow occlusion handling.
         *
         * @sa medianBlur, jointBilateralFilter
         */
        public static void weightedMedianFilter(Mat joint, Mat src, Mat dst, int r, double sigma, int weightType)
        {
            if (joint != null) joint.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_weightedMedianFilter_11(joint.nativeObj, src.nativeObj, dst.nativeObj, r, sigma, weightType);


        }

        /**
         * @brief   Applies weighted median filter to an image.
         *
         * For more details about this implementation, please see @cite zhang2014100+
         *
         * @param   joint       Joint 8-bit, 1-channel or 3-channel image.
         * @param   src         Source 8-bit or floating-point, 1-channel or 3-channel image.
         * @param   dst         Destination image.
         * @param   r           Radius of filtering kernel, should be a positive integer.
         * @param   sigma       Filter range standard deviation for the joint image.
         * @param   weightType  weightType The type of weight definition, see WMFWeightType
         * @param   mask        A 0-1 mask that has the same size with I. This mask is used to ignore the effect of some pixels. If the pixel value on mask is 0,
         *                           the pixel will be ignored when maintaining the joint-histogram. This is useful for applications like optical flow occlusion handling.
         *
         * @sa medianBlur, jointBilateralFilter
         */
        public static void weightedMedianFilter(Mat joint, Mat src, Mat dst, int r, double sigma)
        {
            if (joint != null) joint.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_weightedMedianFilter_12(joint.nativeObj, src.nativeObj, dst.nativeObj, r, sigma);


        }

        /**
         * @brief   Applies weighted median filter to an image.
         *
         * For more details about this implementation, please see @cite zhang2014100+
         *
         * @param   joint       Joint 8-bit, 1-channel or 3-channel image.
         * @param   src         Source 8-bit or floating-point, 1-channel or 3-channel image.
         * @param   dst         Destination image.
         * @param   r           Radius of filtering kernel, should be a positive integer.
         * @param   sigma       Filter range standard deviation for the joint image.
         * @param   weightType  weightType The type of weight definition, see WMFWeightType
         * @param   mask        A 0-1 mask that has the same size with I. This mask is used to ignore the effect of some pixels. If the pixel value on mask is 0,
         *                           the pixel will be ignored when maintaining the joint-histogram. This is useful for applications like optical flow occlusion handling.
         *
         * @sa medianBlur, jointBilateralFilter
         */
        public static void weightedMedianFilter(Mat joint, Mat src, Mat dst, int r)
        {
            if (joint != null) joint.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_Ximgproc_weightedMedianFilter_13(joint.nativeObj, src.nativeObj, dst.nativeObj, r);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::ximgproc::niBlackThreshold(Mat _src, Mat& _dst, double maxValue, int type, int blockSize, double k, int binarizationMethod = BINARIZATION_NIBLACK, double r = 128)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_niBlackThreshold_10(IntPtr _src_nativeObj, IntPtr _dst_nativeObj, double maxValue, int type, int blockSize, double k, int binarizationMethod, double r);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_niBlackThreshold_11(IntPtr _src_nativeObj, IntPtr _dst_nativeObj, double maxValue, int type, int blockSize, double k, int binarizationMethod);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_niBlackThreshold_12(IntPtr _src_nativeObj, IntPtr _dst_nativeObj, double maxValue, int type, int blockSize, double k);

        // C++:  void cv::ximgproc::thinning(Mat src, Mat& dst, int thinningType = THINNING_ZHANGSUEN)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_thinning_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int thinningType);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_thinning_11(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::ximgproc::anisotropicDiffusion(Mat src, Mat& dst, float alpha, float K, int niters)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_anisotropicDiffusion_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, float alpha, float K, int niters);

        // C++:  void cv::ximgproc::createQuaternionImage(Mat img, Mat& qimg)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_createQuaternionImage_10(IntPtr img_nativeObj, IntPtr qimg_nativeObj);

        // C++:  void cv::ximgproc::qconj(Mat qimg, Mat& qcimg)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_qconj_10(IntPtr qimg_nativeObj, IntPtr qcimg_nativeObj);

        // C++:  void cv::ximgproc::qunitary(Mat qimg, Mat& qnimg)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_qunitary_10(IntPtr qimg_nativeObj, IntPtr qnimg_nativeObj);

        // C++:  void cv::ximgproc::qmultiply(Mat src1, Mat src2, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_qmultiply_10(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::ximgproc::qdft(Mat img, Mat& qimg, int flags, bool sideLeft)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_qdft_10(IntPtr img_nativeObj, IntPtr qimg_nativeObj, int flags, [MarshalAs(UnmanagedType.U1)] bool sideLeft);

        // C++:  void cv::ximgproc::colorMatchTemplate(Mat img, Mat templ, Mat& result)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_colorMatchTemplate_10(IntPtr img_nativeObj, IntPtr templ_nativeObj, IntPtr result_nativeObj);

        // C++:  void cv::ximgproc::GradientDericheY(Mat op, Mat& dst, double alpha, double omega)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_GradientDericheY_10(IntPtr op_nativeObj, IntPtr dst_nativeObj, double alpha, double omega);

        // C++:  void cv::ximgproc::GradientDericheX(Mat op, Mat& dst, double alpha, double omega)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_GradientDericheX_10(IntPtr op_nativeObj, IntPtr dst_nativeObj, double alpha, double omega);

        // C++:  Ptr_DisparityWLSFilter cv::ximgproc::createDisparityWLSFilter(Ptr_StereoMatcher matcher_left)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createDisparityWLSFilter_10(IntPtr matcher_left_nativeObj);

        // C++:  Ptr_StereoMatcher cv::ximgproc::createRightMatcher(Ptr_StereoMatcher matcher_left)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createRightMatcher_10(IntPtr matcher_left_nativeObj);

        // C++:  Ptr_DisparityWLSFilter cv::ximgproc::createDisparityWLSFilterGeneric(bool use_confidence)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createDisparityWLSFilterGeneric_10([MarshalAs(UnmanagedType.U1)] bool use_confidence);

        // C++:  int cv::ximgproc::readGT(String src_path, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern int ximgproc_Ximgproc_readGT_10(string src_path, IntPtr dst_nativeObj);

        // C++:  double cv::ximgproc::computeMSE(Mat GT, Mat src, Rect ROI)
        [DllImport(LIBNAME)]
        private static extern double ximgproc_Ximgproc_computeMSE_10(IntPtr GT_nativeObj, IntPtr src_nativeObj, int ROI_x, int ROI_y, int ROI_width, int ROI_height);

        // C++:  double cv::ximgproc::computeBadPixelPercent(Mat GT, Mat src, Rect ROI, int thresh = 24)
        [DllImport(LIBNAME)]
        private static extern double ximgproc_Ximgproc_computeBadPixelPercent_10(IntPtr GT_nativeObj, IntPtr src_nativeObj, int ROI_x, int ROI_y, int ROI_width, int ROI_height, int thresh);
        [DllImport(LIBNAME)]
        private static extern double ximgproc_Ximgproc_computeBadPixelPercent_11(IntPtr GT_nativeObj, IntPtr src_nativeObj, int ROI_x, int ROI_y, int ROI_width, int ROI_height);

        // C++:  void cv::ximgproc::getDisparityVis(Mat src, Mat& dst, double scale = 1.0)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_getDisparityVis_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, double scale);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_getDisparityVis_11(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  Ptr_EdgeBoxes cv::ximgproc::createEdgeBoxes(float alpha = 0.65f, float beta = 0.75f, float eta = 1, float minScore = 0.01f, int maxBoxes = 10000, float edgeMinMag = 0.1f, float edgeMergeThr = 0.5f, float clusterMinMag = 0.5f, float maxAspectRatio = 3, float minBoxArea = 1000, float gamma = 2, float kappa = 1.5f)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_10(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio, float minBoxArea, float gamma, float kappa);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_11(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio, float minBoxArea, float gamma);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_12(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio, float minBoxArea);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_13(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_14(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_15(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_16(float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_17(float alpha, float beta, float eta, float minScore, int maxBoxes);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_18(float alpha, float beta, float eta, float minScore);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_19(float alpha, float beta, float eta);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_110(float alpha, float beta);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_111(float alpha);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_112();

        // C++:  void cv::ximgproc::edgePreservingFilter(Mat src, Mat& dst, int d, double threshold)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_edgePreservingFilter_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double threshold);

        // C++:  Ptr_EdgeDrawing cv::ximgproc::createEdgeDrawing()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeDrawing_10();

        // C++:  Ptr_DTFilter cv::ximgproc::createDTFilter(Mat guide, double sigmaSpatial, double sigmaColor, int mode = DTF_NC, int numIters = 3)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createDTFilter_10(IntPtr guide_nativeObj, double sigmaSpatial, double sigmaColor, int mode, int numIters);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createDTFilter_11(IntPtr guide_nativeObj, double sigmaSpatial, double sigmaColor, int mode);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createDTFilter_12(IntPtr guide_nativeObj, double sigmaSpatial, double sigmaColor);

        // C++:  void cv::ximgproc::dtFilter(Mat guide, Mat src, Mat& dst, double sigmaSpatial, double sigmaColor, int mode = DTF_NC, int numIters = 3)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_dtFilter_10(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigmaSpatial, double sigmaColor, int mode, int numIters);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_dtFilter_11(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigmaSpatial, double sigmaColor, int mode);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_dtFilter_12(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigmaSpatial, double sigmaColor);

        // C++:  Ptr_GuidedFilter cv::ximgproc::createGuidedFilter(Mat guide, int radius, double eps)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createGuidedFilter_10(IntPtr guide_nativeObj, int radius, double eps);

        // C++:  void cv::ximgproc::guidedFilter(Mat guide, Mat src, Mat& dst, int radius, double eps, int dDepth = -1)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_guidedFilter_10(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int radius, double eps, int dDepth);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_guidedFilter_11(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int radius, double eps);

        // C++:  Ptr_AdaptiveManifoldFilter cv::ximgproc::createAMFilter(double sigma_s, double sigma_r, bool adjust_outliers = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createAMFilter_10(double sigma_s, double sigma_r, [MarshalAs(UnmanagedType.U1)] bool adjust_outliers);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createAMFilter_11(double sigma_s, double sigma_r);

        // C++:  void cv::ximgproc::amFilter(Mat joint, Mat src, Mat& dst, double sigma_s, double sigma_r, bool adjust_outliers = false)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_amFilter_10(IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigma_s, double sigma_r, [MarshalAs(UnmanagedType.U1)] bool adjust_outliers);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_amFilter_11(IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigma_s, double sigma_r);

        // C++:  void cv::ximgproc::jointBilateralFilter(Mat joint, Mat src, Mat& dst, int d, double sigmaColor, double sigmaSpace, int borderType = BORDER_DEFAULT)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_jointBilateralFilter_10(IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace, int borderType);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_jointBilateralFilter_11(IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace);

        // C++:  void cv::ximgproc::bilateralTextureFilter(Mat src, Mat& dst, int fr = 3, int numIter = 1, double sigmaAlpha = -1., double sigmaAvg = -1.)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_bilateralTextureFilter_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int fr, int numIter, double sigmaAlpha, double sigmaAvg);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_bilateralTextureFilter_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, int fr, int numIter, double sigmaAlpha);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_bilateralTextureFilter_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, int fr, int numIter);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_bilateralTextureFilter_13(IntPtr src_nativeObj, IntPtr dst_nativeObj, int fr);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_bilateralTextureFilter_14(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::ximgproc::rollingGuidanceFilter(Mat src, Mat& dst, int d = -1, double sigmaColor = 25, double sigmaSpace = 3, int numOfIter = 4, int borderType = BORDER_DEFAULT)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace, int numOfIter, int borderType);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace, int numOfIter);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_13(IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_14(IntPtr src_nativeObj, IntPtr dst_nativeObj, int d);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_15(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  Ptr_FastBilateralSolverFilter cv::ximgproc::createFastBilateralSolverFilter(Mat guide, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda = 128.0, int num_iter = 25, double max_tol = 1e-5)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastBilateralSolverFilter_10(IntPtr guide_nativeObj, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda, int num_iter, double max_tol);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastBilateralSolverFilter_11(IntPtr guide_nativeObj, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda, int num_iter);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastBilateralSolverFilter_12(IntPtr guide_nativeObj, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastBilateralSolverFilter_13(IntPtr guide_nativeObj, double sigma_spatial, double sigma_luma, double sigma_chroma);

        // C++:  void cv::ximgproc::fastBilateralSolverFilter(Mat guide, Mat src, Mat confidence, Mat& dst, double sigma_spatial = 8, double sigma_luma = 8, double sigma_chroma = 8, double lambda = 128.0, int num_iter = 25, double max_tol = 1e-5)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastBilateralSolverFilter_10(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr confidence_nativeObj, IntPtr dst_nativeObj, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda, int num_iter, double max_tol);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastBilateralSolverFilter_11(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr confidence_nativeObj, IntPtr dst_nativeObj, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda, int num_iter);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastBilateralSolverFilter_12(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr confidence_nativeObj, IntPtr dst_nativeObj, double sigma_spatial, double sigma_luma, double sigma_chroma, double lambda);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastBilateralSolverFilter_13(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr confidence_nativeObj, IntPtr dst_nativeObj, double sigma_spatial, double sigma_luma, double sigma_chroma);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastBilateralSolverFilter_14(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr confidence_nativeObj, IntPtr dst_nativeObj, double sigma_spatial, double sigma_luma);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastBilateralSolverFilter_15(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr confidence_nativeObj, IntPtr dst_nativeObj, double sigma_spatial);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastBilateralSolverFilter_16(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr confidence_nativeObj, IntPtr dst_nativeObj);

        // C++:  Ptr_FastGlobalSmootherFilter cv::ximgproc::createFastGlobalSmootherFilter(Mat guide, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastGlobalSmootherFilter_10(IntPtr guide_nativeObj, double lambda, double sigma_color, double lambda_attenuation, int num_iter);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastGlobalSmootherFilter_11(IntPtr guide_nativeObj, double lambda, double sigma_color, double lambda_attenuation);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastGlobalSmootherFilter_12(IntPtr guide_nativeObj, double lambda, double sigma_color);

        // C++:  void cv::ximgproc::fastGlobalSmootherFilter(Mat guide, Mat src, Mat& dst, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastGlobalSmootherFilter_10(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double lambda, double sigma_color, double lambda_attenuation, int num_iter);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastGlobalSmootherFilter_11(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double lambda, double sigma_color, double lambda_attenuation);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastGlobalSmootherFilter_12(IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double lambda, double sigma_color);

        // C++:  void cv::ximgproc::l0Smooth(Mat src, Mat& dst, double lambda = 0.02, double kappa = 2.0)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_l0Smooth_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, double lambda, double kappa);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_l0Smooth_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, double lambda);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_l0Smooth_12(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::ximgproc::covarianceEstimation(Mat src, Mat& dst, int windowRows, int windowCols)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_covarianceEstimation_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int windowRows, int windowCols);

        // C++:  void cv::ximgproc::FastHoughTransform(Mat src, Mat& dst, int dstMatDepth, int angleRange = ARO_315_135, int op = FHT_ADD, int makeSkew = HDO_DESKEW)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_FastHoughTransform_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int dstMatDepth, int angleRange, int op, int makeSkew);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_FastHoughTransform_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, int dstMatDepth, int angleRange, int op);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_FastHoughTransform_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, int dstMatDepth, int angleRange);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_FastHoughTransform_13(IntPtr src_nativeObj, IntPtr dst_nativeObj, int dstMatDepth);

        // C++:  Ptr_FastLineDetector cv::ximgproc::createFastLineDetector(int length_threshold = 10, float distance_threshold = 1.414213562f, double canny_th1 = 50.0, double canny_th2 = 50.0, int canny_aperture_size = 3, bool do_merge = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastLineDetector_10(int length_threshold, float distance_threshold, double canny_th1, double canny_th2, int canny_aperture_size, [MarshalAs(UnmanagedType.U1)] bool do_merge);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastLineDetector_11(int length_threshold, float distance_threshold, double canny_th1, double canny_th2, int canny_aperture_size);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastLineDetector_12(int length_threshold, float distance_threshold, double canny_th1, double canny_th2);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastLineDetector_13(int length_threshold, float distance_threshold, double canny_th1);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastLineDetector_14(int length_threshold, float distance_threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastLineDetector_15(int length_threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastLineDetector_16();

        // C++:  void cv::ximgproc::findEllipses(Mat image, Mat& ellipses, float scoreThreshold = 0.7f, float reliabilityThreshold = 0.5f, float centerDistanceThreshold = 0.05f)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_findEllipses_10(IntPtr image_nativeObj, IntPtr ellipses_nativeObj, float scoreThreshold, float reliabilityThreshold, float centerDistanceThreshold);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_findEllipses_11(IntPtr image_nativeObj, IntPtr ellipses_nativeObj, float scoreThreshold, float reliabilityThreshold);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_findEllipses_12(IntPtr image_nativeObj, IntPtr ellipses_nativeObj, float scoreThreshold);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_findEllipses_13(IntPtr image_nativeObj, IntPtr ellipses_nativeObj);

        // C++:  void cv::ximgproc::fourierDescriptor(Mat src, Mat& dst, int nbElt = -1, int nbFD = -1)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fourierDescriptor_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int nbElt, int nbFD);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fourierDescriptor_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, int nbElt);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fourierDescriptor_12(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::ximgproc::transformFD(Mat src, Mat t, Mat& dst, bool fdContour = true)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_transformFD_10(IntPtr src_nativeObj, IntPtr t_nativeObj, IntPtr dst_nativeObj, [MarshalAs(UnmanagedType.U1)] bool fdContour);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_transformFD_11(IntPtr src_nativeObj, IntPtr t_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::ximgproc::contourSampling(Mat src, Mat& _out, int nbElt)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_contourSampling_10(IntPtr src_nativeObj, IntPtr _out_nativeObj, int nbElt);

        // C++:  Ptr_ContourFitting cv::ximgproc::createContourFitting(int ctr = 1024, int fd = 16)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createContourFitting_10(int ctr, int fd);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createContourFitting_11(int ctr);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createContourFitting_12();

        // C++:  Ptr_SuperpixelLSC cv::ximgproc::createSuperpixelLSC(Mat image, int region_size = 10, float ratio = 0.075f)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelLSC_10(IntPtr image_nativeObj, int region_size, float ratio);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelLSC_11(IntPtr image_nativeObj, int region_size);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelLSC_12(IntPtr image_nativeObj);

        // C++:  void cv::ximgproc::PeiLinNormalization(Mat I, Mat& T)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_PeiLinNormalization_10(IntPtr I_nativeObj, IntPtr T_nativeObj);

        // C++:  void cv::ximgproc::RadonTransform(Mat src, Mat& dst, double theta = 1, double start_angle = 0, double end_angle = 180, bool crop = false, bool norm = false)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_RadonTransform_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, double theta, double start_angle, double end_angle, [MarshalAs(UnmanagedType.U1)] bool crop, [MarshalAs(UnmanagedType.U1)] bool norm);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_RadonTransform_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, double theta, double start_angle, double end_angle, [MarshalAs(UnmanagedType.U1)] bool crop);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_RadonTransform_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, double theta, double start_angle, double end_angle);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_RadonTransform_13(IntPtr src_nativeObj, IntPtr dst_nativeObj, double theta, double start_angle);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_RadonTransform_14(IntPtr src_nativeObj, IntPtr dst_nativeObj, double theta);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_RadonTransform_15(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  Ptr_ScanSegment cv::ximgproc::createScanSegment(int image_width, int image_height, int num_superpixels, int slices = 8, bool merge_small = true)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createScanSegment_10(int image_width, int image_height, int num_superpixels, int slices, [MarshalAs(UnmanagedType.U1)] bool merge_small);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createScanSegment_11(int image_width, int image_height, int num_superpixels, int slices);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createScanSegment_12(int image_width, int image_height, int num_superpixels);

        // C++:  Ptr_SuperpixelSEEDS cv::ximgproc::createSuperpixelSEEDS(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior = 2, int histogram_bins = 5, bool double_step = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSEEDS_10(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior, int histogram_bins, [MarshalAs(UnmanagedType.U1)] bool double_step);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSEEDS_11(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior, int histogram_bins);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSEEDS_12(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSEEDS_13(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels);

        // C++:  Ptr_GraphSegmentation cv::ximgproc::segmentation::createGraphSegmentation(double sigma = 0.5, float k = 300, int min_size = 100)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createGraphSegmentation_10(double sigma, float k, int min_size);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createGraphSegmentation_11(double sigma, float k);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createGraphSegmentation_12(double sigma);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createGraphSegmentation_13();

        // C++:  Ptr_SelectiveSearchSegmentationStrategyColor cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyColor()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyColor_10();

        // C++:  Ptr_SelectiveSearchSegmentationStrategySize cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategySize()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategySize_10();

        // C++:  Ptr_SelectiveSearchSegmentationStrategyTexture cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyTexture()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyTexture_10();

        // C++:  Ptr_SelectiveSearchSegmentationStrategyFill cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyFill()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyFill_10();

        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_10();

        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_11(IntPtr s1_nativeObj);

        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_12(IntPtr s1_nativeObj, IntPtr s2_nativeObj);

        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_13(IntPtr s1_nativeObj, IntPtr s2_nativeObj, IntPtr s3_nativeObj);

        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple cv::ximgproc::segmentation::createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3, Ptr_SelectiveSearchSegmentationStrategy s4)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_14(IntPtr s1_nativeObj, IntPtr s2_nativeObj, IntPtr s3_nativeObj, IntPtr s4_nativeObj);

        // C++:  Ptr_SelectiveSearchSegmentation cv::ximgproc::segmentation::createSelectiveSearchSegmentation()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentation_10();

        // C++:  Ptr_SuperpixelSLIC cv::ximgproc::createSuperpixelSLIC(Mat image, int algorithm = SLICO, int region_size = 10, float ruler = 10.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSLIC_10(IntPtr image_nativeObj, int algorithm, int region_size, float ruler);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSLIC_11(IntPtr image_nativeObj, int algorithm, int region_size);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSLIC_12(IntPtr image_nativeObj, int algorithm);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSLIC_13(IntPtr image_nativeObj);

        // C++:  Ptr_EdgeAwareInterpolator cv::ximgproc::createEdgeAwareInterpolator()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeAwareInterpolator_10();

        // C++:  Ptr_RICInterpolator cv::ximgproc::createRICInterpolator()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createRICInterpolator_10();

        // C++:  Ptr_RFFeatureGetter cv::ximgproc::createRFFeatureGetter()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createRFFeatureGetter_10();

        // C++:  Ptr_StructuredEdgeDetection cv::ximgproc::createStructuredEdgeDetection(String model, Ptr_RFFeatureGetter howToGetFeatures = Ptr<RFFeatureGetter>())
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createStructuredEdgeDetection_10(string model, IntPtr howToGetFeatures_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createStructuredEdgeDetection_11(string model);

        // C++:  void cv::ximgproc::weightedMedianFilter(Mat joint, Mat src, Mat& dst, int r, double sigma = 25.5, int weightType = WMF_EXP, Mat mask = Mat())
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_weightedMedianFilter_10(IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int r, double sigma, int weightType, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_weightedMedianFilter_11(IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int r, double sigma, int weightType);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_weightedMedianFilter_12(IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int r, double sigma);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_weightedMedianFilter_13(IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int r);

    }
}
