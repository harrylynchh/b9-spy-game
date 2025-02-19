using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowToggle : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isLit = true;
    private Transform windowLight;
    void Start()
    {
        windowLight = transform.Find("windowLight");
        windowLight.gameObject.SetActive(isLit);
    }

    // Update is called once per frame
    // void Update()
    // {
    //     windowLight.gameObject.SetActive(isLit);
    // }
}
