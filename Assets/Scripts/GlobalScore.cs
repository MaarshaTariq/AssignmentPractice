using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{

    public GameObject score;
    public int internalScore;
    public static int currentScore;
    public void Update()
    {
        internalScore  = currentScore;
        score.GetComponent<Text>().text = "" +internalScore;
            
    }
}
