using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Scene_Controller : MonoBehaviour
{
    //카메라 현재 상태
    enum Camera_State{camera_left,camera_main,camera_right};
    Camera_State camera_State = Camera_State.camera_main;
    //카메라 위치
    public Transform subcam_main,subcam_left,subcam_right;
    //화면 전환 버튼
    public GameObject left_arrow,right_arrow;
    //생물 설명 패널, 돌아가기 버튼, 돋보기 버튼,퀴즈 버튼
    public GameObject model_Panel,exit_btn,find_btn,quiz_btn;
    //맵, 배경
    public GameObject stage,background,background2;
    //사이즈 부모, 모델 부모
    public GameObject sizeParent,modelParent;
    //생물 리스트
    public GameObject[] models;
    //Zframe
    public zSpace.Core.ZFrame zFrame;
    //동물 번호
    int model_Index;

    //동물 클릭
    public void Click_Model(int num)
    {
        model_Index = num;
        Click_OBJ();
    }

    
    void Click_OBJ()
    {
        Vector3 pos = new Vector3(-1.0f,1.0f,1.0f);
        Vector3 rot = new Vector3(10.0f,180.0f,0);
        zFrame.transform.position = pos;
        zFrame.transform.localEulerAngles = rot; 
        models[model_Index].transform.position = new Vector3(0.4f,-0.4f,-0.6f);
        models[model_Index].transform.localEulerAngles = new Vector3(0,0,0);
        models[model_Index].transform.SetParent(sizeParent.transform); 
        model_Panel.SetActive(true);
        exit_btn.SetActive(true);
        left_arrow.SetActive(false);
        right_arrow.SetActive(false);
        stage.SetActive(false);
        background.SetActive(true);
        quiz_btn.SetActive(false);
        sizeParent.transform.localScale = new Vector3(3,3,3);
        foreach(GameObject model in models)
        {
            model.SetActive(false);
        }
        models[model_Index].SetActive(true);
    }

    #region 카메라 포지션

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
    #endregion

    #region 화면 전환
     public void Click_leftArrow(){
        switch(camera_State){
            case Camera_State.camera_left:
                break;
            case Camera_State.camera_main: 
                camera_State = Camera_State.camera_left;
                zFrame.transform.position = Camera_pos();
                zFrame.transform.localEulerAngles = Camera_rot();
                left_arrow.SetActive(false);
                find_btn.SetActive(true);
                break;
            case Camera_State.camera_right:
                camera_State = Camera_State.camera_main;
                zFrame.transform.position = Camera_pos();
                zFrame.transform.localEulerAngles = Camera_rot();
                right_arrow.SetActive(true);
                break;
        }
    }

    public void Click_rightArrow(){
        switch(camera_State){
            case Camera_State.camera_left:
                camera_State = Camera_State.camera_main;
                zFrame.transform.position = Camera_pos();
                zFrame.transform.localEulerAngles = Camera_rot();
                left_arrow.SetActive(true);
                find_btn.SetActive(false);
                break;
            case Camera_State.camera_main: 
                camera_State = Camera_State.camera_right;
                zFrame.transform.position = Camera_pos();
                zFrame.transform.localEulerAngles = Camera_rot();
                right_arrow.SetActive(false);
                break;
            case Camera_State.camera_right:
                break;
                
        }
    }

    public void Click_ExitBtn(){
        zFrame.transform.position = Camera_pos();
        zFrame.transform.localEulerAngles = Camera_rot();
        left_arrow.SetActive(true);
        right_arrow.SetActive(true);
        stage.SetActive(true);
        exit_btn.SetActive(false);
        model_Panel.SetActive(false);
        background.SetActive(false);
        background2.SetActive(false);
        quiz_btn.SetActive(true);
        sizeParent.transform.localScale = new Vector3(1,1,1);
        models[model_Index].transform.SetParent(modelParent.transform);
        foreach(GameObject model in models)
        {
            model.SetActive(true);
        }
        models[model_Index].GetComponent<IPointerHandlerLogger>().enabled = true;
        Destroy(models[model_Index].GetComponent<zSpace.Core.Samples.Draggable>());
        models[model_Index].transform.position = models[model_Index].GetComponent<IPointerHandlerLogger>().model_pos;
        models[model_Index].transform.localEulerAngles = models[model_Index].GetComponent<IPointerHandlerLogger>().model_rot;
    }

    public void Click_FindBtn(){
        Click_Model(5);
        background.SetActive(false);
        background2.SetActive(true);
        find_btn.SetActive(false);
    }
    #endregion
}
