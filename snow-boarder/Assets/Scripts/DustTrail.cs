using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour {

    [SerializeField] ParticleSystem dustTrailEffect;

    private void OnCollisionEnter2D(Collision2D other) {

        dustTrailEffect.Play();
    }

    private void OnCollisionExit2D(Collision2D other) {
        dustTrailEffect.Stop();
    }
}
