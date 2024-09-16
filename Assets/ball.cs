using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    static public int Initializationflag = 0;
    static public int goalcount = 0;


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
            goalcount = goalcount + 1;
            Initializationflag = 1;
            transform.position = new Vector3(-1f, 1.1f, -0.9f);
            Debug.Log(goalcount);
        }
    }

}
