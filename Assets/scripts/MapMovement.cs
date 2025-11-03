using System;
using UnityEngine;

public class MapMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float deathTime;

    private void Start()
    {
        Destroy(this.gameObject, deathTime);
    }

    private void Update()
    {
        Vector3 moveVector  = new Vector3(rb.linearVelocity.x, mapManager.Instance.moveSpeed, rb.linearVelocity.z);
        rb.linearVelocity = moveVector * Time.deltaTime;
    }
}