using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level001Load : MonoBehaviour
{
   public GameObject fadeIn;
    void Start()
    {
        StartCoroutine(FadeInOff());
        RedirectToLevel.redirectLevel=3;

    }
     
     IEnumerator FadeInOff(){
         yield return new WaitForSeconds(1);
         fadeIn.SetActive(false);
     }

   
}
