

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoioModule
{
    // C++: class VideoCapture
    /**
     @brief Class for video capturing from video files, image sequences or cameras.
     
     The class provides C++ API for capturing video from cameras or for reading video files and image sequences.
     
     Here is how the class can be used:
     @include samples/cpp/videocapture_basic.cpp
     
     @note In @ref videoio_c "C API" the black-box structure `CvCapture` is used instead of %VideoCapture.
     @note
     -   (C++) A basic sample on using the %VideoCapture interface can be found at
         `OPENCV_SOURCE_CODE/samples/cpp/videocapture_starter.cpp`
     -   (Python) A basic sample on using the %VideoCapture interface can be found at
         `OPENCV_SOURCE_CODE/samples/python/video.py`
     -   (Python) A multi threaded video processing sample can be found at
         `OPENCV_SOURCE_CODE/samples/python/video_threaded.py`
     -   (Python) %VideoCapture sample showcasing some features of the Video4Linux2 backend
         `OPENCV_SOURCE_CODE/samples/python/video_v4l2.py`
     */

    public class VideoCapture : DisposableOpenCVObject
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
                        videoio_VideoCapture_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal VideoCapture(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static VideoCapture __fromPtr__(IntPtr addr) { return new VideoCapture(addr); }

        //
        // C++:   cv::VideoCapture::VideoCapture()
        //

        /**
         @brief Default constructor
             @note In @ref videoio_c "C API", when you finished working with video, release CvCapture structure with
             cvReleaseCapture(), or use Ptr&lt;CvCapture&gt; that calls cvReleaseCapture() automatically in the
             destructor.
         */
        public VideoCapture()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoCapture_VideoCapture_10());


        }


        //
        // C++:   cv::VideoCapture::VideoCapture(String filename, int apiPreference = CAP_ANY)
        //

        /**
         @overload
             @brief  Opens a video file or a capturing device or an IP video stream for video capturing with API Preference
         
             @param filename it can be:
             - name of video file (eg. `video.avi`)
             - or image sequence (eg. `img_%02d.jpg`, which will read samples like `img_00.jpg, img_01.jpg, img_02.jpg, ...`)
             - or URL of video stream (eg. `protocol://host:port/script_name?script_params|auth`)
             - or GStreamer pipeline string in gst-launch tool format in case if GStreamer is used as backend
               Note that each video stream or IP camera feed has its own URL scheme. Please refer to the
               documentation of source stream to know the right URL.
             @param apiPreference preferred Capture API backends to use. Can be used to enforce a specific reader
             implementation if multiple are available: e.g. cv::CAP_FFMPEG or cv::CAP_IMAGES or cv::CAP_DSHOW.
         
             @sa cv::VideoCaptureAPIs
         */
        public VideoCapture(string filename, int apiPreference)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoCapture_VideoCapture_11(filename, apiPreference));


        }

        /**
         @overload
             @brief  Opens a video file or a capturing device or an IP video stream for video capturing with API Preference
         
             @param filename it can be:
             - name of video file (eg. `video.avi`)
             - or image sequence (eg. `img_%02d.jpg`, which will read samples like `img_00.jpg, img_01.jpg, img_02.jpg, ...`)
             - or URL of video stream (eg. `protocol://host:port/script_name?script_params|auth`)
             - or GStreamer pipeline string in gst-launch tool format in case if GStreamer is used as backend
               Note that each video stream or IP camera feed has its own URL scheme. Please refer to the
               documentation of source stream to know the right URL.
             @param apiPreference preferred Capture API backends to use. Can be used to enforce a specific reader
             implementation if multiple are available: e.g. cv::CAP_FFMPEG or cv::CAP_IMAGES or cv::CAP_DSHOW.
         
             @sa cv::VideoCaptureAPIs
         */
        public VideoCapture(string filename)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoCapture_VideoCapture_12(filename));


        }


        //
        // C++:   cv::VideoCapture::VideoCapture(String filename, int apiPreference, vector_int _params)
        //

        /**
         @overload
             @brief Opens a video file or a capturing device or an IP video stream for video capturing with API Preference and parameters
         
             The `params` parameter allows to specify extra parameters encoded as pairs `(paramId_1, paramValue_1, paramId_2, paramValue_2, ...)`.
             See cv::VideoCaptureProperties
         */
        public VideoCapture(string filename, int apiPreference, MatOfInt _params)
        {
            if (_params != null) _params.ThrowIfDisposed();
            Mat _params_mat = _params;
            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoCapture_VideoCapture_13(filename, apiPreference, _params_mat.nativeObj));


        }


        //
        // C++:   cv::VideoCapture::VideoCapture(int index, int apiPreference = CAP_ANY)
        //

        /**
         @overload
             @brief  Opens a camera for video capturing
         
             @param index id of the video capturing device to open. To open default camera using default backend just pass 0.
             (to backward compatibility usage of camera_id + domain_offset (CAP_*) is valid when apiPreference is CAP_ANY)
             @param apiPreference preferred Capture API backends to use. Can be used to enforce a specific reader
             implementation if multiple are available: e.g. cv::CAP_DSHOW or cv::CAP_MSMF or cv::CAP_V4L.
         
             @sa cv::VideoCaptureAPIs
         */
        public VideoCapture(int index, int apiPreference)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoCapture_VideoCapture_14(index, apiPreference));


        }

        /**
         @overload
             @brief  Opens a camera for video capturing
         
             @param index id of the video capturing device to open. To open default camera using default backend just pass 0.
             (to backward compatibility usage of camera_id + domain_offset (CAP_*) is valid when apiPreference is CAP_ANY)
             @param apiPreference preferred Capture API backends to use. Can be used to enforce a specific reader
             implementation if multiple are available: e.g. cv::CAP_DSHOW or cv::CAP_MSMF or cv::CAP_V4L.
         
             @sa cv::VideoCaptureAPIs
         */
        public VideoCapture(int index)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoCapture_VideoCapture_15(index));


        }


        //
        // C++:   cv::VideoCapture::VideoCapture(int index, int apiPreference, vector_int _params)
        //

        /**
         @overload
             @brief Opens a camera for video capturing with API Preference and parameters
         
             The `params` parameter allows to specify extra parameters encoded as pairs `(paramId_1, paramValue_1, paramId_2, paramValue_2, ...)`.
             See cv::VideoCaptureProperties
         */
        public VideoCapture(int index, int apiPreference, MatOfInt _params)
        {
            if (_params != null) _params.ThrowIfDisposed();
            Mat _params_mat = _params;
            nativeObj = DisposableObject.ThrowIfNullIntPtr(videoio_VideoCapture_VideoCapture_16(index, apiPreference, _params_mat.nativeObj));


        }


        //
        // C++:  bool cv::VideoCapture::open(String filename, int apiPreference = CAP_ANY)
        //

        /**
         @brief  Opens a video file or a capturing device or an IP video stream for video capturing.
         
             @overload
         
             Parameters are same as the constructor VideoCapture(const String&amp; filename, int apiPreference = CAP_ANY)
             @return `true` if the file has been successfully opened
         
             The method first calls VideoCapture::release to close the already opened file or camera.
         */
        public bool open(string filename, int apiPreference)
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_open_10(nativeObj, filename, apiPreference);


        }

        /**
         @brief  Opens a video file or a capturing device or an IP video stream for video capturing.
         
             @overload
         
             Parameters are same as the constructor VideoCapture(const String&amp; filename, int apiPreference = CAP_ANY)
             @return `true` if the file has been successfully opened
         
             The method first calls VideoCapture::release to close the already opened file or camera.
         */
        public bool open(string filename)
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_open_11(nativeObj, filename);


        }


        //
        // C++:  bool cv::VideoCapture::open(String filename, int apiPreference, vector_int _params)
        //

        /**
         @brief  Opens a video file or a capturing device or an IP video stream for video capturing with API Preference and parameters
         
             @overload
         
             The `params` parameter allows to specify extra parameters encoded as pairs `(paramId_1, paramValue_1, paramId_2, paramValue_2, ...)`.
             See cv::VideoCaptureProperties
         
             @return `true` if the file has been successfully opened
         
             The method first calls VideoCapture::release to close the already opened file or camera.
         */
        public bool open(string filename, int apiPreference, MatOfInt _params)
        {
            ThrowIfDisposed();
            if (_params != null) _params.ThrowIfDisposed();
            Mat _params_mat = _params;
            return videoio_VideoCapture_open_12(nativeObj, filename, apiPreference, _params_mat.nativeObj);


        }


        //
        // C++:  bool cv::VideoCapture::open(int index, int apiPreference = CAP_ANY)
        //

        /**
         @brief  Opens a camera for video capturing
         
             @overload
         
             Parameters are same as the constructor VideoCapture(int index, int apiPreference = CAP_ANY)
             @return `true` if the camera has been successfully opened.
         
             The method first calls VideoCapture::release to close the already opened file or camera.
         */
        public bool open(int index, int apiPreference)
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_open_13(nativeObj, index, apiPreference);


        }

        /**
         @brief  Opens a camera for video capturing
         
             @overload
         
             Parameters are same as the constructor VideoCapture(int index, int apiPreference = CAP_ANY)
             @return `true` if the camera has been successfully opened.
         
             The method first calls VideoCapture::release to close the already opened file or camera.
         */
        public bool open(int index)
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_open_14(nativeObj, index);


        }


        //
        // C++:  bool cv::VideoCapture::open(int index, int apiPreference, vector_int _params)
        //

        /**
         @brief  Opens a camera for video capturing with API Preference and parameters
         
             @overload
         
             The `params` parameter allows to specify extra parameters encoded as pairs `(paramId_1, paramValue_1, paramId_2, paramValue_2, ...)`.
             See cv::VideoCaptureProperties
         
             @return `true` if the camera has been successfully opened.
         
             The method first calls VideoCapture::release to close the already opened file or camera.
         */
        public bool open(int index, int apiPreference, MatOfInt _params)
        {
            ThrowIfDisposed();
            if (_params != null) _params.ThrowIfDisposed();
            Mat _params_mat = _params;
            return videoio_VideoCapture_open_15(nativeObj, index, apiPreference, _params_mat.nativeObj);


        }


        //
        // C++:  bool cv::VideoCapture::isOpened()
        //

        /**
         @brief Returns true if video capturing has been initialized already.
         
             If the previous call to VideoCapture constructor or VideoCapture::open() succeeded, the method returns
             true.
         */
        public bool isOpened()
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_isOpened_10(nativeObj);


        }


        //
        // C++:  void cv::VideoCapture::release()
        //

        /**
         @brief Closes video file or capturing device.
         
             The method is automatically called by subsequent VideoCapture::open and by VideoCapture
             destructor.
         
             The C function also deallocates memory and clears \*capture pointer.
         */
        public void release()
        {
            ThrowIfDisposed();

            videoio_VideoCapture_release_10(nativeObj);


        }


        //
        // C++:  bool cv::VideoCapture::grab()
        //

        /**
         @brief Grabs the next frame from video file or capturing device.
         
             @return `true` (non-zero) in the case of success.
         
             The method/function grabs the next frame from video file or camera and returns true (non-zero) in
             the case of success.
         
             The primary use of the function is in multi-camera environments, especially when the cameras do not
             have hardware synchronization. That is, you call VideoCapture::grab() for each camera and after that
             call the slower method VideoCapture::retrieve() to decode and get frame from each camera. This way
             the overhead on demosaicing or motion jpeg decompression etc. is eliminated and the retrieved frames
             from different cameras will be closer in time.
         
             Also, when a connected camera is multi-head (for example, a stereo camera or a Kinect device), the
             correct way of retrieving data from it is to call VideoCapture::grab() first and then call
             VideoCapture::retrieve() one or more times with different values of the channel parameter.
         
             @ref tutorial_kinect_openni
         */
        public bool grab()
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_grab_10(nativeObj);


        }


        //
        // C++:  bool cv::VideoCapture::retrieve(Mat& image, int flag = 0)
        //

        /**
         @brief Decodes and returns the grabbed video frame.
         
             @param [out] image the video frame is returned here. If no frames has been grabbed the image will be empty.
             @param flag it could be a frame index or a driver specific flag
             @return `false` if no frames has been grabbed
         
             The method decodes and returns the just grabbed frame. If no frames has been grabbed
             (camera has been disconnected, or there are no more frames in video file), the method returns false
             and the function returns an empty image (with %cv::Mat, test it with Mat::empty()).
         
             @sa read()
         
             @note In @ref videoio_c "C API", functions cvRetrieveFrame() and cv.RetrieveFrame() return image stored inside the video
             capturing structure. It is not allowed to modify or release the image! You can copy the frame using
             cvCloneImage and then do whatever you want with the copy.
         */
        public bool retrieve(Mat image, int flag)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();

            return videoio_VideoCapture_retrieve_10(nativeObj, image.nativeObj, flag);


        }

        /**
         @brief Decodes and returns the grabbed video frame.
         
             @param [out] image the video frame is returned here. If no frames has been grabbed the image will be empty.
             @param flag it could be a frame index or a driver specific flag
             @return `false` if no frames has been grabbed
         
             The method decodes and returns the just grabbed frame. If no frames has been grabbed
             (camera has been disconnected, or there are no more frames in video file), the method returns false
             and the function returns an empty image (with %cv::Mat, test it with Mat::empty()).
         
             @sa read()
         
             @note In @ref videoio_c "C API", functions cvRetrieveFrame() and cv.RetrieveFrame() return image stored inside the video
             capturing structure. It is not allowed to modify or release the image! You can copy the frame using
             cvCloneImage and then do whatever you want with the copy.
         */
        public bool retrieve(Mat image)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();

            return videoio_VideoCapture_retrieve_11(nativeObj, image.nativeObj);


        }


        //
        // C++:  bool cv::VideoCapture::read(Mat& image)
        //

        /**
         @brief Grabs, decodes and returns the next video frame.
         
             @param [out] image the video frame is returned here. If no frames has been grabbed the image will be empty.
             @return `false` if no frames has been grabbed
         
             The method/function combines VideoCapture::grab() and VideoCapture::retrieve() in one call. This is the
             most convenient method for reading video files or capturing data from decode and returns the just
             grabbed frame. If no frames has been grabbed (camera has been disconnected, or there are no more
             frames in video file), the method returns false and the function returns empty image (with %cv::Mat, test it with Mat::empty()).
         
             @note In @ref videoio_c "C API", functions cvRetrieveFrame() and cv.RetrieveFrame() return image stored inside the video
             capturing structure. It is not allowed to modify or release the image! You can copy the frame using
             cvCloneImage and then do whatever you want with the copy.
         */
        public bool read(Mat image)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();

            return videoio_VideoCapture_read_10(nativeObj, image.nativeObj);


        }


        //
        // C++:  bool cv::VideoCapture::set(int propId, double value)
        //

        /**
         @brief Sets a property in the VideoCapture.
         
             @param propId Property identifier from cv::VideoCaptureProperties (eg. cv::CAP_PROP_POS_MSEC, cv::CAP_PROP_POS_FRAMES, ...)
             or one from @ref videoio_flags_others
             @param value Value of the property.
             @return `true` if the property is supported by backend used by the VideoCapture instance.
             @note Even if it returns `true` this doesn't ensure that the property
             value has been accepted by the capture device. See note in VideoCapture::get()
         */
        public bool set(int propId, double value)
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_set_10(nativeObj, propId, value);


        }


        //
        // C++:  double cv::VideoCapture::get(int propId)
        //

        /**
         @brief Returns the specified VideoCapture property
         
             @param propId Property identifier from cv::VideoCaptureProperties (eg. cv::CAP_PROP_POS_MSEC, cv::CAP_PROP_POS_FRAMES, ...)
             or one from @ref videoio_flags_others
             @return Value for the specified property. Value 0 is returned when querying a property that is
             not supported by the backend used by the VideoCapture instance.
         
             @note Reading / writing properties involves many layers. Some unexpected result might happens
             along this chain.
             @code{.txt}
             VideoCapture -&gt; API Backend -&gt; Operating System -&gt; Device Driver -&gt; Device Hardware
             @endcode
             The returned value might be different from what really used by the device or it could be encoded
             using device dependent rules (eg. steps or percentage). Effective behaviour depends from device
             driver and API Backend
         */
        public double get(int propId)
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_get_10(nativeObj, propId);


        }


        //
        // C++:  String cv::VideoCapture::getBackendName()
        //

        /**
         @brief Returns used backend API name
         
              @note Stream should be opened.
         */
        public string getBackendName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(videoio_VideoCapture_getBackendName_10(nativeObj)));

            return retVal;
        }


        //
        // C++:  void cv::VideoCapture::setExceptionMode(bool enable)
        //

        /**
         Switches exceptions mode
              *
              * methods raise exceptions if not successful instead of returning an error code
         */
        public void setExceptionMode(bool enable)
        {
            ThrowIfDisposed();

            videoio_VideoCapture_setExceptionMode_10(nativeObj, enable);


        }


        //
        // C++:  bool cv::VideoCapture::getExceptionMode()
        //

        public bool getExceptionMode()
        {
            ThrowIfDisposed();

            return videoio_VideoCapture_getExceptionMode_10(nativeObj);


        }


        //
        // C++: static bool cv::VideoCapture::waitAny(vector_VideoCapture streams, vector_int& readyIndex, int64 timeoutNs = 0)
        //

        // Unknown type 'vector_VideoCapture' (I), skipping the function


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::VideoCapture::VideoCapture()
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_10();

        // C++:   cv::VideoCapture::VideoCapture(String filename, int apiPreference = CAP_ANY)
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_11(string filename, int apiPreference);
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_12(string filename);

        // C++:   cv::VideoCapture::VideoCapture(String filename, int apiPreference, vector_int _params)
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_13(string filename, int apiPreference, IntPtr _params_mat_nativeObj);

        // C++:   cv::VideoCapture::VideoCapture(int index, int apiPreference = CAP_ANY)
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_14(int index, int apiPreference);
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_15(int index);

        // C++:   cv::VideoCapture::VideoCapture(int index, int apiPreference, vector_int _params)
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_16(int index, int apiPreference, IntPtr _params_mat_nativeObj);

        // C++:  bool cv::VideoCapture::open(String filename, int apiPreference = CAP_ANY)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_open_10(IntPtr nativeObj, string filename, int apiPreference);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_open_11(IntPtr nativeObj, string filename);

        // C++:  bool cv::VideoCapture::open(String filename, int apiPreference, vector_int _params)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_open_12(IntPtr nativeObj, string filename, int apiPreference, IntPtr _params_mat_nativeObj);

        // C++:  bool cv::VideoCapture::open(int index, int apiPreference = CAP_ANY)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_open_13(IntPtr nativeObj, int index, int apiPreference);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_open_14(IntPtr nativeObj, int index);

        // C++:  bool cv::VideoCapture::open(int index, int apiPreference, vector_int _params)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_open_15(IntPtr nativeObj, int index, int apiPreference, IntPtr _params_mat_nativeObj);

        // C++:  bool cv::VideoCapture::isOpened()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_isOpened_10(IntPtr nativeObj);

        // C++:  void cv::VideoCapture::release()
        [DllImport(LIBNAME)]
        private static extern void videoio_VideoCapture_release_10(IntPtr nativeObj);

        // C++:  bool cv::VideoCapture::grab()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_grab_10(IntPtr nativeObj);

        // C++:  bool cv::VideoCapture::retrieve(Mat& image, int flag = 0)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_retrieve_10(IntPtr nativeObj, IntPtr image_nativeObj, int flag);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_retrieve_11(IntPtr nativeObj, IntPtr image_nativeObj);

        // C++:  bool cv::VideoCapture::read(Mat& image)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_read_10(IntPtr nativeObj, IntPtr image_nativeObj);

        // C++:  bool cv::VideoCapture::set(int propId, double value)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_set_10(IntPtr nativeObj, int propId, double value);

        // C++:  double cv::VideoCapture::get(int propId)
        [DllImport(LIBNAME)]
        private static extern double videoio_VideoCapture_get_10(IntPtr nativeObj, int propId);

        // C++:  String cv::VideoCapture::getBackendName()
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_getBackendName_10(IntPtr nativeObj);

        // C++:  void cv::VideoCapture::setExceptionMode(bool enable)
        [DllImport(LIBNAME)]
        private static extern void videoio_VideoCapture_setExceptionMode_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool enable);

        // C++:  bool cv::VideoCapture::getExceptionMode()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool videoio_VideoCapture_getExceptionMode_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void videoio_VideoCapture_delete(IntPtr nativeObj);

    }
}
