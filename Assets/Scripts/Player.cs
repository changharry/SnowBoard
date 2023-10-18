using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float torqueAmount = 5f;
    float speed = 20f;
    float boostSpeed = 30f;
    Rigidbody2D playerRigidbody2D;
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] ParticleSystem movingEffect;
    public bool canMove = true;
  
    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        if (canMove) {
            rotatePlayer();
            boostPlayer(); 
        }
       
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

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Ground" && !GetComponent<Crash>().hasCrashed) {
            movingEffect.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Ground") {
            movingEffect.Stop();
        }     
    }
}
