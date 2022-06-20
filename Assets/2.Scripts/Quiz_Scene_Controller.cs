using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz_Scene_Controller : MonoBehaviour
{
    public GameObject[] quizPanels;

    public GameObject back_btn,check_answer_btn;

    public GameObject background,background2;

    int quiznum;

    

    public void MoveToMain(){
        back_btn.SetActive(false);
        check_answer_btn.SetActive(false);
        background.SetActive(true);
        foreach(GameObject quizPanel in quizPanels)
        {
            quizPanel.SetActive(false);
        }
        quizPanels[0].SetActive(true);
    }

    public void MoveToQuiz1(){
        quiznum = 1;
        back_btn.SetActive(true);
        check_answer_btn.SetActive(true);
        background2.SetActive(true);
        foreach(GameObject quizPanel in quizPanels)
        {
            quizPanel.SetActive(false);
        }
        quizPanels[1].SetActive(true);
    }

    public void MoveToQuiz2(){
        quiznum = 2;
        back_btn.SetActive(true);
        check_answer_btn.SetActive(true);
        background2.SetActive(true);
        foreach(GameObject quizPanel in quizPanels)
        {
            quizPanel.SetActive(false);
        }
        quizPanels[2].SetActive(true);
    }

    public void MoveToQuiz3(){
        quiznum = 3;
        back_btn.SetActive(true);
        check_answer_btn.SetActive(true);
        background2.SetActive(true);
        foreach(GameObject quizPanel in quizPanels)
        {
            quizPanel.SetActive(false);
        }
        quizPanels[3].SetActive(true);
    }

    public void MoveToQuiz4(){
        quiznum = 4;
        back_btn.SetActive(true);
        check_answer_btn.SetActive(true);
        background2.SetActive(true);
        foreach(GameObject quizPanel in quizPanels)
        {
            quizPanel.SetActive(false);
        }
        quizPanels[4].SetActive(true);
    }

    public void MoveToQuiz5(){
        quiznum = 5;
        back_btn.SetActive(true);
        check_answer_btn.SetActive(true);
        background2.SetActive(true);
        foreach(GameObject quizPanel in quizPanels)
        {
            quizPanel.SetActive(false);
        }
        quizPanels[5].SetActive(true);
    }

    

    public void Check_answer_btn(){
        Text txt = quizPanels[quiznum].transform.GetChild(0).GetComponent<Text>();
        txt.text = txt.text + "(" + quizPanels[quiznum].GetComponent<Right_Answer>().correctnum +")";
    }
}
