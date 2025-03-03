using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollisionHandler : MonoBehaviour
{
    private GameObject go_player;
    public GameHandler gameHandlerObj;

    private void Start() {
        // GameObject go_player = GameObject.Find("Player").GetComponent<Player_GetHurt>();
        go_player = GameObject.Find("Player");
        if (GameObject.FindWithTag("GameHandler") != null) {
            gameHandlerObj = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("IN LIGHT");
            gameHandlerObj.isInLight = true;
            go_player.GetComponent<Player_GetHurt>().GetHurtStart();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("EXITING LIGHT");
            gameHandlerObj.isInLight = false;
            go_player.GetComponent<Player_GetHurt>().GetHurtStop();
        }
    }
}
