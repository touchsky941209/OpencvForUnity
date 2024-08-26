#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

using OpenCVForUnity.UnityUtils;

namespace OpenCVForUnity.Editor
{
    public class OpenCVForUnityResetDebugMatUtils : MonoBehaviour
    {

        [InitializeOnEnterPlayMode]
        static void InitializeOnEnterPlayMode()
        {

            DebugMatUtils.clear();

        }
    }
}
#endif