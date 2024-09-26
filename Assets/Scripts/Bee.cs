using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bee : MonoBehaviour
{
    public float speed = 0.1f;
    public float steerSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, steerSpeed);   
        transform.Translate(0,speed,0); 
    }
}
