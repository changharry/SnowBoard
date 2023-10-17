using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    Rigidbody2D playerRigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            playerRigidbody2D.AddTorque(torqueAmount);
        }
        if (Input.GetKey(KeyCode.D)) {
            playerRigidbody2D.AddTorque(-torqueAmount);
        }
    }
}
