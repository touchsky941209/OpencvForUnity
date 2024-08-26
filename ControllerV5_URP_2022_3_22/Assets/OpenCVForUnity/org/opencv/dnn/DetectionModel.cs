#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.DnnModule
{

    // C++: class DetectionModel
    /**
     @brief This class represents high-level API for object detection networks.
           *
           * DetectionModel allows to set params for preprocessing input image.
           * DetectionModel creates net from file with trained weights and config,
           * sets preprocessing input, runs forward pass and return result detections.
           * For DetectionModel SSD, Faster R-CNN, YOLO topologies are supported.
     */

    public class DetectionModel : Model
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
                        dnn_DetectionModel_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DetectionModel(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new DetectionModel __fromPtr__(IntPtr addr) { return new DetectionModel(addr); }

        //
        // C++:   cv::dnn::DetectionModel::DetectionModel(String model, String config = "")
        //

        /**
         * @brief Create detection model from network represented in one of the supported formats.
                   * An order of @p model and @p config arguments does not matter.
                   * @param[in] model Binary file contains trained weights.
                   * @param[in] config Text file contains network configuration.
         */
        public DetectionModel(string model, string config) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_DetectionModel_DetectionModel_10(model, config)))
        {



        }

        /**
         * @brief Create detection model from network represented in one of the supported formats.
                   * An order of @p model and @p config arguments does not matter.
                   * @param[in] model Binary file contains trained weights.
                   * @param[in] config Text file contains network configuration.
         */
        public DetectionModel(string model) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_DetectionModel_DetectionModel_11(model)))
        {



        }


        //
        // C++:   cv::dnn::DetectionModel::DetectionModel(Net network)
        //

        /**
         * @brief Create model from deep learning network.
                   * @param[in] network Net object.
         */
        public DetectionModel(Net network) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_DetectionModel_DetectionModel_12(network.nativeObj)))
        {



        }


        //
        // C++:  DetectionModel cv::dnn::DetectionModel::setNmsAcrossClasses(bool value)
        //

        /**
         * @brief nmsAcrossClasses defaults to false,
                   * such that when non max suppression is used during the detect() function, it will do so per-class.
                   * This function allows you to toggle this behaviour.
                   * @param[in] value The new value for nmsAcrossClasses
         */
        public DetectionModel setNmsAcrossClasses(bool value)
        {
            ThrowIfDisposed();

            return new DetectionModel(DisposableObject.ThrowIfNullIntPtr(dnn_DetectionModel_setNmsAcrossClasses_10(nativeObj, value)));


        }


        //
        // C++:  bool cv::dnn::DetectionModel::getNmsAcrossClasses()
        //

        /**
         * @brief Getter for nmsAcrossClasses. This variable defaults to false,
                   * such that when non max suppression is used during the detect() function, it will do so only per-class
         */
        public bool getNmsAcrossClasses()
        {
            ThrowIfDisposed();

            return dnn_DetectionModel_getNmsAcrossClasses_10(nativeObj);


        }


        //
        // C++:  void cv::dnn::DetectionModel::detect(Mat frame, vector_int& classIds, vector_float& confidences, vector_Rect& boxes, float confThreshold = 0.5f, float nmsThreshold = 0.0f)
        //

        /**
         @brief Given the @p input frame, create input blob, run net and return result detections.
                   *  @param[in]  frame  The input image.
                   *  @param[out] classIds Class indexes in result detection.
                   *  @param[out] confidences A set of corresponding confidences.
                   *  @param[out] boxes A set of bounding boxes.
                   *  @param[in] confThreshold A threshold used to filter boxes by confidences.
                   *  @param[in] nmsThreshold A threshold used in non maximum suppression.
         */
        public void detect(Mat frame, MatOfInt classIds, MatOfFloat confidences, MatOfRect boxes, float confThreshold, float nmsThreshold)
        {
            ThrowIfDisposed();
            if (frame != null) frame.ThrowIfDisposed();
            if (classIds != null) classIds.ThrowIfDisposed();
            if (confidences != null) confidences.ThrowIfDisposed();
            if (boxes != null) boxes.ThrowIfDisposed();
            Mat classIds_mat = classIds;
            Mat confidences_mat = confidences;
            Mat boxes_mat = boxes;
            dnn_DetectionModel_detect_10(nativeObj, frame.nativeObj, classIds_mat.nativeObj, confidences_mat.nativeObj, boxes_mat.nativeObj, confThreshold, nmsThreshold);


        }

        /**
         @brief Given the @p input frame, create input blob, run net and return result detections.
                   *  @param[in]  frame  The input image.
                   *  @param[out] classIds Class indexes in result detection.
                   *  @param[out] confidences A set of corresponding confidences.
                   *  @param[out] boxes A set of bounding boxes.
                   *  @param[in] confThreshold A threshold used to filter boxes by confidences.
                   *  @param[in] nmsThreshold A threshold used in non maximum suppression.
         */
        public void detect(Mat frame, MatOfInt classIds, MatOfFloat confidences, MatOfRect boxes, float confThreshold)
        {
            ThrowIfDisposed();
            if (frame != null) frame.ThrowIfDisposed();
            if (classIds != null) classIds.ThrowIfDisposed();
            if (confidences != null) confidences.ThrowIfDisposed();
            if (boxes != null) boxes.ThrowIfDisposed();
            Mat classIds_mat = classIds;
            Mat confidences_mat = confidences;
            Mat boxes_mat = boxes;
            dnn_DetectionModel_detect_11(nativeObj, frame.nativeObj, classIds_mat.nativeObj, confidences_mat.nativeObj, boxes_mat.nativeObj, confThreshold);


        }

        /**
         @brief Given the @p input frame, create input blob, run net and return result detections.
                   *  @param[in]  frame  The input image.
                   *  @param[out] classIds Class indexes in result detection.
                   *  @param[out] confidences A set of corresponding confidences.
                   *  @param[out] boxes A set of bounding boxes.
                   *  @param[in] confThreshold A threshold used to filter boxes by confidences.
                   *  @param[in] nmsThreshold A threshold used in non maximum suppression.
         */
        public void detect(Mat frame, MatOfInt classIds, MatOfFloat confidences, MatOfRect boxes)
        {
            ThrowIfDisposed();
            if (frame != null) frame.ThrowIfDisposed();
            if (classIds != null) classIds.ThrowIfDisposed();
            if (confidences != null) confidences.ThrowIfDisposed();
            if (boxes != null) boxes.ThrowIfDisposed();
            Mat classIds_mat = classIds;
            Mat confidences_mat = confidences;
            Mat boxes_mat = boxes;
            dnn_DetectionModel_detect_12(nativeObj, frame.nativeObj, classIds_mat.nativeObj, confidences_mat.nativeObj, boxes_mat.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::dnn::DetectionModel::DetectionModel(String model, String config = "")
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_DetectionModel_DetectionModel_10(string model, string config);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_DetectionModel_DetectionModel_11(string model);

        // C++:   cv::dnn::DetectionModel::DetectionModel(Net network)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_DetectionModel_DetectionModel_12(IntPtr network_nativeObj);

        // C++:  DetectionModel cv::dnn::DetectionModel::setNmsAcrossClasses(bool value)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_DetectionModel_setNmsAcrossClasses_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool value);

        // C++:  bool cv::dnn::DetectionModel::getNmsAcrossClasses()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool dnn_DetectionModel_getNmsAcrossClasses_10(IntPtr nativeObj);

        // C++:  void cv::dnn::DetectionModel::detect(Mat frame, vector_int& classIds, vector_float& confidences, vector_Rect& boxes, float confThreshold = 0.5f, float nmsThreshold = 0.0f)
        [DllImport(LIBNAME)]
        private static extern void dnn_DetectionModel_detect_10(IntPtr nativeObj, IntPtr frame_nativeObj, IntPtr classIds_mat_nativeObj, IntPtr confidences_mat_nativeObj, IntPtr boxes_mat_nativeObj, float confThreshold, float nmsThreshold);
        [DllImport(LIBNAME)]
        private static extern void dnn_DetectionModel_detect_11(IntPtr nativeObj, IntPtr frame_nativeObj, IntPtr classIds_mat_nativeObj, IntPtr confidences_mat_nativeObj, IntPtr boxes_mat_nativeObj, float confThreshold);
        [DllImport(LIBNAME)]
        private static extern void dnn_DetectionModel_detect_12(IntPtr nativeObj, IntPtr frame_nativeObj, IntPtr classIds_mat_nativeObj, IntPtr confidences_mat_nativeObj, IntPtr boxes_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void dnn_DetectionModel_delete(IntPtr nativeObj);

    }
}

#endif