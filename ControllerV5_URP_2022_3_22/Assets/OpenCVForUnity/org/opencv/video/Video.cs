
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{
    // C++: class Video


    public class Video
    {

        private const int CV_LKFLOW_INITIAL_GUESSES = 4;
        private const int CV_LKFLOW_GET_MIN_EIGENVALS = 8;
        // C++: enum <unnamed>
        public const int OPTFLOW_USE_INITIAL_FLOW = 4;
        public const int OPTFLOW_LK_GET_MIN_EIGENVALS = 8;
        public const int OPTFLOW_FARNEBACK_GAUSSIAN = 256;
        public const int MOTION_TRANSLATION = 0;
        public const int MOTION_EUCLIDEAN = 1;
        public const int MOTION_AFFINE = 2;
        public const int MOTION_HOMOGRAPHY = 3;
        // C++: enum cv.detail.TrackerSamplerCSC.MODE
        public const int TrackerSamplerCSC_MODE_INIT_POS = 1;
        public const int TrackerSamplerCSC_MODE_INIT_NEG = 2;
        public const int TrackerSamplerCSC_MODE_TRACK_POS = 3;
        public const int TrackerSamplerCSC_MODE_TRACK_NEG = 4;
        public const int TrackerSamplerCSC_MODE_DETECT = 5;
        //
        // C++:  Ptr_BackgroundSubtractorMOG2 cv::createBackgroundSubtractorMOG2(int history = 500, double varThreshold = 16, bool detectShadows = true)
        //

        /**
         @brief Creates MOG2 Background Subtractor
         
         @param history Length of the history.
         @param varThreshold Threshold on the squared Mahalanobis distance between the pixel and the model
         to decide whether a pixel is well described by the background model. This parameter does not
         affect the background update.
         @param detectShadows If true, the algorithm will detect shadows and mark them. It decreases the
         speed a bit, so if you do not need this feature, set the parameter to false.
         */
        public static BackgroundSubtractorMOG2 createBackgroundSubtractorMOG2(int history, double varThreshold, bool detectShadows)
        {


            return BackgroundSubtractorMOG2.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_Video_createBackgroundSubtractorMOG2_10(history, varThreshold, detectShadows)));


        }

        /**
         @brief Creates MOG2 Background Subtractor
         
         @param history Length of the history.
         @param varThreshold Threshold on the squared Mahalanobis distance between the pixel and the model
         to decide whether a pixel is well described by the background model. This parameter does not
         affect the background update.
         @param detectShadows If true, the algorithm will detect shadows and mark them. It decreases the
         speed a bit, so if you do not need this feature, set the parameter to false.
         */
        public static BackgroundSubtractorMOG2 createBackgroundSubtractorMOG2(int history, double varThreshold)
        {


            return BackgroundSubtractorMOG2.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_Video_createBackgroundSubtractorMOG2_11(history, varThreshold)));


        }

        /**
         @brief Creates MOG2 Background Subtractor
         
         @param history Length of the history.
         @param varThreshold Threshold on the squared Mahalanobis distance between the pixel and the model
         to decide whether a pixel is well described by the background model. This parameter does not
         affect the background update.
         @param detectShadows If true, the algorithm will detect shadows and mark them. It decreases the
         speed a bit, so if you do not need this feature, set the parameter to false.
         */
        public static BackgroundSubtractorMOG2 createBackgroundSubtractorMOG2(int history)
        {


            return BackgroundSubtractorMOG2.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_Video_createBackgroundSubtractorMOG2_12(history)));


        }

        /**
         @brief Creates MOG2 Background Subtractor
         
         @param history Length of the history.
         @param varThreshold Threshold on the squared Mahalanobis distance between the pixel and the model
         to decide whether a pixel is well described by the background model. This parameter does not
         affect the background update.
         @param detectShadows If true, the algorithm will detect shadows and mark them. It decreases the
         speed a bit, so if you do not need this feature, set the parameter to false.
         */
        public static BackgroundSubtractorMOG2 createBackgroundSubtractorMOG2()
        {


            return BackgroundSubtractorMOG2.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_Video_createBackgroundSubtractorMOG2_13()));


        }


        //
        // C++:  Ptr_BackgroundSubtractorKNN cv::createBackgroundSubtractorKNN(int history = 500, double dist2Threshold = 400.0, bool detectShadows = true)
        //

        /**
         @brief Creates KNN Background Subtractor
         
         @param history Length of the history.
         @param dist2Threshold Threshold on the squared distance between the pixel and the sample to decide
         whether a pixel is close to that sample. This parameter does not affect the background update.
         @param detectShadows If true, the algorithm will detect shadows and mark them. It decreases the
         speed a bit, so if you do not need this feature, set the parameter to false.
         */
        public static BackgroundSubtractorKNN createBackgroundSubtractorKNN(int history, double dist2Threshold, bool detectShadows)
        {


            return BackgroundSubtractorKNN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_Video_createBackgroundSubtractorKNN_10(history, dist2Threshold, detectShadows)));


        }

        /**
         @brief Creates KNN Background Subtractor
         
         @param history Length of the history.
         @param dist2Threshold Threshold on the squared distance between the pixel and the sample to decide
         whether a pixel is close to that sample. This parameter does not affect the background update.
         @param detectShadows If true, the algorithm will detect shadows and mark them. It decreases the
         speed a bit, so if you do not need this feature, set the parameter to false.
         */
        public static BackgroundSubtractorKNN createBackgroundSubtractorKNN(int history, double dist2Threshold)
        {


            return BackgroundSubtractorKNN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_Video_createBackgroundSubtractorKNN_11(history, dist2Threshold)));


        }

        /**
         @brief Creates KNN Background Subtractor
         
         @param history Length of the history.
         @param dist2Threshold Threshold on the squared distance between the pixel and the sample to decide
         whether a pixel is close to that sample. This parameter does not affect the background update.
         @param detectShadows If true, the algorithm will detect shadows and mark them. It decreases the
         speed a bit, so if you do not need this feature, set the parameter to false.
         */
        public static BackgroundSubtractorKNN createBackgroundSubtractorKNN(int history)
        {


            return BackgroundSubtractorKNN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_Video_createBackgroundSubtractorKNN_12(history)));


        }

        /**
         @brief Creates KNN Background Subtractor
         
         @param history Length of the history.
         @param dist2Threshold Threshold on the squared distance between the pixel and the sample to decide
         whether a pixel is close to that sample. This parameter does not affect the background update.
         @param detectShadows If true, the algorithm will detect shadows and mark them. It decreases the
         speed a bit, so if you do not need this feature, set the parameter to false.
         */
        public static BackgroundSubtractorKNN createBackgroundSubtractorKNN()
        {


            return BackgroundSubtractorKNN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_Video_createBackgroundSubtractorKNN_13()));


        }


        //
        // C++:  RotatedRect cv::CamShift(Mat probImage, Rect& window, TermCriteria criteria)
        //

        /**
         @brief Finds an object center, size, and orientation.
         
         @param probImage Back projection of the object histogram. See calcBackProject.
         @param window Initial search window.
         @param criteria Stop criteria for the underlying meanShift.
         returns
         (in old interfaces) Number of iterations CAMSHIFT took to converge
         The function implements the CAMSHIFT object tracking algorithm @cite Bradski98 . First, it finds an
         object center using meanShift and then adjusts the window size and finds the optimal rotation. The
         function returns the rotated rectangle structure that includes the object position, size, and
         orientation. The next position of the search window can be obtained with RotatedRect::boundingRect()
         
         See the OpenCV sample camshiftdemo.c that tracks colored objects.
         
         @note
         -   (Python) A sample explaining the camshift tracking algorithm can be found at
             opencv_source_code/samples/python/camshift.py
         */
        public static RotatedRect CamShift(Mat probImage, Rect window, TermCriteria criteria)
        {
            if (probImage != null) probImage.ThrowIfDisposed();
            double[] window_out = new double[4];
            double[] tmpArray = new double[5];
            video_Video_CamShift_10(probImage.nativeObj, window.x, window.y, window.width, window.height, window_out, criteria.type, criteria.maxCount, criteria.epsilon, tmpArray);
            RotatedRect retVal = new RotatedRect(tmpArray);
            if (window != null) { window.x = (int)window_out[0]; window.y = (int)window_out[1]; window.width = (int)window_out[2]; window.height = (int)window_out[3]; }
            return retVal;
        }


        //
        // C++:  int cv::meanShift(Mat probImage, Rect& window, TermCriteria criteria)
        //

        /**
         @brief Finds an object on a back projection image.
         
         @param probImage Back projection of the object histogram. See calcBackProject for details.
         @param window Initial search window.
         @param criteria Stop criteria for the iterative search algorithm.
         returns
         :   Number of iterations CAMSHIFT took to converge.
         The function implements the iterative object search algorithm. It takes the input back projection of
         an object and the initial position. The mass center in window of the back projection image is
         computed and the search window center shifts to the mass center. The procedure is repeated until the
         specified number of iterations criteria.maxCount is done or until the window center shifts by less
         than criteria.epsilon. The algorithm is used inside CamShift and, unlike CamShift , the search
         window size or orientation do not change during the search. You can simply pass the output of
         calcBackProject to this function. But better results can be obtained if you pre-filter the back
         projection and remove the noise. For example, you can do this by retrieving connected components
         with findContours , throwing away contours with small area ( contourArea ), and rendering the
         remaining contours with drawContours.
         */
        public static int meanShift(Mat probImage, Rect window, TermCriteria criteria)
        {
            if (probImage != null) probImage.ThrowIfDisposed();
            double[] window_out = new double[4];
            int retVal = video_Video_meanShift_10(probImage.nativeObj, window.x, window.y, window.width, window.height, window_out, criteria.type, criteria.maxCount, criteria.epsilon);
            if (window != null) { window.x = (int)window_out[0]; window.y = (int)window_out[1]; window.width = (int)window_out[2]; window.height = (int)window_out[3]; }
            return retVal;
        }


        //
        // C++:  int cv::buildOpticalFlowPyramid(Mat img, vector_Mat& pyramid, Size winSize, int maxLevel, bool withDerivatives = true, int pyrBorder = BORDER_REFLECT_101, int derivBorder = BORDER_CONSTANT, bool tryReuseInputImage = true)
        //

        /**
         @brief Constructs the image pyramid which can be passed to calcOpticalFlowPyrLK.
         
         @param img 8-bit input image.
         @param pyramid output pyramid.
         @param winSize window size of optical flow algorithm. Must be not less than winSize argument of
         calcOpticalFlowPyrLK. It is needed to calculate required padding for pyramid levels.
         @param maxLevel 0-based maximal pyramid level number.
         @param withDerivatives set to precompute gradients for the every pyramid level. If pyramid is
         constructed without the gradients then calcOpticalFlowPyrLK will calculate them internally.
         @param pyrBorder the border mode for pyramid layers.
         @param derivBorder the border mode for gradients.
         @param tryReuseInputImage put ROI of input image into the pyramid if possible. You can pass false
         to force data copying.
         @return number of levels in constructed pyramid. Can be less than maxLevel.
         */
        public static int buildOpticalFlowPyramid(Mat img, List<Mat> pyramid, Size winSize, int maxLevel, bool withDerivatives, int pyrBorder, int derivBorder, bool tryReuseInputImage)
        {
            if (img != null) img.ThrowIfDisposed();
            Mat pyramid_mat = new Mat();
            int retVal = video_Video_buildOpticalFlowPyramid_10(img.nativeObj, pyramid_mat.nativeObj, winSize.width, winSize.height, maxLevel, withDerivatives, pyrBorder, derivBorder, tryReuseInputImage);
            Converters.Mat_to_vector_Mat(pyramid_mat, pyramid);
            pyramid_mat.release();
            return retVal;
        }

        /**
         @brief Constructs the image pyramid which can be passed to calcOpticalFlowPyrLK.
         
         @param img 8-bit input image.
         @param pyramid output pyramid.
         @param winSize window size of optical flow algorithm. Must be not less than winSize argument of
         calcOpticalFlowPyrLK. It is needed to calculate required padding for pyramid levels.
         @param maxLevel 0-based maximal pyramid level number.
         @param withDerivatives set to precompute gradients for the every pyramid level. If pyramid is
         constructed without the gradients then calcOpticalFlowPyrLK will calculate them internally.
         @param pyrBorder the border mode for pyramid layers.
         @param derivBorder the border mode for gradients.
         @param tryReuseInputImage put ROI of input image into the pyramid if possible. You can pass false
         to force data copying.
         @return number of levels in constructed pyramid. Can be less than maxLevel.
         */
        public static int buildOpticalFlowPyramid(Mat img, List<Mat> pyramid, Size winSize, int maxLevel, bool withDerivatives, int pyrBorder, int derivBorder)
        {
            if (img != null) img.ThrowIfDisposed();
            Mat pyramid_mat = new Mat();
            int retVal = video_Video_buildOpticalFlowPyramid_11(img.nativeObj, pyramid_mat.nativeObj, winSize.width, winSize.height, maxLevel, withDerivatives, pyrBorder, derivBorder);
            Converters.Mat_to_vector_Mat(pyramid_mat, pyramid);
            pyramid_mat.release();
            return retVal;
        }

        /**
         @brief Constructs the image pyramid which can be passed to calcOpticalFlowPyrLK.
         
         @param img 8-bit input image.
         @param pyramid output pyramid.
         @param winSize window size of optical flow algorithm. Must be not less than winSize argument of
         calcOpticalFlowPyrLK. It is needed to calculate required padding for pyramid levels.
         @param maxLevel 0-based maximal pyramid level number.
         @param withDerivatives set to precompute gradients for the every pyramid level. If pyramid is
         constructed without the gradients then calcOpticalFlowPyrLK will calculate them internally.
         @param pyrBorder the border mode for pyramid layers.
         @param derivBorder the border mode for gradients.
         @param tryReuseInputImage put ROI of input image into the pyramid if possible. You can pass false
         to force data copying.
         @return number of levels in constructed pyramid. Can be less than maxLevel.
         */
        public static int buildOpticalFlowPyramid(Mat img, List<Mat> pyramid, Size winSize, int maxLevel, bool withDerivatives, int pyrBorder)
        {
            if (img != null) img.ThrowIfDisposed();
            Mat pyramid_mat = new Mat();
            int retVal = video_Video_buildOpticalFlowPyramid_12(img.nativeObj, pyramid_mat.nativeObj, winSize.width, winSize.height, maxLevel, withDerivatives, pyrBorder);
            Converters.Mat_to_vector_Mat(pyramid_mat, pyramid);
            pyramid_mat.release();
            return retVal;
        }

        /**
         @brief Constructs the image pyramid which can be passed to calcOpticalFlowPyrLK.
         
         @param img 8-bit input image.
         @param pyramid output pyramid.
         @param winSize window size of optical flow algorithm. Must be not less than winSize argument of
         calcOpticalFlowPyrLK. It is needed to calculate required padding for pyramid levels.
         @param maxLevel 0-based maximal pyramid level number.
         @param withDerivatives set to precompute gradients for the every pyramid level. If pyramid is
         constructed without the gradients then calcOpticalFlowPyrLK will calculate them internally.
         @param pyrBorder the border mode for pyramid layers.
         @param derivBorder the border mode for gradients.
         @param tryReuseInputImage put ROI of input image into the pyramid if possible. You can pass false
         to force data copying.
         @return number of levels in constructed pyramid. Can be less than maxLevel.
         */
        public static int buildOpticalFlowPyramid(Mat img, List<Mat> pyramid, Size winSize, int maxLevel, bool withDerivatives)
        {
            if (img != null) img.ThrowIfDisposed();
            Mat pyramid_mat = new Mat();
            int retVal = video_Video_buildOpticalFlowPyramid_13(img.nativeObj, pyramid_mat.nativeObj, winSize.width, winSize.height, maxLevel, withDerivatives);
            Converters.Mat_to_vector_Mat(pyramid_mat, pyramid);
            pyramid_mat.release();
            return retVal;
        }

        /**
         @brief Constructs the image pyramid which can be passed to calcOpticalFlowPyrLK.
         
         @param img 8-bit input image.
         @param pyramid output pyramid.
         @param winSize window size of optical flow algorithm. Must be not less than winSize argument of
         calcOpticalFlowPyrLK. It is needed to calculate required padding for pyramid levels.
         @param maxLevel 0-based maximal pyramid level number.
         @param withDerivatives set to precompute gradients for the every pyramid level. If pyramid is
         constructed without the gradients then calcOpticalFlowPyrLK will calculate them internally.
         @param pyrBorder the border mode for pyramid layers.
         @param derivBorder the border mode for gradients.
         @param tryReuseInputImage put ROI of input image into the pyramid if possible. You can pass false
         to force data copying.
         @return number of levels in constructed pyramid. Can be less than maxLevel.
         */
        public static int buildOpticalFlowPyramid(Mat img, List<Mat> pyramid, Size winSize, int maxLevel)
        {
            if (img != null) img.ThrowIfDisposed();
            Mat pyramid_mat = new Mat();
            int retVal = video_Video_buildOpticalFlowPyramid_14(img.nativeObj, pyramid_mat.nativeObj, winSize.width, winSize.height, maxLevel);
            Converters.Mat_to_vector_Mat(pyramid_mat, pyramid);
            pyramid_mat.release();
            return retVal;
        }


        //
        // C++:  void cv::calcOpticalFlowPyrLK(Mat prevImg, Mat nextImg, vector_Point2f prevPts, vector_Point2f& nextPts, vector_uchar& status, vector_float& err, Size winSize = Size(21,21), int maxLevel = 3, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 0.01), int flags = 0, double minEigThreshold = 1e-4)
        //

        /**
         @brief Calculates an optical flow for a sparse feature set using the iterative Lucas-Kanade method with
         pyramids.
         
         @param prevImg first 8-bit input image or pyramid constructed by buildOpticalFlowPyramid.
         @param nextImg second input image or pyramid of the same size and the same type as prevImg.
         @param prevPts vector of 2D points for which the flow needs to be found; point coordinates must be
         single-precision floating-point numbers.
         @param nextPts output vector of 2D points (with single-precision floating-point coordinates)
         containing the calculated new positions of input features in the second image; when
         OPTFLOW_USE_INITIAL_FLOW flag is passed, the vector must have the same size as in the input.
         @param status output status vector (of unsigned chars); each element of the vector is set to 1 if
         the flow for the corresponding features has been found, otherwise, it is set to 0.
         @param err output vector of errors; each element of the vector is set to an error for the
         corresponding feature, type of the error measure can be set in flags parameter; if the flow wasn't
         found then the error is not defined (use the status parameter to find such cases).
         @param winSize size of the search window at each pyramid level.
         @param maxLevel 0-based maximal pyramid level number; if set to 0, pyramids are not used (single
         level), if set to 1, two levels are used, and so on; if pyramids are passed to input then
         algorithm will use as many levels as pyramids have but no more than maxLevel.
         @param criteria parameter, specifying the termination criteria of the iterative search algorithm
         (after the specified maximum number of iterations criteria.maxCount or when the search window
         moves by less than criteria.epsilon.
         @param flags operation flags:
          -   **OPTFLOW_USE_INITIAL_FLOW** uses initial estimations, stored in nextPts; if the flag is
              not set, then prevPts is copied to nextPts and is considered the initial estimate.
          -   **OPTFLOW_LK_GET_MIN_EIGENVALS** use minimum eigen values as an error measure (see
              minEigThreshold description); if the flag is not set, then L1 distance between patches
              around the original and a moved point, divided by number of pixels in a window, is used as a
              error measure.
         @param minEigThreshold the algorithm calculates the minimum eigen value of a 2x2 normal matrix of
         optical flow equations (this matrix is called a spatial gradient matrix in @cite Bouguet00), divided
         by number of pixels in a window; if this value is less than minEigThreshold, then a corresponding
         feature is filtered out and its flow is not processed, so it allows to remove bad points and get a
         performance boost.
         
         The function implements a sparse iterative version of the Lucas-Kanade optical flow in pyramids. See
         @cite Bouguet00 . The function is parallelized with the TBB library.
         
         @note Some examples:
         
         -   An example using the Lucas-Kanade optical flow algorithm can be found at
             opencv_source_code/samples/cpp/lkdemo.cpp
         -   (Python) An example using the Lucas-Kanade optical flow algorithm can be found at
             opencv_source_code/samples/python/lk_track.py
         -   (Python) An example using the Lucas-Kanade tracker for homography matching can be found at
             opencv_source_code/samples/python/lk_homography.py
         */
        public static void calcOpticalFlowPyrLK(Mat prevImg, Mat nextImg, MatOfPoint2f prevPts, MatOfPoint2f nextPts, MatOfByte status, MatOfFloat err, Size winSize, int maxLevel, TermCriteria criteria, int flags, double minEigThreshold)
        {
            if (prevImg != null) prevImg.ThrowIfDisposed();
            if (nextImg != null) nextImg.ThrowIfDisposed();
            if (prevPts != null) prevPts.ThrowIfDisposed();
            if (nextPts != null) nextPts.ThrowIfDisposed();
            if (status != null) status.ThrowIfDisposed();
            if (err != null) err.ThrowIfDisposed();
            Mat prevPts_mat = prevPts;
            Mat nextPts_mat = nextPts;
            Mat status_mat = status;
            Mat err_mat = err;
            video_Video_calcOpticalFlowPyrLK_10(prevImg.nativeObj, nextImg.nativeObj, prevPts_mat.nativeObj, nextPts_mat.nativeObj, status_mat.nativeObj, err_mat.nativeObj, winSize.width, winSize.height, maxLevel, criteria.type, criteria.maxCount, criteria.epsilon, flags, minEigThreshold);


        }

        /**
         @brief Calculates an optical flow for a sparse feature set using the iterative Lucas-Kanade method with
         pyramids.
         
         @param prevImg first 8-bit input image or pyramid constructed by buildOpticalFlowPyramid.
         @param nextImg second input image or pyramid of the same size and the same type as prevImg.
         @param prevPts vector of 2D points for which the flow needs to be found; point coordinates must be
         single-precision floating-point numbers.
         @param nextPts output vector of 2D points (with single-precision floating-point coordinates)
         containing the calculated new positions of input features in the second image; when
         OPTFLOW_USE_INITIAL_FLOW flag is passed, the vector must have the same size as in the input.
         @param status output status vector (of unsigned chars); each element of the vector is set to 1 if
         the flow for the corresponding features has been found, otherwise, it is set to 0.
         @param err output vector of errors; each element of the vector is set to an error for the
         corresponding feature, type of the error measure can be set in flags parameter; if the flow wasn't
         found then the error is not defined (use the status parameter to find such cases).
         @param winSize size of the search window at each pyramid level.
         @param maxLevel 0-based maximal pyramid level number; if set to 0, pyramids are not used (single
         level), if set to 1, two levels are used, and so on; if pyramids are passed to input then
         algorithm will use as many levels as pyramids have but no more than maxLevel.
         @param criteria parameter, specifying the termination criteria of the iterative search algorithm
         (after the specified maximum number of iterations criteria.maxCount or when the search window
         moves by less than criteria.epsilon.
         @param flags operation flags:
          -   **OPTFLOW_USE_INITIAL_FLOW** uses initial estimations, stored in nextPts; if the flag is
              not set, then prevPts is copied to nextPts and is considered the initial estimate.
          -   **OPTFLOW_LK_GET_MIN_EIGENVALS** use minimum eigen values as an error measure (see
              minEigThreshold description); if the flag is not set, then L1 distance between patches
              around the original and a moved point, divided by number of pixels in a window, is used as a
              error measure.
         @param minEigThreshold the algorithm calculates the minimum eigen value of a 2x2 normal matrix of
         optical flow equations (this matrix is called a spatial gradient matrix in @cite Bouguet00), divided
         by number of pixels in a window; if this value is less than minEigThreshold, then a corresponding
         feature is filtered out and its flow is not processed, so it allows to remove bad points and get a
         performance boost.
         
         The function implements a sparse iterative version of the Lucas-Kanade optical flow in pyramids. See
         @cite Bouguet00 . The function is parallelized with the TBB library.
         
         @note Some examples:
         
         -   An example using the Lucas-Kanade optical flow algorithm can be found at
             opencv_source_code/samples/cpp/lkdemo.cpp
         -   (Python) An example using the Lucas-Kanade optical flow algorithm can be found at
             opencv_source_code/samples/python/lk_track.py
         -   (Python) An example using the Lucas-Kanade tracker for homography matching can be found at
             opencv_source_code/samples/python/lk_homography.py
         */
        public static void calcOpticalFlowPyrLK(Mat prevImg, Mat nextImg, MatOfPoint2f prevPts, MatOfPoint2f nextPts, MatOfByte status, MatOfFloat err, Size winSize, int maxLevel, TermCriteria criteria, int flags)
        {
            if (prevImg != null) prevImg.ThrowIfDisposed();
            if (nextImg != null) nextImg.ThrowIfDisposed();
            if (prevPts != null) prevPts.ThrowIfDisposed();
            if (nextPts != null) nextPts.ThrowIfDisposed();
            if (status != null) status.ThrowIfDisposed();
            if (err != null) err.ThrowIfDisposed();
            Mat prevPts_mat = prevPts;
            Mat nextPts_mat = nextPts;
            Mat status_mat = status;
            Mat err_mat = err;
            video_Video_calcOpticalFlowPyrLK_11(prevImg.nativeObj, nextImg.nativeObj, prevPts_mat.nativeObj, nextPts_mat.nativeObj, status_mat.nativeObj, err_mat.nativeObj, winSize.width, winSize.height, maxLevel, criteria.type, criteria.maxCount, criteria.epsilon, flags);


        }

        /**
         @brief Calculates an optical flow for a sparse feature set using the iterative Lucas-Kanade method with
         pyramids.
         
         @param prevImg first 8-bit input image or pyramid constructed by buildOpticalFlowPyramid.
         @param nextImg second input image or pyramid of the same size and the same type as prevImg.
         @param prevPts vector of 2D points for which the flow needs to be found; point coordinates must be
         single-precision floating-point numbers.
         @param nextPts output vector of 2D points (with single-precision floating-point coordinates)
         containing the calculated new positions of input features in the second image; when
         OPTFLOW_USE_INITIAL_FLOW flag is passed, the vector must have the same size as in the input.
         @param status output status vector (of unsigned chars); each element of the vector is set to 1 if
         the flow for the corresponding features has been found, otherwise, it is set to 0.
         @param err output vector of errors; each element of the vector is set to an error for the
         corresponding feature, type of the error measure can be set in flags parameter; if the flow wasn't
         found then the error is not defined (use the status parameter to find such cases).
         @param winSize size of the search window at each pyramid level.
         @param maxLevel 0-based maximal pyramid level number; if set to 0, pyramids are not used (single
         level), if set to 1, two levels are used, and so on; if pyramids are passed to input then
         algorithm will use as many levels as pyramids have but no more than maxLevel.
         @param criteria parameter, specifying the termination criteria of the iterative search algorithm
         (after the specified maximum number of iterations criteria.maxCount or when the search window
         moves by less than criteria.epsilon.
         @param flags operation flags:
          -   **OPTFLOW_USE_INITIAL_FLOW** uses initial estimations, stored in nextPts; if the flag is
              not set, then prevPts is copied to nextPts and is considered the initial estimate.
          -   **OPTFLOW_LK_GET_MIN_EIGENVALS** use minimum eigen values as an error measure (see
              minEigThreshold description); if the flag is not set, then L1 distance between patches
              around the original and a moved point, divided by number of pixels in a window, is used as a
              error measure.
         @param minEigThreshold the algorithm calculates the minimum eigen value of a 2x2 normal matrix of
         optical flow equations (this matrix is called a spatial gradient matrix in @cite Bouguet00), divided
         by number of pixels in a window; if this value is less than minEigThreshold, then a corresponding
         feature is filtered out and its flow is not processed, so it allows to remove bad points and get a
         performance boost.
         
         The function implements a sparse iterative version of the Lucas-Kanade optical flow in pyramids. See
         @cite Bouguet00 . The function is parallelized with the TBB library.
         
         @note Some examples:
         
         -   An example using the Lucas-Kanade optical flow algorithm can be found at
             opencv_source_code/samples/cpp/lkdemo.cpp
         -   (Python) An example using the Lucas-Kanade optical flow algorithm can be found at
             opencv_source_code/samples/python/lk_track.py
         -   (Python) An example using the Lucas-Kanade tracker for homography matching can be found at
             opencv_source_code/samples/python/lk_homography.py
         */
        public static void calcOpticalFlowPyrLK(Mat prevImg, Mat nextImg, MatOfPoint2f prevPts, MatOfPoint2f nextPts, MatOfByte status, MatOfFloat err, Size winSize, int maxLevel, TermCriteria criteria)
        {
            if (prevImg != null) prevImg.ThrowIfDisposed();
            if (nextImg != null) nextImg.ThrowIfDisposed();
            if (prevPts != null) prevPts.ThrowIfDisposed();
            if (nextPts != null) nextPts.ThrowIfDisposed();
            if (status != null) status.ThrowIfDisposed();
            if (err != null) err.ThrowIfDisposed();
            Mat prevPts_mat = prevPts;
            Mat nextPts_mat = nextPts;
            Mat status_mat = status;
            Mat err_mat = err;
            video_Video_calcOpticalFlowPyrLK_12(prevImg.nativeObj, nextImg.nativeObj, prevPts_mat.nativeObj, nextPts_mat.nativeObj, status_mat.nativeObj, err_mat.nativeObj, winSize.width, winSize.height, maxLevel, criteria.type, criteria.maxCount, criteria.epsilon);


        }

        /**
         @brief Calculates an optical flow for a sparse feature set using the iterative Lucas-Kanade method with
         pyramids.
         
         @param prevImg first 8-bit input image or pyramid constructed by buildOpticalFlowPyramid.
         @param nextImg second input image or pyramid of the same size and the same type as prevImg.
         @param prevPts vector of 2D points for which the flow needs to be found; point coordinates must be
         single-precision floating-point numbers.
         @param nextPts output vector of 2D points (with single-precision floating-point coordinates)
         containing the calculated new positions of input features in the second image; when
         OPTFLOW_USE_INITIAL_FLOW flag is passed, the vector must have the same size as in the input.
         @param status output status vector (of unsigned chars); each element of the vector is set to 1 if
         the flow for the corresponding features has been found, otherwise, it is set to 0.
         @param err output vector of errors; each element of the vector is set to an error for the
         corresponding feature, type of the error measure can be set in flags parameter; if the flow wasn't
         found then the error is not defined (use the status parameter to find such cases).
         @param winSize size of the search window at each pyramid level.
         @param maxLevel 0-based maximal pyramid level number; if set to 0, pyramids are not used (single
         level), if set to 1, two levels are used, and so on; if pyramids are passed to input then
         algorithm will use as many levels as pyramids have but no more than maxLevel.
         @param criteria parameter, specifying the termination criteria of the iterative search algorithm
         (after the specified maximum number of iterations criteria.maxCount or when the search window
         moves by less than criteria.epsilon.
         @param flags operation flags:
          -   **OPTFLOW_USE_INITIAL_FLOW** uses initial estimations, stored in nextPts; if the flag is
              not set, then prevPts is copied to nextPts and is considered the initial estimate.
          -   **OPTFLOW_LK_GET_MIN_EIGENVALS** use minimum eigen values as an error measure (see
              minEigThreshold description); if the flag is not set, then L1 distance between patches
              around the original and a moved point, divided by number of pixels in a window, is used as a
              error measure.
         @param minEigThreshold the algorithm calculates the minimum eigen value of a 2x2 normal matrix of
         optical flow equations (this matrix is called a spatial gradient matrix in @cite Bouguet00), divided
         by number of pixels in a window; if this value is less than minEigThreshold, then a corresponding
         feature is filtered out and its flow is not processed, so it allows to remove bad points and get a
         performance boost.
         
         The function implements a sparse iterative version of the Lucas-Kanade optical flow in pyramids. See
         @cite Bouguet00 . The function is parallelized with the TBB library.
         
         @note Some examples:
         
         -   An example using the Lucas-Kanade optical flow algorithm can be found at
             opencv_source_code/samples/cpp/lkdemo.cpp
         -   (Python) An example using the Lucas-Kanade optical flow algorithm can be found at
             opencv_source_code/samples/python/lk_track.py
         -   (Python) An example using the Lucas-Kanade tracker for homography matching can be found at
             opencv_source_code/samples/python/lk_homography.py
         */
        public static void calcOpticalFlowPyrLK(Mat prevImg, Mat nextImg, MatOfPoint2f prevPts, MatOfPoint2f nextPts, MatOfByte status, MatOfFloat err, Size winSize, int maxLevel)
        {
            if (prevImg != null) prevImg.ThrowIfDisposed();
            if (nextImg != null) nextImg.ThrowIfDisposed();
            if (prevPts != null) prevPts.ThrowIfDisposed();
            if (nextPts != null) nextPts.ThrowIfDisposed();
            if (status != null) status.ThrowIfDisposed();
            if (err != null) err.ThrowIfDisposed();
            Mat prevPts_mat = prevPts;
            Mat nextPts_mat = nextPts;
            Mat status_mat = status;
            Mat err_mat = err;
            video_Video_calcOpticalFlowPyrLK_13(prevImg.nativeObj, nextImg.nativeObj, prevPts_mat.nativeObj, nextPts_mat.nativeObj, status_mat.nativeObj, err_mat.nativeObj, winSize.width, winSize.height, maxLevel);


        }

        /**
         @brief Calculates an optical flow for a sparse feature set using the iterative Lucas-Kanade method with
         pyramids.
         
         @param prevImg first 8-bit input image or pyramid constructed by buildOpticalFlowPyramid.
         @param nextImg second input image or pyramid of the same size and the same type as prevImg.
         @param prevPts vector of 2D points for which the flow needs to be found; point coordinates must be
         single-precision floating-point numbers.
         @param nextPts output vector of 2D points (with single-precision floating-point coordinates)
         containing the calculated new positions of input features in the second image; when
         OPTFLOW_USE_INITIAL_FLOW flag is passed, the vector must have the same size as in the input.
         @param status output status vector (of unsigned chars); each element of the vector is set to 1 if
         the flow for the corresponding features has been found, otherwise, it is set to 0.
         @param err output vector of errors; each element of the vector is set to an error for the
         corresponding feature, type of the error measure can be set in flags parameter; if the flow wasn't
         found then the error is not defined (use the status parameter to find such cases).
         @param winSize size of the search window at each pyramid level.
         @param maxLevel 0-based maximal pyramid level number; if set to 0, pyramids are not used (single
         level), if set to 1, two levels are used, and so on; if pyramids are passed to input then
         algorithm will use as many levels as pyramids have but no more than maxLevel.
         @param criteria parameter, specifying the termination criteria of the iterative search algorithm
         (after the specified maximum number of iterations criteria.maxCount or when the search window
         moves by less than criteria.epsilon.
         @param flags operation flags:
          -   **OPTFLOW_USE_INITIAL_FLOW** uses initial estimations, stored in nextPts; if the flag is
              not set, then prevPts is copied to nextPts and is considered the initial estimate.
          -   **OPTFLOW_LK_GET_MIN_EIGENVALS** use minimum eigen values as an error measure (see
              minEigThreshold description); if the flag is not set, then L1 distance between patches
              around the original and a moved point, divided by number of pixels in a window, is used as a
              error measure.
         @param minEigThreshold the algorithm calculates the minimum eigen value of a 2x2 normal matrix of
         optical flow equations (this matrix is called a spatial gradient matrix in @cite Bouguet00), divided
         by number of pixels in a window; if this value is less than minEigThreshold, then a corresponding
         feature is filtered out and its flow is not processed, so it allows to remove bad points and get a
         performance boost.
         
         The function implements a sparse iterative version of the Lucas-Kanade optical flow in pyramids. See
         @cite Bouguet00 . The function is parallelized with the TBB library.
         
         @note Some examples:
         
         -   An example using the Lucas-Kanade optical flow algorithm can be found at
             opencv_source_code/samples/cpp/lkdemo.cpp
         -   (Python) An example using the Lucas-Kanade optical flow algorithm can be found at
             opencv_source_code/samples/python/lk_track.py
         -   (Python) An example using the Lucas-Kanade tracker for homography matching can be found at
             opencv_source_code/samples/python/lk_homography.py
         */
        public static void calcOpticalFlowPyrLK(Mat prevImg, Mat nextImg, MatOfPoint2f prevPts, MatOfPoint2f nextPts, MatOfByte status, MatOfFloat err, Size winSize)
        {
            if (prevImg != null) prevImg.ThrowIfDisposed();
            if (nextImg != null) nextImg.ThrowIfDisposed();
            if (prevPts != null) prevPts.ThrowIfDisposed();
            if (nextPts != null) nextPts.ThrowIfDisposed();
            if (status != null) status.ThrowIfDisposed();
            if (err != null) err.ThrowIfDisposed();
            Mat prevPts_mat = prevPts;
            Mat nextPts_mat = nextPts;
            Mat status_mat = status;
            Mat err_mat = err;
            video_Video_calcOpticalFlowPyrLK_14(prevImg.nativeObj, nextImg.nativeObj, prevPts_mat.nativeObj, nextPts_mat.nativeObj, status_mat.nativeObj, err_mat.nativeObj, winSize.width, winSize.height);


        }

        /**
         @brief Calculates an optical flow for a sparse feature set using the iterative Lucas-Kanade method with
         pyramids.
         
         @param prevImg first 8-bit input image or pyramid constructed by buildOpticalFlowPyramid.
         @param nextImg second input image or pyramid of the same size and the same type as prevImg.
         @param prevPts vector of 2D points for which the flow needs to be found; point coordinates must be
         single-precision floating-point numbers.
         @param nextPts output vector of 2D points (with single-precision floating-point coordinates)
         containing the calculated new positions of input features in the second image; when
         OPTFLOW_USE_INITIAL_FLOW flag is passed, the vector must have the same size as in the input.
         @param status output status vector (of unsigned chars); each element of the vector is set to 1 if
         the flow for the corresponding features has been found, otherwise, it is set to 0.
         @param err output vector of errors; each element of the vector is set to an error for the
         corresponding feature, type of the error measure can be set in flags parameter; if the flow wasn't
         found then the error is not defined (use the status parameter to find such cases).
         @param winSize size of the search window at each pyramid level.
         @param maxLevel 0-based maximal pyramid level number; if set to 0, pyramids are not used (single
         level), if set to 1, two levels are used, and so on; if pyramids are passed to input then
         algorithm will use as many levels as pyramids have but no more than maxLevel.
         @param criteria parameter, specifying the termination criteria of the iterative search algorithm
         (after the specified maximum number of iterations criteria.maxCount or when the search window
         moves by less than criteria.epsilon.
         @param flags operation flags:
          -   **OPTFLOW_USE_INITIAL_FLOW** uses initial estimations, stored in nextPts; if the flag is
              not set, then prevPts is copied to nextPts and is considered the initial estimate.
          -   **OPTFLOW_LK_GET_MIN_EIGENVALS** use minimum eigen values as an error measure (see
              minEigThreshold description); if the flag is not set, then L1 distance between patches
              around the original and a moved point, divided by number of pixels in a window, is used as a
              error measure.
         @param minEigThreshold the algorithm calculates the minimum eigen value of a 2x2 normal matrix of
         optical flow equations (this matrix is called a spatial gradient matrix in @cite Bouguet00), divided
         by number of pixels in a window; if this value is less than minEigThreshold, then a corresponding
         feature is filtered out and its flow is not processed, so it allows to remove bad points and get a
         performance boost.
         
         The function implements a sparse iterative version of the Lucas-Kanade optical flow in pyramids. See
         @cite Bouguet00 . The function is parallelized with the TBB library.
         
         @note Some examples:
         
         -   An example using the Lucas-Kanade optical flow algorithm can be found at
             opencv_source_code/samples/cpp/lkdemo.cpp
         -   (Python) An example using the Lucas-Kanade optical flow algorithm can be found at
             opencv_source_code/samples/python/lk_track.py
         -   (Python) An example using the Lucas-Kanade tracker for homography matching can be found at
             opencv_source_code/samples/python/lk_homography.py
         */
        public static void calcOpticalFlowPyrLK(Mat prevImg, Mat nextImg, MatOfPoint2f prevPts, MatOfPoint2f nextPts, MatOfByte status, MatOfFloat err)
        {
            if (prevImg != null) prevImg.ThrowIfDisposed();
            if (nextImg != null) nextImg.ThrowIfDisposed();
            if (prevPts != null) prevPts.ThrowIfDisposed();
            if (nextPts != null) nextPts.ThrowIfDisposed();
            if (status != null) status.ThrowIfDisposed();
            if (err != null) err.ThrowIfDisposed();
            Mat prevPts_mat = prevPts;
            Mat nextPts_mat = nextPts;
            Mat status_mat = status;
            Mat err_mat = err;
            video_Video_calcOpticalFlowPyrLK_15(prevImg.nativeObj, nextImg.nativeObj, prevPts_mat.nativeObj, nextPts_mat.nativeObj, status_mat.nativeObj, err_mat.nativeObj);


        }


        //
        // C++:  void cv::calcOpticalFlowFarneback(Mat prev, Mat next, Mat& flow, double pyr_scale, int levels, int winsize, int iterations, int poly_n, double poly_sigma, int flags)
        //

        /**
         @brief Computes a dense optical flow using the Gunnar Farneback's algorithm.
         
         @param prev first 8-bit single-channel input image.
         @param next second input image of the same size and the same type as prev.
         @param flow computed flow image that has the same size as prev and type CV_32FC2.
         @param pyr_scale parameter, specifying the image scale (&lt;1) to build pyramids for each image;
         pyr_scale=0.5 means a classical pyramid, where each next layer is twice smaller than the previous
         one.
         @param levels number of pyramid layers including the initial image; levels=1 means that no extra
         layers are created and only the original images are used.
         @param winsize averaging window size; larger values increase the algorithm robustness to image
         noise and give more chances for fast motion detection, but yield more blurred motion field.
         @param iterations number of iterations the algorithm does at each pyramid level.
         @param poly_n size of the pixel neighborhood used to find polynomial expansion in each pixel;
         larger values mean that the image will be approximated with smoother surfaces, yielding more
         robust algorithm and more blurred motion field, typically poly_n =5 or 7.
         @param poly_sigma standard deviation of the Gaussian that is used to smooth derivatives used as a
         basis for the polynomial expansion; for poly_n=5, you can set poly_sigma=1.1, for poly_n=7, a
         good value would be poly_sigma=1.5.
         @param flags operation flags that can be a combination of the following:
          -   **OPTFLOW_USE_INITIAL_FLOW** uses the input flow as an initial flow approximation.
          -   **OPTFLOW_FARNEBACK_GAUSSIAN** uses the Gaussian \f$\texttt{winsize}\times\texttt{winsize}\f$
              filter instead of a box filter of the same size for optical flow estimation; usually, this
              option gives z more accurate flow than with a box filter, at the cost of lower speed;
              normally, winsize for a Gaussian window should be set to a larger value to achieve the same
              level of robustness.
         
         The function finds an optical flow for each prev pixel using the @cite Farneback2003 algorithm so that
         
         \f[\texttt{prev} (y,x)  \sim \texttt{next} ( y + \texttt{flow} (y,x)[1],  x + \texttt{flow} (y,x)[0])\f]
         
         @note Some examples:
         
         -   An example using the optical flow algorithm described by Gunnar Farneback can be found at
             opencv_source_code/samples/cpp/fback.cpp
         -   (Python) An example using the optical flow algorithm described by Gunnar Farneback can be
             found at opencv_source_code/samples/python/opt_flow.py
         */
        public static void calcOpticalFlowFarneback(Mat prev, Mat next, Mat flow, double pyr_scale, int levels, int winsize, int iterations, int poly_n, double poly_sigma, int flags)
        {
            if (prev != null) prev.ThrowIfDisposed();
            if (next != null) next.ThrowIfDisposed();
            if (flow != null) flow.ThrowIfDisposed();

            video_Video_calcOpticalFlowFarneback_10(prev.nativeObj, next.nativeObj, flow.nativeObj, pyr_scale, levels, winsize, iterations, poly_n, poly_sigma, flags);


        }


        //
        // C++:  double cv::computeECC(Mat templateImage, Mat inputImage, Mat inputMask = Mat())
        //

        /**
         @brief Computes the Enhanced Correlation Coefficient value between two images @cite EP08 .
         
         @param templateImage single-channel template image; CV_8U or CV_32F array.
         @param inputImage single-channel input image to be warped to provide an image similar to
          templateImage, same type as templateImage.
         @param inputMask An optional mask to indicate valid values of inputImage.
         
         @sa
         findTransformECC
         */
        public static double computeECC(Mat templateImage, Mat inputImage, Mat inputMask)
        {
            if (templateImage != null) templateImage.ThrowIfDisposed();
            if (inputImage != null) inputImage.ThrowIfDisposed();
            if (inputMask != null) inputMask.ThrowIfDisposed();

            return video_Video_computeECC_10(templateImage.nativeObj, inputImage.nativeObj, inputMask.nativeObj);


        }

        /**
         @brief Computes the Enhanced Correlation Coefficient value between two images @cite EP08 .
         
         @param templateImage single-channel template image; CV_8U or CV_32F array.
         @param inputImage single-channel input image to be warped to provide an image similar to
          templateImage, same type as templateImage.
         @param inputMask An optional mask to indicate valid values of inputImage.
         
         @sa
         findTransformECC
         */
        public static double computeECC(Mat templateImage, Mat inputImage)
        {
            if (templateImage != null) templateImage.ThrowIfDisposed();
            if (inputImage != null) inputImage.ThrowIfDisposed();

            return video_Video_computeECC_11(templateImage.nativeObj, inputImage.nativeObj);


        }


        //
        // C++:  double cv::findTransformECC(Mat templateImage, Mat inputImage, Mat& warpMatrix, int motionType, TermCriteria criteria, Mat inputMask, int gaussFiltSize)
        //

        /**
         @brief Finds the geometric transform (warp) between two images in terms of the ECC criterion @cite EP08 .
         
         @param templateImage single-channel template image; CV_8U or CV_32F array.
         @param inputImage single-channel input image which should be warped with the final warpMatrix in
         order to provide an image similar to templateImage, same type as templateImage.
         @param warpMatrix floating-point \f$2\times 3\f$ or \f$3\times 3\f$ mapping matrix (warp).
         @param motionType parameter, specifying the type of motion:
          -   **MOTION_TRANSLATION** sets a translational motion model; warpMatrix is \f$2\times 3\f$ with
              the first \f$2\times 2\f$ part being the unity matrix and the rest two parameters being
              estimated.
          -   **MOTION_EUCLIDEAN** sets a Euclidean (rigid) transformation as motion model; three
              parameters are estimated; warpMatrix is \f$2\times 3\f$.
          -   **MOTION_AFFINE** sets an affine motion model (DEFAULT); six parameters are estimated;
              warpMatrix is \f$2\times 3\f$.
          -   **MOTION_HOMOGRAPHY** sets a homography as a motion model; eight parameters are
              estimated;\`warpMatrix\` is \f$3\times 3\f$.
         @param criteria parameter, specifying the termination criteria of the ECC algorithm;
         criteria.epsilon defines the threshold of the increment in the correlation coefficient between two
         iterations (a negative criteria.epsilon makes criteria.maxcount the only termination criterion).
         Default values are shown in the declaration above.
         @param inputMask An optional mask to indicate valid values of inputImage.
         @param gaussFiltSize An optional value indicating size of gaussian blur filter; (DEFAULT: 5)
         
         The function estimates the optimum transformation (warpMatrix) with respect to ECC criterion
         (@cite EP08), that is
         
         \f[\texttt{warpMatrix} = \arg\max_{W} \texttt{ECC}(\texttt{templateImage}(x,y),\texttt{inputImage}(x',y'))\f]
         
         where
         
         \f[\begin{bmatrix} x' \\ y' \end{bmatrix} = W \cdot \begin{bmatrix} x \\ y \\ 1 \end{bmatrix}\f]
         
         (the equation holds with homogeneous coordinates for homography). It returns the final enhanced
         correlation coefficient, that is the correlation coefficient between the template image and the
         final warped input image. When a \f$3\times 3\f$ matrix is given with motionType =0, 1 or 2, the third
         row is ignored.
         
         Unlike findHomography and estimateRigidTransform, the function findTransformECC implements an
         area-based alignment that builds on intensity similarities. In essence, the function updates the
         initial transformation that roughly aligns the images. If this information is missing, the identity
         warp (unity matrix) is used as an initialization. Note that if images undergo strong
         displacements/rotations, an initial transformation that roughly aligns the images is necessary
         (e.g., a simple euclidean/similarity transform that allows for the images showing the same image
         content approximately). Use inverse warping in the second image to take an image close to the first
         one, i.e. use the flag WARP_INVERSE_MAP with warpAffine or warpPerspective. See also the OpenCV
         sample image_alignment.cpp that demonstrates the use of the function. Note that the function throws
         an exception if algorithm does not converges.
         
         @sa
         computeECC, estimateAffine2D, estimateAffinePartial2D, findHomography
         */
        public static double findTransformECC(Mat templateImage, Mat inputImage, Mat warpMatrix, int motionType, TermCriteria criteria, Mat inputMask, int gaussFiltSize)
        {
            if (templateImage != null) templateImage.ThrowIfDisposed();
            if (inputImage != null) inputImage.ThrowIfDisposed();
            if (warpMatrix != null) warpMatrix.ThrowIfDisposed();
            if (inputMask != null) inputMask.ThrowIfDisposed();

            return video_Video_findTransformECC_10(templateImage.nativeObj, inputImage.nativeObj, warpMatrix.nativeObj, motionType, criteria.type, criteria.maxCount, criteria.epsilon, inputMask.nativeObj, gaussFiltSize);


        }


        //
        // C++:  double cv::findTransformECC(Mat templateImage, Mat inputImage, Mat& warpMatrix, int motionType = MOTION_AFFINE, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 50, 0.001), Mat inputMask = Mat())
        //

        /**
         @overload
         */
        public static double findTransformECC(Mat templateImage, Mat inputImage, Mat warpMatrix, int motionType, TermCriteria criteria, Mat inputMask)
        {
            if (templateImage != null) templateImage.ThrowIfDisposed();
            if (inputImage != null) inputImage.ThrowIfDisposed();
            if (warpMatrix != null) warpMatrix.ThrowIfDisposed();
            if (inputMask != null) inputMask.ThrowIfDisposed();

            return video_Video_findTransformECC_11(templateImage.nativeObj, inputImage.nativeObj, warpMatrix.nativeObj, motionType, criteria.type, criteria.maxCount, criteria.epsilon, inputMask.nativeObj);


        }

        /**
         @overload
         */
        public static double findTransformECC(Mat templateImage, Mat inputImage, Mat warpMatrix, int motionType, TermCriteria criteria)
        {
            if (templateImage != null) templateImage.ThrowIfDisposed();
            if (inputImage != null) inputImage.ThrowIfDisposed();
            if (warpMatrix != null) warpMatrix.ThrowIfDisposed();

            return video_Video_findTransformECC_12(templateImage.nativeObj, inputImage.nativeObj, warpMatrix.nativeObj, motionType, criteria.type, criteria.maxCount, criteria.epsilon);


        }

        /**
         @overload
         */
        public static double findTransformECC(Mat templateImage, Mat inputImage, Mat warpMatrix, int motionType)
        {
            if (templateImage != null) templateImage.ThrowIfDisposed();
            if (inputImage != null) inputImage.ThrowIfDisposed();
            if (warpMatrix != null) warpMatrix.ThrowIfDisposed();

            return video_Video_findTransformECC_13(templateImage.nativeObj, inputImage.nativeObj, warpMatrix.nativeObj, motionType);


        }

        /**
         @overload
         */
        public static double findTransformECC(Mat templateImage, Mat inputImage, Mat warpMatrix)
        {
            if (templateImage != null) templateImage.ThrowIfDisposed();
            if (inputImage != null) inputImage.ThrowIfDisposed();
            if (warpMatrix != null) warpMatrix.ThrowIfDisposed();

            return video_Video_findTransformECC_14(templateImage.nativeObj, inputImage.nativeObj, warpMatrix.nativeObj);


        }


        //
        // C++:  Mat cv::readOpticalFlow(String path)
        //

        /**
         @brief Read a .flo file
         
          @param path Path to the file to be loaded
         
          The function readOpticalFlow loads a flow field from a file and returns it as a single matrix.
          Resulting Mat has a type CV_32FC2 - floating-point, 2-channel. First channel corresponds to the
          flow in the horizontal direction (u), second - vertical (v).
         */
        public static Mat readOpticalFlow(string path)
        {


            return new Mat(DisposableObject.ThrowIfNullIntPtr(video_Video_readOpticalFlow_10(path)));


        }


        //
        // C++:  bool cv::writeOpticalFlow(String path, Mat flow)
        //

        /**
         @brief Write a .flo to disk
         
          @param path Path to the file to be written
          @param flow Flow field to be stored
         
          The function stores a flow field in a file, returns true on success, false otherwise.
          The flow field must be a 2-channel, floating-point matrix (CV_32FC2). First channel corresponds
          to the flow in the horizontal direction (u), second - vertical (v).
         */
        public static bool writeOpticalFlow(string path, Mat flow)
        {
            if (flow != null) flow.ThrowIfDisposed();

            return video_Video_writeOpticalFlow_10(path, flow.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  Ptr_BackgroundSubtractorMOG2 cv::createBackgroundSubtractorMOG2(int history = 500, double varThreshold = 16, bool detectShadows = true)
        [DllImport(LIBNAME)]
        private static extern IntPtr video_Video_createBackgroundSubtractorMOG2_10(int history, double varThreshold, [MarshalAs(UnmanagedType.U1)] bool detectShadows);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_Video_createBackgroundSubtractorMOG2_11(int history, double varThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_Video_createBackgroundSubtractorMOG2_12(int history);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_Video_createBackgroundSubtractorMOG2_13();

        // C++:  Ptr_BackgroundSubtractorKNN cv::createBackgroundSubtractorKNN(int history = 500, double dist2Threshold = 400.0, bool detectShadows = true)
        [DllImport(LIBNAME)]
        private static extern IntPtr video_Video_createBackgroundSubtractorKNN_10(int history, double dist2Threshold, [MarshalAs(UnmanagedType.U1)] bool detectShadows);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_Video_createBackgroundSubtractorKNN_11(int history, double dist2Threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_Video_createBackgroundSubtractorKNN_12(int history);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_Video_createBackgroundSubtractorKNN_13();

        // C++:  RotatedRect cv::CamShift(Mat probImage, Rect& window, TermCriteria criteria)
        [DllImport(LIBNAME)]
        private static extern void video_Video_CamShift_10(IntPtr probImage_nativeObj, int window_x, int window_y, int window_width, int window_height, double[] window_out, int criteria_type, int criteria_maxCount, double criteria_epsilon, double[] retVal);

        // C++:  int cv::meanShift(Mat probImage, Rect& window, TermCriteria criteria)
        [DllImport(LIBNAME)]
        private static extern int video_Video_meanShift_10(IntPtr probImage_nativeObj, int window_x, int window_y, int window_width, int window_height, double[] window_out, int criteria_type, int criteria_maxCount, double criteria_epsilon);

        // C++:  int cv::buildOpticalFlowPyramid(Mat img, vector_Mat& pyramid, Size winSize, int maxLevel, bool withDerivatives = true, int pyrBorder = BORDER_REFLECT_101, int derivBorder = BORDER_CONSTANT, bool tryReuseInputImage = true)
        [DllImport(LIBNAME)]
        private static extern int video_Video_buildOpticalFlowPyramid_10(IntPtr img_nativeObj, IntPtr pyramid_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel, [MarshalAs(UnmanagedType.U1)] bool withDerivatives, int pyrBorder, int derivBorder, [MarshalAs(UnmanagedType.U1)] bool tryReuseInputImage);
        [DllImport(LIBNAME)]
        private static extern int video_Video_buildOpticalFlowPyramid_11(IntPtr img_nativeObj, IntPtr pyramid_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel, [MarshalAs(UnmanagedType.U1)] bool withDerivatives, int pyrBorder, int derivBorder);
        [DllImport(LIBNAME)]
        private static extern int video_Video_buildOpticalFlowPyramid_12(IntPtr img_nativeObj, IntPtr pyramid_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel, [MarshalAs(UnmanagedType.U1)] bool withDerivatives, int pyrBorder);
        [DllImport(LIBNAME)]
        private static extern int video_Video_buildOpticalFlowPyramid_13(IntPtr img_nativeObj, IntPtr pyramid_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel, [MarshalAs(UnmanagedType.U1)] bool withDerivatives);
        [DllImport(LIBNAME)]
        private static extern int video_Video_buildOpticalFlowPyramid_14(IntPtr img_nativeObj, IntPtr pyramid_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel);

        // C++:  void cv::calcOpticalFlowPyrLK(Mat prevImg, Mat nextImg, vector_Point2f prevPts, vector_Point2f& nextPts, vector_uchar& status, vector_float& err, Size winSize = Size(21,21), int maxLevel = 3, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 0.01), int flags = 0, double minEigThreshold = 1e-4)
        [DllImport(LIBNAME)]
        private static extern void video_Video_calcOpticalFlowPyrLK_10(IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_mat_nativeObj, IntPtr nextPts_mat_nativeObj, IntPtr status_mat_nativeObj, IntPtr err_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel, int criteria_type, int criteria_maxCount, double criteria_epsilon, int flags, double minEigThreshold);
        [DllImport(LIBNAME)]
        private static extern void video_Video_calcOpticalFlowPyrLK_11(IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_mat_nativeObj, IntPtr nextPts_mat_nativeObj, IntPtr status_mat_nativeObj, IntPtr err_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel, int criteria_type, int criteria_maxCount, double criteria_epsilon, int flags);
        [DllImport(LIBNAME)]
        private static extern void video_Video_calcOpticalFlowPyrLK_12(IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_mat_nativeObj, IntPtr nextPts_mat_nativeObj, IntPtr status_mat_nativeObj, IntPtr err_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern void video_Video_calcOpticalFlowPyrLK_13(IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_mat_nativeObj, IntPtr nextPts_mat_nativeObj, IntPtr status_mat_nativeObj, IntPtr err_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel);
        [DllImport(LIBNAME)]
        private static extern void video_Video_calcOpticalFlowPyrLK_14(IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_mat_nativeObj, IntPtr nextPts_mat_nativeObj, IntPtr status_mat_nativeObj, IntPtr err_mat_nativeObj, double winSize_width, double winSize_height);
        [DllImport(LIBNAME)]
        private static extern void video_Video_calcOpticalFlowPyrLK_15(IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_mat_nativeObj, IntPtr nextPts_mat_nativeObj, IntPtr status_mat_nativeObj, IntPtr err_mat_nativeObj);

        // C++:  void cv::calcOpticalFlowFarneback(Mat prev, Mat next, Mat& flow, double pyr_scale, int levels, int winsize, int iterations, int poly_n, double poly_sigma, int flags)
        [DllImport(LIBNAME)]
        private static extern void video_Video_calcOpticalFlowFarneback_10(IntPtr prev_nativeObj, IntPtr next_nativeObj, IntPtr flow_nativeObj, double pyr_scale, int levels, int winsize, int iterations, int poly_n, double poly_sigma, int flags);

        // C++:  double cv::computeECC(Mat templateImage, Mat inputImage, Mat inputMask = Mat())
        [DllImport(LIBNAME)]
        private static extern double video_Video_computeECC_10(IntPtr templateImage_nativeObj, IntPtr inputImage_nativeObj, IntPtr inputMask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern double video_Video_computeECC_11(IntPtr templateImage_nativeObj, IntPtr inputImage_nativeObj);

        // C++:  double cv::findTransformECC(Mat templateImage, Mat inputImage, Mat& warpMatrix, int motionType, TermCriteria criteria, Mat inputMask, int gaussFiltSize)
        [DllImport(LIBNAME)]
        private static extern double video_Video_findTransformECC_10(IntPtr templateImage_nativeObj, IntPtr inputImage_nativeObj, IntPtr warpMatrix_nativeObj, int motionType, int criteria_type, int criteria_maxCount, double criteria_epsilon, IntPtr inputMask_nativeObj, int gaussFiltSize);

        // C++:  double cv::findTransformECC(Mat templateImage, Mat inputImage, Mat& warpMatrix, int motionType = MOTION_AFFINE, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 50, 0.001), Mat inputMask = Mat())
        [DllImport(LIBNAME)]
        private static extern double video_Video_findTransformECC_11(IntPtr templateImage_nativeObj, IntPtr inputImage_nativeObj, IntPtr warpMatrix_nativeObj, int motionType, int criteria_type, int criteria_maxCount, double criteria_epsilon, IntPtr inputMask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern double video_Video_findTransformECC_12(IntPtr templateImage_nativeObj, IntPtr inputImage_nativeObj, IntPtr warpMatrix_nativeObj, int motionType, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double video_Video_findTransformECC_13(IntPtr templateImage_nativeObj, IntPtr inputImage_nativeObj, IntPtr warpMatrix_nativeObj, int motionType);
        [DllImport(LIBNAME)]
        private static extern double video_Video_findTransformECC_14(IntPtr templateImage_nativeObj, IntPtr inputImage_nativeObj, IntPtr warpMatrix_nativeObj);

        // C++:  Mat cv::readOpticalFlow(String path)
        [DllImport(LIBNAME)]
        private static extern IntPtr video_Video_readOpticalFlow_10(string path);

        // C++:  bool cv::writeOpticalFlow(String path, Mat flow)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool video_Video_writeOpticalFlow_10(string path, IntPtr flow_nativeObj);

    }
}
