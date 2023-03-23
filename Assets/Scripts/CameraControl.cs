using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float horizontalSpeed = 10f;
    public float verticalSpeed = 10f;

    void Update()
    {
        //float h = horizontalSpeed * Input.GetAxis("Mouse X");
        //float v = verticalSpeed * Input.GetAxis("Mouse Y");

        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");

        //if(mxVal != 0)
            //transform.Translate()

        



    }
}

