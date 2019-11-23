using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    void OnButtonDown()
    {
        Application.LoadLevel("LevelSelect");
        Debug.Log("button pressed");

    }
}
