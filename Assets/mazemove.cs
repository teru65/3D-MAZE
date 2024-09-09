using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour


{


    void retryMessage()
    {
        transform.Rotate(0, 0, 0);

    }



    void Update()
    {
        transform.Rotate(Input.GetAxis("Vertical") / 20, 0, -Input.GetAxis("Horizontal") / 20, Space.World);
    }
}

