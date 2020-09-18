using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class Gravity : MonoBehaviour
{
    [SerializeField]
    private float groundspeed = 5.0f;
    [SerializeField]
    private float gravity = -9.8f;

    private CharacterController charController;
    // Start is called before the first frame update
    void Start()
    {
        charController = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        float X = Input.GetAxis("Horizontal") * groundspeed;
        float Z = Input.GetAxis("Vertical") * groundspeed;
        Vector3 Movement = new Vector3(X, 0, Z);
        Movement = Vector3.ClampMagnitude(Movement, groundspeed);

        Movement.y = gravity;
        Movement *= Time.deltaTime;
        Movement = transform.TransformDirection(Movement);
        charController.Move(Movement);

    }
}
