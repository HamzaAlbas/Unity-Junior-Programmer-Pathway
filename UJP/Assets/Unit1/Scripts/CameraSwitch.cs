using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject behindCamera, forwardCamera;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            if(behindCamera.activeInHierarchy)
            {
                behindCamera.SetActive(false);
                forwardCamera.SetActive(true);
            }
            else if(forwardCamera.activeInHierarchy)
            {
                forwardCamera.SetActive(false); 
                behindCamera.SetActive(true);
            }
        }
    }
}
