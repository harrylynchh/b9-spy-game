using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Import this for UI components

public class LightLevelHandler : MonoBehaviour
{
    GameHandler script; // Reference to GameHandler
    public Slider slider; // Public reference to assign via Inspector

    void Start()
    {
        // Find GameHandler object
        GameObject handler = GameObject.Find("GameHandler");

        if (handler != null)
        {
            script = handler.GetComponent<GameHandler>();

            if (script == null)
            {
                Debug.LogError("GameHandler script not found on GameHandler object.");
            }
        }
        else
        {
            Debug.LogError("GameHandler GameObject not found in the scene.");
        }

        // Ensure the slider is assigned
        if (slider == null)
        {
            Debug.LogError("Slider reference is missing! Assign it in the Inspector.");
        }
    }

    void Update()
    {
        if (script != null && slider != null)
        {
            slider.value = script.playerLightLevel; // Correct property name
        }
    }
}
