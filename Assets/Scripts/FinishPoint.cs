using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;
    bool hasEffectPlayed = false;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player" && !hasEffectPlayed) {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            hasEffectPlayed = true;
            Invoke("restartGame", 1f); 
        }
    }

    private void restartGame() {
        SceneManager.LoadScene(0);
    }
    
}
