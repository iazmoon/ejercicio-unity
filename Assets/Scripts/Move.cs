using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
            transform.position += new Vector3(1f, 0f, 0f) * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            //transform.position += new Vector3(-speed * Time.deltaTime, 0f, 0f);
            transform.position += new Vector3(-1f, 0f, 0f) * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.position += new Vector3(0f, 0f, speed * Time.deltaTime);
            transform.position += new Vector3(0f, 0f, 1f) * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            //transform.position += new Vector3(0f, 0f, -speed * Time.deltaTime);
            transform.position += new Vector3(0f, 0f, -1f) * speed * Time.deltaTime;
        }
    }
}
