﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonAction()
    {
        Debug.Log("<b>Your button works!</b>");
        UnityEngine.Application.Quit();
        
    }
}
