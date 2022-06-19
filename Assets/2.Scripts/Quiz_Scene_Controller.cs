using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz_Scene_Controller : MonoBehaviour
{
    public GameObject quizPanel1,quizPanel2;

    public GameObject back_btn;

    public void MoveToPanel1(){
        quizPanel1.SetActive(true);
        quizPanel2.SetActive(false);
        back_btn.SetActive(false);
    }

    public void MoveToPanel2(){
        quizPanel1.SetActive(false);
        quizPanel2.SetActive(true);
        back_btn.SetActive(true);
    }

}
