using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz_Scene_Controller : MonoBehaviour
{
    public GameObject[] quizPanels;

    public GameObject back_btn,check_answer_btn;

    public GameObject background,background2;

    int quiznum;

    public AudioSource AudioSource, click_audioSource;

    public AudioClip correct_sound,wrong_sound;


    

    public void MoveToMain(){
        back_btn.SetActive(false);
        check_answer_btn.SetActive(false);
        background2.SetActive(false);
        click_audioSource.Play();
        foreach(GameObject quizPanel in quizPanels)
        {
            quizPanel.SetActive(false);
        }
        quizPanels[0].SetActive(true);
        Right_Answer right_answer = quizPanels[quiznum].GetComponent<Right_Answer>();
        right_answer.check_answer = false;
        //퀴즈 초기화
        quizPanels[quiznum].transform.GetChild(1).GetComponent<TextManager>().Initialize();
    }

    public void MoveToQuiz1(){
        quiznum = 1;
        back_btn.SetActive(true);
        check_answer_btn.SetActive(true);
        background2.SetActive(true);
        click_audioSource.Play();
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
        click_audioSource.Play();
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
        click_audioSource.Play();
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
        click_audioSource.Play();
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
        click_audioSource.Play();
        foreach(GameObject quizPanel in quizPanels)
        {
            quizPanel.SetActive(false);
        }
        quizPanels[5].SetActive(true);
    }

    

    public void Check_answer_btn(){
        Right_Answer right_answer = quizPanels[quiznum].GetComponent<Right_Answer>();
        if(!right_answer.check_answer){
        
            if(right_answer.correctnum == right_answer.num){
                //정답 맞음
                AudioSource.clip = correct_sound;
            }else
            {
                //정답 틀림
                AudioSource.clip = wrong_sound;
            }
            click_audioSource.Play();
            AudioSource.Play();
            quizPanels[quiznum].transform.GetChild(right_answer.correctnum).GetComponent<TextManager>().Select();
            right_answer.check_answer = true;
            check_answer_btn.SetActive(false);
        }
    }
}
