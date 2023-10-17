using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    Vector3 vec = new Vector3(0,0,-100);
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground") {
            crashEffect.Play();
            SpriteRenderer[] spriteRenderersList = (GetComponentsInChildren<SpriteRenderer>());
            foreach (SpriteRenderer i in spriteRenderersList) {
                Destroy(i);
            }
            Invoke("restartGame", 1f);
        }
    }

    private void restartGame() {
        SceneManager.LoadScene(0);
    }
}
