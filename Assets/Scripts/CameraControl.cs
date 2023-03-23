using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float horizontalSpeed = 5f;
    public float verticalSpeed = 5f;

    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");

        transform.Translate(mxVal, myVal, 0);
    }
}

