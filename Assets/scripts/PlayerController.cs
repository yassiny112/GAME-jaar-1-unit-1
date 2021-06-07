using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnspeed;
    public float horizontalInput;
    public float forwardinput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardinput = Input.GetAxis("Vertical");
            //We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardinput);
        transform.Rotate(Vector3.up * turnspeed * horizontalInput * Time.deltaTime);
    }
}
