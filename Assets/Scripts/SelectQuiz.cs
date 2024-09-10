using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectQuiz : MonoBehaviour
{

    public void identitas(){
        SceneManager.LoadScene("Quiz");
    }

    public void Barong(){
        SceneManager.LoadScene("QuizBarong");
    }

    public void Angklung(){
        SceneManager.LoadScene("QuizAngklung");
    }

    public void RumahAdat(){
        SceneManager.LoadScene("QuizRumah");
    }

    public void MepeKasur(){
        SceneManager.LoadScene("QuizKasur");
    }

    public void Kembali(){
        SceneManager.LoadScene("MainMenu");
    }
}
