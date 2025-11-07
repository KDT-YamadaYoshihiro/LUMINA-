using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 5.0f;
    public float jumpForce = 10.0f;

    private Rigidbody rb;
    private CapsuleCollider col;

    public LayerMask groundLayer;
    private float groundCheckRadius = 0.1f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
    }

    void Update()
    {
        Move();
        Attack();
    }

    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0.0f, vertical);

        if (Input.GetButtonDown("Jump") && IsGround())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        rb.AddForce(movement * speed);
    }

    private bool IsGround()
    {
        Vector3 bottomCenter = col.bounds.center - new Vector3(0, col.bounds.extents.y, 0);
        return Physics.CheckSphere(bottomCenter, groundCheckRadius, groundLayer);
    }

    void Attack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //animator.SetTrigger("Attack");
        }
    }
}
