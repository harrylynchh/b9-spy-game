using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollisionHandler : MonoBehaviour
{
    private GameObject go_player;

    private void Start() {
        // GameObject go_player = GameObject.Find("Player").GetComponent<Player_GetHurt>();
        go_player = GameObject.Find("Player");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("IN LIGHT");
            GameObject.Find("GameHandler").GetComponent<GameHandler>().isInLight = true;
            go_player.GetComponent<Player_GetHurt>().GetHurtStart();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("EXITING LIGHT");
            GameObject.Find("GameHandler").GetComponent<GameHandler>().isInLight = false;
            go_player.GetComponent<Player_GetHurt>().GetHurtStop();
        }
    }
}
