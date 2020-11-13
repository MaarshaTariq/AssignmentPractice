using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timer001;
    public GameObject timer002;
    public bool isTakingTime=false;
    public int theRemainingSeconds;
    public static int extendScore;
     

    void Update()
    {
        extendScore = theRemainingSeconds;
        if (isTakingTime == false)
        {
            StartCoroutine(SubtractSeconds());
        }
    }
    public IEnumerator SubtractSeconds()
    {
        isTakingTime = true;
        theRemainingSeconds--;
        timer001.GetComponent<Text>().text = "" + theRemainingSeconds;
        timer002.GetComponent<Text>().text = "" + theRemainingSeconds;
        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }
}
