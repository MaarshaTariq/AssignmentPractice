using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
  
public bool gamePaused=false;
public AudioSource levelMusic;
public GameObject pauseMenu;

    void Update()
    {
        if(Input.GetButtonDown("Cancel")){
            if(gamePaused==false){
                pauseMenu.SetActive(true);

                Time.timeScale=0;
                gamePaused=true;
                Cursor.visible=true;
                levelMusic.Pause();
            }
            else
            {
                pauseMenu.SetActive(false);
                levelMusic.UnPause();
                Cursor.visible=false;
                gamePaused=false;
                Time.timeScale=1;
            }
        }
    }
    public void ResuemGame(){
                pauseMenu.SetActive(false);
                levelMusic.UnPause();
               // Cursor.visible=false;
                gamePaused=false;
                Time.timeScale=1;
    }
     public void RestartLevel(){
                pauseMenu.SetActive(false);
                levelMusic.UnPause();
               // Cursor.visible=false;
                gamePaused=false;
                Time.timeScale=1;
                SceneManager.LoadScene(2);
    }
    public void RedirectToMenu(){
                pauseMenu.SetActive(false);
                levelMusic.UnPause();
               // Cursor.visible=false;
                gamePaused=false;
                Time.timeScale=1;
                SceneManager.LoadScene(1);
    }

}
