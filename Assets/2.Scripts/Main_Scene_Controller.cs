using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Scene_Controller : MonoBehaviour
{
    public GameObject left_arrow,right_arrow;

    public GameObject model_Panel;

    public GameObject stage;

    public GameObject[] models;

    public zSpace.Core.ZFrame zFrame;

    int model_Index;

    public void Click_Model(int num)
    {
        model_Index = num;
        Click_OBJ();
    }

    
    void Click_OBJ()
    {
        zFrame.ViewerScale = 10.0f;
        Vector3 pos = new Vector3(models[model_Index].transform.position.x + 1.0f,models[model_Index].transform.position.y + 1.0f + models[model_Index].transform.position.z);
        zFrame.transform.position = pos;
        model_Panel.SetActive(true);
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
