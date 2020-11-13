using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{

    public GameObject youFell;
    public GameObject levelAudio;
    public GameObject fadeOut;

    public void OnTriggerEnter()
    {
        StartCoroutine(YouFellOff());
    }
    public IEnumerator YouFellOff()
    {
        levelAudio.SetActive(false);
        youFell.SetActive(true);
        
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }
}
