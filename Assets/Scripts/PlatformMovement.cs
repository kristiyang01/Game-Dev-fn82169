using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField]
    private int platformSpeed = 1;
    
    private float distance = 0;

    // Update is called once per frame
    void Update()
    {
        if (distance < 1)
        {
            distance += 0.001f;
        }
        else
        {
            distance = 0f;
            platformSpeed *= -1;
        }
        transform.Translate(platformSpeed * 0.01f, 0, 0);
    }


}