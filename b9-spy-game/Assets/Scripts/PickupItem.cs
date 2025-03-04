using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public GameObject GameHandler;
    GameHandler gameHandler;
    public bool canPickup = false;
    void Start()
    {
        gameHandler = GameHandler.GetComponent<GameHandler>();
    }

    void Update()
    {
        if ((canPickup == true) && (Input.GetKeyDown(KeyCode.E)))
        {
            canPickup = false;
            Pickup();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            canPickup = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            canPickup = false;
        }
    }

    public void Pickup()
    {
        Debug.Log("PICKING UP");
        gameHandler.inventoryCt++;
        gameObject.SetActive(false);
        canPickup = false;
    }
}
