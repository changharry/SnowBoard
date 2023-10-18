using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    float speed = 20f;
    float boostSpeed = 30f;
    Rigidbody2D playerRigidbody2D;
    SurfaceEffector2D surfaceEffector2D;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rotatePlayer();
        boostPlayer();
    }

    void boostPlayer()
    {
        if (Input.GetKey(KeyCode.W)) {
            surfaceEffector2D.speed = boostSpeed;
        } else {
            surfaceEffector2D.speed = speed;
        }
    }

    void rotatePlayer() {
        if (Input.GetKey(KeyCode.A)) {
            playerRigidbody2D.AddTorque(torqueAmount);
        }
        if (Input.GetKey(KeyCode.D)) {
            playerRigidbody2D.AddTorque(-torqueAmount);
        }
    }
}
