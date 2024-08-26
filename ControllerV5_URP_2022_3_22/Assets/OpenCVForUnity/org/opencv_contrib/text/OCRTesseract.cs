
//using OpenCVForUnity.CoreModule;
//using OpenCVForUnity.UtilsModule;
//using System;
//using System.Collections.Generic;
//using System.Runtime.InteropServices;

//namespace OpenCVForUnity.TextModule
//{

//    // C++: class OCRTesseract
//    /**
//     @brief OCRTesseract class provides an interface with the tesseract-ocr API (v3.02.02) in C++.
     
//     Notice that it is compiled only when tesseract-ocr is correctly installed.
     
//     @note
//        -   (C++) An example of OCRTesseract recognition combined with scene text detection can be found
//             at the end_to_end_recognition demo:
//             &lt;https://github.com/opencv/opencv_contrib/blob/master/modules/text/samples/end_to_end_recognition.cpp&gt;
//         -   (C++) Another example of OCRTesseract recognition combined with scene text detection can be
//             found at the webcam_demo:
//             &lt;https://github.com/opencv/opencv_contrib/blob/master/modules/text/samples/webcam_demo.cpp&gt;
//     */

//    public class OCRTesseract : BaseOCR
//    {

//        protected override void Dispose(bool disposing)
//        {

//            try
//            {
//                if (disposing)
//                {
//                }
//                if (IsEnabledDispose)
//                {
//                    if (nativeObj != IntPtr.Zero)
//                        text_OCRTesseract_delete(nativeObj);
//                    nativeObj = IntPtr.Zero;
//                }
//            }
//            finally
//            {
//                base.Dispose(disposing);
//            }

//        }

//        protected internal OCRTesseract(IntPtr addr) : base(addr) { }

//        // internal usage only
//        public static new OCRTesseract __fromPtr__(IntPtr addr) { return new OCRTesseract(addr); }

//        //
//        // C++:  String cv::text::OCRTesseract::run(Mat image, int min_confidence, int component_level = 0)
//        //

//        /**
//         @brief Recognize text using the tesseract-ocr API.
         
//             Takes image on input and returns recognized text in the output_text parameter. Optionally
//             provides also the Rects for individual text elements found (e.g. words), and the list of those
//             text elements with their confidence values.
         
//             @param image Input image CV_8UC1 or CV_8UC3
//             @param output_text Output text of the tesseract-ocr.
//             @param component_rects If provided the method will output a list of Rects for the individual
//             text elements found (e.g. words or text lines).
//             @param component_texts If provided the method will output a list of text strings for the
//             recognition of individual text elements found (e.g. words or text lines).
//             @param component_confidences If provided the method will output a list of confidence values
//             for the recognition of individual text elements found (e.g. words or text lines).
//             @param component_level OCR_LEVEL_WORD (by default), or OCR_LEVEL_TEXTLINE.
//         */
//        public string run(Mat image, int min_confidence, int component_level)
//        {
//            ThrowIfDisposed();
//            if (image != null) image.ThrowIfDisposed();

//            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(text_OCRTesseract_run_10(nativeObj, image.nativeObj, min_confidence, component_level)));

//            return retVal;
//        }

//        /**
//         @brief Recognize text using the tesseract-ocr API.
         
//             Takes image on input and returns recognized text in the output_text parameter. Optionally
//             provides also the Rects for individual text elements found (e.g. words), and the list of those
//             text elements with their confidence values.
         
//             @param image Input image CV_8UC1 or CV_8UC3
//             @param output_text Output text of the tesseract-ocr.
//             @param component_rects If provided the method will output a list of Rects for the individual
//             text elements found (e.g. words or text lines).
//             @param component_texts If provided the method will output a list of text strings for the
//             recognition of individual text elements found (e.g. words or text lines).
//             @param component_confidences If provided the method will output a list of confidence values
//             for the recognition of individual text elements found (e.g. words or text lines).
//             @param component_level OCR_LEVEL_WORD (by default), or OCR_LEVEL_TEXTLINE.
//         */
//        public string run(Mat image, int min_confidence)
//        {
//            ThrowIfDisposed();
//            if (image != null) image.ThrowIfDisposed();

//            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(text_OCRTesseract_run_11(nativeObj, image.nativeObj, min_confidence)));

//            return retVal;
//        }


//        //
//        // C++:  String cv::text::OCRTesseract::run(Mat image, Mat mask, int min_confidence, int component_level = 0)
//        //

//        public string run(Mat image, Mat mask, int min_confidence, int component_level)
//        {
//            ThrowIfDisposed();
//            if (image != null) image.ThrowIfDisposed();
//            if (mask != null) mask.ThrowIfDisposed();

//            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(text_OCRTesseract_run_12(nativeObj, image.nativeObj, mask.nativeObj, min_confidence, component_level)));

//            return retVal;
//        }

//        public string run(Mat image, Mat mask, int min_confidence)
//        {
//            ThrowIfDisposed();
//            if (image != null) image.ThrowIfDisposed();
//            if (mask != null) mask.ThrowIfDisposed();

//            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(text_OCRTesseract_run_13(nativeObj, image.nativeObj, mask.nativeObj, min_confidence)));

//            return retVal;
//        }


//        //
//        // C++:  void cv::text::OCRTesseract::setWhiteList(String char_whitelist)
//        //

//        public void setWhiteList(string char_whitelist)
//        {
//            ThrowIfDisposed();

//            text_OCRTesseract_setWhiteList_10(nativeObj, char_whitelist);


//        }


//        //
//        // C++: static Ptr_OCRTesseract cv::text::OCRTesseract::create(c_string datapath = 0, c_string language = 0, c_string char_whitelist = 0, int oem = OEM_DEFAULT, int psmode = PSM_AUTO)
//        //

//        /**
//         @brief Creates an instance of the OCRTesseract class. Initializes Tesseract.
         
//             @param datapath the name of the parent directory of tessdata ended with "/", or NULL to use the
//             system's default directory.
//             @param language an ISO 639-3 code or NULL will default to "eng".
//             @param char_whitelist specifies the list of characters used for recognition. NULL defaults to ""
//             (All characters will be used for recognition).
//             @param oem tesseract-ocr offers different OCR Engine Modes (OEM), by default
//             tesseract::OEM_DEFAULT is used. See the tesseract-ocr API documentation for other possible
//             values.
//             @param psmode tesseract-ocr offers different Page Segmentation Modes (PSM) tesseract::PSM_AUTO
//             (fully automatic layout analysis) is used. See the tesseract-ocr API documentation for other
//             possible values.
         
//             @note The char_whitelist default is changed after OpenCV 4.7.0/3.19.0 from "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" to "".
//         */
//        public static OCRTesseract create(string datapath, string language, string char_whitelist, int oem, int psmode)
//        {


//            return OCRTesseract.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(text_OCRTesseract_create_10(datapath, language, char_whitelist, oem, psmode)));


//        }

//        /**
//         @brief Creates an instance of the OCRTesseract class. Initializes Tesseract.
         
//             @param datapath the name of the parent directory of tessdata ended with "/", or NULL to use the
//             system's default directory.
//             @param language an ISO 639-3 code or NULL will default to "eng".
//             @param char_whitelist specifies the list of characters used for recognition. NULL defaults to ""
//             (All characters will be used for recognition).
//             @param oem tesseract-ocr offers different OCR Engine Modes (OEM), by default
//             tesseract::OEM_DEFAULT is used. See the tesseract-ocr API documentation for other possible
//             values.
//             @param psmode tesseract-ocr offers different Page Segmentation Modes (PSM) tesseract::PSM_AUTO
//             (fully automatic layout analysis) is used. See the tesseract-ocr API documentation for other
//             possible values.
         
//             @note The char_whitelist default is changed after OpenCV 4.7.0/3.19.0 from "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" to "".
//         */
//        public static OCRTesseract create(string datapath, string language, string char_whitelist, int oem)
//        {


//            return OCRTesseract.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(text_OCRTesseract_create_11(datapath, language, char_whitelist, oem)));


//        }

//        /**
//         @brief Creates an instance of the OCRTesseract class. Initializes Tesseract.
         
//             @param datapath the name of the parent directory of tessdata ended with "/", or NULL to use the
//             system's default directory.
//             @param language an ISO 639-3 code or NULL will default to "eng".
//             @param char_whitelist specifies the list of characters used for recognition. NULL defaults to ""
//             (All characters will be used for recognition).
//             @param oem tesseract-ocr offers different OCR Engine Modes (OEM), by default
//             tesseract::OEM_DEFAULT is used. See the tesseract-ocr API documentation for other possible
//             values.
//             @param psmode tesseract-ocr offers different Page Segmentation Modes (PSM) tesseract::PSM_AUTO
//             (fully automatic layout analysis) is used. See the tesseract-ocr API documentation for other
//             possible values.
         
//             @note The char_whitelist default is changed after OpenCV 4.7.0/3.19.0 from "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" to "".
//         */
//        public static OCRTesseract create(string datapath, string language, string char_whitelist)
//        {


//            return OCRTesseract.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(text_OCRTesseract_create_12(datapath, language, char_whitelist)));


//        }

//        /**
//         @brief Creates an instance of the OCRTesseract class. Initializes Tesseract.
         
//             @param datapath the name of the parent directory of tessdata ended with "/", or NULL to use the
//             system's default directory.
//             @param language an ISO 639-3 code or NULL will default to "eng".
//             @param char_whitelist specifies the list of characters used for recognition. NULL defaults to ""
//             (All characters will be used for recognition).
//             @param oem tesseract-ocr offers different OCR Engine Modes (OEM), by default
//             tesseract::OEM_DEFAULT is used. See the tesseract-ocr API documentation for other possible
//             values.
//             @param psmode tesseract-ocr offers different Page Segmentation Modes (PSM) tesseract::PSM_AUTO
//             (fully automatic layout analysis) is used. See the tesseract-ocr API documentation for other
//             possible values.
         
//             @note The char_whitelist default is changed after OpenCV 4.7.0/3.19.0 from "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" to "".
//         */
//        public static OCRTesseract create(string datapath, string language)
//        {


//            return OCRTesseract.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(text_OCRTesseract_create_13(datapath, language)));


//        }

//        /**
//         @brief Creates an instance of the OCRTesseract class. Initializes Tesseract.
         
//             @param datapath the name of the parent directory of tessdata ended with "/", or NULL to use the
//             system's default directory.
//             @param language an ISO 639-3 code or NULL will default to "eng".
//             @param char_whitelist specifies the list of characters used for recognition. NULL defaults to ""
//             (All characters will be used for recognition).
//             @param oem tesseract-ocr offers different OCR Engine Modes (OEM), by default
//             tesseract::OEM_DEFAULT is used. See the tesseract-ocr API documentation for other possible
//             values.
//             @param psmode tesseract-ocr offers different Page Segmentation Modes (PSM) tesseract::PSM_AUTO
//             (fully automatic layout analysis) is used. See the tesseract-ocr API documentation for other
//             possible values.
         
//             @note The char_whitelist default is changed after OpenCV 4.7.0/3.19.0 from "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" to "".
//         */
//        public static OCRTesseract create(string datapath)
//        {


//            return OCRTesseract.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(text_OCRTesseract_create_14(datapath)));


//        }

//        /**
//         @brief Creates an instance of the OCRTesseract class. Initializes Tesseract.
         
//             @param datapath the name of the parent directory of tessdata ended with "/", or NULL to use the
//             system's default directory.
//             @param language an ISO 639-3 code or NULL will default to "eng".
//             @param char_whitelist specifies the list of characters used for recognition. NULL defaults to ""
//             (All characters will be used for recognition).
//             @param oem tesseract-ocr offers different OCR Engine Modes (OEM), by default
//             tesseract::OEM_DEFAULT is used. See the tesseract-ocr API documentation for other possible
//             values.
//             @param psmode tesseract-ocr offers different Page Segmentation Modes (PSM) tesseract::PSM_AUTO
//             (fully automatic layout analysis) is used. See the tesseract-ocr API documentation for other
//             possible values.
         
//             @note The char_whitelist default is changed after OpenCV 4.7.0/3.19.0 from "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" to "".
//         */
//        public static OCRTesseract create()
//        {


//            return OCRTesseract.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(text_OCRTesseract_create_15()));


//        }


//#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
//        const string LIBNAME = "__Internal";
//#else
//        const string LIBNAME = "opencvforunity";
//#endif



//        // C++:  String cv::text::OCRTesseract::run(Mat image, int min_confidence, int component_level = 0)
//        [DllImport(LIBNAME)]
//        private static extern IntPtr text_OCRTesseract_run_10(IntPtr nativeObj, IntPtr image_nativeObj, int min_confidence, int component_level);
//        [DllImport(LIBNAME)]
//        private static extern IntPtr text_OCRTesseract_run_11(IntPtr nativeObj, IntPtr image_nativeObj, int min_confidence);

//        // C++:  String cv::text::OCRTesseract::run(Mat image, Mat mask, int min_confidence, int component_level = 0)
//        [DllImport(LIBNAME)]
//        private static extern IntPtr text_OCRTesseract_run_12(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr mask_nativeObj, int min_confidence, int component_level);
//        [DllImport(LIBNAME)]
//        private static extern IntPtr text_OCRTesseract_run_13(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr mask_nativeObj, int min_confidence);

//        // C++:  void cv::text::OCRTesseract::setWhiteList(String char_whitelist)
//        [DllImport(LIBNAME)]
//        private static extern void text_OCRTesseract_setWhiteList_10(IntPtr nativeObj, string char_whitelist);

//        // C++: static Ptr_OCRTesseract cv::text::OCRTesseract::create(c_string datapath = 0, c_string language = 0, c_string char_whitelist = 0, int oem = OEM_DEFAULT, int psmode = PSM_AUTO)
//        [DllImport(LIBNAME)]
//        private static extern IntPtr text_OCRTesseract_create_10(string datapath, string language, string char_whitelist, int oem, int psmode);
//        [DllImport(LIBNAME)]
//        private static extern IntPtr text_OCRTesseract_create_11(string datapath, string language, string char_whitelist, int oem);
//        [DllImport(LIBNAME)]
//        private static extern IntPtr text_OCRTesseract_create_12(string datapath, string language, string char_whitelist);
//        [DllImport(LIBNAME)]
//        private static extern IntPtr text_OCRTesseract_create_13(string datapath, string language);
//        [DllImport(LIBNAME)]
//        private static extern IntPtr text_OCRTesseract_create_14(string datapath);
//        [DllImport(LIBNAME)]
//        private static extern IntPtr text_OCRTesseract_create_15();

//        // native support for java finalize()
//        [DllImport(LIBNAME)]
//        private static extern void text_OCRTesseract_delete(IntPtr nativeObj);

//    }
//}
