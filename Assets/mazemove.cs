using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour


{
    private Quaternion _initialRotation; // 初期回転
    void Start()
    {
        _initialRotation = gameObject.transform.rotation;
    }



    // 更新用の関数
    void Update()
    {


        if (ball.Initializationflag > 0)
        {
            gameObject.transform.rotation = _initialRotation; // 回転の初期化
            ball.Initializationflag = 0;

        }


        transform.Rotate(Input.GetAxis("Vertical") / 20, 0, -Input.GetAxis("Horizontal") / 20, Space.World);
    }




}

