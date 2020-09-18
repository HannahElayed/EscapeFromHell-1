using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += new Vector3(0.0f, 0.1f, 0.0f);
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f, 0.0f, 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, 0.0f, -0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0.0f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0.0f, 1.0f, 0.0f);
        }

    }
    private void FixedUpdate()
    {

    }

}