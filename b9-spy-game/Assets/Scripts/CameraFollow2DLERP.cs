
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class CameraFollow2DLERP : MonoBehaviour
{

    private GameObject target;
    public float camSpeed = 4.0f;

    void Start()
    {
        target = GameObject.FindWithTag("Player");
    }

    void FixedUpdate()
    {
        Vector2 pos = Vector2.Lerp((Vector2)transform.position, new Vector2(transform.position.x, target.transform.position.y), camSpeed * Time.fixedDeltaTime);
        transform.position = new Vector3(pos.x, pos.y, transform.position.z);
    }
}