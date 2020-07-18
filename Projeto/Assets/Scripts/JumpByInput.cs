using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]
public class JumpByInput : MonoBehaviour
{
    [SerializeField] 
    private float jumpIntensity;
    private bool isCollidingWithGround;

    private new Rigidbody2D rigidbody2D;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isCollidingWithGround)
            Jump();
    }
    private void Jump()
    {
        rigidbody2D.AddForce(Vector2.up * jumpIntensity);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
            isCollidingWithGround = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
            isCollidingWithGround = false;
    }
}
