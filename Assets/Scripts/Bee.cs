using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bee : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    [SerializeField] float steerSpeed = 12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;
        float moveAmount = Input.GetAxis("Vertical") * speed;
        transform.Rotate(0, 0, -steerAmount);   
        transform.Translate(0,moveAmount,0); 
    }
}
