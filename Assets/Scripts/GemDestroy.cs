using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemDestroy : MonoBehaviour
{
    public AudioSource gemCollectedSound;
    public GameObject scoreBox;
    public void OnTriggerEnter()
    {
        GlobalScore.currentScore += 1000;
        gemCollectedSound.Play();
        Destroy(gameObject);
    }
}
