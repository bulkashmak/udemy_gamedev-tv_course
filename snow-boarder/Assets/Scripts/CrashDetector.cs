using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class CrashDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
=======
public class CrashDetector : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground") {
            Debug.Log("Ouch, hit my head");
        }
>>>>>>> 8ec949de355f531f28ab6eea51fdbc4b63af7803
    }
}
