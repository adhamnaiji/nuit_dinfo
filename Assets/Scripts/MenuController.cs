using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public void PlayBtn(){
        SceneManager.LoadScene(2);
        
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene(1);

    }



}
