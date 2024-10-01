using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasHoney = false;

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package"){
            Debug.Log("picked up Honey!");
            hasHoney = true;
        }

        if (other.tag == "Hive" && hasHoney == true){
            Debug.Log("dropped off Honey!");
            hasHoney = false;
        }
    }

}
