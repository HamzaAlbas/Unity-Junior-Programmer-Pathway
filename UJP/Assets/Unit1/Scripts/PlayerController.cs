using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    
    void Update()
    {
        //We'll move the vehicle forward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
