using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // This is a reference to the Rigidbody component called 'rb'.
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float SidewaysForceinx = 500f;

    // We marked this as FIxedUpdate because we are messing with Physics.
    void FixedUpdate()
    {
        //Add forward force value.
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if( Input.GetKey("b"))
        {
            rb.AddForce(SidewaysForceinx * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("v"))
        {
            rb.AddForce(-SidewaysForceinx * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<gamemanager>().endgame();
        }
    }
}
