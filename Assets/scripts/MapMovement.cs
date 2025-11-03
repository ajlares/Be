using System;
using UnityEngine;

public class MapMovement : MonoBehaviour
{
    public Rigidbody rb;

    private void Start()
    {
        Destroy(this.gameObject, 10f);
    }

    private void Update()
    {
        Vector3 moveVector  = new Vector3(rb.linearVelocity.x, mapManager.Instance.moveSpeed, rb.linearVelocity.z);
        rb.linearVelocity = moveVector * Time.deltaTime;
    }
}