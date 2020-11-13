using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMainMenu : MonoBehaviour
{
    public GameObject logoText;
    
        void Start()
    {
        StartCoroutine(RunSplash());
    }
    
    IEnumerator RunSplash(){
       
       
       yield return new WaitForSeconds(3.5f);
       logoText.SetActive(true);
       yield return new WaitForSeconds(3.5f);
       SceneManager.LoadScene(1);


    }


}
