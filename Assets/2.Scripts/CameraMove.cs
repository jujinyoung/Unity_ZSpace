using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Camera[] subCamera;

    public void MovingCamera(GameObject index){
        Vector3 new_position = index.transform.position;
        Vector3 new_rotation = index.transform.eulerAngles;
        //  transform.position = new_position;
        //  transform.eulerAngles = new_rotation;
        iTween.MoveTo(this.gameObject, iTween.Hash("position",
        new_position, "easetype", 
        iTween.EaseType.easeOutBack, "time", 1.0f));

        iTween.RotateTo(this.gameObject, iTween.Hash("rotation",
        new_rotation, "easetype", 
        iTween.EaseType.easeOutBack, "time", 1.0f));
    }
    
}
