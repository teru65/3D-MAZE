using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class move : MonoBehaviour


{




    // 更新用の関数
    void Update()
    {
        transform.Rotate(Input.GetAxis("Vertical") / 20, 0, -Input.GetAxis("Horizontal") / 20, Space.World);
    }




}

