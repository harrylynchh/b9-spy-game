using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowToggle : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isLightOn = true;
    private Transform windowLight;
    void Start()
    {
        windowLight = transform.Find("windowLight");
        windowLight.gameObject.SetActive(isLightOn);
    }
}
