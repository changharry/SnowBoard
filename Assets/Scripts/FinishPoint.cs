using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Invoke("restartGame", 0.5f);
        }
    }

    private void restartGame() {
        SceneManager.LoadScene(0);
    }
    
}
