using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public static SceneMove instance;

    private void Awake() { 
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

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

    public void LoadTest()
    {
        SceneManager.LoadScene("TestScene");
    }

    public void TestScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
}
