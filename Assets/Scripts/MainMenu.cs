using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Exit(){
        Application.Quit();
        Debug.Log("Game Close");
    }

    public void Selection(){
        SceneManager.LoadScene("Selection");
    }

    public void Play(){
        SceneManager.LoadScene("Play");
    }

    public void Quizz(){
        SceneManager.LoadScene("SelectQuiz");
    }

    [SerializeField] GameObject exitPanel;

    void Update()
    {
        // Deteksi jika tombol kembali ditekan
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene ().buildIndex!=0)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                if (exitPanel){
                    exitPanel.SetActive(true);
                }
            }
        }
    }

    public void onUserClick(int choice){
        if (choice==1){
            Application.Quit();
        }
        exitPanel.SetActive (false);
    }
}

