
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.MlModule
{

    // C++: class DTrees
    /**
     @brief The class represents a single decision tree or a collection of decision trees.
     
     The current public interface of the class allows user to train only a single decision tree, however
     the class is capable of storing multiple decision trees and using them for prediction (by summing
     responses or using a voting schemes), and the derived from DTrees classes (such as RTrees and Boost)
     use this capability to implement decision tree ensembles.
     
     @sa @ref ml_intro_trees
     */

    public class DTrees : StatModel
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
                        ml_DTrees_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DTrees(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new DTrees __fromPtr__(IntPtr addr) { return new DTrees(addr); }

        // C++: enum cv.ml.DTrees.Flags
        public const int PREDICT_AUTO = 0;
        public const int PREDICT_SUM = (1 << 8);
        public const int PREDICT_MAX_VOTE = (2 << 8);
        public const int PREDICT_MASK = (3 << 8);
        //
        // C++:  int cv::ml::DTrees::getMaxCategories()
        //

        /**
         @see setMaxCategories
         */
        public int getMaxCategories()
        {
            ThrowIfDisposed();

            return ml_DTrees_getMaxCategories_10(nativeObj);


        }


        //
        // C++:  void cv::ml::DTrees::setMaxCategories(int val)
        //

        /**
         @copybrief getMaxCategories @see getMaxCategories
         */
        public void setMaxCategories(int val)
        {
            ThrowIfDisposed();

            ml_DTrees_setMaxCategories_10(nativeObj, val);


        }


        //
        // C++:  int cv::ml::DTrees::getMaxDepth()
        //

        /**
         @see setMaxDepth
         */
        public int getMaxDepth()
        {
            ThrowIfDisposed();

            return ml_DTrees_getMaxDepth_10(nativeObj);


        }


        //
        // C++:  void cv::ml::DTrees::setMaxDepth(int val)
        //

        /**
         @copybrief getMaxDepth @see getMaxDepth
         */
        public void setMaxDepth(int val)
        {
            ThrowIfDisposed();

            ml_DTrees_setMaxDepth_10(nativeObj, val);


        }


        //
        // C++:  int cv::ml::DTrees::getMinSampleCount()
        //

        /**
         @see setMinSampleCount
         */
        public int getMinSampleCount()
        {
            ThrowIfDisposed();

            return ml_DTrees_getMinSampleCount_10(nativeObj);


        }


        //
        // C++:  void cv::ml::DTrees::setMinSampleCount(int val)
        //

        /**
         @copybrief getMinSampleCount @see getMinSampleCount
         */
        public void setMinSampleCount(int val)
        {
            ThrowIfDisposed();

            ml_DTrees_setMinSampleCount_10(nativeObj, val);


        }


        //
        // C++:  int cv::ml::DTrees::getCVFolds()
        //

        /**
         @see setCVFolds
         */
        public int getCVFolds()
        {
            ThrowIfDisposed();

            return ml_DTrees_getCVFolds_10(nativeObj);


        }


        //
        // C++:  void cv::ml::DTrees::setCVFolds(int val)
        //

        /**
         @copybrief getCVFolds @see getCVFolds
         */
        public void setCVFolds(int val)
        {
            ThrowIfDisposed();

            ml_DTrees_setCVFolds_10(nativeObj, val);


        }


        //
        // C++:  bool cv::ml::DTrees::getUseSurrogates()
        //

        /**
         @see setUseSurrogates
         */
        public bool getUseSurrogates()
        {
            ThrowIfDisposed();

            return ml_DTrees_getUseSurrogates_10(nativeObj);


        }


        //
        // C++:  void cv::ml::DTrees::setUseSurrogates(bool val)
        //

        /**
         @copybrief getUseSurrogates @see getUseSurrogates
         */
        public void setUseSurrogates(bool val)
        {
            ThrowIfDisposed();

            ml_DTrees_setUseSurrogates_10(nativeObj, val);


        }


        //
        // C++:  bool cv::ml::DTrees::getUse1SERule()
        //

        /**
         @see setUse1SERule
         */
        public bool getUse1SERule()
        {
            ThrowIfDisposed();

            return ml_DTrees_getUse1SERule_10(nativeObj);


        }


        //
        // C++:  void cv::ml::DTrees::setUse1SERule(bool val)
        //

        /**
         @copybrief getUse1SERule @see getUse1SERule
         */
        public void setUse1SERule(bool val)
        {
            ThrowIfDisposed();

            ml_DTrees_setUse1SERule_10(nativeObj, val);


        }


        //
        // C++:  bool cv::ml::DTrees::getTruncatePrunedTree()
        //

        /**
         @see setTruncatePrunedTree
         */
        public bool getTruncatePrunedTree()
        {
            ThrowIfDisposed();

            return ml_DTrees_getTruncatePrunedTree_10(nativeObj);


        }


        //
        // C++:  void cv::ml::DTrees::setTruncatePrunedTree(bool val)
        //

        /**
         @copybrief getTruncatePrunedTree @see getTruncatePrunedTree
         */
        public void setTruncatePrunedTree(bool val)
        {
            ThrowIfDisposed();

            ml_DTrees_setTruncatePrunedTree_10(nativeObj, val);


        }


        //
        // C++:  float cv::ml::DTrees::getRegressionAccuracy()
        //

        /**
         @see setRegressionAccuracy
         */
        public float getRegressionAccuracy()
        {
            ThrowIfDisposed();

            return ml_DTrees_getRegressionAccuracy_10(nativeObj);


        }


        //
        // C++:  void cv::ml::DTrees::setRegressionAccuracy(float val)
        //

        /**
         @copybrief getRegressionAccuracy @see getRegressionAccuracy
         */
        public void setRegressionAccuracy(float val)
        {
            ThrowIfDisposed();

            ml_DTrees_setRegressionAccuracy_10(nativeObj, val);


        }


        //
        // C++:  Mat cv::ml::DTrees::getPriors()
        //

        /**
         @see setPriors
         */
        public Mat getPriors()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(ml_DTrees_getPriors_10(nativeObj)));


        }


        //
        // C++:  void cv::ml::DTrees::setPriors(Mat val)
        //

        /**
         @copybrief getPriors @see getPriors
         */
        public void setPriors(Mat val)
        {
            ThrowIfDisposed();
            if (val != null) val.ThrowIfDisposed();

            ml_DTrees_setPriors_10(nativeObj, val.nativeObj);


        }


        //
        // C++: static Ptr_DTrees cv::ml::DTrees::create()
        //

        /**
         @brief Creates the empty model
         
             The static method creates empty decision tree with the specified parameters. It should be then
             trained using train method (see StatModel::train). Alternatively, you can load the model from
             file using Algorithm::load&lt;DTrees&gt;(filename).
         */
        public static DTrees create()
        {


            return DTrees.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_DTrees_create_10()));


        }


        //
        // C++: static Ptr_DTrees cv::ml::DTrees::load(String filepath, String nodeName = String())
        //

        /**
         @brief Loads and creates a serialized DTrees from a file
              *
              * Use DTree::save to serialize and store an DTree to disk.
              * Load the DTree from this file again, by calling this function with the path to the file.
              * Optionally specify the node for the file containing the classifier
              *
              * @param filepath path to serialized DTree
              * @param nodeName name of node containing the classifier
         */
        public static DTrees load(string filepath, string nodeName)
        {


            return DTrees.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_DTrees_load_10(filepath, nodeName)));


        }

        /**
         @brief Loads and creates a serialized DTrees from a file
              *
              * Use DTree::save to serialize and store an DTree to disk.
              * Load the DTree from this file again, by calling this function with the path to the file.
              * Optionally specify the node for the file containing the classifier
              *
              * @param filepath path to serialized DTree
              * @param nodeName name of node containing the classifier
         */
        public static DTrees load(string filepath)
        {


            return DTrees.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_DTrees_load_11(filepath)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::ml::DTrees::getMaxCategories()
        [DllImport(LIBNAME)]
        private static extern int ml_DTrees_getMaxCategories_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setMaxCategories(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setMaxCategories_10(IntPtr nativeObj, int val);

        // C++:  int cv::ml::DTrees::getMaxDepth()
        [DllImport(LIBNAME)]
        private static extern int ml_DTrees_getMaxDepth_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setMaxDepth(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setMaxDepth_10(IntPtr nativeObj, int val);

        // C++:  int cv::ml::DTrees::getMinSampleCount()
        [DllImport(LIBNAME)]
        private static extern int ml_DTrees_getMinSampleCount_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setMinSampleCount(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setMinSampleCount_10(IntPtr nativeObj, int val);

        // C++:  int cv::ml::DTrees::getCVFolds()
        [DllImport(LIBNAME)]
        private static extern int ml_DTrees_getCVFolds_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setCVFolds(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setCVFolds_10(IntPtr nativeObj, int val);

        // C++:  bool cv::ml::DTrees::getUseSurrogates()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_DTrees_getUseSurrogates_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setUseSurrogates(bool val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setUseSurrogates_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // C++:  bool cv::ml::DTrees::getUse1SERule()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_DTrees_getUse1SERule_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setUse1SERule(bool val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setUse1SERule_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // C++:  bool cv::ml::DTrees::getTruncatePrunedTree()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_DTrees_getTruncatePrunedTree_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setTruncatePrunedTree(bool val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setTruncatePrunedTree_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // C++:  float cv::ml::DTrees::getRegressionAccuracy()
        [DllImport(LIBNAME)]
        private static extern float ml_DTrees_getRegressionAccuracy_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setRegressionAccuracy(float val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setRegressionAccuracy_10(IntPtr nativeObj, float val);

        // C++:  Mat cv::ml::DTrees::getPriors()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_DTrees_getPriors_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setPriors(Mat val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setPriors_10(IntPtr nativeObj, IntPtr val_nativeObj);

        // C++: static Ptr_DTrees cv::ml::DTrees::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_DTrees_create_10();

        // C++: static Ptr_DTrees cv::ml::DTrees::load(String filepath, String nodeName = String())
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_DTrees_load_10(string filepath, string nodeName);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_DTrees_load_11(string filepath);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_delete(IntPtr nativeObj);

    }
}
