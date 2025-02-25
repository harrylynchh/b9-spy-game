using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollisionHandler : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("IN LIGHT");
            GameObject.Find("GameHandler").GetComponent<GameHandler>().isInLight = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("EXITING LIGHT");
            GameObject.Find("GameHandler").GetComponent<GameHandler>().isInLight = false;
        }
    }
}
