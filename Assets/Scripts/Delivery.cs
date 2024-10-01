using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package"){
            Debug.Log("picked up Honey!");
        }

        if (other.tag == "Hive"){
            Debug.Log("dropped off Honey!");
        }
    }

}
