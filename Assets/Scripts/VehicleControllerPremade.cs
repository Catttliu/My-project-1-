using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleControllerPremade : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotateSpeed = 5f;
    float forward;
    float xVal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forward = Input.GetAxis("Vertical");
        transform.Translate(transform.forward * speed * Time.deltaTime * forward);
        xVal = Input.GetAxis("Horizontal");
        transform.Rotate(transform.up, rotateSpeed * Time.deltaTime * xVal);
    }
}
