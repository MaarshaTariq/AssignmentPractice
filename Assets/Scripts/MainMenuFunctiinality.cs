using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunctiinality : MonoBehaviour
{
   public AudioSource playBtnSound;
    public void playGame()
    {
        playBtnSound.Play();
        RedirectToLevel.redirectLevel=3;
        SceneManager.LoadScene(2);
    }
    public void QuitGame()
    {
        playBtnSound.Play();
        Application.Quit();
    }
    public void viewCredits()
    {     
        playBtnSound.Play();

        SceneManager.LoadScene(4);
    }


}
