using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public string playerName;
    private float horizontalInput;
    private float verticalInput;

    void Start()
    {
        
    }

    
    void Update()
    {
        //We'll move the vehicle forward.
        if(playerName == "P1")
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
        }
        else if (playerName == "P2")
        {
            horizontalInput = Input.GetAxis("HorizontalAlt");
            verticalInput = Input.GetAxis("VerticalAlt");
        }


        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
