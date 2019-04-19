using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 8f;
    public Rigidbody rb;

    private const string InputStrH = "Horizontal";
    private const string InputStrV = "Vertical";

    private float inputH;
    private float inputV;
    private Vector3 force = Vector3.zero;

    private void FixedUpdate()
    {
        inputH = Input.GetAxis(InputStrH);
        inputV = Input.GetAxis(InputStrV);
        
        force = new Vector3(inputH, 0f, inputV) * speed;
        rb.AddForce(force);
    }
}
