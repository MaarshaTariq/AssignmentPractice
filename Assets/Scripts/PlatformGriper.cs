using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGriper : MonoBehaviour
{

    public GameObject theLedge;
    public GameObject thePlayer;
    public void OnTriggerEnter()
    {
        thePlayer.transform.parent = theLedge.transform;
    }

    public void OnTriggerExit()
    {
        thePlayer.transform.parent = null;
        
    }
}
