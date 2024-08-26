#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.DnnModule
{

    // C++: class TextRecognitionModel
    /**
     @brief This class represents high-level API for text recognition networks.
      *
      * TextRecognitionModel allows to set params for preprocessing input image.
      * TextRecognitionModel creates net from file with trained weights and config,
      * sets preprocessing input, runs forward pass and return recognition result.
      * For TextRecognitionModel, CRNN-CTC is supported.
     */

    public class TextRecognitionModel : Model
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
                        dnn_TextRecognitionModel_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TextRecognitionModel(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TextRecognitionModel __fromPtr__(IntPtr addr) { return new TextRecognitionModel(addr); }

        //
        // C++:   cv::dnn::TextRecognitionModel::TextRecognitionModel(Net network)
        //

        /**
         * @brief Create Text Recognition model from deep learning network
              * Call setDecodeType() and setVocabulary() after constructor to initialize the decoding method
              * @param[in] network Net object
         */
        public TextRecognitionModel(Net network) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_TextRecognitionModel_10(network.nativeObj)))
        {



        }


        //
        // C++:   cv::dnn::TextRecognitionModel::TextRecognitionModel(string model, string config = "")
        //

        /**
         * @brief Create text recognition model from network represented in one of the supported formats
              * Call setDecodeType() and setVocabulary() after constructor to initialize the decoding method
              * @param[in] model Binary file contains trained weights
              * @param[in] config Text file contains network configuration
         */
        public TextRecognitionModel(string model, string config) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_TextRecognitionModel_11(model, config)))
        {



        }

        /**
         * @brief Create text recognition model from network represented in one of the supported formats
              * Call setDecodeType() and setVocabulary() after constructor to initialize the decoding method
              * @param[in] model Binary file contains trained weights
              * @param[in] config Text file contains network configuration
         */
        public TextRecognitionModel(string model) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_TextRecognitionModel_12(model)))
        {



        }


        //
        // C++:  TextRecognitionModel cv::dnn::TextRecognitionModel::setDecodeType(string decodeType)
        //

        /**
         * @brief Set the decoding method of translating the network output into string
              * @param[in] decodeType The decoding method of translating the network output into string, currently supported type:
              *    - `"CTC-greedy"` greedy decoding for the output of CTC-based methods
              *    - `"CTC-prefix-beam-search"` Prefix beam search decoding for the output of CTC-based methods
         */
        public TextRecognitionModel setDecodeType(string decodeType)
        {
            ThrowIfDisposed();

            return new TextRecognitionModel(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_setDecodeType_10(nativeObj, decodeType)));


        }


        //
        // C++:  string cv::dnn::TextRecognitionModel::getDecodeType()
        //

        /**
         * @brief Get the decoding method
              * @return the decoding method
         */
        public string getDecodeType()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_getDecodeType_10(nativeObj)));

            return retVal;
        }


        //
        // C++:  TextRecognitionModel cv::dnn::TextRecognitionModel::setDecodeOptsCTCPrefixBeamSearch(int beamSize, int vocPruneSize = 0)
        //

        /**
         * @brief Set the decoding method options for `"CTC-prefix-beam-search"` decode usage
              * @param[in] beamSize Beam size for search
              * @param[in] vocPruneSize Parameter to optimize big vocabulary search,
              * only take top @p vocPruneSize tokens in each search step, @p vocPruneSize &lt;= 0 stands for disable this prune.
         */
        public TextRecognitionModel setDecodeOptsCTCPrefixBeamSearch(int beamSize, int vocPruneSize)
        {
            ThrowIfDisposed();

            return new TextRecognitionModel(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_setDecodeOptsCTCPrefixBeamSearch_10(nativeObj, beamSize, vocPruneSize)));


        }

        /**
         * @brief Set the decoding method options for `"CTC-prefix-beam-search"` decode usage
              * @param[in] beamSize Beam size for search
              * @param[in] vocPruneSize Parameter to optimize big vocabulary search,
              * only take top @p vocPruneSize tokens in each search step, @p vocPruneSize &lt;= 0 stands for disable this prune.
         */
        public TextRecognitionModel setDecodeOptsCTCPrefixBeamSearch(int beamSize)
        {
            ThrowIfDisposed();

            return new TextRecognitionModel(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_setDecodeOptsCTCPrefixBeamSearch_11(nativeObj, beamSize)));


        }


        //
        // C++:  TextRecognitionModel cv::dnn::TextRecognitionModel::setVocabulary(vector_string vocabulary)
        //

        /**
         * @brief Set the vocabulary for recognition.
              * @param[in] vocabulary the associated vocabulary of the network.
         */
        public TextRecognitionModel setVocabulary(List<string> vocabulary)
        {
            ThrowIfDisposed();
            Mat vocabulary_mat = Converters.vector_string_to_Mat(vocabulary);
            return new TextRecognitionModel(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_setVocabulary_10(nativeObj, vocabulary_mat.nativeObj)));


        }


        //
        // C++:  vector_string cv::dnn::TextRecognitionModel::getVocabulary()
        //

        /**
         * @brief Get the vocabulary for recognition.
              * @return vocabulary the associated vocabulary
         */
        public List<string> getVocabulary()
        {
            ThrowIfDisposed();
            List<string> retVal = new List<string>();
            Mat retValMat = new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_getVocabulary_10(nativeObj)));
            Converters.Mat_to_vector_string(retValMat, retVal);
            return retVal;
        }


        //
        // C++:  string cv::dnn::TextRecognitionModel::recognize(Mat frame)
        //

        /**
         * @brief Given the @p input frame, create input blob, run net and return recognition result
              * @param[in] frame The input image
              * @return The text recognition result
         */
        public string recognize(Mat frame)
        {
            ThrowIfDisposed();
            if (frame != null) frame.ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_recognize_10(nativeObj, frame.nativeObj)));

            return retVal;
        }


        //
        // C++:  void cv::dnn::TextRecognitionModel::recognize(Mat frame, vector_Mat roiRects, vector_string& results)
        //

        /**
         * @brief Given the @p input frame, create input blob, run net and return recognition result
              * @param[in] frame The input image
              * @param[in] roiRects List of text detection regions of interest (cv::Rect, CV_32SC4). ROIs is be cropped as the network inputs
              * @param[out] results A set of text recognition results.
         */
        public void recognize(Mat frame, List<Mat> roiRects, List<string> results)
        {
            ThrowIfDisposed();
            if (frame != null) frame.ThrowIfDisposed();
            Mat roiRects_mat = Converters.vector_Mat_to_Mat(roiRects);
            Mat results_mat = new Mat();
            dnn_TextRecognitionModel_recognize_11(nativeObj, frame.nativeObj, roiRects_mat.nativeObj, results_mat.nativeObj);
            Converters.Mat_to_vector_string(results_mat, results);
            results_mat.release();

        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::dnn::TextRecognitionModel::TextRecognitionModel(Net network)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_TextRecognitionModel_10(IntPtr network_nativeObj);

        // C++:   cv::dnn::TextRecognitionModel::TextRecognitionModel(string model, string config = "")
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_TextRecognitionModel_11(string model, string config);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_TextRecognitionModel_12(string model);

        // C++:  TextRecognitionModel cv::dnn::TextRecognitionModel::setDecodeType(string decodeType)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_setDecodeType_10(IntPtr nativeObj, string decodeType);

        // C++:  string cv::dnn::TextRecognitionModel::getDecodeType()
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_getDecodeType_10(IntPtr nativeObj);

        // C++:  TextRecognitionModel cv::dnn::TextRecognitionModel::setDecodeOptsCTCPrefixBeamSearch(int beamSize, int vocPruneSize = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_setDecodeOptsCTCPrefixBeamSearch_10(IntPtr nativeObj, int beamSize, int vocPruneSize);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_setDecodeOptsCTCPrefixBeamSearch_11(IntPtr nativeObj, int beamSize);

        // C++:  TextRecognitionModel cv::dnn::TextRecognitionModel::setVocabulary(vector_string vocabulary)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_setVocabulary_10(IntPtr nativeObj, IntPtr vocabulary_mat_nativeObj);

        // C++:  vector_string cv::dnn::TextRecognitionModel::getVocabulary()
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_getVocabulary_10(IntPtr nativeObj);

        // C++:  string cv::dnn::TextRecognitionModel::recognize(Mat frame)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_recognize_10(IntPtr nativeObj, IntPtr frame_nativeObj);

        // C++:  void cv::dnn::TextRecognitionModel::recognize(Mat frame, vector_Mat roiRects, vector_string& results)
        [DllImport(LIBNAME)]
        private static extern void dnn_TextRecognitionModel_recognize_11(IntPtr nativeObj, IntPtr frame_nativeObj, IntPtr roiRects_mat_nativeObj, IntPtr results_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void dnn_TextRecognitionModel_delete(IntPtr nativeObj);

    }
}

#endif