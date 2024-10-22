#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgcodecsModule;
using OpenCVForUnity.ImgprocModule;
using OpenCVForUnity.UnityUtils;
using OpenCVForUnity.UnityUtils.Helper;
using OpenCVForUnityExample.DnnModel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OpenCVForUnityExample
{
    /// <summary>
    /// Facial Expression Recognition Example
    /// An example of using OpenCV dnn module with Facial Expression Recognition.
    /// Referring to https://github.com/opencv/opencv_zoo/tree/master/models/facial_expression_recognition
    /// </summary>
    [RequireComponent(typeof(WebCamTextureToMatHelper))]
    public class FacialExpressionRecognitionExample : MonoBehaviour
    {
        [Header("TEST")]

        [TooltipAttribute("Path to test input image.")]
        public string testInputImage;

        public string result_emotion;

        /// <summary>
        /// The texture.
        /// </summary>
        Texture2D texture;

        /// <summary>
        /// The webcam texture to mat helper.
        /// </summary>
        WebCamTextureToMatHelper webCamTextureToMatHelper;

        /// <summary>
        /// The bgr mat.
        /// </summary>
        Mat bgrMat;

        /// <summary>
        /// The facial expression recognizer.
        /// </summary>
        FacialExpressionRecognizer facialExpressionRecognizer;

        /// <summary>
        /// The FPS monitor.
        /// </summary>
        FpsMonitor fpsMonitor;

        /// <summary>
        /// FACIAL_EXPRESSION_RECOGNITION_MODEL_FILENAME
        /// </summary>
        protected static readonly string FACIAL_EXPRESSION_RECOGNITION_MODEL_FILENAME = "OpenCVForUnity/dnn/facial_expression_recognition_mobilefacenet_2022july.onnx";

        /// <summary>
        /// The facial expression recognition model filepath.
        /// </summary>
        string facial_expression_recognition_model_filepath;

        /// <summary>
        /// FACE_RECOGNITION_MODEL_FILENAME
        /// </summary>
        protected static readonly string FACE_RECOGNITION_MODEL_FILENAME = "OpenCVForUnity/dnn/face_recognition_sface_2021dec.onnx";

        /// <summary>
        /// The face recognition model filepath.
        /// </summary>
        string face_recognition_model_filepath;


        /// <summary>
        /// The YuNetV2FaceDetector.
        /// </summary>
        YuNetV2FaceDetector faceDetector;

        int inputSizeW = 320;
        int inputSizeH = 320;
        float scoreThreshold = 0.9f;
        float nmsThreshold = 0.3f;
        int topK = 5000;

        /// <summary>
        /// FACE_DETECTION_MODEL_FILENAME
        /// </summary>
        protected static readonly string FACE_DETECTION_MODEL_FILENAME = "OpenCVForUnity/dnn/face_detection_yunet_2023mar.onnx";

        /// <summary>
        /// The face detection model filepath.
        /// </summary>
        string face_detection_model_filepath;


#if UNITY_WEBGL
        IEnumerator getFilePath_Coroutine;
#endif

        // Use this for initialization
        void Start()
        {
            fpsMonitor = GetComponent<FpsMonitor>();

            webCamTextureToMatHelper = gameObject.GetComponent<WebCamTextureToMatHelper>();

#if UNITY_WEBGL
            getFilePath_Coroutine = GetFilePath();
            StartCoroutine(getFilePath_Coroutine);
#else
            face_detection_model_filepath = Utils.getFilePath(FACE_DETECTION_MODEL_FILENAME);
            facial_expression_recognition_model_filepath = Utils.getFilePath(FACIAL_EXPRESSION_RECOGNITION_MODEL_FILENAME);
            face_recognition_model_filepath = Utils.getFilePath(FACE_RECOGNITION_MODEL_FILENAME);
            Run();
#endif
        }

#if UNITY_WEBGL
        private IEnumerator GetFilePath()
        {
            var getFilePathAsync_0_Coroutine = Utils.getFilePathAsync(FACE_DETECTION_MODEL_FILENAME, (result) =>
            {
                face_detection_model_filepath = result;
            });
            yield return getFilePathAsync_0_Coroutine;

            var getFilePathAsync_1_Coroutine = Utils.getFilePathAsync(FACIAL_EXPRESSION_RECOGNITION_MODEL_FILENAME, (result) =>
            {
                facial_expression_recognition_model_filepath = result;
            });
            yield return getFilePathAsync_1_Coroutine;

            var getFilePathAsync_2_Coroutine = Utils.getFilePathAsync(FACE_RECOGNITION_MODEL_FILENAME, (result) =>
            {
                face_recognition_model_filepath = result;
            });
            yield return getFilePathAsync_2_Coroutine;

            getFilePath_Coroutine = null;

            Run();
        }
#endif

        // Use this for initialization
        void Run()
        {
            //if true, The error log of the Native side OpenCV will be displayed on the Unity Editor Console.
            Utils.setDebugMode(true);


            if (string.IsNullOrEmpty(face_detection_model_filepath))
            {
                Debug.LogError(FACE_DETECTION_MODEL_FILENAME + " is not loaded. Please read “StreamingAssets/OpenCVForUnity/dnn/setup_dnn_module.pdf” to make the necessary setup.");
            }
            else
            {
                faceDetector = new YuNetV2FaceDetector(face_detection_model_filepath, "", new Size(inputSizeW, inputSizeH), scoreThreshold, nmsThreshold, topK);
            }

            if (string.IsNullOrEmpty(facial_expression_recognition_model_filepath) || string.IsNullOrEmpty(face_recognition_model_filepath))
            {
                Debug.LogError(FACIAL_EXPRESSION_RECOGNITION_MODEL_FILENAME + " or " + FACE_RECOGNITION_MODEL_FILENAME + " is not loaded. Please read “StreamingAssets/OpenCVForUnity/dnn/setup_dnn_module.pdf” to make the necessary setup.");
            }
            else
            {
                facialExpressionRecognizer = new FacialExpressionRecognizer(facial_expression_recognition_model_filepath, face_recognition_model_filepath, "");
            }


            if (string.IsNullOrEmpty(testInputImage))
            {
#if UNITY_ANDROID && !UNITY_EDITOR
                // Avoids the front camera low light issue that occurs in only some Android devices (e.g. Google Pixel, Pixel2).
                webCamTextureToMatHelper.avoidAndroidFrontCameraLowLightIssue = true;
#endif
                webCamTextureToMatHelper.Initialize();
            }
            else
            {
                /////////////////////
                // TEST

                var getFilePathAsync_0_Coroutine = Utils.getFilePathAsync("OpenCVForUnity/dnn/" + testInputImage, (result) =>
                {
                    string test_input_image_filepath = result;
                    if (string.IsNullOrEmpty(test_input_image_filepath)) Debug.Log("The file:" + testInputImage + " did not exist in the folder “Assets/StreamingAssets/OpenCVForUnity/dnn”.");

                    Mat img = Imgcodecs.imread(test_input_image_filepath);
                    if (img.empty())
                    {
                        img = new Mat(424, 640, CvType.CV_8UC3, new Scalar(0, 0, 0));
                        Imgproc.putText(img, testInputImage + " is not loaded.", new Point(5, img.rows() - 30), Imgproc.FONT_HERSHEY_SIMPLEX, 0.7, new Scalar(255, 255, 255, 255), 2, Imgproc.LINE_AA, false);
                        Imgproc.putText(img, "Please read console message.", new Point(5, img.rows() - 10), Imgproc.FONT_HERSHEY_SIMPLEX, 0.7, new Scalar(255, 255, 255, 255), 2, Imgproc.LINE_AA, false);
                    }
                    else
                    {
                        TickMeter tm = new TickMeter();
                        tm.start();

                        Mat faces = faceDetector.infer(img);

                        tm.stop();
                        Debug.Log("YuNetFaceDetector Inference time, ms: " + tm.getTimeMilli());

                        List<Mat> expressions = new List<Mat>();

                        // Estimate the expression of each face
                        for (int i = 0; i < faces.rows(); ++i)
                        {
                            tm.reset();
                            tm.start();

                            // Facial expression recognizer inference
                            Mat facialExpression = facialExpressionRecognizer.infer(img, faces.row(i));

                            tm.stop();
                            Debug.Log("FacialExpressionRecognizer Inference time (preprocess + infer + postprocess), ms: " + tm.getTimeMilli());

                            if (!facialExpression.empty())
                                expressions.Add(facialExpression);
                        }
                        faceDetector.visualize(img, faces, true, false);
                        facialExpressionRecognizer.visualize(img, expressions, faces, true, false);
                    }

                    gameObject.transform.localScale = new Vector3(img.width(), img.height(), 1);
                    float imageWidth = img.width();
                    float imageHeight = img.height();
                    float widthScale = (float)Screen.width / imageWidth;
                    float heightScale = (float)Screen.height / imageHeight;
                    if (widthScale < heightScale)
                    {
                        Camera.main.orthographicSize = (imageWidth * (float)Screen.height / (float)Screen.width) / 2;
                    }
                    else
                    {
                        Camera.main.orthographicSize = imageHeight / 2;
                    }

                    Imgproc.cvtColor(img, img, Imgproc.COLOR_BGR2RGB);
                    Texture2D texture = new Texture2D(img.cols(), img.rows(), TextureFormat.RGB24, false);
                    Utils.matToTexture2D(img, texture);
                    gameObject.GetComponent<Renderer>().material.mainTexture = texture;

                });
                StartCoroutine(getFilePathAsync_0_Coroutine);

                /////////////////////
            }
        }

        /// <summary>
        /// Raises the webcam texture to mat helper initialized event.
        /// </summary>
        public void OnWebCamTextureToMatHelperInitialized()
        {
            Debug.Log("OnWebCamTextureToMatHelperInitialized");

            Mat webCamTextureMat = webCamTextureToMatHelper.GetMat();

            texture = new Texture2D(webCamTextureMat.cols(), webCamTextureMat.rows(), TextureFormat.RGBA32, false);
            Utils.matToTexture2D(webCamTextureMat, texture);

            gameObject.GetComponent<Renderer>().material.mainTexture = texture;

            gameObject.transform.localScale = new Vector3(webCamTextureMat.cols(), webCamTextureMat.rows(), 1);
            Debug.Log("Screen.width " + Screen.width + " Screen.height " + Screen.height + " Screen.orientation " + Screen.orientation);

            if (fpsMonitor != null)
            {
                fpsMonitor.Add("width", webCamTextureMat.width().ToString());
                fpsMonitor.Add("height", webCamTextureMat.height().ToString());
                fpsMonitor.Add("orientation", Screen.orientation.ToString());
            }


            float width = webCamTextureMat.width();
            float height = webCamTextureMat.height();

            float widthScale = (float)Screen.width / width;
            float heightScale = (float)Screen.height / height;
            if (widthScale < heightScale)
            {
                Camera.main.orthographicSize = (width * (float)Screen.height / (float)Screen.width) / 2;
            }
            else
            {
                Camera.main.orthographicSize = height / 2;
            }

            bgrMat = new Mat(webCamTextureMat.rows(), webCamTextureMat.cols(), CvType.CV_8UC3);
        }

        /// <summary>
        /// Raises the webcam texture to mat helper disposed event.
        /// </summary>
        public void OnWebCamTextureToMatHelperDisposed()
        {
            Debug.Log("OnWebCamTextureToMatHelperDisposed");

            if (bgrMat != null)
                bgrMat.Dispose();

            if (texture != null)
            {
                Texture2D.Destroy(texture);
                texture = null;
            }
        }

        /// <summary>
        /// Raises the webcam texture to mat helper error occurred event.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public void OnWebCamTextureToMatHelperErrorOccurred(WebCamTextureToMatHelper.ErrorCode errorCode)
        {
            Debug.Log("OnWebCamTextureToMatHelperErrorOccurred " + errorCode);
        }

        // Update is called once per frame
        void Update()
        {

            if (webCamTextureToMatHelper.IsPlaying() && webCamTextureToMatHelper.DidUpdateThisFrame())
            {
                getEmotion();
                Mat rgbaMat = webCamTextureToMatHelper.GetMat();

                if (faceDetector == null || facialExpressionRecognizer == null)
                {
                    Imgproc.putText(rgbaMat, "model file is not loaded.", new Point(5, rgbaMat.rows() - 30), Imgproc.FONT_HERSHEY_SIMPLEX, 0.7, new Scalar(255, 255, 255, 255), 2, Imgproc.LINE_AA, false);
                    Imgproc.putText(rgbaMat, "Please read console message.", new Point(5, rgbaMat.rows() - 10), Imgproc.FONT_HERSHEY_SIMPLEX, 0.7, new Scalar(255, 255, 255, 255), 2, Imgproc.LINE_AA, false);
                }
                else
                {
                    Imgproc.cvtColor(rgbaMat, bgrMat, Imgproc.COLOR_RGBA2BGR);

                    //TickMeter tm = new TickMeter();
                    //tm.start();

                    Mat faces = faceDetector.infer(bgrMat);

                    //tm.stop();
                    //Debug.Log("YuNetFaceDetector Inference time, ms: " + tm.getTimeMilli());

                    List<Mat> expressions = new List<Mat>();

                    // Estimate the expression of each face
                    for (int i = 0; i < faces.rows(); ++i)
                    {
                        //tm.reset();
                        //tm.start();

                        // Facial expression recognizer inference
                        Mat facialExpression = facialExpressionRecognizer.infer(bgrMat, faces.row(i));

                        //tm.stop();
                        //Debug.Log("FacialExpressionRecognizer Inference time (preprocess + infer + postprocess), ms: " + tm.getTimeMilli());

                        if (!facialExpression.empty())
                            expressions.Add(facialExpression);
                    }

                    Imgproc.cvtColor(bgrMat, rgbaMat, Imgproc.COLOR_BGR2RGBA);

                    //faceDetector.visualize(rgbaMat, faces, false, true);
                    facialExpressionRecognizer.visualize(rgbaMat, expressions, faces, false, true);
                }

                Utils.matToTexture2D(rgbaMat, texture);
            }

        }

        void getEmotion(){
            result_emotion = facialExpressionRecognizer.emotion;
        }

        /// <summary>
        /// Raises the destroy event.
        /// </summary>
        void OnDestroy()
        {
            webCamTextureToMatHelper.Dispose();

            if (faceDetector != null)
                faceDetector.dispose();

            if (facialExpressionRecognizer != null)
                facialExpressionRecognizer.dispose();

            Utils.setDebugMode(false);

#if UNITY_WEBGL
            if (getFilePath_Coroutine != null)
            {
                StopCoroutine(getFilePath_Coroutine);
                ((IDisposable)getFilePath_Coroutine).Dispose();
            }
#endif
        }

        /// <summary>
        /// Raises the back button click event.
        /// </summary>
        public void OnBackButtonClick()
        {
            SceneManager.LoadScene("OpenCVForUnityExample");
        }

        /// <summary>
        /// Raises the play button click event.
        /// </summary>
        public void OnPlayButtonClick()
        {
            webCamTextureToMatHelper.Play();
        }

        /// <summary>
        /// Raises the pause button click event.
        /// </summary>
        public void OnPauseButtonClick()
        {
            webCamTextureToMatHelper.Pause();
        }

        /// <summary>
        /// Raises the stop button click event.
        /// </summary>
        public void OnStopButtonClick()
        {
            webCamTextureToMatHelper.Stop();
        }

        /// <summary>
        /// Raises the change camera button click event.
        /// </summary>
        public void OnChangeCameraButtonClick()
        {
            webCamTextureToMatHelper.requestedIsFrontFacing = !webCamTextureToMatHelper.requestedIsFrontFacing;
        }
    }
}

#endif