using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.collider.tag == "Ground") {
            SceneManager.LoadScene(0);
        }
    }
}
