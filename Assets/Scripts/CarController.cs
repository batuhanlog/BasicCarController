using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 5.0f;   
    public float turnSpeed;
    private float horizantalInput;
    private float forwardInput;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        horizantalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizantalInput);
    }
}
