using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;

    
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.left);
    }
}
