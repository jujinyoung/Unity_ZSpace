using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public void LoadLearnPage(){
        SceneManager.LoadScene("LearnPage");
        Debug.Log("학습하기");
    }

    public void LoadMainPage(){
        SceneManager.LoadScene("MainPage");
    }

    public void LoadQuizPage(){
        SceneManager.LoadScene("QuizPage");
        Debug.Log("퀴즈하기");
    }

    public void QuitPage(){
        Application.Quit();
    }
}
