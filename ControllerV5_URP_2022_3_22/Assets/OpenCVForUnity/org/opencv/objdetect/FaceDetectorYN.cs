

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{
    // C++: class FaceDetectorYN
    /**
     @brief DNN-based face detector
     
     model download link: https://github.com/opencv/opencv_zoo/tree/master/models/face_detection_yunet
     */

    public class FaceDetectorYN : DisposableOpenCVObject
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
                        objdetect_FaceDetectorYN_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal FaceDetectorYN(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static FaceDetectorYN __fromPtr__(IntPtr addr) { return new FaceDetectorYN(addr); }

        //
        // C++:  void cv::FaceDetectorYN::setInputSize(Size input_size)
        //

        /**
         @brief Set the size for the network input, which overwrites the input size of creating model. Call this method when the size of input image does not match the input size when creating model
              *
              * @param input_size the size of the input image
         */
        public void setInputSize(Size input_size)
        {
            ThrowIfDisposed();

            objdetect_FaceDetectorYN_setInputSize_10(nativeObj, input_size.width, input_size.height);


        }


        //
        // C++:  Size cv::FaceDetectorYN::getInputSize()
        //

        public Size getInputSize()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[2];
            objdetect_FaceDetectorYN_getInputSize_10(nativeObj, tmpArray);
            Size retVal = new Size(tmpArray);

            return retVal;
        }


        //
        // C++:  void cv::FaceDetectorYN::setScoreThreshold(float score_threshold)
        //

        /**
         @brief Set the score threshold to filter out bounding boxes of score less than the given value
              *
              * @param score_threshold threshold for filtering out bounding boxes
         */
        public void setScoreThreshold(float score_threshold)
        {
            ThrowIfDisposed();

            objdetect_FaceDetectorYN_setScoreThreshold_10(nativeObj, score_threshold);


        }


        //
        // C++:  float cv::FaceDetectorYN::getScoreThreshold()
        //

        public float getScoreThreshold()
        {
            ThrowIfDisposed();

            return objdetect_FaceDetectorYN_getScoreThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::FaceDetectorYN::setNMSThreshold(float nms_threshold)
        //

        /**
         @brief Set the Non-maximum-suppression threshold to suppress bounding boxes that have IoU greater than the given value
              *
              * @param nms_threshold threshold for NMS operation
         */
        public void setNMSThreshold(float nms_threshold)
        {
            ThrowIfDisposed();

            objdetect_FaceDetectorYN_setNMSThreshold_10(nativeObj, nms_threshold);


        }


        //
        // C++:  float cv::FaceDetectorYN::getNMSThreshold()
        //

        public float getNMSThreshold()
        {
            ThrowIfDisposed();

            return objdetect_FaceDetectorYN_getNMSThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::FaceDetectorYN::setTopK(int top_k)
        //

        /**
         @brief Set the number of bounding boxes preserved before NMS
              *
              * @param top_k the number of bounding boxes to preserve from top rank based on score
         */
        public void setTopK(int top_k)
        {
            ThrowIfDisposed();

            objdetect_FaceDetectorYN_setTopK_10(nativeObj, top_k);


        }


        //
        // C++:  int cv::FaceDetectorYN::getTopK()
        //

        public int getTopK()
        {
            ThrowIfDisposed();

            return objdetect_FaceDetectorYN_getTopK_10(nativeObj);


        }


        //
        // C++:  int cv::FaceDetectorYN::detect(Mat image, Mat& faces)
        //

        /**
         @brief Detects faces in the input image. Following is an example output.
         
              * ![image](pics/lena-face-detection.jpg)
         
              *  @param image an image to detect
              *  @param faces detection results stored in a 2D cv::Mat of shape [num_faces, 15]
              *  - 0-1: x, y of bbox top left corner
              *  - 2-3: width, height of bbox
              *  - 4-5: x, y of right eye (blue point in the example image)
              *  - 6-7: x, y of left eye (red point in the example image)
              *  - 8-9: x, y of nose tip (green point in the example image)
              *  - 10-11: x, y of right corner of mouth (pink point in the example image)
              *  - 12-13: x, y of left corner of mouth (yellow point in the example image)
              *  - 14: face score
         */
        public int detect(Mat image, Mat faces)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (faces != null) faces.ThrowIfDisposed();

            return objdetect_FaceDetectorYN_detect_10(nativeObj, image.nativeObj, faces.nativeObj);


        }


        //
        // C++: static Ptr_FaceDetectorYN cv::FaceDetectorYN::create(String model, String config, Size input_size, float score_threshold = 0.9f, float nms_threshold = 0.3f, int top_k = 5000, int backend_id = 0, int target_id = 0)
        //

        /**
         @brief Creates an instance of face detector class with given parameters
              *
              *  @param model the path to the requested model
              *  @param config the path to the config file for compability, which is not requested for ONNX models
              *  @param input_size the size of the input image
              *  @param score_threshold the threshold to filter out bounding boxes of score smaller than the given value
              *  @param nms_threshold the threshold to suppress bounding boxes of IoU bigger than the given value
              *  @param top_k keep top K bboxes before NMS
              *  @param backend_id the id of backend
              *  @param target_id the id of target device
         */
        public static FaceDetectorYN create(string model, string config, Size input_size, float score_threshold, float nms_threshold, int top_k, int backend_id, int target_id)
        {


            return FaceDetectorYN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(objdetect_FaceDetectorYN_create_10(model, config, input_size.width, input_size.height, score_threshold, nms_threshold, top_k, backend_id, target_id)));


        }

        /**
         @brief Creates an instance of face detector class with given parameters
              *
              *  @param model the path to the requested model
              *  @param config the path to the config file for compability, which is not requested for ONNX models
              *  @param input_size the size of the input image
              *  @param score_threshold the threshold to filter out bounding boxes of score smaller than the given value
              *  @param nms_threshold the threshold to suppress bounding boxes of IoU bigger than the given value
              *  @param top_k keep top K bboxes before NMS
              *  @param backend_id the id of backend
              *  @param target_id the id of target device
         */
        public static FaceDetectorYN create(string model, string config, Size input_size, float score_threshold, float nms_threshold, int top_k, int backend_id)
        {


            return FaceDetectorYN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(objdetect_FaceDetectorYN_create_11(model, config, input_size.width, input_size.height, score_threshold, nms_threshold, top_k, backend_id)));


        }

        /**
         @brief Creates an instance of face detector class with given parameters
              *
              *  @param model the path to the requested model
              *  @param config the path to the config file for compability, which is not requested for ONNX models
              *  @param input_size the size of the input image
              *  @param score_threshold the threshold to filter out bounding boxes of score smaller than the given value
              *  @param nms_threshold the threshold to suppress bounding boxes of IoU bigger than the given value
              *  @param top_k keep top K bboxes before NMS
              *  @param backend_id the id of backend
              *  @param target_id the id of target device
         */
        public static FaceDetectorYN create(string model, string config, Size input_size, float score_threshold, float nms_threshold, int top_k)
        {


            return FaceDetectorYN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(objdetect_FaceDetectorYN_create_12(model, config, input_size.width, input_size.height, score_threshold, nms_threshold, top_k)));


        }

        /**
         @brief Creates an instance of face detector class with given parameters
              *
              *  @param model the path to the requested model
              *  @param config the path to the config file for compability, which is not requested for ONNX models
              *  @param input_size the size of the input image
              *  @param score_threshold the threshold to filter out bounding boxes of score smaller than the given value
              *  @param nms_threshold the threshold to suppress bounding boxes of IoU bigger than the given value
              *  @param top_k keep top K bboxes before NMS
              *  @param backend_id the id of backend
              *  @param target_id the id of target device
         */
        public static FaceDetectorYN create(string model, string config, Size input_size, float score_threshold, float nms_threshold)
        {


            return FaceDetectorYN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(objdetect_FaceDetectorYN_create_13(model, config, input_size.width, input_size.height, score_threshold, nms_threshold)));


        }

        /**
         @brief Creates an instance of face detector class with given parameters
              *
              *  @param model the path to the requested model
              *  @param config the path to the config file for compability, which is not requested for ONNX models
              *  @param input_size the size of the input image
              *  @param score_threshold the threshold to filter out bounding boxes of score smaller than the given value
              *  @param nms_threshold the threshold to suppress bounding boxes of IoU bigger than the given value
              *  @param top_k keep top K bboxes before NMS
              *  @param backend_id the id of backend
              *  @param target_id the id of target device
         */
        public static FaceDetectorYN create(string model, string config, Size input_size, float score_threshold)
        {


            return FaceDetectorYN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(objdetect_FaceDetectorYN_create_14(model, config, input_size.width, input_size.height, score_threshold)));


        }

        /**
         @brief Creates an instance of face detector class with given parameters
              *
              *  @param model the path to the requested model
              *  @param config the path to the config file for compability, which is not requested for ONNX models
              *  @param input_size the size of the input image
              *  @param score_threshold the threshold to filter out bounding boxes of score smaller than the given value
              *  @param nms_threshold the threshold to suppress bounding boxes of IoU bigger than the given value
              *  @param top_k keep top K bboxes before NMS
              *  @param backend_id the id of backend
              *  @param target_id the id of target device
         */
        public static FaceDetectorYN create(string model, string config, Size input_size)
        {


            return FaceDetectorYN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(objdetect_FaceDetectorYN_create_15(model, config, input_size.width, input_size.height)));


        }


        //
        // C++: static Ptr_FaceDetectorYN cv::FaceDetectorYN::create(String framework, vector_uchar bufferModel, vector_uchar bufferConfig, Size input_size, float score_threshold = 0.9f, float nms_threshold = 0.3f, int top_k = 5000, int backend_id = 0, int target_id = 0)
        //

        /**
         @overload
              *
              *  @param framework Name of origin framework
              *  @param bufferModel A buffer with a content of binary file with weights
              *  @param bufferConfig A buffer with a content of text file contains network configuration
              *  @param input_size the size of the input image
              *  @param score_threshold the threshold to filter out bounding boxes of score smaller than the given value
              *  @param nms_threshold the threshold to suppress bounding boxes of IoU bigger than the given value
              *  @param top_k keep top K bboxes before NMS
              *  @param backend_id the id of backend
              *  @param target_id the id of target device
         */
        public static FaceDetectorYN create(string framework, MatOfByte bufferModel, MatOfByte bufferConfig, Size input_size, float score_threshold, float nms_threshold, int top_k, int backend_id, int target_id)
        {
            if (bufferModel != null) bufferModel.ThrowIfDisposed();
            if (bufferConfig != null) bufferConfig.ThrowIfDisposed();
            Mat bufferModel_mat = bufferModel;
            Mat bufferConfig_mat = bufferConfig;
            return FaceDetectorYN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(objdetect_FaceDetectorYN_create_16(framework, bufferModel_mat.nativeObj, bufferConfig_mat.nativeObj, input_size.width, input_size.height, score_threshold, nms_threshold, top_k, backend_id, target_id)));


        }

        /**
         @overload
              *
              *  @param framework Name of origin framework
              *  @param bufferModel A buffer with a content of binary file with weights
              *  @param bufferConfig A buffer with a content of text file contains network configuration
              *  @param input_size the size of the input image
              *  @param score_threshold the threshold to filter out bounding boxes of score smaller than the given value
              *  @param nms_threshold the threshold to suppress bounding boxes of IoU bigger than the given value
              *  @param top_k keep top K bboxes before NMS
              *  @param backend_id the id of backend
              *  @param target_id the id of target device
         */
        public static FaceDetectorYN create(string framework, MatOfByte bufferModel, MatOfByte bufferConfig, Size input_size, float score_threshold, float nms_threshold, int top_k, int backend_id)
        {
            if (bufferModel != null) bufferModel.ThrowIfDisposed();
            if (bufferConfig != null) bufferConfig.ThrowIfDisposed();
            Mat bufferModel_mat = bufferModel;
            Mat bufferConfig_mat = bufferConfig;
            return FaceDetectorYN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(objdetect_FaceDetectorYN_create_17(framework, bufferModel_mat.nativeObj, bufferConfig_mat.nativeObj, input_size.width, input_size.height, score_threshold, nms_threshold, top_k, backend_id)));


        }

        /**
         @overload
              *
              *  @param framework Name of origin framework
              *  @param bufferModel A buffer with a content of binary file with weights
              *  @param bufferConfig A buffer with a content of text file contains network configuration
              *  @param input_size the size of the input image
              *  @param score_threshold the threshold to filter out bounding boxes of score smaller than the given value
              *  @param nms_threshold the threshold to suppress bounding boxes of IoU bigger than the given value
              *  @param top_k keep top K bboxes before NMS
              *  @param backend_id the id of backend
              *  @param target_id the id of target device
         */
        public static FaceDetectorYN create(string framework, MatOfByte bufferModel, MatOfByte bufferConfig, Size input_size, float score_threshold, float nms_threshold, int top_k)
        {
            if (bufferModel != null) bufferModel.ThrowIfDisposed();
            if (bufferConfig != null) bufferConfig.ThrowIfDisposed();
            Mat bufferModel_mat = bufferModel;
            Mat bufferConfig_mat = bufferConfig;
            return FaceDetectorYN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(objdetect_FaceDetectorYN_create_18(framework, bufferModel_mat.nativeObj, bufferConfig_mat.nativeObj, input_size.width, input_size.height, score_threshold, nms_threshold, top_k)));


        }

        /**
         @overload
              *
              *  @param framework Name of origin framework
              *  @param bufferModel A buffer with a content of binary file with weights
              *  @param bufferConfig A buffer with a content of text file contains network configuration
              *  @param input_size the size of the input image
              *  @param score_threshold the threshold to filter out bounding boxes of score smaller than the given value
              *  @param nms_threshold the threshold to suppress bounding boxes of IoU bigger than the given value
              *  @param top_k keep top K bboxes before NMS
              *  @param backend_id the id of backend
              *  @param target_id the id of target device
         */
        public static FaceDetectorYN create(string framework, MatOfByte bufferModel, MatOfByte bufferConfig, Size input_size, float score_threshold, float nms_threshold)
        {
            if (bufferModel != null) bufferModel.ThrowIfDisposed();
            if (bufferConfig != null) bufferConfig.ThrowIfDisposed();
            Mat bufferModel_mat = bufferModel;
            Mat bufferConfig_mat = bufferConfig;
            return FaceDetectorYN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(objdetect_FaceDetectorYN_create_19(framework, bufferModel_mat.nativeObj, bufferConfig_mat.nativeObj, input_size.width, input_size.height, score_threshold, nms_threshold)));


        }

        /**
         @overload
              *
              *  @param framework Name of origin framework
              *  @param bufferModel A buffer with a content of binary file with weights
              *  @param bufferConfig A buffer with a content of text file contains network configuration
              *  @param input_size the size of the input image
              *  @param score_threshold the threshold to filter out bounding boxes of score smaller than the given value
              *  @param nms_threshold the threshold to suppress bounding boxes of IoU bigger than the given value
              *  @param top_k keep top K bboxes before NMS
              *  @param backend_id the id of backend
              *  @param target_id the id of target device
         */
        public static FaceDetectorYN create(string framework, MatOfByte bufferModel, MatOfByte bufferConfig, Size input_size, float score_threshold)
        {
            if (bufferModel != null) bufferModel.ThrowIfDisposed();
            if (bufferConfig != null) bufferConfig.ThrowIfDisposed();
            Mat bufferModel_mat = bufferModel;
            Mat bufferConfig_mat = bufferConfig;
            return FaceDetectorYN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(objdetect_FaceDetectorYN_create_110(framework, bufferModel_mat.nativeObj, bufferConfig_mat.nativeObj, input_size.width, input_size.height, score_threshold)));


        }

        /**
         @overload
              *
              *  @param framework Name of origin framework
              *  @param bufferModel A buffer with a content of binary file with weights
              *  @param bufferConfig A buffer with a content of text file contains network configuration
              *  @param input_size the size of the input image
              *  @param score_threshold the threshold to filter out bounding boxes of score smaller than the given value
              *  @param nms_threshold the threshold to suppress bounding boxes of IoU bigger than the given value
              *  @param top_k keep top K bboxes before NMS
              *  @param backend_id the id of backend
              *  @param target_id the id of target device
         */
        public static FaceDetectorYN create(string framework, MatOfByte bufferModel, MatOfByte bufferConfig, Size input_size)
        {
            if (bufferModel != null) bufferModel.ThrowIfDisposed();
            if (bufferConfig != null) bufferConfig.ThrowIfDisposed();
            Mat bufferModel_mat = bufferModel;
            Mat bufferConfig_mat = bufferConfig;
            return FaceDetectorYN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(objdetect_FaceDetectorYN_create_111(framework, bufferModel_mat.nativeObj, bufferConfig_mat.nativeObj, input_size.width, input_size.height)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::FaceDetectorYN::setInputSize(Size input_size)
        [DllImport(LIBNAME)]
        private static extern void objdetect_FaceDetectorYN_setInputSize_10(IntPtr nativeObj, double input_size_width, double input_size_height);

        // C++:  Size cv::FaceDetectorYN::getInputSize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_FaceDetectorYN_getInputSize_10(IntPtr nativeObj, double[] retVal);

        // C++:  void cv::FaceDetectorYN::setScoreThreshold(float score_threshold)
        [DllImport(LIBNAME)]
        private static extern void objdetect_FaceDetectorYN_setScoreThreshold_10(IntPtr nativeObj, float score_threshold);

        // C++:  float cv::FaceDetectorYN::getScoreThreshold()
        [DllImport(LIBNAME)]
        private static extern float objdetect_FaceDetectorYN_getScoreThreshold_10(IntPtr nativeObj);

        // C++:  void cv::FaceDetectorYN::setNMSThreshold(float nms_threshold)
        [DllImport(LIBNAME)]
        private static extern void objdetect_FaceDetectorYN_setNMSThreshold_10(IntPtr nativeObj, float nms_threshold);

        // C++:  float cv::FaceDetectorYN::getNMSThreshold()
        [DllImport(LIBNAME)]
        private static extern float objdetect_FaceDetectorYN_getNMSThreshold_10(IntPtr nativeObj);

        // C++:  void cv::FaceDetectorYN::setTopK(int top_k)
        [DllImport(LIBNAME)]
        private static extern void objdetect_FaceDetectorYN_setTopK_10(IntPtr nativeObj, int top_k);

        // C++:  int cv::FaceDetectorYN::getTopK()
        [DllImport(LIBNAME)]
        private static extern int objdetect_FaceDetectorYN_getTopK_10(IntPtr nativeObj);

        // C++:  int cv::FaceDetectorYN::detect(Mat image, Mat& faces)
        [DllImport(LIBNAME)]
        private static extern int objdetect_FaceDetectorYN_detect_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr faces_nativeObj);

        // C++: static Ptr_FaceDetectorYN cv::FaceDetectorYN::create(String model, String config, Size input_size, float score_threshold = 0.9f, float nms_threshold = 0.3f, int top_k = 5000, int backend_id = 0, int target_id = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_FaceDetectorYN_create_10(string model, string config, double input_size_width, double input_size_height, float score_threshold, float nms_threshold, int top_k, int backend_id, int target_id);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_FaceDetectorYN_create_11(string model, string config, double input_size_width, double input_size_height, float score_threshold, float nms_threshold, int top_k, int backend_id);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_FaceDetectorYN_create_12(string model, string config, double input_size_width, double input_size_height, float score_threshold, float nms_threshold, int top_k);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_FaceDetectorYN_create_13(string model, string config, double input_size_width, double input_size_height, float score_threshold, float nms_threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_FaceDetectorYN_create_14(string model, string config, double input_size_width, double input_size_height, float score_threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_FaceDetectorYN_create_15(string model, string config, double input_size_width, double input_size_height);

        // C++: static Ptr_FaceDetectorYN cv::FaceDetectorYN::create(String framework, vector_uchar bufferModel, vector_uchar bufferConfig, Size input_size, float score_threshold = 0.9f, float nms_threshold = 0.3f, int top_k = 5000, int backend_id = 0, int target_id = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_FaceDetectorYN_create_16(string framework, IntPtr bufferModel_mat_nativeObj, IntPtr bufferConfig_mat_nativeObj, double input_size_width, double input_size_height, float score_threshold, float nms_threshold, int top_k, int backend_id, int target_id);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_FaceDetectorYN_create_17(string framework, IntPtr bufferModel_mat_nativeObj, IntPtr bufferConfig_mat_nativeObj, double input_size_width, double input_size_height, float score_threshold, float nms_threshold, int top_k, int backend_id);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_FaceDetectorYN_create_18(string framework, IntPtr bufferModel_mat_nativeObj, IntPtr bufferConfig_mat_nativeObj, double input_size_width, double input_size_height, float score_threshold, float nms_threshold, int top_k);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_FaceDetectorYN_create_19(string framework, IntPtr bufferModel_mat_nativeObj, IntPtr bufferConfig_mat_nativeObj, double input_size_width, double input_size_height, float score_threshold, float nms_threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_FaceDetectorYN_create_110(string framework, IntPtr bufferModel_mat_nativeObj, IntPtr bufferConfig_mat_nativeObj, double input_size_width, double input_size_height, float score_threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_FaceDetectorYN_create_111(string framework, IntPtr bufferModel_mat_nativeObj, IntPtr bufferConfig_mat_nativeObj, double input_size_width, double input_size_height);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_FaceDetectorYN_delete(IntPtr nativeObj);

    }
}
