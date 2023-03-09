using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topMax = 30;
    public float bottomMax = -10;

    void Update()
    {
        if(transform.position.z > topMax)
            Destroy(gameObject);
        else if (transform.position.z < bottomMax)
            Destroy(gameObject);
    }
}
