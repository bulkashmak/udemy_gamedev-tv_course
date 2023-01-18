using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
=======
public class FinishLine : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Debug.Log("You finished!");
        }
>>>>>>> 8ec949de355f531f28ab6eea51fdbc4b63af7803
    }
}
