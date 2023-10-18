using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    public bool ifCrash = false;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip audioClip;
    Vector3 vec = new Vector3(0,0,-100);
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground") {
            ifCrash = true;
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(audioClip);
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
