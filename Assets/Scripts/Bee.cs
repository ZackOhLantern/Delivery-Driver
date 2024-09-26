using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bee : MonoBehaviour
{
    [SerializeField] float speed = 15f;
    [SerializeField] float steerSpeed = 300f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);   
        transform.Translate(0,moveAmount,0); 
    }
}
