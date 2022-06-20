using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public AudioSource audioSource;
    public void LoadLearnPage(){
        audioSource.Play();
        SceneManager.LoadScene("LearnPage");
    }

    public void LoadMainPage(){
        audioSource.Play();
        SceneManager.LoadScene("MainPage");
    }

    public void LoadQuizPage(){
        audioSource.Play();
        SceneManager.LoadScene("QuizPage");
    }

    public void QuitPage(){
        Application.Quit();
    }
}
