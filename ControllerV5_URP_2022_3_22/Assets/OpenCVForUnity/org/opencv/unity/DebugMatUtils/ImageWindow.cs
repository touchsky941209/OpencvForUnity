using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;
using UnityEngine;
using UnityEngine.UI;

namespace OpenCVForUnity.UnityUtils
{
    [RequireComponent(typeof(RectTransform))]
    [RequireComponent(typeof(RawImage))]
    [RequireComponent(typeof(LayoutElement))]
    public class ImageWindow : MonoBehaviour
    {
        public RawImage bigImage;

        public InputField dumpInputField;

        string winname;

        Mat mat;

        Texture2D texture;

        string dumpText;

        RectTransform rectTracsform;

        RawImage rawImage;

        LayoutElement layoutElement;

        AspectRatioFitter aspectRatioFilter;

        void Awake()
        {
            //Debug.Log("Awake " + this.name);

            rectTracsform = this.GetComponent<RectTransform>();
            rawImage = this.GetComponent<RawImage>();
            layoutElement = this.GetComponent<LayoutElement>();

            texture = new Texture2D(100, 100, TextureFormat.RGBA32, false);
        }

        void OnDestroy()
        {
            //Debug.Log("OnDestroy " + this.name);

            if (mat != null) mat.Dispose();

            // Destroy the texture and set it to null
            if (texture != null)
            {
                if (bigImage.texture == texture)
                {
                    bigImage.transform.parent.gameObject.SetActive(false);
                    dumpInputField.gameObject.SetActive(false);
                }

                Texture2D.Destroy(texture);
                texture = null;
            }
        }

        public void setWinname(string winname)
        {
            this.winname = winname;
        }

        public void setMat(Mat img, bool dump, CoreModule.Rect roi, string debugText)
        {

            dumpText = "";
            dumpText += "<b>" + winname + "</b>";

            if (img == null)
            {
                if (mat != null) mat.Dispose();

                mat = new Mat(100, 100, CvType.CV_8UC4, new Scalar(0, 0, 0, 255));

                Imgproc.line(mat, new Point(0, 0), new Point(mat.width(), mat.height()), new Scalar(0, 255, 0, 255));
                Imgproc.line(mat, new Point(mat.width(), 0), new Point(0, mat.height()), new Scalar(0, 255, 0, 255));
            }
            else
            {
                //Debug.Log(winname + " img.ToString() " + img.ToString());

                Mat roiImg;
                if (roi != null)
                {
                    roiImg = new Mat(img, roi);
                }
                else
                {
                    roiImg = img;
                }
                //Debug.Log(winname + " roiImg.ToString() " + roiImg.ToString());

                //https://github.com/opencv/opencv/blob/4.8.0/modules/highgui/src/precomp.hpp#L154-L175
                int imgDepth = roiImg.depth();
                int imgChannels = roiImg.channels();
                int imgDims = roiImg.dims();

                if (imgDepth != CvType.CV_16F && imgDepth != CvType.CV_32S && imgChannels != 2 && imgChannels <= 4 && imgDims < 3)
                {
                    if (mat != null && roiImg.width() == mat.width() && roiImg.height() == mat.height() && roiImg.GetType() == mat.GetType())
                    {
                        //Debug.Log(winname + " reuse mat");
                        roiImg.copyTo(mat);
                    }
                    else
                    {
                        if (mat != null) mat.Dispose();

                        if (imgDepth == CvType.CV_8U)
                        {
                            mat = roiImg.clone();
                        }
                        else
                        {
                            mat = new Mat();
                            switch (imgDepth)
                            {
                                case CvType.CV_8S:
                                    //Core.convertScaleAbs(roiImg, mat, 1, 127);
                                    roiImg.convertTo(mat, CvType.CV_8U, 1, 127);
                                    break;
                                case CvType.CV_16S:
                                    //Core.convertScaleAbs(roiImg, mat, 1 / 255.0, 127);
                                    roiImg.convertTo(mat, CvType.CV_8U, 1 / 255.0, 127);
                                    break;
                                case CvType.CV_16U:
                                    //Core.convertScaleAbs(roiImg, mat, 1 / 255.0);
                                    roiImg.convertTo(mat, CvType.CV_8U, 1 / 255.0);
                                    break;
                                case CvType.CV_32F:
                                case CvType.CV_64F: // assuming image has values in range [0, 1)
                                    roiImg.convertTo(mat, CvType.CV_8U, 255.0, 0.0);
                                    break;
                            }
                        }
                    }
                }
                else
                {

                    if (mat != null && roiImg.width() == mat.width() && roiImg.height() == mat.height())
                    {
                        //Debug.Log(winname + " reuse mat");
                        mat.setTo(new Scalar(255, 255, 255, 255));
                    }
                    else
                    {
                        if (mat != null) mat.Dispose();

                        mat = new Mat(100, 100, CvType.CV_8UC4, new Scalar(255, 255, 255, 255));
                    }
                    Imgproc.line(mat, new Point(0, 0), new Point(mat.width(), mat.height()), new Scalar(255, 0, 0, 255));
                    Imgproc.line(mat, new Point(mat.width(), 0), new Point(0, mat.height()), new Scalar(255, 0, 0, 255));

                    dumpText += "\nIf depth == CvType.CV_16F && depth == CvType.CV_32S && channels == 2 && dims > 2, image preview is not supported. If the dump flag is enabled, the Mat value can be dumped.";

                }

                dumpText += "\n" + img.ToString();
                if (roi != null) dumpText += "\n<b>roi</b> : " + roi.ToString();
                if (dump)
                {
                    if (roiImg.width() * roiImg.height() <= 400)
                    {
                        dumpText += "\n<b>dump</b> : " + roiImg.dump();
                    }
                    else
                    {
                        dumpText += "\n<b>dump</b> : Mat larger than 400 pixels cannot be dumped, so specify roi in the imshow method.";
                    }
                }

                if (roi != null) roiImg.Dispose();
            }
            if (!string.IsNullOrEmpty(debugText)) dumpText += "\n<b>debugText</b> : " + debugText;

            //Debug.Log(winname + " mat.ToString() " + mat.ToString());

            if (mat.width() != texture.width || mat.height() != texture.height)
            {

#if UNITY_2021_1_OR_NEWER
                texture.Reinitialize(mat.width(), mat.height());
#else
                texture.Resize(mat.width(), mat.height());
#endif

                if (bigImage.texture == texture)
                {
                    aspectRatioFilter.aspectRatio = (float)texture.width / (float)texture.height;
                    dumpInputField.text = dumpText;
                }
            }

            Utils.matToTexture2D(mat, texture);

            rawImage.texture = texture;

            setNewDimension(mat.width(), mat.height());
        }

        public void setNewDimension​(int width, int height)
        {
            rectTracsform.sizeDelta = new Vector2(width, height);

            if (width < height)
            {
                layoutElement.preferredWidth = 100 * (float)width / (float)height;
                layoutElement.preferredHeight = 100;
            }
            else
            {
                layoutElement.preferredWidth = 100;
                layoutElement.preferredHeight = 100 * (float)height / (float)width;
            }
        }

        public void setNewPosition​(int x, int y)
        {
            rectTracsform.localPosition = new Vector3(x, -y, 0);
        }

        public void OnPointerClick()
        {
            //Debug.Log("OnPointerClick " + this.name);

            bigImage.texture = texture;
            aspectRatioFilter = bigImage.GetComponent<AspectRatioFitter>();
            aspectRatioFilter.aspectRatio = (float)texture.width / (float)texture.height;
            bigImage.transform.parent.gameObject.SetActive(false);
            bigImage.transform.parent.gameObject.SetActive(true);

            dumpInputField.text = dumpText;
            dumpInputField.gameObject.SetActive(false);
            dumpInputField.gameObject.SetActive(true);
        }
    }
}
