using OpenCVForUnity.CoreModule;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace OpenCVForUnity.UnityUtils
{
    public static class DebugMatUtils
    {

#pragma warning disable 0414
        private static GameObject opencvDebugMatCanvas = null;

        private static GameObject imageWindows = null;

        private static RawImage bigImage = null;

        private static InputField dumpInputField = null;

        private static ImageWindow imageWindowTemplate = null;

        private static Dictionary<string, ImageWindow> imageWindowsDictionary = null;
#pragma warning restore 0414

        /**
         * LayoutType
         */
        public enum LayoutType
        {
            TOP,
            LEFT,
            RIGHT,
            BOTTOM
        }

        /**
         * Destroys the DebugMatUtils GameObjects.
         * 
         * The method clear destroys DebugMatUtils-related GameObjects from the hierarchy.
         * 
         */
        public static void clear()
        {
            //Debug.Log("clear()");
            if (opencvDebugMatCanvas != null)
            {
                GameObject.Destroy(opencvDebugMatCanvas);
            }
            opencvDebugMatCanvas = null;
            imageWindows = null;
            bigImage = null;
            dumpInputField = null;
            imageWindowTemplate = null;
            imageWindowsDictionary = null;
        }

        /**
         * Setup the DebugMatUtils GameObject.
         * 
         * The method setup sets up DebugMatUtils-related GameObjects to the hierarchy.
         * By calling this method, the initialization process that occurs when the imshow() method is called for the first time can be performed in advance.
         * 
         * @param type LayoutType
         */
        public static void setup(LayoutType type = LayoutType.RIGHT)
        {
            if (opencvDebugMatCanvas == null)
            {
                //Debug.Log("setup()");

                opencvDebugMatCanvas = GameObject.Instantiate(Resources.Load<GameObject>("OpenCVDebugMatCanvas"));
                opencvDebugMatCanvas.name = opencvDebugMatCanvas.name.Substring(0, opencvDebugMatCanvas.name.Length - 7);

                switch (type)
                {
                    case LayoutType.TOP:
                        imageWindows = opencvDebugMatCanvas.transform.Find("VerticalPanel/TopImageWindows").gameObject;
                        break;
                    case LayoutType.LEFT:
                        imageWindows = opencvDebugMatCanvas.transform.Find("VerticalPanel/HorizontalPanel/LeftImageWindows").gameObject;
                        break;
                    case LayoutType.RIGHT:
                    default:
                        imageWindows = opencvDebugMatCanvas.transform.Find("VerticalPanel/HorizontalPanel/RightImageWindows").gameObject;
                        break;
                    case LayoutType.BOTTOM:
                        imageWindows = opencvDebugMatCanvas.transform.Find("VerticalPanel/BottomImageWindows").gameObject;
                        break;
                }

                imageWindows.SetActive(true);

                bigImage = opencvDebugMatCanvas.transform.Find("VerticalPanel/HorizontalPanel/MainPanel/BigImageWindow/BigImage").gameObject.GetComponent<RawImage>();

                dumpInputField = opencvDebugMatCanvas.transform.Find("VerticalPanel/HorizontalPanel/MainPanel/DumpInputField").gameObject.GetComponent<InputField>();

                imageWindowTemplate = Resources.Load<GameObject>("ImageWindow").GetComponent<ImageWindow>();

                imageWindowsDictionary = new Dictionary<string, ImageWindow>();
            }
        }

        /** 
         * Displays an image in the specified window.
         * 
         * The method imshow displays an image in the specified window.
         * 
         * If the image is 8-bit unsigned, it is displayed as is.
         * If the image is 16-bit unsigned, the pixels are divided by 256. That is, the
         * value range [0,255\*256] is mapped to [0,255].
         * If the image is 32-bit or 64-bit floating-point, the pixel values are multiplied by 255. That is, the
         * value range [0,1] is mapped to [0,255].
         * 32-bit integer images are not processed anymore due to ambiguouty of required transform.
         * Convert to 8-bit unsigned matrix using a custom preprocessing specific to image's context.
         * 
         * @param winname Name of the window.
         * @param mat Image to be shown.
         * @param dump Whether to display the result of mat.dump() method?
         * @param roi Extract the intersecting rectangle of img and roi.
         * @param debugText Displays the specified string in the InputField.
         */
        public static void imshow(string winname, Mat img, bool dump = false, CoreModule.Rect roi = null, string debugText = null)
        {

            CoreModule.Rect newRoi = null;
            if (roi != null)
            {
                if (roi.empty()) return;

                newRoi = CoreModule.Rect.intersect(new CoreModule.Rect(0, 0, img.width(), img.height()), roi);
                if (newRoi.empty()) return;
                //Debug.Log("newRoi " + newRoi);
            }

            setup();

            if (imageWindowsDictionary.Count >= 50) return;

            if (string.IsNullOrWhiteSpace(winname))
            {
                int i = 0;
                while (imageWindowsDictionary.ContainsKey("Mat_" + i))
                {
                    i++;
                }
                winname = "Mat_" + i;
            }

            if (!imageWindowsDictionary.ContainsKey(winname))
            {
                //Debug.Log("init "+winname);

                ImageWindow newImageWindow = GameObject.Instantiate(imageWindowTemplate.gameObject).GetComponent<ImageWindow>();
                newImageWindow.transform.SetParent(imageWindows.transform);
                newImageWindow.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                newImageWindow.name = winname;
                newImageWindow.bigImage = bigImage;
                newImageWindow.dumpInputField = dumpInputField;
                imageWindowsDictionary.Add(winname, newImageWindow);
            }
            ImageWindow imageWindow = imageWindowsDictionary[winname];

            imageWindow.setWinname(winname);
            imageWindow.setMat(img, dump, newRoi, debugText);
        }

        /** 
         * Displays debug text in the specified window.
         * 
         * The method imshow displays debug text in the specified window.
         * 
         * @param winname Name of the window.
         * @param debugText Displays the specified string in the InputField.
         */
        public static void imshow(string winname, string debugText)
        {
            imshow(winname, null, false, null, debugText);
        }

        /**
         * Destroys the specified window.
         * 
         * The method destroyWindow destroys the window with the given name.
         * 
         * @param winname Name of the window to be destroyed.
         */
        public static void destroyWindow(string winname)
        {
            if (winname == null) return;

            if (imageWindowsDictionary == null) return;

            if (imageWindowsDictionary.ContainsKey(winname))
            {
                GameObject.Destroy(imageWindowsDictionary[winname].gameObject);
                imageWindowsDictionary.Remove(winname);
            }
        }

        /**
         * Destroys all of the windows.
         * 
         * The method destroyAllWindows destroys all of the opened windows.
         */
        public static void destroyAllWindows()
        {
            if (imageWindowsDictionary == null) return;

            foreach (var value in imageWindowsDictionary.Values)
            {
                GameObject.Destroy(value.gameObject);
            }
            imageWindowsDictionary.Clear();
        }
    }
}
