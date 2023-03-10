using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private Material material;
    private float direction = 1;

    private float randomR;
    private float randomG;
    private float randomB;
    private float randomA;

    private float randomX;
    private float randomY;
    private float randomZ;

    private float randomRot;
    private float randomRotSpeed;

    private int randomIndex;

    void Start()
    {
        //transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        material = Renderer.material;
        randomIndex = Random.Range(0, 4);
        Debug.Log("Index: " + randomIndex);

        InvokeRepeating("RandomColor", 1, 1);
        InvokeRepeating("RandomScale", 1, 1);
        InvokeRepeating("RandomRotation", 1, 1);
    }
    
    void Update()
    {
        if (randomIndex == 0)
        {
            ChangeColor();
        }
        else if (randomIndex == 1)
        {
            ChangePosition();
        }
        else if (randomIndex == 2)
        {
            ChangeScale();
        }
        else if (randomIndex == 3)
        {
            ChangeRotation();
        }
        else if (randomIndex == 4)
        {
            ChangeColor();
            ChangePosition();
            ChangeRotation();
            ChangeScale();
        }
    }

    private void ChangeColor()
    {
        material.color = new Color(randomR, randomG, randomB, randomA);
    }

    private void ChangePosition()
    {

        transform.Translate(5 * Time.deltaTime * new Vector3(0, 0, direction));

        if (transform.position.z >= 10)
        {
            direction = -1;
        }
        else if (transform.position.z <= -10)
        {
            direction = 1;
        }
    }

    private void ChangeScale()
    {
        transform.localScale = new Vector3(randomX, randomY, randomZ);
    }

    private void ChangeRotation()
    {
        transform.Rotate(randomRot * Time.deltaTime * randomRotSpeed, 0.0f, 0.0f);
    }

    private void RandomColor()
    {
        randomR = Random.Range(0, 1.0f);
        randomG = Random.Range(0, 1.0f);
        randomB = Random.Range(0, 1.0f);
        randomA = Random.Range(0, 1.0f);
    }

    private void RandomScale()
    {
        randomX = Random.Range(0.5f, 5f);
        randomY = Random.Range(0.5f, 5f);
        randomZ = Random.Range(0.5f, 5f);
    }

    private void RandomRotation()
    {
        randomRot = Random.Range(0f, 180f);
        randomRotSpeed = Random.Range(1f, 10f);
    }


}
