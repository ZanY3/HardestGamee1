using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 speed;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb.velocity = speed;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Ground")) return;

        speed = -speed;
    }
}
