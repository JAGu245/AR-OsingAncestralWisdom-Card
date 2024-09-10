using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selection : MonoBehaviour
{
    public void SukuOsing(){
        SceneManager.LoadScene("SukuOsing");
    }

    public void identitas(){
        SceneManager.LoadScene("Identitas");
    }

    public void Barong(){
        SceneManager.LoadScene("Barong");
    }

    public void Angklung(){
        SceneManager.LoadScene("Angklung");
    }

    public void RumahAdat(){
        SceneManager.LoadScene("RumahAdat");
    }

    public void MepeKasur(){
        SceneManager.LoadScene("MepeKasur");
    }

    public void Kembali(){
        SceneManager.LoadScene("MainMenu");
    }
}
