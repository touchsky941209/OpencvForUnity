#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.DnnModule
{

    // C++: class TextDetectionModel
    /**
     @brief Base class for text detection networks
     */

    public class TextDetectionModel : Model
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
                        dnn_TextDetectionModel_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TextDetectionModel(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TextDetectionModel __fromPtr__(IntPtr addr) { return new TextDetectionModel(addr); }

        //
        // C++:  void cv::dnn::TextDetectionModel::detect(Mat frame, vector_vector_Point& detections, vector_float& confidences)
        //

        /**
         @brief Performs detection
              *
              * Given the input @p frame, prepare network input, run network inference, post-process network output and return result detections.
              *
              * Each result is quadrangle's 4 points in this order:
              * - bottom-left
              * - top-left
              * - top-right
              * - bottom-right
              *
              * Use cv::getPerspectiveTransform function to retrieve image region without perspective transformations.
              *
              * @note If DL model doesn't support that kind of output then result may be derived from detectTextRectangles() output.
              *
              * @param[in] frame The input image
              * @param[out] detections array with detections' quadrangles (4 points per result)
              * @param[out] confidences array with detection confidences
         */
        public void detect(Mat frame, List<MatOfPoint> detections, MatOfFloat confidences)
        {
            ThrowIfDisposed();
            if (frame != null) frame.ThrowIfDisposed();
            if (confidences != null) confidences.ThrowIfDisposed();
            Mat detections_mat = new Mat();
            Mat confidences_mat = confidences;
            dnn_TextDetectionModel_detect_10(nativeObj, frame.nativeObj, detections_mat.nativeObj, confidences_mat.nativeObj);
            Converters.Mat_to_vector_vector_Point(detections_mat, detections);
            detections_mat.release();

        }


        //
        // C++:  void cv::dnn::TextDetectionModel::detect(Mat frame, vector_vector_Point& detections)
        //

        /**
         @overload
         */
        public void detect(Mat frame, List<MatOfPoint> detections)
        {
            ThrowIfDisposed();
            if (frame != null) frame.ThrowIfDisposed();
            Mat detections_mat = new Mat();
            dnn_TextDetectionModel_detect_11(nativeObj, frame.nativeObj, detections_mat.nativeObj);
            Converters.Mat_to_vector_vector_Point(detections_mat, detections);
            detections_mat.release();

        }


        //
        // C++:  void cv::dnn::TextDetectionModel::detectTextRectangles(Mat frame, vector_RotatedRect& detections, vector_float& confidences)
        //

        /**
         @brief Performs detection
              *
              * Given the input @p frame, prepare network input, run network inference, post-process network output and return result detections.
              *
              * Each result is rotated rectangle.
              *
              * @note Result may be inaccurate in case of strong perspective transformations.
              *
              * @param[in] frame the input image
              * @param[out] detections array with detections' RotationRect results
              * @param[out] confidences array with detection confidences
         */
        public void detectTextRectangles(Mat frame, MatOfRotatedRect detections, MatOfFloat confidences)
        {
            ThrowIfDisposed();
            if (frame != null) frame.ThrowIfDisposed();
            if (detections != null) detections.ThrowIfDisposed();
            if (confidences != null) confidences.ThrowIfDisposed();
            Mat detections_mat = detections;
            Mat confidences_mat = confidences;
            dnn_TextDetectionModel_detectTextRectangles_10(nativeObj, frame.nativeObj, detections_mat.nativeObj, confidences_mat.nativeObj);


        }


        //
        // C++:  void cv::dnn::TextDetectionModel::detectTextRectangles(Mat frame, vector_RotatedRect& detections)
        //

        /**
         @overload
         */
        public void detectTextRectangles(Mat frame, MatOfRotatedRect detections)
        {
            ThrowIfDisposed();
            if (frame != null) frame.ThrowIfDisposed();
            if (detections != null) detections.ThrowIfDisposed();
            Mat detections_mat = detections;
            dnn_TextDetectionModel_detectTextRectangles_11(nativeObj, frame.nativeObj, detections_mat.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::dnn::TextDetectionModel::detect(Mat frame, vector_vector_Point& detections, vector_float& confidences)
        [DllImport(LIBNAME)]
        private static extern void dnn_TextDetectionModel_detect_10(IntPtr nativeObj, IntPtr frame_nativeObj, IntPtr detections_mat_nativeObj, IntPtr confidences_mat_nativeObj);

        // C++:  void cv::dnn::TextDetectionModel::detect(Mat frame, vector_vector_Point& detections)
        [DllImport(LIBNAME)]
        private static extern void dnn_TextDetectionModel_detect_11(IntPtr nativeObj, IntPtr frame_nativeObj, IntPtr detections_mat_nativeObj);

        // C++:  void cv::dnn::TextDetectionModel::detectTextRectangles(Mat frame, vector_RotatedRect& detections, vector_float& confidences)
        [DllImport(LIBNAME)]
        private static extern void dnn_TextDetectionModel_detectTextRectangles_10(IntPtr nativeObj, IntPtr frame_nativeObj, IntPtr detections_mat_nativeObj, IntPtr confidences_mat_nativeObj);

        // C++:  void cv::dnn::TextDetectionModel::detectTextRectangles(Mat frame, vector_RotatedRect& detections)
        [DllImport(LIBNAME)]
        private static extern void dnn_TextDetectionModel_detectTextRectangles_11(IntPtr nativeObj, IntPtr frame_nativeObj, IntPtr detections_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void dnn_TextDetectionModel_delete(IntPtr nativeObj);

    }
}

#endif