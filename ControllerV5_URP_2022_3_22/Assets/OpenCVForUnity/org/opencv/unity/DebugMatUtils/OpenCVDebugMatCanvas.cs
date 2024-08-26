using OpenCVForUnity.UnityUtils;
using UnityEngine;

public class OpenCVDebugMatCanvas : MonoBehaviour
{

    private void OnDisable()
    {
        DebugMatUtils.clear();
    }
}
