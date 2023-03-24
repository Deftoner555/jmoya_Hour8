using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightcontrol : MonoBehaviour
{
    public GameObject LightGO;

    void Start()
    {
        LightGO = GameObject.Find("Lightbulb");
    }

    void Update()
    {
        //if (Input.GetKey(KeyCode.L))
            
    }
}
