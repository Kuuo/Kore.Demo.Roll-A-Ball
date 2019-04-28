using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 8f;
    
    
    private const string InputStrH = "Horizontal";
    private const string InputStrV = "Vertical";
    
    
    private Vector3 force = Vector3.zero;
    private float inputH;
    private float inputV;
    

    private void FixedUpdate()
    {
        inputH = Input.GetAxis(InputStrH);
        inputV = Input.GetAxis(InputStrV);

        force = new Vector3(inputH, 0f, inputV) * speed;
        rb.AddForce(force);
    }
}