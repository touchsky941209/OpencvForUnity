using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraViewportScript : MonoBehaviour
{
    public Transform target;
    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
      //  Vector3 viewPos = cam.WorldToViewportPoint(target.position);
       // if (viewPos.x > 0.5F)
       //   print("target is on the right side!");
       // else
       //     print("target is on the left side!");
     //   Debug.Log("THe position of the sphere is " + viewPos);
    }
}
