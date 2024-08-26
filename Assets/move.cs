using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour

{
    void Update()
    {
        transform.Rotate(new Vector3(Input.GetAxis("Horizontal"), -Input.GetAxis("Horizontal"), 0));
    }
}

