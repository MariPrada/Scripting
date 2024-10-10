using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MenuPrincipal : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("LevelSelector"); 
    }

    public void Salir()
    {
        Debug.Log("Saliendo..."); 
        Application.Quit();
    }

    public void Creditos()
    {

    }

    public void Instrucciones()
    {

    }
    public void Achievements()
    {
        SceneManager.LoadScene("Logros");
    }

}
