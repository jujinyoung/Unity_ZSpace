using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Scene_Controller : MonoBehaviour
{
    enum Camera_State{camera_left,camera_main,camera_right};
    public GameObject left_arrow,right_arrow;

    public GameObject model_Panel,exit_btn;

    public GameObject stage;

    public GameObject[] models;

    public zSpace.Core.ZFrame zFrame;

    int model_Index;

    public Transform subcam_main,subcam_left,subcam_right;

    Camera_State camera_State = Camera_State.camera_main;

    public void Click_leftArrow(){
        switch(camera_State){
            case Camera_State.camera_left:
                break;
            case Camera_State.camera_main: 
                camera_State = Camera_State.camera_left;
                zFrame.transform.position = subcam_left.position;
                left_arrow.SetActive(false);
                break;
            case Camera_State.camera_right:
                camera_State = Camera_State.camera_main;
                zFrame.transform.position = subcam_main.position;
                right_arrow.SetActive(true);
                break;                
        }
    }

    public void Click_rightArrow(){
        switch(camera_State){
            case Camera_State.camera_left:
                camera_State = Camera_State.camera_main;
                zFrame.transform.position = subcam_main.position;
                left_arrow.SetActive(true);
                break;
            case Camera_State.camera_main: 
                camera_State = Camera_State.camera_right;
                zFrame.transform.position = subcam_right.position;
                right_arrow.SetActive(false);
                break;
            case Camera_State.camera_right:
                break;
                
        }
    }

    public void Click_ExitBtn(){
        zFrame.ViewerScale = 15.0f; 
        zFrame.transform.position = Camera_pos();
        zFrame.transform.localEulerAngles = Camera_rot();
        left_arrow.SetActive(true);
        right_arrow.SetActive(true);
        stage.SetActive(true);
        exit_btn.SetActive(false);
        model_Panel.SetActive(false);
        foreach(GameObject model in models)
        {
            model.SetActive(true);
        }
        models[model_Index].GetComponent<IPointerHandlerLogger>().enabled = true;
        Destroy(models[model_Index].GetComponent<zSpace.Core.Samples.Draggable>());
        models[model_Index].transform.position = models[model_Index].GetComponent<IPointerHandlerLogger>().model_pos;
        models[model_Index].transform.localEulerAngles = models[model_Index].GetComponent<IPointerHandlerLogger>().model_rot;
    }

    private Vector3 Camera_pos(){
        Vector3 pos = new Vector3();
        switch(camera_State){
            case Camera_State.camera_left:
                pos = subcam_left.position;
                break;
            case Camera_State.camera_main: 
                pos = subcam_main.position;
                break;
            case Camera_State.camera_right:
                pos = subcam_right.position;
                break;
                
        }

        return pos;
    }

    private Vector3 Camera_rot(){
        Vector3 rot = new Vector3();
        switch(camera_State){
            case Camera_State.camera_left:
                rot = subcam_left.localEulerAngles;
                break;
            case Camera_State.camera_main: 
                rot = subcam_main.localEulerAngles;
                break;
            case Camera_State.camera_right:
                rot = subcam_right.localEulerAngles;
                break;
                
        }

        return rot;
    }

    public void Click_Model(int num)
    {
        model_Index = num;
        Click_OBJ();
    }

    
    void Click_OBJ()
    {
        zFrame.ViewerScale = 8.0f;
        Vector3 pos = new Vector3(-1.0f,1.0f,1.0f);
        Vector3 rot = new Vector3(10.0f,180.0f,0);
        zFrame.transform.position = pos;
        zFrame.transform.localEulerAngles = rot; 
        models[model_Index].transform.position = new Vector3(0,0,0);
        models[model_Index].transform.localEulerAngles = new Vector3(0,0,0);
        model_Panel.SetActive(true);
        exit_btn.SetActive(true);
        left_arrow.SetActive(false);
        right_arrow.SetActive(false);
        stage.SetActive(false);
        foreach(GameObject model in models)
        {
            model.SetActive(false);
        }
        models[model_Index].SetActive(true);
    }

}
