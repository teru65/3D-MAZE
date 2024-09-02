using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour

{


    void Update()
    {
        transform.Rotate(Input.GetAxis("Vertical") / 10, 0, -Input.GetAxis("Horizontal") / 10);
    }
}

