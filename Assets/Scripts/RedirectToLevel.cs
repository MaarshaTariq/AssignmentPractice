﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectToLevel : MonoBehaviour
{
    public static int redirectLevel;
    

    // Update is called once per frame
    void Update()
    {
        if (redirectLevel == 3)
        {
            SceneManager.LoadScene(redirectLevel);
        }
        
    }
}
