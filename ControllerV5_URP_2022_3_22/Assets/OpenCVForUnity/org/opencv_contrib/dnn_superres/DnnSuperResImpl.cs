#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Dnn_superresModule
{
    // C++: class DnnSuperResImpl
    /**
     @brief A class to upscale images via convolutional neural networks.
     The following four models are implemented:
     
     - edsr
     - espcn
     - fsrcnn
     - lapsrn
     */

    public class DnnSuperResImpl : DisposableOpenCVObject
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
                        dnn_1superres_DnnSuperResImpl_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DnnSuperResImpl(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static DnnSuperResImpl __fromPtr__(IntPtr addr) { return new DnnSuperResImpl(addr); }

        //
        // C++: static Ptr_DnnSuperResImpl cv::dnn_superres::DnnSuperResImpl::create()
        //

        /**
         @brief Empty constructor for python
         */
        public static DnnSuperResImpl create()
        {


            return DnnSuperResImpl.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(dnn_1superres_DnnSuperResImpl_create_10()));


        }


        //
        // C++:  void cv::dnn_superres::DnnSuperResImpl::readModel(String path)
        //

        /**
         @brief Read the model from the given path
             @param path Path to the model file.
         */
        public void readModel(string path)
        {
            ThrowIfDisposed();

            dnn_1superres_DnnSuperResImpl_readModel_10(nativeObj, path);


        }


        //
        // C++:  void cv::dnn_superres::DnnSuperResImpl::setModel(String algo, int scale)
        //

        /**
         @brief Set desired model
             @param algo String containing one of the desired models:
                 - __edsr__
                 - __espcn__
                 - __fsrcnn__
                 - __lapsrn__
             @param scale Integer specifying the upscale factor
         */
        public void setModel(string algo, int scale)
        {
            ThrowIfDisposed();

            dnn_1superres_DnnSuperResImpl_setModel_10(nativeObj, algo, scale);


        }


        //
        // C++:  void cv::dnn_superres::DnnSuperResImpl::setPreferableBackend(int backendId)
        //

        /**
         @brief Set computation backend
         */
        public void setPreferableBackend(int backendId)
        {
            ThrowIfDisposed();

            dnn_1superres_DnnSuperResImpl_setPreferableBackend_10(nativeObj, backendId);


        }


        //
        // C++:  void cv::dnn_superres::DnnSuperResImpl::setPreferableTarget(int targetId)
        //

        /**
         @brief Set computation target
         */
        public void setPreferableTarget(int targetId)
        {
            ThrowIfDisposed();

            dnn_1superres_DnnSuperResImpl_setPreferableTarget_10(nativeObj, targetId);


        }


        //
        // C++:  void cv::dnn_superres::DnnSuperResImpl::upsample(Mat img, Mat& result)
        //

        /**
         @brief Upsample via neural network
             @param img Image to upscale
             @param result Destination upscaled image
         */
        public void upsample(Mat img, Mat result)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (result != null) result.ThrowIfDisposed();

            dnn_1superres_DnnSuperResImpl_upsample_10(nativeObj, img.nativeObj, result.nativeObj);


        }


        //
        // C++:  void cv::dnn_superres::DnnSuperResImpl::upsampleMultioutput(Mat img, vector_Mat imgs_new, vector_int scale_factors, vector_String node_names)
        //

        /**
         @brief Upsample via neural network of multiple outputs
             @param img Image to upscale
             @param imgs_new Destination upscaled images
             @param scale_factors Scaling factors of the output nodes
             @param node_names Names of the output nodes in the neural network
         */
        public void upsampleMultioutput(Mat img, List<Mat> imgs_new, MatOfInt scale_factors, List<string> node_names)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (scale_factors != null) scale_factors.ThrowIfDisposed();
            Mat imgs_new_mat = Converters.vector_Mat_to_Mat(imgs_new);
            Mat scale_factors_mat = scale_factors;
            Mat node_names_mat = Converters.vector_String_to_Mat(node_names);
            dnn_1superres_DnnSuperResImpl_upsampleMultioutput_10(nativeObj, img.nativeObj, imgs_new_mat.nativeObj, scale_factors_mat.nativeObj, node_names_mat.nativeObj);


        }


        //
        // C++:  int cv::dnn_superres::DnnSuperResImpl::getScale()
        //

        /**
         @brief Returns the scale factor of the model:
             @return Current scale factor.
         */
        public int getScale()
        {
            ThrowIfDisposed();

            return dnn_1superres_DnnSuperResImpl_getScale_10(nativeObj);


        }


        //
        // C++:  String cv::dnn_superres::DnnSuperResImpl::getAlgorithm()
        //

        /**
         @brief Returns the scale factor of the model:
             @return Current algorithm.
         */
        public string getAlgorithm()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(dnn_1superres_DnnSuperResImpl_getAlgorithm_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_DnnSuperResImpl cv::dnn_superres::DnnSuperResImpl::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_1superres_DnnSuperResImpl_create_10();

        // C++:  void cv::dnn_superres::DnnSuperResImpl::readModel(String path)
        [DllImport(LIBNAME)]
        private static extern void dnn_1superres_DnnSuperResImpl_readModel_10(IntPtr nativeObj, string path);

        // C++:  void cv::dnn_superres::DnnSuperResImpl::setModel(String algo, int scale)
        [DllImport(LIBNAME)]
        private static extern void dnn_1superres_DnnSuperResImpl_setModel_10(IntPtr nativeObj, string algo, int scale);

        // C++:  void cv::dnn_superres::DnnSuperResImpl::setPreferableBackend(int backendId)
        [DllImport(LIBNAME)]
        private static extern void dnn_1superres_DnnSuperResImpl_setPreferableBackend_10(IntPtr nativeObj, int backendId);

        // C++:  void cv::dnn_superres::DnnSuperResImpl::setPreferableTarget(int targetId)
        [DllImport(LIBNAME)]
        private static extern void dnn_1superres_DnnSuperResImpl_setPreferableTarget_10(IntPtr nativeObj, int targetId);

        // C++:  void cv::dnn_superres::DnnSuperResImpl::upsample(Mat img, Mat& result)
        [DllImport(LIBNAME)]
        private static extern void dnn_1superres_DnnSuperResImpl_upsample_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr result_nativeObj);

        // C++:  void cv::dnn_superres::DnnSuperResImpl::upsampleMultioutput(Mat img, vector_Mat imgs_new, vector_int scale_factors, vector_String node_names)
        [DllImport(LIBNAME)]
        private static extern void dnn_1superres_DnnSuperResImpl_upsampleMultioutput_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr imgs_new_mat_nativeObj, IntPtr scale_factors_mat_nativeObj, IntPtr node_names_mat_nativeObj);

        // C++:  int cv::dnn_superres::DnnSuperResImpl::getScale()
        [DllImport(LIBNAME)]
        private static extern int dnn_1superres_DnnSuperResImpl_getScale_10(IntPtr nativeObj);

        // C++:  String cv::dnn_superres::DnnSuperResImpl::getAlgorithm()
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_1superres_DnnSuperResImpl_getAlgorithm_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void dnn_1superres_DnnSuperResImpl_delete(IntPtr nativeObj);

    }
}

#endif