using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Camera should follow the Car
public class FollowCamera : MonoBehaviour {

    [SerializeField] GameObject objectToFollow;
    Vector3 cameraOffset = new Vector3 (0, 0, -10);

    void LateUpdate() {
        transform.position = objectToFollow.transform.position + cameraOffset;
    }
}
