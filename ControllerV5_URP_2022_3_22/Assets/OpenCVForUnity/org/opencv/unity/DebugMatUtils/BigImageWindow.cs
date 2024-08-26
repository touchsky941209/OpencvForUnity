using OpenCVForUnity.CoreModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace OpenCVForUnity.UnityUtils
{
    public class BigImageWindow : MonoBehaviour
    {

        public RectTransform bigImageWindow;

        public InputField dumpInputField;

        public void OnPointerClick()
        {
            //Debug.Log("OnPointerClick " + this.name);

            bigImageWindow.gameObject.SetActive(false);
            dumpInputField.gameObject.SetActive(false);
        }
    }
}
