using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevelOne : MonoBehaviour
{
    private bool hotZone = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            hotZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            hotZone = false;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&hotZone)
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
