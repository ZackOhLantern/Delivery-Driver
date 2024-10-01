using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 noHoneyColor = new Color32 (255,255,255,255);
    [SerializeField] Color32 hasHoneyColor = new Color32 (255,170,0,255);
    bool hasHoney = false;
    SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && hasHoney == false){
            Debug.Log("picked up Honey!");
            hasHoney = true;
            Destroy(other.gameObject, 0f);
            spriteRenderer.color = hasHoneyColor;
        }

        if (other.tag == "Hive" && hasHoney == true){
            Debug.Log("dropped off Honey!");
            hasHoney = false;
            spriteRenderer.color = noHoneyColor;
        }
    }

}
