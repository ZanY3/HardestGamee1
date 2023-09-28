using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 0;
    public Vector3 spawnPoint;


    private void Start()
    {
        spawnPoint = transform.position;
    }
    void Update()
    {
        Vector3 moveDirection = new Vector3();
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.z = Input.GetAxisRaw("Vertical");

        GetComponent<Rigidbody>().velocity = moveDirection * speed;
    }

    private void OnCollisionEnter(Collision other)
    {
       if(other.gameObject.name.Contains("Enemy"))
        {
            transform.position = spawnPoint;
        }
    }
}
