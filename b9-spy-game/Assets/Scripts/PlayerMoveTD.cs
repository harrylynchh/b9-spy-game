using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveTD : MonoBehaviour
{
    public Rigidbody2D rb2D;
    private bool FaceUp = true; // determine which way player is facing.
    public static float runSpeed = 6f;
    public float startSpeed = 1f;
    public bool isAlive = true;
    void Start()
    {
        rb2D = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 hvMove = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        if (isAlive == true)
        {
            transform.position = transform.position + hvMove * runSpeed * Time.deltaTime;

            if ((Input.GetAxis("Horizontal") != 0) || (Input.GetAxis("Vertical") != 0))
            {
                //     anim.SetBool ("Walk", true);
                //     if (!WalkSFX.isPlaying){
                //           WalkSFX.Play();
                //     }
            }
            else
            {
                //     anim.SetBool ("Walk", false);
                //     WalkSFX.Stop();
            }

        }
    }
}
