using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMovement : MonoBehaviour
{
    [SerializeField]
    private float horizontalVelocity;

    private void Update()
    {
        Move();
    }
    private void Move()
    {
        transform.position += Vector3.right * horizontalVelocity * Time.deltaTime;
    }
}
