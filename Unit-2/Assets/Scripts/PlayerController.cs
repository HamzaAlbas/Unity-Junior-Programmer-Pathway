using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public GameObject projectile;
    public float speed;
    public float maxPos;


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if(transform.position.x > maxPos)
        {
            transform.position = new Vector3(maxPos, 0, 0);
        }
        if(transform.position.x < -maxPos)
        {
            transform.position = new Vector3(-maxPos, 0, 0);
        }

        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
        }
    }
}
