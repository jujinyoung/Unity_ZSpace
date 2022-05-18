using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraButton : MonoBehaviour
{
    public CameraMove my_camera;
    public Camera subCamera;

    public void OnMouseDown(){
        GameObject cameraObject = subCamera.gameObject;
        my_camera.MovingCamera(cameraObject);
        Debug.Log("클릭됨.");
    }
}
