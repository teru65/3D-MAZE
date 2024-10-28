using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ballmove : MonoBehaviour
{


    static public int Initializationflag = 0;
    static public int stage;


    // Update is called once per frame
    void Update()
    {
        var body = GameObject.Find("Ball").GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.UpArrow))
        {
            body.WakeUp();
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            body.WakeUp();
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            body.WakeUp();
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            body.WakeUp();
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pitfall")
        {
            Initializationflag = 1;
            transform.position = new Vector3(-1f, 1.1f, -0.9f);
        }
        else if (collision.gameObject.tag == "goal")
        {
            stage = stage + 1;
            if (stage == 7)
            {
                SceneManager.LoadScene("clear");
            }
            else
            {
                Initializationflag = 1;
                transform.position = new Vector3(-1f, 1.1f, -0.9f);
                Debug.Log(stage);

                // 受信するオブジェクトを見つけてメッセージを送信
                GameObject receiver = GameObject.Find("director");
                if (receiver != null)
                {
                    receiver.SendMessage("ReceiveMessage"); // 引数なし
                }
            }
        }
    }

}
