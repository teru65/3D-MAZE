using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private float movex;
    private float movey;
    private float movez;
    // Start is called before the first frame update
    void Start()
    {
        movex = -1;
        movey = 1.1f;
        movez = -0.9f;

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pitfall")
        {
            GameObject[] objectBArray = GameObject.FindGameObjectsWithTag("maze");
            foreach (var obj in objectBArray)
            {
                obj.SendMessage("retryMessage");
            }

            transform.position = new Vector3(movex, movey, movez);
        }
    }

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
}
