using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform target;
    public Vector3 offset = new Vector3(0, 0, 10);
    public float smoothSpeed = 0.5f;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 withoutSmooth = target.position - offset;
        Vector3 withSmooth = Vector3.Lerp(transform.position, withoutSmooth, smoothSpeed);
        transform.position = withSmooth;

    }
}


