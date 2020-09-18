using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Move2: MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float JumpForce = 20f;

    // Start is called before the first frame update
    void Start()
    {
        //print(transform.position.x);
        //print(transform.position.y);
        //print(transform.position.z);
        transform.position = new Vector3(-36.7f, 3.07f, -43.9f);

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        bool y = Input.GetKey(KeyCode.Space);
        
        if (y == true) { float fy = 1.0f; transform.position += new Vector3(1.0f * x * speed * Time.deltaTime, 1.0f * JumpForce * fy * Time.deltaTime, 1.0f * z * speed * Time.deltaTime); }
        else { float fy = 0.0f; transform.position += new Vector3(1.0f * x * speed * Time.deltaTime, 1.0f * JumpForce * fy * Time.deltaTime, 1.0f * z * speed * Time.deltaTime); }

        
            
        //transform.position += new Vector3(1.0f*x*speed*Time.deltaTime, 1.0f * speed * fy * Time.deltaTime, 1.0f * z *speed* Time.deltaTime);
    }
}
