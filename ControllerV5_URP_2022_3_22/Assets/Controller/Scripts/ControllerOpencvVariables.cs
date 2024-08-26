using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenCVForUnityExample;
using OpenCVForUnity;
using Range = OpenCVForUnity.CoreModule.Range;
using OpenCVForUnity.CoreModule;
using UnityEngine.SceneManagement;
using UnityEngine.VFX;


// public controllerOpencvVariables ControllerOpencvVariables;
// void Start()
// {
//     controllerOpencvVariables = GameObject.Find("Name of Object").GetComponent<ControllerOpencvVariables>();

// }
//VERY SMALL TEST COMMENT
public class ControllerOpencvVariables : MonoBehaviour
{
    //VARIABLES FOR CONVERTING WORLD SPACE TO VIEWPORT


    //VFX CONNECTIONS
    [SerializeField]
    public VisualEffect vfxGraph01;

    [SerializeField]
    float _localTestFloat;


    //VARIABLES FOR DEALING WITH MONITOR SIZE AND CONVERTING TO WORLDSCAPE
    [SerializeField]
    int _sizeX;
    
    [SerializeField]
    int _sizeY;

    //VARIABLES THAT HOLD THE OFFSET FOR WORLDSPACE
    int _screenXOffset;
    int _screenYOffset;

    //RIGHT HAND
    //right hand finger tips
    [SerializeField] Vector3 _localHand01_04;
    [SerializeField] Vector3 _localHand01_08;
    [SerializeField] Vector3 _localHand01_12;
    [SerializeField] Vector3 _localHand01_16;
    [SerializeField] Vector3 _localHand01_20;
    //right hand knuckles
    [SerializeField] Vector3 _localHand01_05;
    [SerializeField] Vector3 _localHand01_09;
    [SerializeField] Vector3 _localHand01_13;
    [SerializeField] Vector3 _localHand01_17;
    // base of hand
    [SerializeField] Vector3 _localHand01_00;

    //LEFT HAND
    //left hand finger tips
    [SerializeField] Vector3 _localHand02_04;
    [SerializeField] Vector3 _localHand02_08;
    [SerializeField] Vector3 _localHand02_12;
    [SerializeField] Vector3 _localHand02_16;
    [SerializeField] Vector3 _localHand02_20;
    //left hand knuckles
    [SerializeField] Vector3 _localHand02_05;
    [SerializeField] Vector3 _localHand02_09;
    [SerializeField] Vector3 _localHand02_13;
    [SerializeField] Vector3 _localHand02_17;
    // base of hand
    [SerializeField] Vector3 _localHand02_00;


    public string face_emotion;
    public Vector3[] hand_pose_left;
    public Vector3[] hand_pose_right;
    public Point right_eye;
    public Point left_eye;
    public Point nose;
    public Point right_mouth;
    public Point left_mouth;
    public float cam_width;
    public float cam_height;

    void Start()
    {
        hand_pose_left = new Vector3[21];
        hand_pose_right = new Vector3[21];
        _screenXOffset = _sizeX / 2;
        _screenYOffset = _sizeY / 2;

    }

    // Update is called once per frame
    void FixedUpdate()
    {


        // getFace();
        string activeSceneName = SceneManager.GetActiveScene().name;
        if( activeSceneName == "FaceDetectionYuNetExample") getFace();
        if( activeSceneName == "FacialExpressionRecognitionExample") getEmotion();
        if( activeSceneName == "HandPoseEstimationMediaPipeExample") getHandPose();
        if (activeSceneName == "HandPoseEstimationMediaPipeExample") sendToVFXGraph();


    }

    void getFace()

    {
        // !! SHOULD GO IN AND REMOVE ALL THE FINDS HERE. THESE CAN BE A PERMANENT LINK INSTEAD
        right_eye = GameObject.Find("Quad").GetComponent<FaceDetectionYuNetExample>().position_right_eye;
        left_eye = GameObject.Find("Quad").GetComponent<FaceDetectionYuNetExample>().position_left_eye;
        nose = GameObject.Find("Quad").GetComponent<FaceDetectionYuNetExample>().position_nose;
        right_mouth = GameObject.Find("Quad").GetComponent<FaceDetectionYuNetExample>().position_right_mouth;
        left_mouth = GameObject.Find("Quad").GetComponent<FaceDetectionYuNetExample>().position_left_mouth;
    }

    void getEmotion()
    {
        face_emotion = GameObject.Find("Quad").GetComponent<FacialExpressionRecognitionExample>().result_emotion;
    }

    void getHandPose()
    {
        hand_pose_left = GameObject.Find("Quad").GetComponent<HandPoseEstimationMediaPipeExample>().handpose_landmarks_points_left;
        hand_pose_right = GameObject.Find("Quad").GetComponent<HandPoseEstimationMediaPipeExample>().handpose_landmarks_points_right;
    }
    void sendToVFXGraph()
    {
        //VFX CONNECTIONS
        cam_width = GameObject.Find("Quad").GetComponent<HandPoseEstimationMediaPipeExample>().camera_width;
        cam_height = GameObject.Find("Quad").GetComponent<HandPoseEstimationMediaPipeExample>().camera_height;
        float scale_x = 50;
        float scale_y = 50;
        float SIZE_X = cam_width/2 / scale_x;
        float SIZE_Y = cam_height/2 / scale_y;

        Debug.Log("He: " + hand_pose_left[8]);
        Debug.Log("Camera:  " + _screenXOffset);
        Debug.Log("Cam_width:  " + cam_width);
        Debug.Log("Cam_height:  " + cam_height);

        //PREP VALUES FOR VFX GRAPH RIGHT HAND
        //FINGER TIPS






        // //Hand01_04
        // _localHand01_04.x = hand_pose_left[4].x - _screenXOffset;
        // _localHand01_04.y = (hand_pose_left[4].y - _screenYOffset) * -1;
        // //Hand01_08
        // _localHand01_08.x = hand_pose_left[8].x - _screenXOffset;
        // _localHand01_08.y = (hand_pose_left[8].y - _screenYOffset) * -1;
        // //Hand01_12
        // _localHand01_12.x = hand_pose_left[12].x - _screenXOffset;
        // _localHand01_12.y = (hand_pose_left[12].y - _screenYOffset) * -1;
        // //Hand01_16
        // _localHand01_16.x = hand_pose_left[16].x - _screenXOffset;
        // _localHand01_16.y = (hand_pose_left[16].y - _screenYOffset) * -1;
        // //Hand01_20
        // _localHand01_20.x = hand_pose_left[20].x - _screenXOffset;
        // _localHand01_20.y = (hand_pose_left[20].y - _screenYOffset) * -1;
        // //KNUCKLES
        // //Hand01_05
        // _localHand01_05.x = hand_pose_left[5].x - _screenXOffset;
        // _localHand01_05.y = (hand_pose_left[5].y - _screenYOffset) * -1;
        // //Hand01_09
        // _localHand01_09.x = hand_pose_left[9].x - _screenXOffset;
        // _localHand01_09.y = (hand_pose_left[9].y - _screenYOffset) * -1;
        // //Hand01_13
        // _localHand01_13.x = hand_pose_left[13].x - _screenXOffset;
        // _localHand01_13.y = (hand_pose_left[13].y - _screenYOffset) * -1;
        // //Hand01_17
        // _localHand01_17.x = hand_pose_left[17].x - _screenXOffset;
        // _localHand01_17.y = (hand_pose_left[17].y - _screenYOffset) * -1;
        // //BASE
        // _localHand01_00.x = hand_pose_left[0].x - _screenXOffset;
        // _localHand01_00.y = (hand_pose_left[0].y - _screenYOffset) * -1;


        // //PREP VALUES FOR VFX GRAPH LEFT HAND
        // //FINGER TIPS
        // //Hand02_04
        // _localHand02_04.x = hand_pose_right[4].x - _screenXOffset;
        // _localHand02_04.y = (hand_pose_right[4].y - _screenYOffset) * -1;
        // //Hand02_08
        // _localHand02_08.x = hand_pose_right[8].x - _screenXOffset;
        // _localHand02_08.y = (hand_pose_right[8].y - _screenYOffset) * -1;
        // //Hand02_12
        // _localHand02_12.x = hand_pose_right[12].x - _screenXOffset;
        // _localHand02_12.y = (hand_pose_right[12].y - _screenYOffset) * -1;
        // //Hand02_16
        // _localHand02_16.x = hand_pose_right[16].x - _screenXOffset;
        // _localHand02_16.y = (hand_pose_right[16].y - _screenYOffset) * -1;
        // //Hand02_20
        // _localHand02_20.x = hand_pose_right[20].x - _screenXOffset;
        // _localHand02_20.y = (hand_pose_right[20].y - _screenYOffset) * -1;
        // //KNUCKLES
        // //Hand02_05
        // _localHand02_05.x = hand_pose_right[5].x - _screenXOffset;
        // _localHand02_05.y = (hand_pose_right[5].y - _screenYOffset) * -1;
        // //Hand02_09
        // _localHand02_09.x = hand_pose_right[9].x - _screenXOffset;
        // _localHand02_09.y = (hand_pose_right[9].y - _screenYOffset) * -1;
        // //Hand02_13
        // _localHand02_13.x = hand_pose_right[13].x - _screenXOffset;
        // _localHand02_13.y = (hand_pose_right[13].y - _screenYOffset) * -1;
        // //Hand02_17
        // _localHand02_17.x = hand_pose_right[17].x - _screenXOffset;
        // _localHand02_17.y = (hand_pose_right[17].y - _screenYOffset) * -1;
        // //BASE
        // _localHand02_00.x = hand_pose_right[0].x - _screenXOffset;
        // _localHand02_00.y = (hand_pose_right[0].y - _screenYOffset) * -1;












        // //Hand01_04
        // _localHand01_04.x = 0;
        // _localHand01_04.y = 0;
        // //Hand01_08
        // _localHand01_08.x = 0;
        // _localHand01_08.y = 0;
        // //Hand01_12
        // _localHand01_12.x = 0;
        // _localHand01_12.y = 0;
        // //Hand01_16
        // _localHand01_16.x = 0;
        // _localHand01_16.y = 0;
        // //Hand01_20
        // _localHand01_20.x = 0;
        // _localHand01_20.y = 0;
        // //KNUCKLES
        // //Hand01_05
        // _localHand01_05.x = 0;
        // _localHand01_05.y = 0;
        // //Hand01_09
        // _localHand01_09.x = 0;
        // _localHand01_09.y = 0;
        // //Hand01_13
        // _localHand01_13.x = 0;
        // _localHand01_13.y = 0;
        // //Hand01_17
        // _localHand01_17.x = 0;
        // _localHand01_17.y = 0;
        // //BASE
        // _localHand01_00.x = 0;
        // _localHand01_00.y = 0;


        // //PREP VALUES FOR VFX GRAPH LEFT HAND
        // //FINGER TIPS
        // //Hand02_04
        // _localHand02_04.x = 0;
        // _localHand02_04.y = 0;
        // //Hand02_08
        // _localHand02_08.x = 0;
        // _localHand02_08.y = 0;
        // //Hand02_12
        // _localHand02_12.x = 0;
        // _localHand02_12.y = 0;
        // //Hand02_16
        // _localHand02_16.x = 0;
        // _localHand02_16.y = 0;
        // //Hand02_20
        // _localHand02_20.x = 0;
        // _localHand02_20.y = 0;
        // //KNUCKLES
        // //Hand02_05
        // _localHand02_05.x = 0;
        // _localHand02_05.y = 0;
        // //Hand02_09
        // _localHand02_09.x = 0;
        // _localHand02_09.y = 0;
        // //Hand02_13
        // _localHand02_13.x = 0;
        // _localHand02_13.y = 0;
        // //Hand02_17
        // _localHand02_17.x = 0;
        // _localHand02_17.y = 0;
        // //BASE
        // _localHand02_00.x = 0;
        // _localHand02_00.y = 0;

















        //Hand01_04
        _localHand01_04.x = hand_pose_left[4].x ;
        _localHand01_04.y = (hand_pose_left[4].y ) * 1;
        //Hand01_08
        _localHand01_08.x = hand_pose_left[8].x / scale_x - SIZE_X ;
        _localHand01_08.y = (hand_pose_left[8].y / scale_y - SIZE_Y) * ( -1 );
        //Hand01_12
        _localHand01_12.x = hand_pose_left[12].x ;
        _localHand01_12.y = (hand_pose_left[12].y) * 1;
        //Hand01_16
        _localHand01_16.x = hand_pose_left[16].x ;
        _localHand01_16.y = (hand_pose_left[16].y ) * 1;
        //Hand01_20
        _localHand01_20.x = hand_pose_left[20].x ;
        _localHand01_20.y = (hand_pose_left[20].y) * 1;
        //KNUCKLES
        //Hand01_05
        _localHand01_05.x = hand_pose_left[5].x ;
        _localHand01_05.y = (hand_pose_left[5].y ) * 1;
        //Hand01_09
        _localHand01_09.x = hand_pose_left[9].x ;
        _localHand01_09.y = (hand_pose_left[9].y ) * 1;
        //Hand01_13
        _localHand01_13.x = hand_pose_left[13].x ;
        _localHand01_13.y = (hand_pose_left[13].y ) * 1;
        //Hand01_17
        _localHand01_17.x = hand_pose_left[17].x ;
        _localHand01_17.y = (hand_pose_left[17].y ) * 1;
        //BASE
        _localHand01_00.x = hand_pose_left[0].x;
        _localHand01_00.y = (hand_pose_left[0].y) * 1;


        //PREP VALUES FOR VFX GRAPH LEFT HAND
        //FINGER TIPS
        //Hand02_04
        _localHand02_04.x = hand_pose_right[4].x ;
        _localHand02_04.y = (hand_pose_right[4].y ) * 1;
        //Hand02_08
        _localHand02_08.x = hand_pose_right[8].x / scale_x - SIZE_X ;
        _localHand02_08.y = (hand_pose_right[8].y / scale_y - SIZE_Y) * ( -1 );
        //Hand02_12
        _localHand02_12.x = hand_pose_right[12].x ;
        _localHand02_12.y = (hand_pose_right[12].y ) * 1;
        //Hand02_16
        _localHand02_16.x = hand_pose_right[16].x;
        _localHand02_16.y = (hand_pose_right[16].y ) * 1;
        //Hand02_20
        _localHand02_20.x = hand_pose_right[20].x ;
        _localHand02_20.y = (hand_pose_right[20].y ) * 1;
        //KNUCKLES
        //Hand02_05
        _localHand02_05.x = hand_pose_right[5].x ;
        _localHand02_05.y = (hand_pose_right[5].y ) * 1;
        //Hand02_09
        _localHand02_09.x = hand_pose_right[9].x ;
        _localHand02_09.y = (hand_pose_right[9].y ) * 1;
        //Hand02_13
        _localHand02_13.x = hand_pose_right[13].x ;
        _localHand02_13.y = (hand_pose_right[13].y ) * 1;
        //Hand02_17
        _localHand02_17.x = hand_pose_right[17].x ;
        _localHand02_17.y = (hand_pose_right[17].y ) * 1;
        //BASE
        _localHand02_00.x = hand_pose_right[0].x ;
        _localHand02_00.y = (hand_pose_right[0].y) * 1;


        // //PASS VALUES TO VFX GRAPH
        // //RIGHT HAND
        // vfxGraph01.SetVector3("_Hand01_04", _localHand01_04);
        vfxGraph01.SetVector3("_Hand01_08", _localHand01_08);
        // vfxGraph01.SetVector3("_Hand01_12", _localHand01_12);
        // vfxGraph01.SetVector3("_Hand01_16", _localHand01_16);
        // vfxGraph01.SetVector3("_Hand01_20", _localHand01_20);
        // vfxGraph01.SetVector3("_Hand01_05", _localHand01_05);
        // vfxGraph01.SetVector3("_Hand01_09", _localHand01_09);
        // vfxGraph01.SetVector3("_Hand01_13", _localHand01_13);
        // vfxGraph01.SetVector3("_Hand01_17", _localHand01_17);
        // vfxGraph01.SetVector3("_Hand01_00", _localHand01_00);
        // //LEFT HAND
        // vfxGraph01.SetVector3("_Hand02_04", _localHand02_04);
        vfxGraph01.SetVector3("_Hand02_08", _localHand02_08);
        // vfxGraph01.SetVector3("_Hand02_12", _localHand02_12);
        // vfxGraph01.SetVector3("_Hand02_16", _localHand02_16);
        // vfxGraph01.SetVector3("_Hand02_20", _localHand02_20);
        // vfxGraph01.SetVector3("_Hand02_05", _localHand02_05);
        // vfxGraph01.SetVector3("_Hand02_09", _localHand02_09);
        // vfxGraph01.SetVector3("_Hand02_13", _localHand02_13);
        // vfxGraph01.SetVector3("_Hand02_17", _localHand02_17);
        // vfxGraph01.SetVector3("_Hand02_00", _localHand02_00);
    }
}
