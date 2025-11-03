using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float gravity;
    public float horizontalSpeed;
    private float directionX = 0f;
    public float jumpForce;
    public Rigidbody rb;
    
    private void FixedUpdate()
    {
        directionX = PlayerInputReader.Instance.Direction;
        Vector3 velocity = rb.linearVelocity;
        velocity.x = directionX * horizontalSpeed;
        rb.linearVelocity = velocity;
        
        rb.AddForce(new Vector3(0, gravity, 0), ForceMode.Acceleration);
    }

    public void Jump()
    {
        Debug.Log("Jump");
        rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
    }
    public void SwapGravity()
    {
        gravity *= -1;
        jumpForce *= -1;
        rb.linearVelocity = Vector3.zero;
        transform.Rotate(0, 0, 180);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("jumpZone"))
        {
            Jump();
        }
    }
}
