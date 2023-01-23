using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadSceneDelay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            FindObjectOfType<PlayerController>().DisableControls();
            Invoke("ReloadScene", loadSceneDelay);
        }
    }

    void ReloadScene() => SceneManager.LoadScene(0);
}
