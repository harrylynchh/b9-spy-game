using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoundItemsHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GameHandler;
    GameHandler handler;
    public bool test;
    void Start()
    {
        handler = GameHandler.GetComponent<GameHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = $"{handler.inventoryCt} / 5 Found";
    }
}
