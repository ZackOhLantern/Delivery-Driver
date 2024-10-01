using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bee : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float steerSpeed = 300f;
    [SerializeField] float slowSpeed = 3f;
    [SerializeField] float boostSpeed = 10f;

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);   
        transform.Translate(0,moveAmount,0); 
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Boost"){
            speed = boostSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D other){
        speed = slowSpeed;
    }
}
